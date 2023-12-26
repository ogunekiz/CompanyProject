using Company.Entity.Concrete;
using Newtonsoft.Json;
using System.Text;
using System.Windows.Forms;

namespace Company.WinForm
{
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }

        string apiUrl = "http://localhost:1616/api/";
        private void frmPersonel_Load(object sender, EventArgs e)
        {
            GetPersonelList();
        }

        public async void GetPersonelList()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(apiUrl);
            HttpResponseMessage response = await client.GetAsync("Personel/GetPersonelList");
            string data = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<List<Personel>>(data);

            dgPersonel.DataSource = result;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNo.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurName.Text) || string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("Please do not leave the fields blank.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int no = Convert.ToInt32(txtNo.Text);
                string name = txtName.Text;
                string surName = txtSurName.Text;
                string city = txtCity.Text;

                Personel newPersonel = new Personel()
                {
                    No = no,
                    Name = name,
                    SurName = surName,
                    City = city,
                };

                var json = JsonConvert.SerializeObject(newPersonel);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                using (var client = new HttpClient())
                {
                    var url = $"{apiUrl}Personel/AddPersonel";

                    HttpResponseMessage responseMessage = client.PostAsync(url, data).Result;

                    if (responseMessage.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Personel successfully registered.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetPersonelList();
                        FormClear();
                    }
                }
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);
            int no = Convert.ToInt32(txtNo.Text);
            string name = txtName.Text;
            string surName = txtSurName.Text;
            string city = txtCity.Text;

            Personel newPersonel = new Personel()
            {
                Id = id,
                No = no,
                Name = name,
                SurName = surName,
                City = city,
            };

            var json = JsonConvert.SerializeObject(newPersonel);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using (var client = new HttpClient())
            {
                var url = $"{apiUrl}Personel/UpdatePersonel";

                HttpResponseMessage responseMessage = client.PostAsync(url, data).Result;

                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Personel successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetPersonelList();
                    FormClear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);

            using (var client = new HttpClient())
            {
                var url = $"{apiUrl}Personel/DeletePersonel?id={id}";

                HttpResponseMessage responseMessage = client.DeleteAsync(url).Result;

                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Personel successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetPersonelList();
                    FormClear();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgPersonel.Rows[e.RowIndex];

                lblId.Text = row.Cells["Id"].Value.ToString();
                txtNo.Text = row.Cells["No"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtSurName.Text = row.Cells["SurName"].Value.ToString();
                txtCity.Text = row.Cells["City"].Value.ToString();
            }
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            dgPersonel.DataSource = null;
            GetPersonelList();
        }

        private void txtNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        void FormClear()
        {
            txtNo.Clear();
            txtName.Clear();
            txtSurName.Clear();
            txtCity.Clear();
        }
    }
}
