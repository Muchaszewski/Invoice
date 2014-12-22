using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using Faktury.DialogBox;
using System.Drawing;
using Faktury.Utils;
using Faktury.Items;

namespace Faktury.Utils
{
    public static class PrintPreview
    {
        public static void Draw(InvoiceAdd form, object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // 816x / 1188y
            //Margin 96 default
            int MarginX = 50;
            int MarginY = 96;

            string TFamily = "Arial";
            int TSize = 16;
            string StFamily = "Arial";
            int StSize = 13;
            string Family = "Arial";
            int Size = 9;
            string SFamily = "Arial";
            int SSize = 8;
            Font Tfont = new System.Drawing.Font(TFamily, TSize);
            Font TfontB = new System.Drawing.Font(TFamily, TSize, FontStyle.Bold);
            Font Stfont = new System.Drawing.Font(StFamily, StSize);
            Font StfontB = new System.Drawing.Font(StFamily, StSize, FontStyle.Bold);
            Font font = new System.Drawing.Font(Family, Size);
            Font fontB = new System.Drawing.Font(Family, Size, FontStyle.Bold);
            Font fontI = new System.Drawing.Font(Family, Size, FontStyle.Italic);
            Font Sfont = new System.Drawing.Font(SFamily, SSize);
            Font SfontB = new System.Drawing.Font(SFamily, SSize, FontStyle.Bold);


            e.Graphics.DrawString("Faktura nr " + form.textBoxNr.Text + "/" + form.textBoxNrYear.Text, TfontB, Brushes.Black, MarginX, 96);
            e.Graphics.DrawString("strona 1/1", fontB, Brushes.Black, 816 - 50 - MarginX, 1188 - MarginY);


            int titleSeparator = 150;
            e.Graphics.DrawLine(Pens.Black, MarginX, titleSeparator, 816 - MarginX, titleSeparator);


            int dateSpaces = 150;
            e.Graphics.DrawString("Data wystawienia", font, Brushes.Black, MarginX, titleSeparator + 5);
            e.Graphics.DrawString(form.dateTimePickerMaking.Text, fontB, Brushes.Black, MarginX, titleSeparator + 22);

            e.Graphics.DrawString("Data sprzedaży", font, Brushes.Black, MarginX + dateSpaces * 1, titleSeparator + 5);
            e.Graphics.DrawString(form.dateTimePickerSelling.Text, fontB, Brushes.Black, MarginX + dateSpaces * 1, titleSeparator + 22);

            e.Graphics.DrawString("Miejsce wystawienia", font, Brushes.Black, MarginX + dateSpaces * 2, titleSeparator + 5);
            e.Graphics.DrawString(form.textBoxPlace.Text, fontB, Brushes.Black, MarginX + dateSpaces * 2, titleSeparator + 22);

            e.Graphics.DrawString("Forma płatności", font, Brushes.Black, MarginX + dateSpaces * 3, titleSeparator + 5);
            e.Graphics.DrawString(form.comboBoxPaymentCheck.Text, fontB, Brushes.Black, MarginX + dateSpaces * 3, titleSeparator + 22);
            if (form.comboBoxPaymentCheck.SelectedIndex == 1)
            {
                e.Graphics.DrawString(form.textBoxAddNote.Text, fontB, Brushes.Black, MarginX + dateSpaces * 3, titleSeparator + 35);
            }

            // e.Graphics.DrawString("Termin płatności", font, Brushes.Black, MarginX + dateSpaces * 4, titleSeparator + 5);


            int sellerTitle = titleSeparator + 70;
            e.Graphics.DrawString(form.textBoxSeller1.Text, StfontB, Brushes.Black, MarginX, sellerTitle);
            e.Graphics.DrawString(form.textBoxData1.Text, font, Brushes.Black, MarginX, sellerTitle + 27);

            e.Graphics.DrawString(form.textBoxSeller2.Text, StfontB, Brushes.Black, MarginX + 355, sellerTitle);
            e.Graphics.DrawString(form.textBoxData2.Text, font, Brushes.Black, MarginX + 355, sellerTitle + 27);


            int sLP = 35;
            int sName = 300;
            int sCount = 33;
            int sJm = 33;
            int sPrice = 70;
            int sVAT = 33;
            int sPriceTax = 65;
            int sValue = 80;
            //int sTaxValue = 80; //Temp

            int itemsTitle = sellerTitle + 170;
            int columnWidth = 0;

            e.Graphics.DrawString("Lp", fontB, Brushes.Black, MarginX + columnWidth, itemsTitle); columnWidth += sLP;
            e.Graphics.DrawString("Nazwa towaru / usługi", fontB, Brushes.Black, MarginX + columnWidth, itemsTitle); columnWidth += sName;
            e.Graphics.DrawString("Ilość", fontB, Brushes.Black, MarginX + columnWidth, itemsTitle); columnWidth += sCount;
            e.Graphics.DrawString("J.m", fontB, Brushes.Black, MarginX + columnWidth, itemsTitle); columnWidth += sJm;
            e.Graphics.DrawString("Cena\r\nnetto", fontB, Brushes.Black, MarginX + columnWidth, itemsTitle - 9); columnWidth += sPrice;
            e.Graphics.DrawString("Wartość\r\n   netto", fontB, Brushes.Black, MarginX + columnWidth, itemsTitle - 9); columnWidth += sValue;
            e.Graphics.DrawString("VAT", fontB, Brushes.Black, MarginX + columnWidth, itemsTitle); columnWidth += sVAT;
            e.Graphics.DrawString("Kwota\r\n VAT", fontB, Brushes.Black, MarginX + columnWidth, itemsTitle - 9); columnWidth += sPriceTax;
            e.Graphics.DrawString("Wartość\r\n  brutto", fontB, Brushes.Black, MarginX + columnWidth, itemsTitle - 9);

            e.Graphics.DrawLine(Pens.Black, MarginX, itemsTitle + 22, 816 - MarginX, itemsTitle + 22);


            int itemsSeparator = itemsTitle + 10;
            int rowSize = 12;
            int i = 1;
            foreach (var item in form.sInvoice.Items)
            {
                columnWidth = 0;
                e.Graphics.DrawString(i++.ToString(), Sfont, Brushes.Black, MarginX + columnWidth, itemsSeparator + (i - 1) * rowSize); columnWidth += sLP;
                e.Graphics.DrawString(item.Name, Sfont, Brushes.Black, MarginX + columnWidth, itemsSeparator + (i - 1) * rowSize); columnWidth += sName;
                e.Graphics.DrawString(item.Quantity.ToString(), Sfont, Brushes.Black, MarginX + columnWidth, itemsSeparator + (i - 1) * rowSize); columnWidth += sCount;
                e.Graphics.DrawString(Description.GetDescription(item.Unit), Sfont, Brushes.Black, MarginX + columnWidth, itemsSeparator + (i - 1) * rowSize); columnWidth += sJm;
                e.Graphics.DrawString(Utils.ConvertToPriceCostum(item.Price, form.sInvoice.Currency), Sfont, Brushes.Black, MarginX + columnWidth, itemsSeparator + (i - 1) * rowSize); columnWidth += sPrice;
                e.Graphics.DrawString(Utils.CalculateQuantityValue(item.Price, item.Tax, item.Quantity) + Utils.DrawCurrency(form.sInvoice.Currency), Sfont, Brushes.Black, MarginX + columnWidth, itemsSeparator + (i - 1) * rowSize); columnWidth += sValue;
                e.Graphics.DrawString(Utils.ConvertToTax(item.Tax), Sfont, Brushes.Black, MarginX + columnWidth, itemsSeparator + (i - 1) * rowSize); columnWidth += sVAT;
                e.Graphics.DrawString(Utils.CalculateTaxQuantityValuePrice(item.Price, item.Tax, item.Quantity) + Utils.DrawCurrency(form.sInvoice.Currency), Sfont, Brushes.Black, MarginX + columnWidth, itemsSeparator + (i - 1) * rowSize); columnWidth += sPriceTax;
                e.Graphics.DrawString(Utils.CalculateTaxQuantityValue(item.Price, item.Tax, item.Quantity) + Utils.DrawCurrency(form.sInvoice.Currency), Sfont, Brushes.Black, MarginX + columnWidth, itemsSeparator + (i - 1) * rowSize);

            }

            int itemsSummary = itemsSeparator + (i - 1) * rowSize + rowSize + 2;
            i = 1;
            e.Graphics.DrawLine(Pens.Black, MarginX + 399, itemsSummary, 816 - MarginX, itemsSummary);
            e.Graphics.DrawString("W tym: ", Sfont, Brushes.Black, MarginX + 404, itemsSummary + (i - 1) * rowSize);
            foreach (var item in form.TotalTaxOnlyValue)
            {
                columnWidth = sLP + sName + sCount + sJm + sPrice;
                e.Graphics.DrawString(Utils.ConvertToPriceCostum(item.Price, form.sInvoice.Currency), Sfont, Brushes.Black, MarginX + columnWidth, itemsSummary + (i - 1) * rowSize); columnWidth += sValue;
                e.Graphics.DrawString(Utils.ConvertToTax(item.TaxAmount), Sfont, Brushes.Black, MarginX + columnWidth, itemsSummary + (i - 1) * rowSize); columnWidth += sVAT;
                e.Graphics.DrawString(Utils.ConvertToPriceCostum(item.PriceTax - item.Price, form.sInvoice.Currency), Sfont, Brushes.Black, MarginX + columnWidth, itemsSummary + (i - 1) * rowSize); columnWidth += sPriceTax;
                e.Graphics.DrawString(Utils.ConvertToPriceCostum(item.PriceTax, form.sInvoice.Currency), Sfont, Brushes.Black, MarginX + columnWidth, itemsSummary + (i - 1) * rowSize);
                i++;
            }
            i++;
            columnWidth = sLP + sName + sCount + sJm + sPrice;
            e.Graphics.DrawLine(Pens.Black, MarginX + 399, itemsSummary + (i - 1) * rowSize, 816 - MarginX, itemsSummary + (i - 1) * rowSize);
            e.Graphics.DrawString(form.textBoxValue1.Text, Sfont, Brushes.Black, MarginX + columnWidth, itemsSummary + (i - 1) * rowSize); columnWidth += sValue;
            e.Graphics.DrawString("Razem: ", Sfont, Brushes.Black, MarginX + 404, itemsSummary + (i - 1) * rowSize); columnWidth += sVAT;
            e.Graphics.DrawString(form.textBoxTax1.Text, Sfont, Brushes.Black, MarginX + columnWidth, itemsSummary + (i - 1) * rowSize); columnWidth += sPriceTax;
            e.Graphics.DrawString(form.textBoxTaxValue1.Text, Sfont, Brushes.Black, MarginX + columnWidth, itemsSummary + (i - 1) * rowSize);
            i++;
            if (form.textBoxWarning.Text != "")
            {
                e.Graphics.DrawString("Uwagi: " + form.textBoxWarning.Text, Sfont, Brushes.Black, MarginX, itemsSummary + (i - 1) * rowSize);
            }
            columnWidth = sLP + sName + sCount + sJm + sPrice;
            if (form.sInvoice.Currency != Data.Config.ConvertedCurrency)
            {
                e.Graphics.DrawString(form.textBoxValueDefault.Text, Sfont, Brushes.Black, MarginX + columnWidth, itemsSummary + (i - 1) * rowSize); columnWidth += sValue;
                switch (Data.Config.ConvertedCurrency)
                {
                    case ECurrencyItem.PLN: e.Graphics.DrawString("w złotych: ", Sfont, Brushes.Black, MarginX + 404, itemsSummary + (i - 1) * rowSize); columnWidth += sVAT; break;
                    case ECurrencyItem.EUR: e.Graphics.DrawString("w euro: ", Sfont, Brushes.Black, MarginX + 404, itemsSummary + (i - 1) * rowSize); columnWidth += sVAT; break;
                    default: e.Graphics.DrawString("w WALUTA: ", Sfont, Brushes.Black, MarginX + 404, itemsSummary + (i - 1) * rowSize); columnWidth += sVAT; break;
                }
                e.Graphics.DrawString(form.textBoxTaxDefault.Text, Sfont, Brushes.Black, MarginX + columnWidth, itemsSummary + (i - 1) * rowSize); columnWidth += sPriceTax;
                e.Graphics.DrawString(form.textBoxTaxValueDefault.Text, Sfont, Brushes.Black, MarginX + columnWidth, itemsSummary + (i - 1) * rowSize);
                //Tabela i kurs
                i++;
                e.Graphics.DrawLine(Pens.Black, MarginX + 250, itemsSummary + (i - 1) * rowSize, 816 - MarginX, itemsSummary + (i - 1) * rowSize);
                e.Graphics.DrawString("Kurs waluty euro w zł: " + form.NBPRates.GetCurrenciesRate("EUR"), SfontB, Brushes.Black, MarginX + 250, itemsSummary + (i - 1) * rowSize);
                e.Graphics.DrawString(form.textBoxTable.Text, SfontB, Brushes.Black, MarginX + 250, itemsSummary + i * rowSize);
            }
            i += 5;
            //Do zapłaty
            e.Graphics.DrawString("Do zapłaty: " + form.textBoxTaxValue1.Text, StfontB, Brushes.Black, MarginX, itemsSummary + (i - 1) * rowSize);
            i++;
            //Słownie
            e.Graphics.DrawString("Razem słownie: " + form.textBoxNumberToWord.Text, StfontB, Brushes.Black, MarginX, itemsSummary + (i - 1) * rowSize + 6);
            //podpisy
            i += 5;
            rowSize = 18;
            if (form.sInvoice.Contractors[0] != null)
            {
                e.Graphics.DrawLine(Pens.Black, MarginX, itemsSummary + i * rowSize, MarginX + 250, itemsSummary + i * rowSize);
                e.Graphics.DrawString(form.sInvoice.Contractors[0].Name, SfontB, Brushes.Black, MarginX + 45, itemsSummary + (i - 1) * rowSize - 4);
                e.Graphics.DrawString("Fakturę wystawił", Sfont, Brushes.Black, MarginX + 45, itemsSummary + i * rowSize);
            }

            if (form.sInvoice.Contractors[1] != null)
            {
                e.Graphics.DrawLine(Pens.Black, MarginX + 385, itemsSummary + i * rowSize, MarginX + 250 + 385, itemsSummary + i * rowSize);
                e.Graphics.DrawString("Fakturę odebrał", Sfont, Brushes.Black, MarginX + 45 + 385, itemsSummary + i * rowSize);
            }
        }
    }
}
