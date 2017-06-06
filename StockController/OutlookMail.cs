using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace StockController
{
    public class OutlookMail
    {
        /// <summary>
        /// Отправка письма на почтовый ящик Outlook, средствами C#
        /// </summary>
        /// <param name="_subject">Тема письма</param>
        /// <param name="_to">Адрес получателя</param>
        /// <param name="_body">Тело письма</param>

        public static void CreateMail(string _subject, string _to, string _body)
        {
            Outlook.Application oApp = new Outlook.Application();
            Outlook.MailItem mailItem = oApp.Application.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.Application.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.Subject = _subject;
            mailItem.To = _to;
            mailItem.Body = _body;
            mailItem.Importance = Outlook.OlImportance.olImportanceLow;
            mailItem.Display(true);
        }
    }
}
