using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using Telegram.Request;
using Telegram;

namespace Telegram_bot
{
    class Program
    {
        static void Main(string[] args)
        {
            TelegramRequest Tr = new TelegramRequest(Settings.Default.Token);
            Tr.ResponseReceived += Tr_ResponseReceived;
            Thread thr = new Thread(Tr.GetUpdates);
            thr.IsBackground = true;
            thr.Start();
            //Console.Read();
            //--------------------------------------МЕТОДЫ------------------------------------
            //Method m = new Method(Settings.Default.Token);
            //m.Getme();
            //m.SendMessage("Ну привет", 426565057);
            //m.FormatMessage(426565057, 426565057, 9);
            //Console.WriteLine(m.Getme());
            //m.SendPhotoImputFile(ChatID, @"E:\Eagle.JPG", "Выпал ОРЕЛ!");
            Console.ReadLine();
            //--------------------------------------------------------------------------------
        }

        private static void Tr_ResponseReceived(object sendr, ParameterResponse e)
        {
            Console.WriteLine("{0}: {1}  chatId:{2}", e.name, e.message, e.chatID);
        }
    }
}
