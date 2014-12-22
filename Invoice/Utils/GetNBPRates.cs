using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
public class GetNBPRates
{
    //
    //http://codeguru.geekclub.pl/forum/watek/kurs-nbp---pobieranie-kursow-nbp,475591
    //

    private const string file_dir = "http://www.nbp.pl/Kursy/xml/dir.txt";
    private const string xml_url = "http://www.nbp.pl/kursy/xml/";
    private int start_int = 1;
    private string file_name;

    private string numertabeli;
    public DateTime DateOfRate;
    public GetNBPRates(DateTime dateOfRate)
    {
        DateOfRate = dateOfRate;
        GetFileName();
    }

    public string GetCurrenciesTable(string currency_name) 
    { 
        Dictionary<string, decimal> result = new Dictionary<string, decimal>();
        return "Tabela nr " + numertabeli + "/A/NBP/" + DateOfRate.Year + " z dnia " + DateOfRate.ToShortDateString();
    }
    public string GetCurrenciesRate(string currency_name)
    {
        Dictionary<string, decimal> result = new Dictionary<string, decimal>();
        return LoadRate(currency_name).ToString();
    }
    private decimal LoadRate(string currency_name)
    {
        string file = xml_url + file_name + ".xml"; 
        DataSet ds = new DataSet();
        try
        {
            ds.ReadXml(file);
        }
        catch
        {
            MessageBox.Show("Brak połączenia z serwerem NBP. Sprawdź czy istnieje połączenie ręcznie na http://rss.nbp.pl/kursy/TabelaA.xml \r\nWięcej informacji na temat stanu połączenia i przerw technicznych na http://www.nbp.pl" + "\r\nAplilacja zostanie zamknięta");
            Process.GetCurrentProcess().Kill();
            
        }
        var tabela = ds.Tables["pozycja"].AsEnumerable(); 
        var kurs = (from k in tabela where k["kod_waluty"].ToString() == currency_name select new { Kurs = k["kurs_sredni"].ToString() }).First();
        return Convert.ToDecimal(kurs.Kurs);
    }
    private void GetFileName()
    {
        WebClient client = new WebClient(); 
        Stream strm = client.OpenRead(file_dir); 
        StreamReader sr = new StreamReader(strm); 
        string file_list = sr.ReadToEnd(); 
        string date_str = string.Empty; 
        bool has_this_rate = false; 
        while (!has_this_rate)
        {
            numertabeli = start_int.ToString().PadLeft(3, '0');
            date_str = "a" + numertabeli + "z" + DateOfRate.ToString("yyMMdd"); 
            if (file_list.Contains(date_str))
            { 
                has_this_rate = true; 
            } 
            start_int++;
            if (start_int > 365) 
            { 
                start_int = 1; DateOfRate = DateOfRate.AddDays(-1);
            }
        } 
        file_name = date_str;
    }
}