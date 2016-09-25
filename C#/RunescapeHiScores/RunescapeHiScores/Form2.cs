using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunescapeHiScores
{
    public partial class Form2 : Form
    {
        private string[][] userTwoArray;
        private WebClient _client;
        private String UsernamePlayerOne;

        public Form2(string rSuserOne)
        {
            InitializeComponent();
            _client = new WebClient();
            groupBox1.Text = rSuserOne.ToUpper();
            UsernamePlayerOne = null;

            if (rSuserOne.Length == 0)
            {
                groupBox1.Text = "[Username not found.]".ToUpper();
                UsernamePlayerOne = null;
            }


            try
            {
                string Player1 =
                    _client.DownloadString("http://services.runescape.com/m=hiscore/index_lite.ws?player=" + rSuserOne);
                userTwoArray = Player1.Split('\n').Select(t => t.Split(',')).ToArray();
                UsernamePlayerOne = rSuserOne;
            }
            catch (Exception)
            {
                
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (UsernamePlayerOne != null)
              LoadAllPlayersLevels();
            

        }

      

        private void LoadAllPlayersLevels()
        {
            Debug.Assert(userTwoArray != null, "userTwoArray != null");
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            }
    }
}
