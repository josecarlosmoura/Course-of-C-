using _12_Events.Lib;
using _12_Events.Lib.Messenger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnVideoEncode.Click += EventClick;
        }

        public void EventClick(object sender, EventArgs e)
        {
            Video video = new Video { Name = "video.mp4" };
            VideoEncode videoEncode = new VideoEncode();

            videoEncode.Encoded += new Email().SendMessage;
            videoEncode.Encoded += new Sms().SendMessage;

            videoEncode.Encode(video);
        }
    }
}
