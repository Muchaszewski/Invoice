using System;
using System.Threading;
using System.Threading.Tasks;

using Google;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using Google.Apis.Services;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;
using Faktury.Options;


namespace Faktury.Utils.Backup
{
    public static class GoogleDriveBackup
    {
        private static string MimeFolder = "application/vnd.google-apps.folder";

        private static UserCredential credential;
        private static DriveService service;
        private static DateTime id;
        private static List<File> driveContent;
        /// <summary>
        /// mod 5 = 0 items
        /// mod 5 = 1 config
        /// mod 5 = 2 contractors
        /// mod 5 = 3 invoice
        /// mod 5 = 4 folder
        /// </summary>
        public static List<File> DriveContent
        {
            get { return GoogleDriveBackup.driveContent; }
        }

        /// <summary>
        /// Establish connection with google drive with given ClientID and ClientSecrets
        /// </summary>
        public static void Connect()
        {
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = "176534462054-dvkjkjrgqs7maek51oql45oaonuqoh36.apps.googleusercontent.com",
                    ClientSecret = "SCpCI8mC52OeZMsm5kKbiK84",
                },
                new[] { DriveService.Scope.Drive },
                "Faktury",
                CancellationToken.None).Result;

            // Create the service.
            service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Invoice Backup Drive",
            });

            Load();
        }


        public static void Make()
        {
            id = DateTime.Now;
            string folder = "Backup " + id;

            TextWindow textWindow = new TextWindow(folder);
            textWindow.Show();
            textWindow.DialogText.Text = "Tworzenie folderu";
            File folderFile = CreateFolder(folder);

            textWindow.DialogText.Text = "Wysyłanie pliku INVOICE";
            insertFile("Invoice", Data.Invoices.Count + "_" + FileWriter.getModificationDate(FileWriter.INVOICES_LIST), folderFile.Id, "text/xml", FileWriter.INVOICES_LIST);

            textWindow.DialogText.Text = "Wysyłanie pliku CONTRACTORS";
            insertFile("Contractors", Data.Contractors.Count + "_" + FileWriter.getModificationDate(FileWriter.CONTRACTORS_LIST), folderFile.Id, "text/xml", FileWriter.CONTRACTORS_LIST);

            textWindow.DialogText.Text = "Wysyłanie pliku CONFIG";
            insertFile("Config", Data.Config.InvoiceNumer + "_" + FileWriter.getModificationDate(FileWriter.CONFIG), folderFile.Id, "text/xml", FileWriter.CONFIG);

            textWindow.DialogText.Text = "Wysyłanie pliku ITEMS";
            insertFile("Items", Data.Items.Count + "_" + FileWriter.getModificationDate(FileWriter.ITEMS_LIST), folderFile.Id, "text/xml", FileWriter.ITEMS_LIST);
            textWindow.Close();
        }

        /// <summary>
        /// Create new folder
        /// </summary>
        /// <param name="folderId">Folder name</param>
        /// <param name="parentId">Parent folder; default root</param>
        /// <returns>Folder metadata, null is returned if an API error occurred</returns>
        public static File CreateFolder(string folderId, string parentId = "root")
        {
            File body = new File();
            body.Title = folderId;
            body.Description = "Folder";
            body.MimeType = MimeFolder;
            body.Parents = new List<ParentReference>() { new ParentReference() { Id = parentId } };
            try
            {
                FilesResource.InsertRequest request = service.Files.Insert(body);
                return request.Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
                return null;
            }
        }

        /// <summary>
        /// Insert new file.
        /// </summary>
        /// <param name="service">Drive API service instance.</param>
        /// <param name="title">Title of the file to insert, including the extension.</param>
        /// <param name="description">Description of the file to insert.</param>
        /// <param name="parentId">Parent folder's ID.</param>
        /// <param name="mimeType">MIME type of the file to insert.</param>
        /// <param name="filename">Filename of the file to insert.</param>
        /// <returns>Inserted file metadata, null is returned if an API error occurred.</returns>
        private static File insertFile(string title, string description, string parentId, string mimeType, string filename)
        {
            // File's metadata.
            File body = new File();
            body.Title = title;
            body.Description = description;
            body.MimeType = mimeType;

            // Set the parent folder.
            if (!String.IsNullOrEmpty(parentId))
            {
                body.Parents = new List<ParentReference>() { new ParentReference() { Id = parentId } };
            }

            // File's content.
            byte[] byteArray = System.IO.File.ReadAllBytes(filename);
            System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
            try
            {
                FilesResource.InsertMediaUpload request = service.Files.Insert(body, stream, mimeType);
                try
                {
                    request.Upload();

                    File file = request.ResponseBody;
                    // Uncomment the following line to print the File ID.
                    //Console.WriteLine("File ID: " + file.Id);

                    return file;
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred in Insert: " + e.Message);
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
                return null;
            }
        }


        public static void Load()
        {
            List<File> result = new List<File>();
            FilesResource.ListRequest request = service.Files.List();

            TextWindow textWindow = new TextWindow("Wczytywanie danych z Google Drive");
            textWindow.Show();
            textWindow.DialogText.Text = "Wczytywanie danych z Google Drive";
            do
            {
                try
                {
                    FileList files = request.Execute();
                    result.AddRange(files.Items);
                    request.PageToken = files.NextPageToken;
                }
                catch (Exception e)
                {
                    textWindow.DialogText.Text = "BŁĄD!";
                    Console.WriteLine("An error occurred: " + e.Message);
                    request.PageToken = null;
                }
            } while (!String.IsNullOrEmpty(request.PageToken));
            textWindow.Close();
            driveContent = result;
        }

        public static List<BackupItems> GetBackupData()
        {
            List<BackupItems> result = new List<BackupItems>();
            BackupItems temp = new BackupItems();
            int counter = 0;
            foreach (var item in DriveContent)
            {
                if (item.MimeType == MimeFolder)
                {
                    temp.File = item;
                }
                else
                {
                    if (item.Title == "Invoice")
                    {
                        string[] lines = Regex.Split(item.Description, "_");
                        temp.InvoiceCount = Convert.ToInt32(lines[0]);
                        temp.InvoiceData = lines[1];
                    }
                    else if (item.Title == "Contractors")
                    {
                        string[] lines = Regex.Split(item.Description, "_");
                        temp.ContractorCount = Convert.ToInt32(lines[0]);
                        temp.ContractorData = lines[1];
                    }
                    else if (item.Title == "Items")
                    {
                        string[] lines = Regex.Split(item.Description, "_");
                        temp.ItemCount = Convert.ToInt32(lines[0]);
                        temp.ItemData = lines[1];
                    }
                    else if (item.Title == "Config")
                    {
                        string[] lines = Regex.Split(item.Description, "_");
                        temp.ConfigCount = Convert.ToInt32(lines[0]);
                        temp.ConfigData = lines[1];
                    }
                }
                counter++;
                if(counter == 5)
                {
                    result.Add(temp.Copy());
                    temp = new BackupItems();
                    counter = 0;
                }
            }
            return result;
        }

        /// <summary>
        /// Download a file and return a string with its content.
        /// </summary>
        /// <param name="file">Drive File instance.</param>
        /// <returns>File's content if successful, null otherwise.</returns>
        public static byte[] DownloadFile(File file)
        {
            if (!String.IsNullOrEmpty(file.DownloadUrl))
            {
                try
                {
                    TextWindow textWindow = new TextWindow("Wczytywanie danych z Google Drive");
                    textWindow.Show();
                    textWindow.DialogText.Text = "Pobieranie danych";
                    var item = service.Files.Get(file.Id).Execute();
                    textWindow.Close();
                    return service.HttpClient.GetByteArrayAsync(file.DownloadUrl).Result;
                }
                catch (Exception e)
                {

                    Console.WriteLine("An error occurred: " + e.Message);
                    return null;
                }
            }
            else
            {
                // The file doesn't have any content stored on Drive.
                return null;
            }
        }
    }
}
