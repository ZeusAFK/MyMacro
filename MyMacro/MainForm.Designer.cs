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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbApplication = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridMacroList = new System.Windows.Forms.DataGridView();
            this.activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tecla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMacroList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplicacion:";
            // 
            // cmbApplication
            // 
            this.cmbApplication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApplication.FormattingEnabled = true;
            this.cmbApplication.Location = new System.Drawing.Point(77, 6);
            this.cmbApplication.Name = "cmbApplication";
            this.cmbApplication.Size = new System.Drawing.Size(456, 21);
            this.cmbApplication.TabIndex = 1;
            this.cmbApplication.Click += new System.EventHandler(this.cmbApplication_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
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
            this.gridMacroList.BackgroundColor = System.Drawing.Color.White;
            this.gridMacroList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMacroList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activo,
            this.tecla,
            this.descripcion,
            this.tiempo});
            this.gridMacroList.Location = new System.Drawing.Point(12, 65);
            this.gridMacroList.MultiSelect = false;
            this.gridMacroList.Name = "gridMacroList";
            this.gridMacroList.RowHeadersVisible = false;
            this.gridMacroList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridMacroList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridMacroList.Size = new System.Drawing.Size(521, 286);
            this.gridMacroList.TabIndex = 4;
            this.gridMacroList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMacroList_CellClick);
            this.gridMacroList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMacroList_CellValueChanged);
            this.gridMacroList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridMacroList_KeyPress);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tecla.DefaultCellStyle = dataGridViewCellStyle7;
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
            this.descripcion.Width = 250;
            // 
            // tiempo
            // 
            dataGridViewCellStyle8.Format = "N0";
            this.tiempo.DefaultCellStyle = dataGridViewCellStyle8;
            this.tiempo.FillWeight = 99.49239F;
            this.tiempo.HeaderText = "Tiempo (ms)";
            this.tiempo.Name = "tiempo";
            this.tiempo.Width = 90;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quitar seleccionado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(407, 357);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(129, 23);
            this.btnActivate.TabIndex = 6;
            this.btnActivate.Text = "Activar";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 390);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridMacroList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbApplication);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyMacro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridMacroList)).EndInit();
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecla;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
    }
}

