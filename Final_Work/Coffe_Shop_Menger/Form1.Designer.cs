namespace Coffe_Shop_Menger
{
    partial class Form1
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
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_ext = new System.Windows.Forms.Button();
            this.total_cal = new System.Windows.Forms.Label();
            this.selectbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.meal_type = new System.Windows.Forms.Label();
            this.productname = new System.Windows.Forms.TextBox();
            this.calories = new System.Windows.Forms.TextBox();
            this.cal = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_vegan = new System.Windows.Forms.RadioButton();
            this.rdb_alc = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.productListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(532, 384);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(126, 59);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(664, 384);
            this.btn_load.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(126, 59);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(796, 384);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(126, 59);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_ext
            // 
            this.btn_ext.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ext.Location = new System.Drawing.Point(796, 449);
            this.btn_ext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ext.Name = "btn_ext";
            this.btn_ext.Size = new System.Drawing.Size(126, 59);
            this.btn_ext.TabIndex = 3;
            this.btn_ext.Text = "Exit";
            this.btn_ext.UseVisualStyleBackColor = true;
            this.btn_ext.Click += new System.EventHandler(this.btn_ext_Click);
            // 
            // total_cal
            // 
            this.total_cal.AutoSize = true;
            this.total_cal.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.total_cal.Location = new System.Drawing.Point(933, 528);
            this.total_cal.Name = "total_cal";
            this.total_cal.Size = new System.Drawing.Size(26, 27);
            this.total_cal.TabIndex = 6;
            this.total_cal.Text = "0";
            this.total_cal.Click += new System.EventHandler(this.total_cal_Click);
            // 
            // selectbox
            // 
            this.selectbox.FormattingEnabled = true;
            this.selectbox.Location = new System.Drawing.Point(32, 468);
            this.selectbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectbox.Name = "selectbox";
            this.selectbox.Size = new System.Drawing.Size(258, 28);
            this.selectbox.TabIndex = 7;
            this.selectbox.SelectedIndexChanged += new System.EventHandler(this.selectbox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label2.Location = new System.Drawing.Point(27, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product name:";
            // 
            // meal_type
            // 
            this.meal_type.AutoSize = true;
            this.meal_type.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.meal_type.Location = new System.Drawing.Point(27, 435);
            this.meal_type.Name = "meal_type";
            this.meal_type.Size = new System.Drawing.Size(185, 27);
            this.meal_type.TabIndex = 9;
            this.meal_type.Text = "Product type :";
            // 
            // productname
            // 
            this.productname.Location = new System.Drawing.Point(32, 401);
            this.productname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(258, 26);
            this.productname.TabIndex = 10;
            this.productname.TextChanged += new System.EventHandler(this.productname_TextChanged);
            // 
            // calories
            // 
            this.calories.Location = new System.Drawing.Point(336, 401);
            this.calories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calories.Name = "calories";
            this.calories.Size = new System.Drawing.Size(179, 26);
            this.calories.TabIndex = 12;
            this.calories.TextChanged += new System.EventHandler(this.calories_TextChanged);
            // 
            // cal
            // 
            this.cal.AutoSize = true;
            this.cal.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.cal.Location = new System.Drawing.Point(332, 369);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(125, 27);
            this.cal.TabIndex = 11;
            this.cal.Text = "Calories :";
            this.cal.Click += new System.EventHandler(this.cal_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(336, 476);
            this.price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(179, 26);
            this.price.TabIndex = 14;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label1.Location = new System.Drawing.Point(332, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Price :";
            // 
            // rdb_vegan
            // 
            this.rdb_vegan.AutoSize = true;
            this.rdb_vegan.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.rdb_vegan.Location = new System.Drawing.Point(12, 524);
            this.rdb_vegan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_vegan.Name = "rdb_vegan";
            this.rdb_vegan.Size = new System.Drawing.Size(135, 31);
            this.rdb_vegan.TabIndex = 15;
            this.rdb_vegan.TabStop = true;
            this.rdb_vegan.Text = "Is vegan";
            this.rdb_vegan.UseVisualStyleBackColor = true;
            this.rdb_vegan.CheckedChanged += new System.EventHandler(this.rdb_vegan_CheckedChanged);
            // 
            // rdb_alc
            // 
            this.rdb_alc.AutoSize = true;
            this.rdb_alc.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.rdb_alc.Location = new System.Drawing.Point(168, 524);
            this.rdb_alc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_alc.Name = "rdb_alc";
            this.rdb_alc.Size = new System.Drawing.Size(132, 31);
            this.rdb_alc.TabIndex = 16;
            this.rdb_alc.TabStop = true;
            this.rdb_alc.Text = "Alcohol";
            this.rdb_alc.UseVisualStyleBackColor = true;
            this.rdb_alc.CheckedChanged += new System.EventHandler(this.rdb_alc_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.brd,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(14, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(983, 331);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Type";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Calories";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 75;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 75;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Vegan";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 75;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cheese";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 75;
            // 
            // brd
            // 
            this.brd.HeaderText = "Bread";
            this.brd.MinimumWidth = 6;
            this.brd.Name = "brd";
            this.brd.Width = 75;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Alcohol";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 75;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(664, 449);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(126, 59);
            this.btn_reset.TabIndex = 19;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(532, 450);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(126, 59);
            this.btn_remove.TabIndex = 18;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label3.Location = new System.Drawing.Point(743, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 27);
            this.label3.TabIndex = 20;
            this.label3.Text = "Total amount:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.radioButton1.Location = new System.Drawing.Point(336, 524);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(198, 31);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Brown bread";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.radioButton2.Location = new System.Drawing.Point(574, 524);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(120, 31);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Cheese";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(928, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 124);
            this.button1.TabIndex = 19;
            this.button1.Text = "pictures";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productListBindingSource
            // 
            this.productListBindingSource.DataSource = typeof(PRODUCTS.productList);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1010, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdb_alc);
            this.Controls.Add(this.rdb_vegan);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calories);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.meal_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectbox);
            this.Controls.Add(this.total_cal);
            this.Controls.Add(this.btn_ext);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Coffe shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_ext;
        private System.Windows.Forms.Label total_cal;
        private System.Windows.Forms.ComboBox selectbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label meal_type;
        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.TextBox calories;
        private System.Windows.Forms.Label cal;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_vegan;
        private System.Windows.Forms.RadioButton rdb_alc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productListBindingSource;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn brd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
    }
}
