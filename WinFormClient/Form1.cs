using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormClient.Models;

namespace WinFormClient
{
    public partial class Form1 : Form
    {
        public readonly string _baseUrl = @"http://localhost:59652/api/Employee/GetAllEmployee";

        public Form1()
        {
            InitializeComponent();
            GetAllEmployee();
        }
        private async void GetAllEmployee()
        {
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri(_baseUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(_baseUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        var employeeList = JsonConvert.DeserializeObject<IList<EmployeeModel>>(result);
                        grdEmployee.DataSource = employeeList.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : {0}", ex.Message.ToString());                
            }


        }
    }
}
