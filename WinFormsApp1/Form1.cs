using Newtonsoft.Json;
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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private const string APP_PATH = "http://jsonplaceholder.typicode.com/users/1";
        private static string token;
        User user = new User();

        static HttpClient CreateClient(string accessToken = " ") //создание http-клиента с токеном
        {
            var client = new HttpClient();
            if (!string.IsNullOrWhiteSpace(accessToken))
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            }
            return client;
        }

        static string GetValues(string token) //получение продуктов
        {
            using (var client = CreateClient(token))
            {
                var response = client.GetAsync(APP_PATH).Result;
                
                //var userList = JsonConvert.DeserializeObject<List<User>>(response.ToString());
                return response.Content.ReadAsStringAsync().Result;
            }
        }



        public Form1()
        {
            InitializeComponent();
        }

        public void button1_ClickAsync(object sender, EventArgs e)
        {
            string info = GetValues(token);
            User user = JsonConvert.DeserializeObject<User>(info);

            
                label1.Text = Convert.ToString(user.id);
                label2.Text =Convert.ToString(user.name);
                label3.Text = Convert.ToString(user.username);
                label4.Text = Convert.ToString(user.email);

                label6.Text = Convert.ToString(user.address.street);
                label7.Text = Convert.ToString(user.address.suite);
                label8.Text = Convert.ToString(user.address.city);                
                label9.Text = Convert.ToString(user.address.zipcode);
                label10.Text = Convert.ToString(user.address.Geo.lat);
                label11.Text = Convert.ToString(user.address.Geo.lng);

                label12.Text = Convert.ToString(user.phone);
                label13.Text = Convert.ToString(user.website);
                label14.Text = Convert.ToString(user.Company.name);
                label15.Text = Convert.ToString(user.Company.catchPhrase);
                label16.Text = Convert.ToString(user.Company.bs);



        }
    }
}
