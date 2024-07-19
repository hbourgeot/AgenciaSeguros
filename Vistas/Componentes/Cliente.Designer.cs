namespace AgenciaSeguros.Vistas.Componentes
{
  partial class Cliente
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
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.button2 = new System.Windows.Forms.Button();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.telefonoText = new System.Windows.Forms.MaskedTextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.correoText = new System.Windows.Forms.MaskedTextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.nombreText = new System.Windows.Forms.TextBox();
      this.codPostalText = new System.Windows.Forms.MaskedTextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.documentoText = new System.Windows.Forms.MaskedTextBox();
      this.paisText = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.estadoText = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.ciudadText = new System.Windows.Forms.TextBox();
      this.direccionText = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.PaleVioletRed;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.Location = new System.Drawing.Point(63, 356);
      this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(163, 28);
      this.button2.TabIndex = 34;
      this.button2.Text = "Cancelar";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // btnGuardar
      // 
      this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
      this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGuardar.Location = new System.Drawing.Point(269, 356);
      this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(163, 28);
      this.btnGuardar.TabIndex = 33;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = false;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // telefonoText
      // 
      this.telefonoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.telefonoText.Location = new System.Drawing.Point(63, 165);
      this.telefonoText.Mask = "(0999) 000-0000";
      this.telefonoText.Name = "telefonoText";
      this.telefonoText.Size = new System.Drawing.Size(93, 20);
      this.telefonoText.TabIndex = 27;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(61, 149);
      this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(49, 13);
      this.label5.TabIndex = 26;
      this.label5.Text = "Teléfono";
      // 
      // correoText
      // 
      this.correoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.correoText.Location = new System.Drawing.Point(259, 114);
      this.correoText.Name = "correoText";
      this.correoText.Size = new System.Drawing.Size(173, 20);
      this.correoText.TabIndex = 23;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(257, 92);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(93, 13);
      this.label3.TabIndex = 22;
      this.label3.Text = "Correo electrónico";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(61, 92);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(90, 13);
      this.label2.TabIndex = 21;
      this.label2.Text = "Nombre completo";
      // 
      // nombreText
      // 
      this.nombreText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.nombreText.Location = new System.Drawing.Point(63, 114);
      this.nombreText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.nombreText.MaxLength = 200;
      this.nombreText.Name = "nombreText";
      this.nombreText.Size = new System.Drawing.Size(173, 20);
      this.nombreText.TabIndex = 20;
      // 
      // codPostalText
      // 
      this.codPostalText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.codPostalText.Location = new System.Drawing.Point(182, 165);
      this.codPostalText.Mask = "0000";
      this.codPostalText.Name = "codPostalText";
      this.codPostalText.Size = new System.Drawing.Size(69, 20);
      this.codPostalText.TabIndex = 35;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(179, 149);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(72, 13);
      this.label4.TabIndex = 36;
      this.label4.Text = "Código Postal";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(279, 149);
      this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(102, 13);
      this.label6.TabIndex = 38;
      this.label6.Text = "Cédula de Identidad";
      // 
      // documentoText
      // 
      this.documentoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.documentoText.Location = new System.Drawing.Point(282, 165);
      this.documentoText.Mask = "L-00000000000";
      this.documentoText.Name = "documentoText";
      this.documentoText.Size = new System.Drawing.Size(151, 20);
      this.documentoText.TabIndex = 37;
      // 
      // paisText
      // 
      this.paisText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.paisText.Location = new System.Drawing.Point(63, 213);
      this.paisText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.paisText.MaxLength = 200;
      this.paisText.Name = "paisText";
      this.paisText.Size = new System.Drawing.Size(107, 20);
      this.paisText.TabIndex = 39;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(61, 198);
      this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(29, 13);
      this.label7.TabIndex = 40;
      this.label7.Text = "País";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(192, 198);
      this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(40, 13);
      this.label8.TabIndex = 42;
      this.label8.Text = "Estado";
      // 
      // estadoText
      // 
      this.estadoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.estadoText.Location = new System.Drawing.Point(195, 213);
      this.estadoText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.estadoText.MaxLength = 200;
      this.estadoText.Name = "estadoText";
      this.estadoText.Size = new System.Drawing.Size(107, 20);
      this.estadoText.TabIndex = 41;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(323, 198);
      this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(40, 13);
      this.label9.TabIndex = 44;
      this.label9.Text = "Ciudad";
      // 
      // ciudadText
      // 
      this.ciudadText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ciudadText.Location = new System.Drawing.Point(326, 213);
      this.ciudadText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.ciudadText.MaxLength = 200;
      this.ciudadText.Name = "ciudadText";
      this.ciudadText.Size = new System.Drawing.Size(107, 20);
      this.ciudadText.TabIndex = 43;
      // 
      // direccionText
      // 
      this.direccionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.direccionText.Location = new System.Drawing.Point(63, 268);
      this.direccionText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.direccionText.Multiline = true;
      this.direccionText.Name = "direccionText";
      this.direccionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.direccionText.Size = new System.Drawing.Size(369, 74);
      this.direccionText.TabIndex = 45;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(61, 246);
      this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(52, 13);
      this.label10.TabIndex = 46;
      this.label10.Text = "Dirección";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(211, 25);
      this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(84, 13);
      this.label11.TabIndex = 47;
      this.label11.Text = "Registrar Cliente";
      // 
      // Cliente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(238)))), ((int)(((byte)(251)))));
      this.ClientSize = new System.Drawing.Size(503, 414);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.direccionText);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.ciudadText);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.estadoText);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.paisText);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.documentoText);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.codPostalText);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.telefonoText);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.correoText);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.nombreText);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "Cliente";
      this.Text = "Clientes";
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.MaskedTextBox telefonoText;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.MaskedTextBox correoText;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox nombreText;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.MaskedTextBox codPostalText;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.MaskedTextBox documentoText;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox ciudadText;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox estadoText;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox paisText;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox direccionText;
  }
}