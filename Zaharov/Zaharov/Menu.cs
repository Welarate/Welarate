using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Zaharov
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            con.Open();
            
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UJNMDI1\SQLEXPRESS;Initial Catalog=ZaharovBase;Integrated Security=True");
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        string now_tab; 
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f.Show();
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabs("Category");
            now_tab = "Category";
            закрытьВсеВкладкиToolStripMenuItem.Enabled = true;
        }

        private void tabs(string s)
        {
            ds.Tables.Clear();
            da.Dispose();
            SqlCommand cmd = new SqlCommand("Select * From " + s, con);
            da.SelectCommand = cmd;
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void основаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabs("client");
            now_tab = "client";
            закрытьВсеВкладкиToolStripMenuItem.Enabled = true;
        }

        private void ПродажаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabs("sale");
            now_tab = "sale";
            закрытьВсеВкладкиToolStripMenuItem.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            dataGridView1.Visible = false;
            switch (now_tab)
            {
                case "Category":
                    Name_category_text.Text = "";
                    break;
                case "client":
                    code_client_text.Text = "";
                    first_name_text.Text = "";
                    Last_name_text.Text = "";
                    Soure_id_text.Text = "";
                    break;
                case "sale":
                    client_id_text.Text = "";
                    sale_number_text.Text = "";
                    dateTimePicker1.Value = Convert.ToDateTime(DateTime.Now);
                    dateTimePicker2.Value = Convert.ToDateTime(DateTime.Now);
                    sale_sum_text.Text = "";
                    status_id_text.Text = "";
                    break;
            }



            switch (now_tab)
            {
                case "Category":
                    menuStrip1.Enabled = false;
                    category_panel.Visible = true;
                    Add_button.Visible = true;
                    Return_button.Visible = true;
                    break;
                case "client":
                    menuStrip1.Enabled = false;
                    client_panel.Visible = true;
                    Add_button.Visible = true;
                    Return_button.Visible = true;
                    break;
                case "sale":
                    menuStrip1.Enabled = false;
                    sale_panel.Visible = true;
                    Add_button.Visible = true;
                    Return_button.Visible = true;
                    break;
                default:
                    MessageBox.Show("Выберите вкладку");
                    dataGridView1.Visible = true;
                    break;
            }



        }

        
        private void Add_button_Click(object sender, EventArgs e)
        {
            switch (now_tab)
            {
                case "Category":
                    SqlCommand cmd = new SqlCommand("Insert into Category (name) Values (@name)", con);
                    cmd.Parameters.AddWithValue("@name", Name_category_text.Text);
                    cmd.ExecuteNonQuery();
                    tabs(now_tab);
                    return_tabs_after_add();
                    break;
                case "client":
                    SqlCommand cmd1 = new SqlCommand("Insert into client (code,firstname,lastname,soure_id) Values (@code,@firstname,@lastname,@soure_id)", con);
                    cmd1.Parameters.AddWithValue("@code", code_client_text.Text);
                    cmd1.Parameters.AddWithValue("@firstname", first_name_text.Text);
                    cmd1.Parameters.AddWithValue("@lastname", Last_name_text.Text);
                    cmd1.Parameters.AddWithValue("@soure_id", Convert.ToInt32(Soure_id_text.Text));
                    cmd1.ExecuteNonQuery();
                    tabs(now_tab);
                    return_tabs_after_add();
                    break;
                case "sale":
                    SqlCommand cmd2 = new SqlCommand("Insert into sale (client_id,number,dt_created,dt_modified,sale_sum,status_id) Values (@client_id,@number,@dt_created,@dt_modified,@sale_sum,@status_id)", con);
                    cmd2.Parameters.AddWithValue("@client_id", client_id_text.Text);
                    cmd2.Parameters.AddWithValue("@number", sale_number_text.Text);
                    cmd2.Parameters.AddWithValue("@dt_created", Convert.ToDateTime(dateTimePicker1.Value));
                    cmd2.Parameters.AddWithValue("@dt_modified", Convert.ToDateTime(dateTimePicker2.Value));
                    cmd2.Parameters.AddWithValue("@sale_sum", sale_sum_text.Text);
                    cmd2.Parameters.AddWithValue("@status_id", status_id_text.Text);
                    cmd2.ExecuteNonQuery();
                    tabs(now_tab);
                    return_tabs_after_add();
                    break;
            }
        }

        private void Return_button_Click(object sender, EventArgs e)
        {
            return_tabs_after_add();
        }

        private void return_tabs_after_add()
        {
            panel1.Enabled = true;
            menuStrip1.Enabled = true;
            dataGridView1.Visible = true;
            Add_button.Visible = false;
            Return_button.Visible = false;
            Edit.Visible = false;
            switch (now_tab)
            {
                case "Category":
                    category_panel.Visible = false;
                    break;
                case "client":
                    client_panel.Visible = false;
                    break;
                case "sale":
                    sale_panel.Visible = false;
                    
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (now_tab)
            {
                case "Category":

                    DialogResult result = MessageBox.Show("Вы точно хотите удалить строку?","Удаление", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        SqlCommand cmddel = new SqlCommand("Delete From Category Where id = " + i, con);
                        cmddel.ExecuteNonQuery();
                        tabs(now_tab);
                        return_tabs_after_add();
                    }

                    break;
                case "client":
                    DialogResult result1 = MessageBox.Show("Вы точно хотите удалить строку?", "Удаление", MessageBoxButtons.OKCancel);
                    if (result1 == DialogResult.OK)
                    {
                        int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        SqlCommand cmddel = new SqlCommand("Delete From client Where id = " + i, con);
                        cmddel.ExecuteNonQuery();
                        tabs(now_tab);
                        return_tabs_after_add();
                    }
                    break;
                case "sale":
                    DialogResult result2 = MessageBox.Show("Вы точно хотите удалить строку?","Удаление", MessageBoxButtons.OKCancel);
                    if (result2 == DialogResult.OK)
                    {
                        int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        SqlCommand cmddel = new SqlCommand("Delete From sale Where id = " + i, con);
                        cmddel.ExecuteNonQuery();
                        tabs(now_tab);
                        return_tabs_after_add();
                    }
                    break;
                default:
                    MessageBox.Show("Выберите вкладку");
                    dataGridView1.Visible = true;
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ind = 0;
            if((now_tab != "Category") && (now_tab != "client") && (now_tab != "sale"))
            {
                MessageBox.Show("Выберите вкладку");
            }
            else
            {
                panel1.Enabled = false;
                Edit.Visible = true;
                Return_button.Visible = true;
                dataGridView1.Visible = false;
                ind = dataGridView1.CurrentRow.Index;
                switch (now_tab)
                {

                    case "Category":
                        category_panel.Visible = true;
                        Name_category_text.Text = dataGridView1[1, ind].Value.ToString();
                        break;
                    case "client":
                        client_panel.Visible = true;
                        code_client_text.Text = dataGridView1[1, ind].Value.ToString();
                        first_name_text.Text = dataGridView1[2, ind].Value.ToString();
                        Last_name_text.Text = dataGridView1[3, ind].Value.ToString();
                        Soure_id_text.Text = dataGridView1[4, ind].Value.ToString();
                        break;
                    case "sale":
                        sale_panel.Visible = true;
                        client_id_text.Text = dataGridView1[1, ind].Value.ToString();
                        sale_number_text.Text = dataGridView1[2, ind].Value.ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(dataGridView1[3, ind].Value.ToString());
                        dateTimePicker2.Value = Convert.ToDateTime(dataGridView1[4, ind].Value.ToString());
                        sale_sum_text.Text = dataGridView1[5, ind].Value.ToString();
                        status_id_text.Text = dataGridView1[6, ind].Value.ToString();
                        break;
                }
            }

            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            switch (now_tab)
            {
                case "Category":
                    SqlCommand cmded = new SqlCommand("Update Category set name = @name Where id = " + dataGridView1.CurrentRow.Cells[0].Value, con);
                    cmded.Parameters.AddWithValue("@name", Name_category_text.Text);
                    cmded.ExecuteNonQuery();
                    tabs(now_tab);
                    return_tabs_after_add();
                    break;
                case "client":
                    SqlCommand cmded1 = new SqlCommand("Update client set code = @code, firstname=@firstname, lastname=@lastname,soure_id=@soure_id Where id = " + dataGridView1.CurrentRow.Cells[0].Value, con);
                    cmded1.Parameters.AddWithValue("@code", code_client_text.Text);
                    cmded1.Parameters.AddWithValue("@firstname", first_name_text.Text);
                    cmded1.Parameters.AddWithValue("@lastname", Last_name_text.Text);
                    cmded1.Parameters.AddWithValue("@soure_id", Convert.ToInt32(Soure_id_text.Text));
                    cmded1.ExecuteNonQuery();
                    tabs(now_tab);
                    return_tabs_after_add();
                    break;
                case "sale":
                    SqlCommand cmded2 = new SqlCommand("Update sale set client_id = @client_id, number = @number, dt_created=@dt_created, dt_modified=@dt_modified,sale_sum=@sale_sum,status_id=@status_id Where id = " + dataGridView1.CurrentRow.Cells[0].Value, con);
                    cmded2.Parameters.AddWithValue("@client_id", client_id_text.Text);
                    cmded2.Parameters.AddWithValue("@number", sale_number_text.Text);
                    cmded2.Parameters.AddWithValue("@dt_created", Convert.ToDateTime(dateTimePicker1.Value));
                    cmded2.Parameters.AddWithValue("@dt_modified", Convert.ToDateTime(dateTimePicker2.Value));
                    cmded2.Parameters.AddWithValue("@sale_sum", sale_sum_text.Text);
                    cmded2.Parameters.AddWithValue("@status_id", status_id_text.Text);
                    cmded2.ExecuteNonQuery();
                    tabs(now_tab);
                    return_tabs_after_add();
                    break;
            }
        }

        private void закрытьВсеВкладкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            закрытьВсеВкладкиToolStripMenuItem.Enabled = false;
        }
    }
}


