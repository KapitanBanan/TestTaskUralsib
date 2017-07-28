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
            Console.ReadLine();
        }

        private static void Tr_ResponseReceived(object sendr, ParameterResponse e)
        {
            Console.WriteLine("{0}: {1}  chatId:{2}", e.name, e.message, e.chatID);
        }
    }
}
