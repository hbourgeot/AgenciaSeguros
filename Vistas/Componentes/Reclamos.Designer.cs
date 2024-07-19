namespace AgenciaSeguros.Vistas.Componentes
{
  partial class Reclamos
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
      this.clienteCombobox = new System.Windows.Forms.ComboBox();
      this.label13 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.label2 = new System.Windows.Forms.Label();
      this.descripcionText = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.estadoCombobox = new System.Windows.Forms.ComboBox();
      this.polizasCombobox = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // clienteCombobox
      // 
      this.clienteCombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.clienteCombobox.FormattingEnabled = true;
      this.clienteCombobox.Location = new System.Drawing.Point(183, 70);
      this.clienteCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.clienteCombobox.Name = "clienteCombobox";
      this.clienteCombobox.Size = new System.Drawing.Size(232, 21);
      this.clienteCombobox.TabIndex = 116;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(61, 50);
      this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(40, 13);
      this.label13.TabIndex = 114;
      this.label13.Text = "Estado";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(180, 50);
      this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(39, 13);
      this.label11.TabIndex = 113;
      this.label11.Text = "Cliente";
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(61, 151);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 13);
      this.label2.TabIndex = 119;
      this.label2.Text = "Descripción";
      // 
      // descripcionText
      // 
      this.descripcionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.descripcionText.Location = new System.Drawing.Point(63, 173);
      this.descripcionText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.descripcionText.Multiline = true;
      this.descripcionText.Name = "descripcionText";
      this.descripcionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.descripcionText.Size = new System.Drawing.Size(227, 74);
      this.descripcionText.TabIndex = 118;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(61, 98);
      this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(35, 13);
      this.label10.TabIndex = 112;
      this.label10.Text = "Póliza";
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.PaleVioletRed;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
      this.button2.Location = new System.Drawing.Point(307, 173);
      this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(107, 28);
      this.button2.TabIndex = 111;
      this.button2.Text = "Cancelar";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // btnGuardar
      // 
      this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
      this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLight;
      this.btnGuardar.Location = new System.Drawing.Point(307, 218);
      this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(107, 28);
      this.btnGuardar.TabIndex = 110;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = false;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(201, 20);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(89, 13);
      this.label1.TabIndex = 109;
      this.label1.Text = "Registrar reclamo";
      // 
      // estadoCombobox
      // 
      this.estadoCombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.estadoCombobox.FormattingEnabled = true;
      this.estadoCombobox.Items.AddRange(new object[] {
            "No atendido",
            "En proceso",
            "Respondido",
            "Rechazado"});
      this.estadoCombobox.Location = new System.Drawing.Point(63, 70);
      this.estadoCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.estadoCombobox.Name = "estadoCombobox";
      this.estadoCombobox.Size = new System.Drawing.Size(100, 21);
      this.estadoCombobox.TabIndex = 120;
      // 
      // polizasCombobox
      // 
      this.polizasCombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.polizasCombobox.FormattingEnabled = true;
      this.polizasCombobox.Location = new System.Drawing.Point(63, 120);
      this.polizasCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.polizasCombobox.Name = "polizasCombobox";
      this.polizasCombobox.Size = new System.Drawing.Size(351, 21);
      this.polizasCombobox.TabIndex = 121;
      // 
      // Reclamos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(238)))), ((int)(((byte)(251)))));
      this.ClientSize = new System.Drawing.Size(485, 298);
      this.Controls.Add(this.polizasCombobox);
      this.Controls.Add(this.estadoCombobox);
      this.Controls.Add(this.clienteCombobox);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.descripcionText);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "Reclamos";
      this.Text = "Reclamos";
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox clienteCombobox;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.ComboBox estadoCombobox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox descripcionText;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox polizasCombobox;
  }
}