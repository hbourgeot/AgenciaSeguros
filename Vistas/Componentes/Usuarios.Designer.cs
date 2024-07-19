namespace AgenciaSeguros.Vistas.Componentes
{
  partial class Usuarios
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
      this.label1 = new System.Windows.Forms.Label();
      this.nombreText = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.correoText = new System.Windows.Forms.MaskedTextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.edadNum = new System.Windows.Forms.NumericUpDown();
      this.telefonoText = new System.Windows.Forms.MaskedTextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.comboRol = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.claveText = new System.Windows.Forms.MaskedTextBox();
      this.labelClave = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.btnMostrar = new System.Windows.Forms.Button();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.edadNum)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(203, 12);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(69, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Crear usuario";
      // 
      // nombreText
      // 
      this.nombreText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.nombreText.Location = new System.Drawing.Point(45, 77);
      this.nombreText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.nombreText.MaxLength = 200;
      this.nombreText.Name = "nombreText";
      this.nombreText.Size = new System.Drawing.Size(400, 20);
      this.nombreText.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(42, 56);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(90, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Nombre completo";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(42, 128);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(93, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Correo electronico";
      // 
      // correoText
      // 
      this.correoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.correoText.Location = new System.Drawing.Point(45, 144);
      this.correoText.Name = "correoText";
      this.correoText.Size = new System.Drawing.Size(377, 20);
      this.correoText.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(45, 187);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(32, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Edad";
      // 
      // edadNum
      // 
      this.edadNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.edadNum.Location = new System.Drawing.Point(47, 203);
      this.edadNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.edadNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.edadNum.Name = "edadNum";
      this.edadNum.Size = new System.Drawing.Size(87, 20);
      this.edadNum.TabIndex = 8;
      this.edadNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // telefonoText
      // 
      this.telefonoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.telefonoText.Location = new System.Drawing.Point(145, 203);
      this.telefonoText.Mask = "(0999) 000-0000";
      this.telefonoText.Name = "telefonoText";
      this.telefonoText.Size = new System.Drawing.Size(158, 20);
      this.telefonoText.TabIndex = 10;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(142, 187);
      this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(49, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Teléfono";
      // 
      // comboRol
      // 
      this.comboRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.comboRol.FormattingEnabled = true;
      this.comboRol.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
      this.comboRol.Location = new System.Drawing.Point(327, 203);
      this.comboRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.comboRol.Name = "comboRol";
      this.comboRol.Size = new System.Drawing.Size(118, 21);
      this.comboRol.TabIndex = 11;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(325, 187);
      this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(23, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "Rol";
      // 
      // claveText
      // 
      this.claveText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.claveText.Location = new System.Drawing.Point(47, 261);
      this.claveText.Name = "claveText";
      this.claveText.Size = new System.Drawing.Size(300, 20);
      this.claveText.TabIndex = 14;
      // 
      // labelClave
      // 
      this.labelClave.AutoSize = true;
      this.labelClave.Location = new System.Drawing.Point(45, 245);
      this.labelClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelClave.Name = "labelClave";
      this.labelClave.Size = new System.Drawing.Size(61, 13);
      this.labelClave.TabIndex = 13;
      this.labelClave.Text = "Contraseña";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radioButton2);
      this.groupBox1.Controls.Add(this.radioButton1);
      this.groupBox1.Location = new System.Drawing.Point(51, 302);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.groupBox1.Size = new System.Drawing.Size(119, 46);
      this.groupBox1.TabIndex = 15;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Activo";
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.radioButton2.Location = new System.Drawing.Point(70, 25);
      this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(38, 17);
      this.radioButton2.TabIndex = 1;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "No";
      this.radioButton2.UseVisualStyleBackColor = true;
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.radioButton1.Location = new System.Drawing.Point(13, 25);
      this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(35, 17);
      this.radioButton1.TabIndex = 0;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Sí";
      this.radioButton1.UseVisualStyleBackColor = true;
      // 
      // btnGuardar
      // 
      this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
      this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLight;
      this.btnGuardar.Location = new System.Drawing.Point(309, 319);
      this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(129, 28);
      this.btnGuardar.TabIndex = 16;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = false;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.PaleVioletRed;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
      this.button2.Location = new System.Drawing.Point(176, 319);
      this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(129, 28);
      this.button2.TabIndex = 17;
      this.button2.Text = "Cancelar";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // btnMostrar
      // 
      this.btnMostrar.BackColor = System.Drawing.Color.LightGreen;
      this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
      this.btnMostrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.btnMostrar.Location = new System.Drawing.Point(376, 245);
      this.btnMostrar.Name = "btnMostrar";
      this.btnMostrar.Size = new System.Drawing.Size(68, 36);
      this.btnMostrar.TabIndex = 18;
      this.btnMostrar.Text = "Mostrar";
      this.btnMostrar.UseVisualStyleBackColor = false;
      this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // Usuarios
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(238)))), ((int)(((byte)(251)))));
      this.ClientSize = new System.Drawing.Size(489, 362);
      this.Controls.Add(this.btnMostrar);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.claveText);
      this.Controls.Add(this.labelClave);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.comboRol);
      this.Controls.Add(this.telefonoText);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.edadNum);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.correoText);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.nombreText);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "Usuarios";
      this.Text = "Usuarios";
      ((System.ComponentModel.ISupportInitialize)(this.edadNum)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox nombreText;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.MaskedTextBox correoText;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown edadNum;
    private System.Windows.Forms.MaskedTextBox telefonoText;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox comboRol;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.MaskedTextBox claveText;
    private System.Windows.Forms.Label labelClave;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button btnMostrar;
    private System.Windows.Forms.ErrorProvider errorProvider1;
  }
}