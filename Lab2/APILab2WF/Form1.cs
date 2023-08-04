using System.Windows.Forms;
using APILab2WF.DTO;

namespace APILab2WF
{
    public partial class Form1 : Form
    {
        HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44363/api/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HttpResponseMessage resp = client.GetAsync("Student").Result;

            if (resp.IsSuccessStatusCode)
            {
                List<StudentDTO> stds = resp.Content.ReadAsAsync<List<StudentDTO>>().Result;
                dvgStudents.DataSource = stds;
                comSup.DisplayMember = "St_Fname";
                comSup.ValueMember = "St_Id";
                comSup.DataSource = stds;
            }

            HttpResponseMessage mess = client.GetAsync("Department").Result;
            if (mess.IsSuccessStatusCode)
            {
                List<DepartmentDTO> depts = mess.Content.ReadAsAsync<List<DepartmentDTO>>().Result;

                comDept.DisplayMember = "Dept_Name";
                comDept.ValueMember = "Dept_Id";
                comDept.DataSource = depts;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new StudentDTO()
            {
                St_Fname = txtFName.Text,
                St_Lname = txtLName.Text,
                St_Address = txtAdd.Text,
                St_Age = (int)numAge.Value,
                Dept_Id = (int)comDept.SelectedValue,
                St_super = (int)comSup.SelectedValue,
            };
            HttpResponseMessage res = client.PostAsJsonAsync("Student", student).Result;
            if (res.IsSuccessStatusCode)
            {
                Form1_Load(null, null);
            }
        }

        private void dvgStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}