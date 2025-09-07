using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Text.Json;
using ID_Card_Inventory.Photopea;

namespace ID_Card_Inventory
{
    public partial class PhotopeaForm : Form
    {
        public PhotopeaForm()
        {
            InitializeComponent();
           var _config  = new PhotopeaConfig();

        }

        private async void PhotopeaForm_Load(object sender, EventArgs e)
        {
            var webView21 = PhotopeaWebView;
             await PhotopeaConfig.OpenInPhotopeaAsync(webView21);
        }
    }
}
