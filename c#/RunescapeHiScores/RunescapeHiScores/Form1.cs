using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace RunescapeHiScores
{
    public partial class Form1 : Form
    {
        private WebClient _client;
      //  private const string ROOT_URL = "http://services.runescape.com/m=hiscore/index_lite.ws?player=";
        private String RSuserOne, RSuserTwo;
      private string[][] userTwoArray;
        private string[][] userOneArray;
        

        public string[][] UserOneArray
        {
            get
            {
                return userOneArray;
            }

            set
            {
                userOneArray = value;
            }
        }

   

   
        public Form1()
        {
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _client = new WebClient();
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
          string Player1 = _client.DownloadString("http://services.runescape.com/m=hiscore/index_lite.ws?player=" + RSuserOne);
           userTwoArray = Player1.Split('\n').Select(t => t.Split(',')).ToArray();
           // listBox1.Items.Add(userTwoArray[0][1]);
        }


 

        // Parses HTML into a two-dimensional string array
        private string[][] Parse(string html)
        {
            return html.Split('\n').Select(t => t.Split(',')).ToArray();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form2(RSuserOne).Show();
            
            this.Hide();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RSuserOne = textBox1.Text;
            try
            {
                string Player1 =
                    _client.DownloadString("http://services.runescape.com/m=hiscore/index_lite.ws?player=" + RSuserOne);
                userTwoArray = Player1.Split('\n').Select(t => t.Split(',')).ToArray();
                extraButton.Visible = true;
                if (userOneSkill1 != null)
                {
                    addLevelToPlayerOne();
                    addXPToPlayerOne();

                }
            }
            catch (Exception)
            {
                extraButton.Visible = true;
            }




           

            
            
        }

        private void addXPToPlayerOne()
        {
            userOneXP1.Text = userTwoArray[0][2];
                            userOneXP2.Text = userTwoArray[1][2];
            userOneXP3.Text = userTwoArray[2][2];
            userOneXP4.Text = userTwoArray[3][2];
            userOneXP5.Text = userTwoArray[4][2];
            userOneXP6.Text = userTwoArray[5][2];
            userOneXP7.Text = userTwoArray[6][2];
            userOneXP8.Text = userTwoArray[7][2];
            userOneXP9.Text = userTwoArray[8][2];
            userOneXP10.Text = userTwoArray[9][2];
            userOneXP11.Text = userTwoArray[10][2];
            userOneXP12.Text = userTwoArray[11][2];
            userOneXP13.Text = userTwoArray[12][2];
            userOneXP14.Text = userTwoArray[13][2];
            userOneXP15.Text = userTwoArray[14][2];
            userOneXP16.Text = userTwoArray[15][2];
            userOneXP17.Text = userTwoArray[16][2];
            userOneXP18.Text = userTwoArray[17][2];
            userOneXP19.Text = userTwoArray[18][2];
            userOneXP20.Text = userTwoArray[19][2];
            userOneXP21.Text = userTwoArray[20][2];
            userOneXP22.Text = userTwoArray[21][2];
            userOneXP23.Text = userTwoArray[22][2];
            userOneXP24.Text = userTwoArray[23][2];
            userOneXP25.Text = userTwoArray[24][2];
            userOneXP26.Text = userTwoArray[25][2];
            userOneXP27.Text = userTwoArray[26][2];
            userOneXP28.Text = userTwoArray[27][2];
     
        }

        private void addLevelToPlayerOne()
        {
            Debug.Assert(userOneSkill1 != null, "userOneSkill1 != null");
            userOneSkill1.Text = userTwoArray[0][1];
                userOneSkill2.Text = userTwoArray[1][1];
                userOneSkill3.Text = userTwoArray[2][1];
                userOneSkill4.Text = userTwoArray[3][1];
                userOneSkill5.Text = userTwoArray[4][1];
                userOneSkill6.Text = userTwoArray[5][1];
                userOneSkill7.Text = userTwoArray[6][1];
                userOneSkill8.Text = userTwoArray[7][1];
                userOneSkill9.Text = userTwoArray[8][1];
                userOneSkill10.Text = userTwoArray[9][1];
                userOneSkill11.Text = userTwoArray[10][1];
                userOneSkill12.Text = userTwoArray[11][1];
                userOneSkill13.Text = userTwoArray[12][1];
                userOneSkill14.Text = userTwoArray[13][1];
                userOneSkill15.Text = userTwoArray[14][1];
                userOneSkill16.Text = userTwoArray[15][1];
                userOneSkill17.Text = userTwoArray[16][1];
                userOneSkill18.Text = userTwoArray[17][1];
                userOneSkill19.Text = userTwoArray[18][1];
                userOneSkill20.Text = userTwoArray[19][1];
                userOneSkill21.Text = userTwoArray[20][1];
                userOneSkill22.Text = userTwoArray[21][1];
                userOneSkill23.Text = userTwoArray[22][1];
                userOneSkill24.Text = userTwoArray[23][1];
                userOneSkill25.Text = userTwoArray[24][1];
                userOneSkill26.Text = userTwoArray[25][1];
                userOneSkill27.Text = userTwoArray[26][1];
                userOneSkill28.Text = userTwoArray[27][1];
            
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RSuserTwo = textBox106.Text;
            string Player2 =
                _client.DownloadString("http://services.runescape.com/m=hiscore/index_lite.ws?player=" + RSuserTwo);
            UserOneArray = Player2.Split('\n').Select(t => t.Split(',')).ToArray();


       
            if (userOneSkill1 != null)
            {
                addLevelToPlayerTwo();
                addXPToPlayerOneTwo();

            }

        }

        private void addLevelToPlayerTwo()
        {
            userTwoSkill1.Text = UserOneArray[0][1];
            userTwoSkill2.Text = UserOneArray[1][1];
            userTwoSkill3.Text = UserOneArray[2][1];
            userTwoSkill4.Text = UserOneArray[3][1];
            userTwoSkill5.Text = UserOneArray[4][1];
            userTwoSkill6.Text = UserOneArray[5][1];
            userTwoSkill7.Text = UserOneArray[6][1];
            userTwoSkill8.Text = UserOneArray[7][1];
            userTwoSkill9.Text = UserOneArray[8][1];
            userTwoSkill10.Text = UserOneArray[9][1];
            userTwoSkill11.Text = UserOneArray[10][1];
            userTwoSkill12.Text = UserOneArray[11][1];
            userTwoSkill13.Text = UserOneArray[12][1];
            userTwoSkill14.Text = UserOneArray[13][1];
            userTwoSkill15.Text = UserOneArray[14][1];
            userTwoSkill16.Text = UserOneArray[15][1];
            userTwoSkill17.Text = UserOneArray[16][1];
            userTwoSkill18.Text = UserOneArray[17][1];
            userTwoSkill19.Text = UserOneArray[18][1];
            userTwoSkill20.Text = UserOneArray[19][1];
            userTwoSkill21.Text = UserOneArray[20][1];
            userTwoSkill22.Text = UserOneArray[21][1];
            userTwoSkill23.Text = UserOneArray[22][1];
            userTwoSkill24.Text = UserOneArray[23][1];
            userTwoSkill25.Text = UserOneArray[24][1];
            userTwoSkill26.Text = UserOneArray[25][1];
            userTwoSkill27.Text = UserOneArray[26][1];
            userTwoSkill28.Text = UserOneArray[27][1];
        }

        private void addXPToPlayerOneTwo()
        {
            userTwoXP1.Text = UserOneArray[0][2];
            userTwoXP2.Text = UserOneArray[1][2];
            userTwoXP3.Text = UserOneArray[2][2];
            userTwoXP4.Text = UserOneArray[3][2];
            userTwoXP5.Text = UserOneArray[4][2];
            userTwoXP6.Text = UserOneArray[5][2];
            userTwoXP7.Text = UserOneArray[6][2];
            userTwoXP8.Text = UserOneArray[7][2];
            userTwoXP9.Text = UserOneArray[8][2];
            userTwoXP10.Text = UserOneArray[9][2];
            userTwoXP11.Text = UserOneArray[10][2];
            userTwoXP12.Text = UserOneArray[11][2];
            userTwoXP13.Text = UserOneArray[12][2];
            userTwoXP14.Text = UserOneArray[13][2];
            userTwoXP15.Text = UserOneArray[14][2];
            userTwoXP16.Text = UserOneArray[15][2];
            userTwoXP17.Text = UserOneArray[16][2];
            userTwoXP18.Text = UserOneArray[17][2];
            userTwoXP19.Text = UserOneArray[18][2];
            userTwoXP20.Text = UserOneArray[19][2];
            userTwoXP21.Text = UserOneArray[20][2];
            userTwoXP22.Text = UserOneArray[21][2];
            userTwoXP23.Text = UserOneArray[22][2];
            userTwoXP24.Text = UserOneArray[23][2];
            userTwoXP25.Text = UserOneArray[24][2];
            userTwoXP26.Text = UserOneArray[25][2];
            userTwoXP27.Text = UserOneArray[26][2];
            userTwoXP28.Text = UserOneArray[27][2];
        }
    }


}
