namespace RadioButton
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
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.rbMediano = new System.Windows.Forms.RadioButton();
            this.rbChico = new System.Windows.Forms.RadioButton();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtTamaño = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbGrande
            // 
            this.rbGrande.AutoSize = true;
            this.rbGrande.Location = new System.Drawing.Point(488, 88);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.Size = new System.Drawing.Size(60, 17);
            this.rbGrande.TabIndex = 0;
            this.rbGrande.TabStop = true;
            this.rbGrande.Text = "Grande";
            this.rbGrande.UseVisualStyleBackColor = true;
            this.rbGrande.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbMediano
            // 
            this.rbMediano.AutoSize = true;
            this.rbMediano.Location = new System.Drawing.Point(488, 156);
            this.rbMediano.Name = "rbMediano";
            this.rbMediano.Size = new System.Drawing.Size(66, 17);
            this.rbMediano.TabIndex = 1;
            this.rbMediano.TabStop = true;
            this.rbMediano.Text = "Mediano";
            this.rbMediano.UseVisualStyleBackColor = true;
            this.rbMediano.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbChico
            // 
            this.rbChico.AutoSize = true;
            this.rbChico.Location = new System.Drawing.Point(488, 219);
            this.rbChico.Name = "rbChico";
            this.rbChico.Size = new System.Drawing.Size(52, 17);
            this.rbChico.TabIndex = 2;
            this.rbChico.TabStop = true;
            this.rbChico.Text = "Chico";
            this.rbChico.UseVisualStyleBackColor = true;
            this.rbChico.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Location = new System.Drawing.Point(159, 41);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(117, 13);
            this.txtTitulo.TabIndex = 3;
            this.txtTitulo.Text = "BAÑO PARA PERROS";
            this.txtTitulo.Click += new System.EventHandler(this.txtTitulo_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(309, 335);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de la Mascota";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sexo de la Mascota";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(206, 123);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(206, 207);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 20);
            this.txtSex.TabIndex = 8;
            // 
            // txtTamaño
            // 
            this.txtTamaño.AutoSize = true;
            this.txtTamaño.Location = new System.Drawing.Point(220, 274);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(0, 13);
            this.txtTamaño.TabIndex = 9;
            this.txtTamaño.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "El perro es de Tamaño";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.rbChico);
            this.Controls.Add(this.rbMediano);
            this.Controls.Add(this.rbGrande);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbGrande;
        private System.Windows.Forms.RadioButton rbMediano;
        private System.Windows.Forms.RadioButton rbChico;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label txtTamaño;
        private System.Windows.Forms.Label label4;
    }
}

