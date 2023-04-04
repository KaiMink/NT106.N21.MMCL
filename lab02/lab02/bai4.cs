using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace lab02
{   //class sv
    
    public partial class bai4 : Form
    {
        //tạo ds sinh viên
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        public bai4()
        {
            InitializeComponent();
        }
        
        //check thông số:
        bool checkThongSo(string person)
        {
            string[] in4 = person.Split('\n');
            //check tên
            foreach (char c in in4[0])
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("tên không đúng định dạng");
                    return false;
                }
            }
            //check ID
            int ID;
            if (!int.TryParse(in4[1], out ID)||in4[1].Length!=8)
            {
                MessageBox.Show("ID không đúng định dạng");
                return false;
            }
            //check phone
            foreach (char c in in4[2])
            {
                if (!char.IsNumber(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("SDT không đúng định dạng");
                    return false;
                }
            }
            //ktra số chữ số 
            if(in4[2].Length!=10)
            {
                MessageBox.Show("SDT không đủ 10 số");
            }
            //ktra chữ số đầu 
            if(!in4[2].StartsWith("0"))
            {
                MessageBox.Show("SDT không bắt đầu bằng số 0");
            }
            //check điểm môn 1 2 3 
            double d1=Convert.ToDouble(textd1W.Text), d2 = Convert.ToDouble(textd2W.Text), d3 = Convert.ToDouble(textd3W.Text);
            if (d1 > 10 || d1 < 0 || d2 > 10 || d2 < 0 || d3 > 10 || d2 < 0)
            {
                MessageBox.Show("điểm không đúng định dạng");
                return false;
            }
            if (!double.TryParse(in4[3], out d1) || !double.TryParse(in4[4], out d2) || !double.TryParse(in4[5], out d3))
            {
                MessageBox.Show("điểm không đúng định dạng");
                return false;
            }
            else
                return true;
        }

        //in thông tin
        void Inthongtin(SinhVien sv)
        {
            textNameR.Text = sv.HoTen;
            textIDR.Text = Convert.ToString(sv.MSSV);
            textPhoneR.Text = sv.DienThoai;
            textd1R.Text = Convert.ToString(sv.DiemMon1);
            textd2R.Text = Convert.ToString(sv.DiemMon2);
            textd3R.Text = Convert.ToString(sv.DiemMon3);
            textTBMR.Text = Convert.ToString(sv.DiemTrungBinh);
        }
        
        private void buttReadFi_Click(object sender, EventArgs e)
        {
            // Đọc danh sách sinh viên từ file bằng BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream("input4.txt", FileMode.Open);
            List<SinhVien> danhSachSinhVien = (List<SinhVien>)formatter.Deserialize(fs);
            fs.Close();

            //tính dtb
            foreach (SinhVien sv in danhSachSinhVien)
            {
                float dtb = (sv.DiemMon1 + sv.DiemMon2 + sv.DiemMon3) / 3.0f;
                sv.DiemTrungBinh = dtb;
            }

            //ghi vào output4
            FileStream fs2 = new FileStream("output4.txt", FileMode.OpenOrCreate);
            formatter.Serialize(fs2, danhSachSinhVien);
            Inthongtin(danhSachSinhVien[0]);
            foreach (SinhVien sv in danhSachSinhVien)
            {
                richTextBox1.Text += sv.HoTen + "\n" + Convert.ToString(sv.MSSV) + "\n" + sv.DienThoai + "\n" + Convert.ToString(sv.DiemMon1) + "\n" + Convert.ToString(sv.DiemMon2) + "\n" + Convert.ToString(sv.DiemMon3) + "\n" + Convert.ToString(sv.DiemTrungBinh) + "\n" + "\n";
            }
            fs2.Close();
        }
        private void buttBack_Click(object sender, EventArgs e)
        {
            int index = int.Parse(STT.Text);

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream("output4.txt", FileMode.Open);
            List<SinhVien> danhSachSinhVien = (List<SinhVien>)formatter.Deserialize(fs);
            if (index == 1)
                MessageBox.Show("Đây là sinh viên đầu tiên");
            else
            {
                index--;
                STT.Text = Convert.ToString(index);
                Inthongtin(danhSachSinhVien[index-1]);
            }
            fs.Close();
        }

        private void buttNext_Click(object sender, EventArgs e)
        {
            int index = int.Parse(STT.Text);

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream("output4.txt", FileMode.Open);
            List<SinhVien> danhSachSinhVien = (List<SinhVien>)formatter.Deserialize(fs);


            if (index == danhSachSinhVien.Count)
                MessageBox.Show("Đây là sinh viên cuối cùng");
            else
            {
                index++;
                STT.Text = Convert.ToString(index);
                Inthongtin(danhSachSinhVien[index-1]);
            }
            fs.Close();
        }

        private void buttAdd_Click(object sender, EventArgs e)
        {
            string person = textNameW.Text + "\n" + textIDW.Text + "\n" + textPhoneW.Text + "\n" + textd1W.Text + "\n" + textd2W.Text + "\n" + textd3W.Text;
            if(!checkThongSo(person))
            {
                textNameW.Clear();
                textIDW.Clear();
                textPhoneW.Clear();
                textd1W.Clear();
                textd2W.Clear();
                textd3W.Clear();
                return;
            }
            // Lấy thông tin của sinh viên từ form
            string hoTen = textNameW.Text;
            int mssv = int.Parse(textIDW.Text);
            string dienThoai = textPhoneW.Text;
            float diemMon1 = float.Parse(textd1W.Text);
            float diemMon2 = float.Parse(textd2W.Text);
            float diemMon3 = float.Parse(textd3W.Text);

            // Tạo một sinh viên mới
            SinhVien sv = new SinhVien
            {
                HoTen = hoTen,
                MSSV = mssv,
                DienThoai = dienThoai,
                DiemMon1 = diemMon1,
                DiemMon2 = diemMon2,
                DiemMon3 = diemMon3
            };

            // Thêm sinh viên vào danh sách
            danhSachSinhVien.Add(sv);

            // Xóa thông tin của sinh viên vừa nhập
            textNameW.Clear();
            textIDW.Clear();
            textPhoneW.Clear();
            textd1W.Clear();
            textd2W.Clear();
            textd3W.Clear();

            //in vào richtextbox
            richTextBox1.Text += person + "\n" + "\n";
        }

        private void butwWrFi_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream("input4.txt", FileMode.OpenOrCreate);
            //chuyển data thành byte và lưu vào file
            formatter.Serialize(fs, danhSachSinhVien);
            fs.Close();
            textNameW.Clear();
            textIDW.Clear();
            textPhoneW.Clear();
            textd1W.Clear();
            textd2W.Clear();
            textd3W.Clear();
            richTextBox1.Clear();
            MessageBox.Show("Lưu thành công");
        }

        private void buttB5_Click(object sender, EventArgs e)
        {
            bai5 f = new bai5();
            f.Show();
            this.Hide();
        }
    }
    [Serializable]
    public class SinhVien
    {
        public string HoTen { get; set; }
        public int MSSV { get; set; }
        public string DienThoai { get; set; }
        public float DiemMon1 { get; set; }
        public float DiemMon2 { get; set; }
        public float DiemMon3 { get; set; }
        public float DiemTrungBinh { get; set; }
    }
}

