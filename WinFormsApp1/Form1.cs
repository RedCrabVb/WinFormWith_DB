using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {


        static string datasource = @"DESKTOP-EU75ISF\MSSQLSERVER01";//your server
        static string database = "some_doctors"; //your database name

        static string connString = @"Data Source=" + datasource + ";Initial Catalog="
            + database + ";Integrated Security=SSPI";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //your connection string 


            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                Console.WriteLine("hello, good connect");

                string cmd = "(SELECT * FROM dbo.[Врач])";
                using (SqlCommand command = new SqlCommand(cmd, con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["ФИО"].ToString());

                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        row.Cells[0].Value = reader["ФИО"].ToString();
                        row.Cells[1].Value = reader["Должность"].ToString();
                        row.Cells[2].Value = reader["Оклад"].ToString();
                        row.Cells[3].Value = reader["Телефон"].ToString();
                        row.Cells[4].Value = reader["Паспортные данные"].ToString();
                        row.Cells[5].Value = reader["Примечание"].ToString();
                        row.Cells[6].Value = reader["Стаж работы по специальности"].ToString();
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = textBoxFIO.Text;
            row.Cells[1].Value = textBoxProffesion.Text;
            row.Cells[2].Value = textBoxAmount.Text;
            row.Cells[3].Value = textBoxPhone.Text;
            row.Cells[4].Value = textBoxPassport.Text;
            row.Cells[5].Value = textBoxNote.Text;
            row.Cells[6].Value = textBoxWorkYear.Text;
            dataGridView1.Rows.Add(row);

            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();

                    string cmd = "insert into dbo.[Врач] ([ФИО], [Должность], [Квалификация], " +
                        "[Стаж работы по специальности], [Оклад], [Телефон], [Паспортные данные], [Примечание]) values " +
                        "('" + textBoxFIO.Text + "', '" + textBoxProffesion.Text + "', '--', " + textBoxWorkYear.Text + ", " +
                        "'" + textBoxAmount.Text + "', " +
                        "'" + textBoxPhone.Text + "', '" + textBoxPassport.Text + "', '" + textBoxNote.Text + "')";


                    adapter.InsertCommand = new SqlCommand(cmd, con);
                    adapter.InsertCommand.ExecuteNonQuery();
                }
            } catch(Exception f) {
                MessageBox.Show("error save: " + f.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}