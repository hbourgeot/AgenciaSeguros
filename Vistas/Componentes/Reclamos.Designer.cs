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
      this.clienteCombobox.FormattingEnabled = true;
      this.clienteCombobox.Location = new System.Drawing.Point(274, 107);
      this.clienteCombobox.Name = "clienteCombobox";
      this.clienteCombobox.Size = new System.Drawing.Size(346, 28);
      this.clienteCombobox.TabIndex = 116;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(91, 77);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(60, 20);
      this.label13.TabIndex = 114;
      this.label13.Text = "Estado";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(270, 77);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(58, 20);
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
      this.label2.Location = new System.Drawing.Point(91, 233);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(92, 20);
      this.label2.TabIndex = 119;
      this.label2.Text = "Descripción";
      // 
      // descripcionText
      // 
      this.descripcionText.Location = new System.Drawing.Point(95, 266);
      this.descripcionText.Multiline = true;
      this.descripcionText.Name = "descripcionText";
      this.descripcionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.descripcionText.Size = new System.Drawing.Size(340, 113);
      this.descripcionText.TabIndex = 118;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(91, 151);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(51, 20);
      this.label10.TabIndex = 112;
      this.label10.Text = "Póliza";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(460, 266);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(160, 43);
      this.button2.TabIndex = 111;
      this.button2.Text = "Cancelar";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // btnGuardar
      // 
      this.btnGuardar.Location = new System.Drawing.Point(460, 336);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(160, 43);
      this.btnGuardar.TabIndex = 110;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(301, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(134, 20);
      this.label1.TabIndex = 109;
      this.label1.Text = "Registrar reclamo";
      // 
      // estadoCombobox
      // 
      this.estadoCombobox.FormattingEnabled = true;
      this.estadoCombobox.Items.AddRange(new object[] {
            "No atendido",
            "En proceso",
            "Respondido",
            "Rechazado"});
      this.estadoCombobox.Location = new System.Drawing.Point(95, 107);
      this.estadoCombobox.Name = "estadoCombobox";
      this.estadoCombobox.Size = new System.Drawing.Size(148, 28);
      this.estadoCombobox.TabIndex = 120;
      // 
      // polizasCombobox
      // 
      this.polizasCombobox.FormattingEnabled = true;
      this.polizasCombobox.Location = new System.Drawing.Point(95, 184);
      this.polizasCombobox.Name = "polizasCombobox";
      this.polizasCombobox.Size = new System.Drawing.Size(525, 28);
      this.polizasCombobox.TabIndex = 121;
      // 
      // Reclamos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(728, 458);
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