namespace AgenciaSeguros
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
      this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label4 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(134, 111);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(188, 39);
      this.label1.TabIndex = 0;
      this.label1.Text = "Bienvenido";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(95, 202);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(132, 18);
      this.label2.TabIndex = 1;
      this.label2.Text = "Correo electrónico";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(95, 276);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(85, 18);
      this.label3.TabIndex = 3;
      this.label3.Text = "Contraseña";
      // 
      // maskedTextBox1
      // 
      this.maskedTextBox1.Location = new System.Drawing.Point(98, 297);
      this.maskedTextBox1.Name = "maskedTextBox1";
      this.maskedTextBox1.Size = new System.Drawing.Size(180, 20);
      this.maskedTextBox1.TabIndex = 4;
      this.maskedTextBox1.UseSystemPasswordChar = true;
      // 
      // maskedTextBox2
      // 
      this.maskedTextBox2.Location = new System.Drawing.Point(98, 223);
      this.maskedTextBox2.Name = "maskedTextBox2";
      this.maskedTextBox2.Size = new System.Drawing.Size(248, 20);
      this.maskedTextBox2.TabIndex = 5;
      // 
      // button1
      // 
      this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.button1.Location = new System.Drawing.Point(284, 297);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(62, 21);
      this.button1.TabIndex = 6;
      this.button1.Text = "Mostrar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(98, 391);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(129, 24);
      this.button2.TabIndex = 7;
      this.button2.Text = "Salir";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(229, 391);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(117, 24);
      this.button3.TabIndex = 8;
      this.button3.Text = "Entrar";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label4);
      this.panel1.Location = new System.Drawing.Point(449, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(450, 558);
      this.panel1.TabIndex = 9;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label4.Location = new System.Drawing.Point(43, 40);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(357, 42);
      this.label4.TabIndex = 0;
      this.label4.Text = "CubreMax Seguros";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(896, 555);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.maskedTextBox2);
      this.Controls.Add(this.maskedTextBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label4;
  }
}

