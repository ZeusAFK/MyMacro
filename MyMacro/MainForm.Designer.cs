namespace MyMacro
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbApplication = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridMacroList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tecla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridMacroList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplicacion:";
            // 
            // cmbApplication
            // 
            this.cmbApplication.BackColor = System.Drawing.Color.Black;
            this.cmbApplication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApplication.ForeColor = System.Drawing.Color.White;
            this.cmbApplication.FormattingEnabled = true;
            this.cmbApplication.Location = new System.Drawing.Point(77, 47);
            this.cmbApplication.Name = "cmbApplication";
            this.cmbApplication.Size = new System.Drawing.Size(491, 21);
            this.cmbApplication.TabIndex = 1;
            this.cmbApplication.Click += new System.EventHandler(this.cmbApplication_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de macros";
            // 
            // gridMacroList
            // 
            this.gridMacroList.AllowUserToDeleteRows = false;
            this.gridMacroList.AllowUserToResizeColumns = false;
            this.gridMacroList.AllowUserToResizeRows = false;
            this.gridMacroList.BackgroundColor = System.Drawing.Color.Black;
            this.gridMacroList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMacroList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activo,
            this.tecla,
            this.descripcion,
            this.tiempo});
            this.gridMacroList.Location = new System.Drawing.Point(47, 95);
            this.gridMacroList.MultiSelect = false;
            this.gridMacroList.Name = "gridMacroList";
            this.gridMacroList.RowHeadersVisible = false;
            this.gridMacroList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridMacroList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridMacroList.Size = new System.Drawing.Size(479, 269);
            this.gridMacroList.TabIndex = 4;
            this.gridMacroList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMacroList_CellClick);
            this.gridMacroList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMacroList_CellValueChanged);
            this.gridMacroList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridMacroList_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quitar seleccionado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(439, 370);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(129, 23);
            this.btnActivate.TabIndex = 6;
            this.btnActivate.Text = "Activar";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "My Macro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(531, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "v1.0.0";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::MyMacro.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(524, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(14, 14);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 51;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            this.btnMinimize.MouseHover += new System.EventHandler(this.btnMinimize_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::MyMacro.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(544, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(14, 14);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 50;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // activo
            // 
            this.activo.FillWeight = 101.5228F;
            this.activo.HeaderText = "Activo";
            this.activo.Name = "activo";
            this.activo.Width = 50;
            // 
            // tecla
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tecla.DefaultCellStyle = dataGridViewCellStyle1;
            this.tecla.FillWeight = 99.49239F;
            this.tecla.HeaderText = "Tecla";
            this.tecla.Name = "tecla";
            this.tecla.ReadOnly = true;
            this.tecla.Width = 120;
            // 
            // descripcion
            // 
            this.descripcion.FillWeight = 99.49239F;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 220;
            // 
            // tiempo
            // 
            dataGridViewCellStyle2.Format = "N0";
            this.tiempo.DefaultCellStyle = dataGridViewCellStyle2;
            this.tiempo.FillWeight = 99.49239F;
            this.tiempo.HeaderText = "Tiempo (ms)";
            this.tiempo.Name = "tiempo";
            this.tiempo.Width = 90;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyMacro.Properties.Resources.ventana;
            this.ClientSize = new System.Drawing.Size(580, 437);
            this.ControlBox = false;
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridMacroList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbApplication);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyMacro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridMacroList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbApplication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridMacroList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecla;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
    }
}

