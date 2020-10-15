namespace Zaharov
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zaharovBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaharovBaseDataSet = new Zaharov.ZaharovBaseDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Zaharov.ZaharovBaseDataSetTableAdapters.CategoryTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Name_category = new System.Windows.Forms.Label();
            this.Name_category_text = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.Return_button = new System.Windows.Forms.Button();
            this.client_id = new System.Windows.Forms.Label();
            this.sale_number = new System.Windows.Forms.Label();
            this.date_create_sale = new System.Windows.Forms.Label();
            this.sale_number_text = new System.Windows.Forms.TextBox();
            this.client_id_text = new System.Windows.Forms.TextBox();
            this.date_redakt_sale = new System.Windows.Forms.Label();
            this.sale_panel = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.status_id_text = new System.Windows.Forms.TextBox();
            this.status_id = new System.Windows.Forms.Label();
            this.sale_sum_text = new System.Windows.Forms.TextBox();
            this.sale_sum = new System.Windows.Forms.Label();
            this.client_panel = new System.Windows.Forms.Panel();
            this.Soure_id = new System.Windows.Forms.Label();
            this.Last_name = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.Label();
            this.code_client = new System.Windows.Forms.Label();
            this.Soure_id_text = new System.Windows.Forms.TextBox();
            this.Last_name_text = new System.Windows.Forms.TextBox();
            this.first_name_text = new System.Windows.Forms.TextBox();
            this.code_client_text = new System.Windows.Forms.TextBox();
            this.category_panel = new System.Windows.Forms.Panel();
            this.Edit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.закрытьВсеВкладкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaharovBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaharovBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.sale_panel.SuspendLayout();
            this.client_panel.SuspendLayout();
            this.category_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoriesToolStripMenuItem,
            this.ClientToolStripMenuItem,
            this.SaleToolStripMenuItem,
            this.закрытьВсеВкладкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CategoriesToolStripMenuItem
            // 
            this.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem";
            this.CategoriesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.CategoriesToolStripMenuItem.Text = "Категории";
            this.CategoriesToolStripMenuItem.Click += new System.EventHandler(this.главнаяToolStripMenuItem_Click);
            // 
            // ClientToolStripMenuItem
            // 
            this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
            this.ClientToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ClientToolStripMenuItem.Text = "Клиент";
            this.ClientToolStripMenuItem.Click += new System.EventHandler(this.ПродажаToolStripMenuItem_Click);
            // 
            // SaleToolStripMenuItem
            // 
            this.SaleToolStripMenuItem.Name = "SaleToolStripMenuItem";
            this.SaleToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.SaleToolStripMenuItem.Text = "Продажа";
            this.SaleToolStripMenuItem.Click += new System.EventHandler(this.основаToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(13, 43);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 307);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // zaharovBaseDataSetBindingSource
            // 
            this.zaharovBaseDataSetBindingSource.DataSource = this.zaharovBaseDataSet;
            this.zaharovBaseDataSetBindingSource.Position = 0;
            // 
            // zaharovBaseDataSet
            // 
            this.zaharovBaseDataSet.DataSetName = "ZaharovBaseDataSet";
            this.zaharovBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.zaharovBaseDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = global::Zaharov.Properties.Resources.redact;
            this.button4.Location = new System.Drawing.Point(141, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 46);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::Zaharov.Properties.Resources.minus1;
            this.button2.Location = new System.Drawing.Point(71, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 46);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::Zaharov.Properties.Resources.plus;
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 46);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name_category
            // 
            this.Name_category.AutoSize = true;
            this.Name_category.Location = new System.Drawing.Point(3, 10);
            this.Name_category.Name = "Name_category";
            this.Name_category.Size = new System.Drawing.Size(35, 13);
            this.Name_category.TabIndex = 8;
            this.Name_category.Text = "Name";
            // 
            // Name_category_text
            // 
            this.Name_category_text.Location = new System.Drawing.Point(6, 28);
            this.Name_category_text.Name = "Name_category_text";
            this.Name_category_text.Size = new System.Drawing.Size(100, 20);
            this.Name_category_text.TabIndex = 10;
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_button.Location = new System.Drawing.Point(150, 57);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(80, 23);
            this.Add_button.TabIndex = 11;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Visible = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Return_button
            // 
            this.Return_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Return_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Return_button.Location = new System.Drawing.Point(150, 88);
            this.Return_button.Name = "Return_button";
            this.Return_button.Size = new System.Drawing.Size(80, 23);
            this.Return_button.TabIndex = 12;
            this.Return_button.Text = "Вернуться";
            this.Return_button.UseVisualStyleBackColor = false;
            this.Return_button.Visible = false;
            this.Return_button.Click += new System.EventHandler(this.Return_button_Click);
            // 
            // client_id
            // 
            this.client_id.AutoSize = true;
            this.client_id.Location = new System.Drawing.Point(3, 10);
            this.client_id.Name = "client_id";
            this.client_id.Size = new System.Drawing.Size(62, 13);
            this.client_id.TabIndex = 14;
            this.client_id.Text = "ID клиента";
            // 
            // sale_number
            // 
            this.sale_number.AutoSize = true;
            this.sale_number.Location = new System.Drawing.Point(3, 49);
            this.sale_number.Name = "sale_number";
            this.sale_number.Size = new System.Drawing.Size(41, 13);
            this.sale_number.TabIndex = 15;
            this.sale_number.Text = "Номер";
            // 
            // date_create_sale
            // 
            this.date_create_sale.AutoSize = true;
            this.date_create_sale.Location = new System.Drawing.Point(3, 96);
            this.date_create_sale.Name = "date_create_sale";
            this.date_create_sale.Size = new System.Drawing.Size(84, 13);
            this.date_create_sale.TabIndex = 16;
            this.date_create_sale.Text = "Дата создания";
            // 
            // sale_number_text
            // 
            this.sale_number_text.Location = new System.Drawing.Point(6, 69);
            this.sale_number_text.Name = "sale_number_text";
            this.sale_number_text.Size = new System.Drawing.Size(100, 20);
            this.sale_number_text.TabIndex = 17;
            // 
            // client_id_text
            // 
            this.client_id_text.Location = new System.Drawing.Point(6, 26);
            this.client_id_text.Name = "client_id_text";
            this.client_id_text.Size = new System.Drawing.Size(100, 20);
            this.client_id_text.TabIndex = 21;
            // 
            // date_redakt_sale
            // 
            this.date_redakt_sale.AutoSize = true;
            this.date_redakt_sale.Location = new System.Drawing.Point(3, 139);
            this.date_redakt_sale.Name = "date_redakt_sale";
            this.date_redakt_sale.Size = new System.Drawing.Size(92, 13);
            this.date_redakt_sale.TabIndex = 22;
            this.date_redakt_sale.Text = "Дата изменения";
            // 
            // sale_panel
            // 
            this.sale_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sale_panel.Controls.Add(this.dateTimePicker2);
            this.sale_panel.Controls.Add(this.dateTimePicker1);
            this.sale_panel.Controls.Add(this.status_id_text);
            this.sale_panel.Controls.Add(this.status_id);
            this.sale_panel.Controls.Add(this.sale_sum_text);
            this.sale_panel.Controls.Add(this.sale_sum);
            this.sale_panel.Controls.Add(this.client_id_text);
            this.sale_panel.Controls.Add(this.date_redakt_sale);
            this.sale_panel.Controls.Add(this.client_id);
            this.sale_panel.Controls.Add(this.sale_number);
            this.sale_panel.Controls.Add(this.date_create_sale);
            this.sale_panel.Controls.Add(this.sale_number_text);
            this.sale_panel.Location = new System.Drawing.Point(12, 43);
            this.sale_panel.Name = "sale_panel";
            this.sale_panel.Size = new System.Drawing.Size(126, 308);
            this.sale_panel.TabIndex = 23;
            this.sale_panel.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 155);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // status_id_text
            // 
            this.status_id_text.Location = new System.Drawing.Point(6, 240);
            this.status_id_text.Name = "status_id_text";
            this.status_id_text.Size = new System.Drawing.Size(100, 20);
            this.status_id_text.TabIndex = 26;
            // 
            // status_id
            // 
            this.status_id.AutoSize = true;
            this.status_id.Location = new System.Drawing.Point(3, 221);
            this.status_id.Name = "status_id";
            this.status_id.Size = new System.Drawing.Size(41, 13);
            this.status_id.TabIndex = 25;
            this.status_id.Text = "Статус";
            // 
            // sale_sum_text
            // 
            this.sale_sum_text.Location = new System.Drawing.Point(6, 195);
            this.sale_sum_text.Name = "sale_sum_text";
            this.sale_sum_text.Size = new System.Drawing.Size(100, 20);
            this.sale_sum_text.TabIndex = 24;
            // 
            // sale_sum
            // 
            this.sale_sum.AutoSize = true;
            this.sale_sum.Location = new System.Drawing.Point(3, 178);
            this.sale_sum.Name = "sale_sum";
            this.sale_sum.Size = new System.Drawing.Size(88, 13);
            this.sale_sum.TabIndex = 23;
            this.sale_sum.Text = "Сумма продажи";
            // 
            // client_panel
            // 
            this.client_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.client_panel.Controls.Add(this.Soure_id);
            this.client_panel.Controls.Add(this.Last_name);
            this.client_panel.Controls.Add(this.first_name);
            this.client_panel.Controls.Add(this.code_client);
            this.client_panel.Controls.Add(this.Soure_id_text);
            this.client_panel.Controls.Add(this.Last_name_text);
            this.client_panel.Controls.Add(this.first_name_text);
            this.client_panel.Controls.Add(this.code_client_text);
            this.client_panel.Location = new System.Drawing.Point(12, 43);
            this.client_panel.Name = "client_panel";
            this.client_panel.Size = new System.Drawing.Size(126, 307);
            this.client_panel.TabIndex = 25;
            this.client_panel.Visible = false;
            // 
            // Soure_id
            // 
            this.Soure_id.AutoSize = true;
            this.Soure_id.Location = new System.Drawing.Point(3, 138);
            this.Soure_id.Name = "Soure_id";
            this.Soure_id.Size = new System.Drawing.Size(56, 13);
            this.Soure_id.TabIndex = 35;
            this.Soure_id.Text = "Внутр? ID";
            // 
            // Last_name
            // 
            this.Last_name.AutoSize = true;
            this.Last_name.Location = new System.Drawing.Point(3, 93);
            this.Last_name.Name = "Last_name";
            this.Last_name.Size = new System.Drawing.Size(56, 13);
            this.Last_name.TabIndex = 34;
            this.Last_name.Text = "Фамилия";
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Location = new System.Drawing.Point(3, 50);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(29, 13);
            this.first_name.TabIndex = 33;
            this.first_name.Text = "Имя";
            // 
            // code_client
            // 
            this.code_client.AutoSize = true;
            this.code_client.Location = new System.Drawing.Point(3, 10);
            this.code_client.Name = "code_client";
            this.code_client.Size = new System.Drawing.Size(70, 13);
            this.code_client.TabIndex = 32;
            this.code_client.Text = "Код клиента";
            // 
            // Soure_id_text
            // 
            this.Soure_id_text.Location = new System.Drawing.Point(6, 160);
            this.Soure_id_text.Name = "Soure_id_text";
            this.Soure_id_text.Size = new System.Drawing.Size(100, 20);
            this.Soure_id_text.TabIndex = 31;
            // 
            // Last_name_text
            // 
            this.Last_name_text.Location = new System.Drawing.Point(6, 111);
            this.Last_name_text.Name = "Last_name_text";
            this.Last_name_text.Size = new System.Drawing.Size(100, 20);
            this.Last_name_text.TabIndex = 30;
            // 
            // first_name_text
            // 
            this.first_name_text.Location = new System.Drawing.Point(6, 68);
            this.first_name_text.Name = "first_name_text";
            this.first_name_text.Size = new System.Drawing.Size(100, 20);
            this.first_name_text.TabIndex = 29;
            // 
            // code_client_text
            // 
            this.code_client_text.Location = new System.Drawing.Point(6, 28);
            this.code_client_text.Name = "code_client_text";
            this.code_client_text.Size = new System.Drawing.Size(100, 20);
            this.code_client_text.TabIndex = 28;
            // 
            // category_panel
            // 
            this.category_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.category_panel.Controls.Add(this.Name_category);
            this.category_panel.Controls.Add(this.Name_category_text);
            this.category_panel.Location = new System.Drawing.Point(12, 43);
            this.category_panel.Name = "category_panel";
            this.category_panel.Size = new System.Drawing.Size(126, 307);
            this.category_panel.TabIndex = 26;
            this.category_panel.Visible = false;
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Edit.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit.Location = new System.Drawing.Point(144, 55);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(97, 27);
            this.Edit.TabIndex = 27;
            this.Edit.Text = "Редактировать";
            this.Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Visible = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(13, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 49);
            this.panel1.TabIndex = 28;
            // 
            // закрытьВсеВкладкиToolStripMenuItem
            // 
            this.закрытьВсеВкладкиToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.закрытьВсеВкладкиToolStripMenuItem.Enabled = false;
            this.закрытьВсеВкладкиToolStripMenuItem.Name = "закрытьВсеВкладкиToolStripMenuItem";
            this.закрытьВсеВкладкиToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.закрытьВсеВкладкиToolStripMenuItem.Text = "Закрыть все вкладки";
            this.закрытьВсеВкладкиToolStripMenuItem.Click += new System.EventHandler(this.закрытьВсеВкладкиToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.sale_panel);
            this.Controls.Add(this.client_panel);
            this.Controls.Add(this.category_panel);
            this.Controls.Add(this.Return_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaharovBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaharovBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.sale_panel.ResumeLayout(false);
            this.sale_panel.PerformLayout();
            this.client_panel.ResumeLayout(false);
            this.client_panel.PerformLayout();
            this.category_panel.ResumeLayout(false);
            this.category_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaleToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource zaharovBaseDataSetBindingSource;
        private ZaharovBaseDataSet zaharovBaseDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private ZaharovBaseDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Name_category;
        private System.Windows.Forms.TextBox Name_category_text;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Return_button;
        private System.Windows.Forms.Label client_id;
        private System.Windows.Forms.Label sale_number;
        private System.Windows.Forms.Label date_create_sale;
        private System.Windows.Forms.TextBox sale_number_text;
        private System.Windows.Forms.TextBox client_id_text;
        private System.Windows.Forms.Label date_redakt_sale;
        private System.Windows.Forms.Panel sale_panel;
        private System.Windows.Forms.TextBox status_id_text;
        private System.Windows.Forms.Label status_id;
        private System.Windows.Forms.TextBox sale_sum_text;
        private System.Windows.Forms.Label sale_sum;
        private System.Windows.Forms.Panel client_panel;
        private System.Windows.Forms.Label Soure_id;
        private System.Windows.Forms.Label Last_name;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.Label code_client;
        private System.Windows.Forms.TextBox Soure_id_text;
        private System.Windows.Forms.TextBox Last_name_text;
        private System.Windows.Forms.TextBox first_name_text;
        private System.Windows.Forms.TextBox code_client_text;
        private System.Windows.Forms.Panel category_panel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem закрытьВсеВкладкиToolStripMenuItem;
    }
}