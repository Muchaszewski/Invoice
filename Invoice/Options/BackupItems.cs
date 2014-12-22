﻿using Google.Apis.Drive.v2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktury.Options
{
    public class BackupItems
    {
        private int itemCount;
        public int ItemCount
        {
            get { return itemCount; }
            set { itemCount = value; }
        }

        private string itemData;
        public string ItemData
        {
            get { return itemData; }
            set { itemData = value; }
        }

        private int configCount;
        public int ConfigCount
        {
            get { return configCount; }
            set { configCount = value; }
        }

        private string configData;
        public string ConfigData
        {
            get { return configData; }
            set { configData = value; }
        }

        private int contractorCount;
        public int ContractorCount
        {
            get { return contractorCount; }
            set { contractorCount = value; }
        }

        private string contractorData;
        public string ContractorData
        {
            get { return contractorData; }
            set { contractorData = value; }
        }

        private int invoiceCount;
        public int InvoiceCount
        {
            get { return invoiceCount; }
            set { invoiceCount = value; }
        }

        private string invoiceData;
        public string InvoiceData
        {
            get { return invoiceData; }
            set { invoiceData = value; }
        }

        private File file;
        public File File
        {
            get { return file; }
            set { file = value; }
        }

        public BackupItems Copy()
        {
            return (BackupItems)this.MemberwiseClone();
        }
    }
}
