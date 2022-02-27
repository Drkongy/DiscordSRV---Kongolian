using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;


namespace DiscordSRV___Kongolian
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        // discord srv init Stuff
        public DiscordRpcClient client;
        bool Initialize = false;


        // Variables
        public String AppID;
        public String subtext;
        public String details;
        public String BigImageID;
        public String SmallImageID;
        public String BigImageTxt;
        public String SmallImageTxt;
        public bool timeStamps = true;



        // for when the form loads

        private void Main_Load(object sender, EventArgs e)
        {

        }

        // Windows bar code

        Point lastPoint;
        bool mousedown;
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WindowBar_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y); // records the position of the mouse.
            mousedown = true;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void WindowBar_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;

        }



        // Main App

        //Application ID / Init
        private void TBAppID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);  // makes sure only numeral digits can be entered.

        }
        private void TBAppID_TextChanged(object sender, EventArgs e)
        {

            AppID = TBAppID.Text;

            // ini
            if(TBAppID.Text == "")
            {
                label2.Text = "Please Enter Valid ID";

            }
            else
            {
                if (AppID != "" || AppID != null)
                {
                    label2.Text = "The Application ID is usally 16 - 20 Characters long!";
                    Initialize = true;
                    client = new DiscordRpcClient(AppID);
                    client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
                    client.Initialize();
                }
            }


        }




        // for sub text
        private void TbsubText_TextChanged(object sender, EventArgs e)
        {
            if (TBAppID.Text == "")
            {
                LblError.Text = "Please Enter Valid Text";

            }
            else
            {
                LblError.Text = "";

                subtext = TbsubText.Text;

            }
        }

        private void TBDetails_TextChanged(object sender, EventArgs e)
        {
            if (TBDetails.Text == "")
            {
                LblError.Text = "Please Enter Valid Text";

            }
            else
            {
                LblError.Text = "";

                details = TBDetails.Text;

            }
        }

        private void TbBID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);  // makes sure only numeral digits can be entered.
        }

        private void TbBID_TextChanged(object sender, EventArgs e)
        {
            if (TbBID.Text == "")
            {
                LblError.Text = "Please Enter Valid Image ID";

            }
            else
            {
                LblError.Text = "";

                BigImageID = TbBID.Text;

            }
        }

        private void TbsID_TextChanged(object sender, EventArgs e)
        {
            if (TbsID.Text == "")
            {
                LblError.Text = "Please Enter Valid Image ID";

            }
            else
            {
                LblError.Text = "";

                SmallImageID = TbsID.Text;

            }
        }


        private void TBBtxt_TextChanged(object sender, EventArgs e)
        {
            if (TBBtxt.Text == "")
            {
                LblError.Text = "Please Enter Valid Image Text";

            }
            else
            {
                LblError.Text = "";

                BigImageTxt = TbsID.Text;

            }
        }

        private void TBStxt_TextChanged(object sender, EventArgs e)
        {
            if (TBStxt.Text == "")
            {
                LblError.Text = "Please Enter Valid Image Text";

            }
            else
            {
                LblError.Text = "";

                SmallImageTxt = TBStxt.Text;

            }
        }

        private void CBTimeStamps_CheckedChanged(object sender, EventArgs e)
        {
            if(CBTimeStamps.Checked == true)
            {
                timeStamps = true;
            }
            else
            {
                timeStamps = false;
            }
        }


 






        // the button that displays stuff to the rich presence.
        private void BtnBuild_Click(object sender, EventArgs e)
        {

              subtext = TbsubText.Text;
              details = TBDetails.Text;
              BigImageID = TbBID.Text;
              SmallImageID = TbsID.Text;
              BigImageTxt = TBBtxt.Text;
              SmallImageTxt = TBStxt.Text;



            if(timeStamps == true)
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {

                    Details = $"{details}",
                    State = $"{subtext}",
                    Timestamps = Timestamps.Now,

                    Assets = new Assets()
                    {
                        LargeImageKey = $"{BigImageID}",
                        LargeImageText = $"{BigImageTxt}",
                        SmallImageKey = $"{SmallImageID}",
                        SmallImageText = $"{SmallImageTxt}"
                    }
                });
            }
            else
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {

                    Details = $"{details}",
                    State = $"{subtext}",
                    //Timestamps = Timestamps.Now,

                    Assets = new Assets()
                    {
                        LargeImageKey = $"{BigImageID}",
                        LargeImageText = $"{BigImageTxt}",
                        SmallImageKey = $"{SmallImageID}",
                        SmallImageText = $"{SmallImageTxt}"
                    }
                });
            }



            }


    }
}