using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameWare.Helpers;
using GameWare.Controllers;
using GameWare.Models;

namespace GameWare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlatformController platformController = new PlatformController();
            List<Platform> platforms = platformController.getPlatforms();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = platforms;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "code";
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Platform selectedPlatform = (Platform)comboBox1.SelectedItem;
            string platformCode = selectedPlatform.code;
            string query = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(query) && platformCode != "any")
            {
                GameController gameController = new GameController();
                List<Game> games = gameController.getGamesByQuery(query, platformCode);
                listBox1.DataSource = games;
                listBox1.DisplayMember = "name";
                if (games.Count > 0)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
            }
            else if (!string.IsNullOrWhiteSpace(query) && platformCode == "any")
            {
                GameController gameController = new GameController();
                List<Game> games = gameController.getGamesByQuery(query);
                listBox1.DataSource = games;
                listBox1.DisplayMember = "name";
                if (games.Count > 0)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Game selectedGame = (Game)listBox1.SelectedItem;
            int id = selectedGame.id;
            Downloader downloader = new Downloader(id);
            downloader.Show();
        }
    }
}
