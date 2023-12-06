using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programação_06._09
{
    public partial class Form4 : Form
    {
        private int userId;
        public Form4(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            panel1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection connect = new Connection();
            SqlConnection connection = connect.ReturnConnection();

            string query = "SELECT * FROM Tabela2 WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", userId);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Document document = new Document();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            PdfWriter.GetInstance(document, new FileStream(path + "/Relatorio.pdf", FileMode.Create));
            document.Open();
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    document.Add(new Paragraph(row[column].ToString()));
                }
            }
            document.Close();
            connect.CloseConnection();

            MessageBox.Show("Relatório gerado com sucesso!");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
