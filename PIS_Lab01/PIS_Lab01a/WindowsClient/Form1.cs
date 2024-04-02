using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class Form1 : Form
    {
        private readonly HttpClient httpClient;
        public Form1()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string paramX = textBox1.Text;
            string paramY = textBox2.Text;

            var formData = new MultipartFormDataContent();
            formData.Add(new StringContent(paramX), "X");
            formData.Add(new StringContent(paramY), "Y");

            try
            {
                var response = await httpClient.PostAsync("http://localhost:5062/sum", formData);
                response.EnsureSuccessStatusCode();

                string responseText = await response.Content.ReadAsStringAsync();
                label1.Text = responseText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
