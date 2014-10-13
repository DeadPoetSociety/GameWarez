using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWare
{
    public partial class Downloader : Form
    {
        int id;

        public Downloader(int id)
        {
            this.id = id;
            InitializeComponent();
            webBrowser1.Url = new Uri("http://coolrom.com/dlpop.php?id=" + id);
            webBrowser1.Visible = true;
            webBrowser1.Show();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
            
        }
    }
}
