namespace Vista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtnombre = new TextBox();
            txtestatura = new TextBox();
            txtedad = new TextBox();
            txtgenero = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Crearbutton = new Button();
            Mostrarbutton = new Button();
            PersonasdataGridView = new DataGridView();
            PersonasbindingSource = new BindingSource(components);
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estaturaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            edadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            generoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)PersonasdataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PersonasbindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 37);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 66);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Estatura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 100);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 121);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "Genero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 147);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Nacimiento:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(187, 34);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(176, 23);
            txtnombre.TabIndex = 5;
            // 
            // txtestatura
            // 
            txtestatura.Location = new Point(187, 63);
            txtestatura.Name = "txtestatura";
            txtestatura.Size = new Size(176, 23);
            txtestatura.TabIndex = 6;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(187, 92);
            txtedad.Name = "txtedad";
            txtedad.ReadOnly = true;
            txtedad.Size = new Size(176, 23);
            txtedad.TabIndex = 7;
            // 
            // txtgenero
            // 
            txtgenero.Location = new Point(187, 118);
            txtgenero.Name = "txtgenero";
            txtgenero.Size = new Size(176, 23);
            txtgenero.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(187, 147);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(95, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // Crearbutton
            // 
            Crearbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Crearbutton.Location = new Point(187, 176);
            Crearbutton.Name = "Crearbutton";
            Crearbutton.Size = new Size(75, 23);
            Crearbutton.TabIndex = 10;
            Crearbutton.Text = "Agregar";
            Crearbutton.UseVisualStyleBackColor = true;
            Crearbutton.Click += Crearbutton_Click;
            // 
            // Mostrarbutton
            // 
            Mostrarbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mostrarbutton.Location = new Point(268, 176);
            Mostrarbutton.Name = "Mostrarbutton";
            Mostrarbutton.Size = new Size(75, 23);
            Mostrarbutton.TabIndex = 11;
            Mostrarbutton.Text = "Mostrar";
            Mostrarbutton.UseVisualStyleBackColor = true;
            Mostrarbutton.Click += Mostrarbutton_Click;
            // 
            // PersonasdataGridView
            // 
            PersonasdataGridView.AllowUserToAddRows = false;
            PersonasdataGridView.AllowUserToDeleteRows = false;
            PersonasdataGridView.AutoGenerateColumns = false;
            PersonasdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonasdataGridView.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, estaturaDataGridViewTextBoxColumn, edadDataGridViewTextBoxColumn, generoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn });
            PersonasdataGridView.DataSource = PersonasbindingSource;
            PersonasdataGridView.Location = new Point(5, 205);
            PersonasdataGridView.Name = "PersonasdataGridView";
            PersonasdataGridView.ReadOnly = true;
            PersonasdataGridView.Size = new Size(592, 239);
            PersonasdataGridView.TabIndex = 12;
            // 
            // PersonasbindingSource
            // 
            PersonasbindingSource.DataSource = typeof(Entidades.Persona);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estaturaDataGridViewTextBoxColumn
            // 
            estaturaDataGridViewTextBoxColumn.DataPropertyName = "Estatura";
            estaturaDataGridViewTextBoxColumn.HeaderText = "Estatura";
            estaturaDataGridViewTextBoxColumn.Name = "estaturaDataGridViewTextBoxColumn";
            estaturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            edadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            generoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha Nacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            fechaNacimientoDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 446);
            Controls.Add(PersonasdataGridView);
            Controls.Add(Mostrarbutton);
            Controls.Add(Crearbutton);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtgenero);
            Controls.Add(txtedad);
            Controls.Add(txtestatura);
            Controls.Add(txtnombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PersonasdataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)PersonasbindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtnombre;
        private TextBox txtestatura;
        private TextBox txtedad;
        private TextBox txtgenero;
        private DateTimePicker dateTimePicker1;
        private Button Crearbutton;
        private Button Mostrarbutton;
        private DataGridView PersonasdataGridView;
        private BindingSource PersonasbindingSource;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estaturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
    }
}
