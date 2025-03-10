namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGrid1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.GroupBox();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Bagregar = new System.Windows.Forms.Button();
            this.Bmodificar = new System.Windows.Forms.Button();
            this.Beliminar = new System.Windows.Forms.Button();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.Contacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid1
            // 
            this.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.Birth,
            this.Gen,
            this.email,
            this.phone,
            this.city});
            this.DataGrid1.Location = new System.Drawing.Point(12, 224);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.Size = new System.Drawing.Size(693, 179);
            this.DataGrid1.TabIndex = 0;
            this.DataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // Birth
            // 
            this.Birth.HeaderText = "Fecha de nacimiento";
            this.Birth.Name = "Birth";
            // 
            // Gen
            // 
            this.Gen.HeaderText = "Genero";
            this.Gen.Name = "Gen";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // phone
            // 
            this.phone.HeaderText = "Telefono";
            this.phone.Name = "phone";
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.Name = "city";
            // 
            // Contacto
            // 
            this.Contacto.Controls.Add(this.txtfind);
            this.Contacto.Controls.Add(this.label8);
            this.Contacto.Controls.Add(this.label7);
            this.Contacto.Controls.Add(this.Bagregar);
            this.Contacto.Controls.Add(this.Bmodificar);
            this.Contacto.Controls.Add(this.Beliminar);
            this.Contacto.Controls.Add(this.txtGen);
            this.Contacto.Controls.Add(this.label6);
            this.Contacto.Controls.Add(this.txtBirth);
            this.Contacto.Controls.Add(this.label5);
            this.Contacto.Controls.Add(this.txtID);
            this.Contacto.Controls.Add(this.label4);
            this.Contacto.Controls.Add(this.txtCity);
            this.Contacto.Controls.Add(this.label3);
            this.Contacto.Controls.Add(this.txtPhone);
            this.Contacto.Controls.Add(this.label2);
            this.Contacto.Controls.Add(this.txtEmail);
            this.Contacto.Controls.Add(this.label1);
            this.Contacto.Controls.Add(this.txtName);
            this.Contacto.Location = new System.Drawing.Point(12, 12);
            this.Contacto.Name = "Contacto";
            this.Contacto.Size = new System.Drawing.Size(693, 206);
            this.Contacto.TabIndex = 1;
            this.Contacto.TabStop = false;
            this.Contacto.Text = "Contacto";
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(414, 101);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(238, 20);
            this.txtfind.TabIndex = 15;
            this.txtfind.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Buscar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Genero";
            // 
            // Bagregar
            // 
            this.Bagregar.Location = new System.Drawing.Point(351, 130);
            this.Bagregar.Name = "Bagregar";
            this.Bagregar.Size = new System.Drawing.Size(138, 30);
            this.Bagregar.TabIndex = 2;
            this.Bagregar.Text = "Agregar";
            this.Bagregar.UseVisualStyleBackColor = true;
            this.Bagregar.Click += new System.EventHandler(this.Bagregar_Click);
            // 
            // Bmodificar
            // 
            this.Bmodificar.Location = new System.Drawing.Point(538, 130);
            this.Bmodificar.Name = "Bmodificar";
            this.Bmodificar.Size = new System.Drawing.Size(138, 30);
            this.Bmodificar.TabIndex = 3;
            this.Bmodificar.Text = "Modificar";
            this.Bmodificar.UseVisualStyleBackColor = true;
            this.Bmodificar.Click += new System.EventHandler(this.Bmodificar_Click);
            // 
            // Beliminar
            // 
            this.Beliminar.Location = new System.Drawing.Point(351, 170);
            this.Beliminar.Name = "Beliminar";
            this.Beliminar.Size = new System.Drawing.Size(138, 30);
            this.Beliminar.TabIndex = 4;
            this.Beliminar.Text = "Eliminar";
            this.Beliminar.UseVisualStyleBackColor = true;
            this.Beliminar.Click += new System.EventHandler(this.Beliminar_Click_1);
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(414, 69);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(238, 20);
            this.txtGen.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nacimiento";
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(414, 34);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(238, 20);
            this.txtBirth.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(93, 180);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(238, 20);
            this.txtID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ciudad";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(93, 140);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(238, 20);
            this.txtCity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefono";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(93, 105);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(238, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 20);
            this.txtName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 415);
            this.Controls.Add(this.Contacto);
            this.Controls.Add(this.DataGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.Contacto.ResumeLayout(false);
            this.Contacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid1;
        private System.Windows.Forms.GroupBox Contacto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button Bagregar;
        private System.Windows.Forms.Button Bmodificar;
        private System.Windows.Forms.Button Beliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gen;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
    }
}

