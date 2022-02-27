using System;
using System.IO;
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
            DataLoad();
            Initialize = true;
            client = new DiscordRpcClient(AppID);
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();
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
            subtext = TbsubText.Text;

        }

        private void TBDetails_TextChanged(object sender, EventArgs e)
        {
            details = TBDetails.Text;

        }

        private void TbBID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);  // makes sure only numeral digits can be entered.
        }

        private void TbBID_TextChanged(object sender, EventArgs e)
        {
            BigImageID = TbBID.Text;

        }

        private void TbsID_TextChanged(object sender, EventArgs e)
        {
            SmallImageID = TbsID.Text;




        }


        private void TBBtxt_TextChanged(object sender, EventArgs e)
        {
            BigImageTxt = TbsID.Text;

        }

        private void TBStxt_TextChanged(object sender, EventArgs e)
        {

            SmallImageTxt = TBStxt.Text;


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

            DataSave(); // saves the data

        }


        private void DataLoad()
        {
            try
            {
                var first = new System.IO.StreamReader("C:\\ProgramData\\KongolianDII\\first.ID");
                string FirstTime = first.ReadLine();
                first.Close();


                if(FirstTime == "True")
                {
                    var first2 = new System.IO.StreamWriter("C:\\ProgramData\\KongolianDII\\first.ID");
                    first2.Write("False");
                    first2.Close();
                }

                var d = new System.IO.StreamReader("C:\\ProgramData\\KongolianDII\\Data.ID");
                AppID = d.ReadLine();
                details = d.ReadLine();
                subtext = d.ReadLine();
                BigImageID = d.ReadLine();
                SmallImageID = d.ReadLine();
                BigImageTxt = d.ReadLine();
                SmallImageTxt = d.ReadLine();
                timeStamps = bool.Parse(d.ReadLine());
                d.Close();

                TBAppID.Text = AppID;
                TBDetails.Text = details;
                TbsubText.Text = subtext;
                TbBID.Text = BigImageID;
                TbsID.Text = SmallImageID;
                TBBtxt.Text = BigImageTxt;
                TBStxt.Text = SmallImageTxt;
                CBTimeStamps.Checked = timeStamps;





            }
            catch (DirectoryNotFoundException)
            {
                DirectoryInfo di = new DirectoryInfo("C:\\ProgramData\\KongolianDII\\");
                di.Create();



                var first = new System.IO.StreamWriter("C:\\ProgramData\\KongolianDII\\first.ID");
                first.Write("True");
                first.Close();


                var Data = new System.IO.StreamWriter("C:\\ProgramData\\KongolianDII\\Data.ID");
                Data.WriteLine("947177821787271210"); // AppID
                Data.WriteLine("Cool discord integration app made by Drkongy"); // details
                Data.WriteLine("Testing An Amazing App"); // subtext
                Data.WriteLine("monkiclickercursordarkhd_1"); // bigimageID
                Data.WriteLine("monkiclickercursordarkhd_1"); // SmallImageID
                Data.WriteLine("Big Image Text"); // bigImageText
                Data.WriteLine("Small Image Text"); // SmallImageText
                Data.WriteLine("True"); // TimeStamps
                Data.Close();
            }

   

            AppID = "947177821787271210";


        }



        private void DataSave()
        {
            var Data = new System.IO.StreamWriter("C:\\ProgramData\\KongolianDII\\Data.ID");
            Data.WriteLine(AppID); // AppID
            Data.WriteLine(details); // details
            Data.WriteLine(subtext); // subtext
            Data.WriteLine(BigImageID); // bigimageID
            Data.WriteLine(SmallImageID); // SmallImageID
            Data.WriteLine(BigImageTxt); // bigImageText
            Data.WriteLine(SmallImageTxt); // SmallImageText
            Data.WriteLine(timeStamps); // TimeStamps
            Data.Close();
        }


    }
}