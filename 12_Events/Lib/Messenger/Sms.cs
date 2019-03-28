using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Events.Lib.Messenger
{
    public class Sms
    {
        public void SendMessage(object sender, VideoEventArgs args)
        {
            Console.WriteLine($"SMS sended to video {args.Video.Name}");
        }
    }
}
