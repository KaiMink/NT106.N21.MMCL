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
using Newtonsoft.Json;
namespace Week6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            // Khai báo URL của API ToDo List
            string apiUrl = "https://jsonplaceholder.typicode.com/todos";

            // Khởi tạo HTTP Client
            var httpClient = new HttpClient();

            try
            {
                // Gọi API để lấy toàn bộ danh sách các task
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                // Đọc kết quả trả về dưới dạng chuỗi JSON
                string responseBody = await response.Content.ReadAsStringAsync();

                // Chuyển đổi chuỗi JSON thành danh sách các task
                var tasks = JsonConvert.DeserializeObject<Task[]>(responseBody);

                // Hiển thị danh sách các task lên DataGridView
                dataGridView1.DataSource = tasks;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    
    }
    class Task
    {
        public int userId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
    }
}
