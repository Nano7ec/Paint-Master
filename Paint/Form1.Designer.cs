namespace Paint
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
            this.picBoxPapel = new System.Windows.Forms.PictureBox();
            this.picBoxNegro = new System.Windows.Forms.PictureBox();
            this.picBoxColores = new System.Windows.Forms.PictureBox();
            this.trackBarTamanioPincel = new System.Windows.Forms.TrackBar();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrador = new System.Windows.Forms.Button();
            this.btnPincel = new System.Windows.Forms.Button();
            this.lblTamanioPincel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Clear = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.Cuadrado = new System.Windows.Forms.Button();
            this.Elipse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNegro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxColores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTamanioPincel)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxPapel
            // 
            this.picBoxPapel.BackColor = System.Drawing.Color.White;
            this.picBoxPapel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picBoxPapel.Location = new System.Drawing.Point(99, 12);
            this.picBoxPapel.Name = "picBoxPapel";
            this.picBoxPapel.Size = new System.Drawing.Size(1035, 624);
            this.picBoxPapel.TabIndex = 0;
            this.picBoxPapel.TabStop = false;
            this.picBoxPapel.Paint += new System.Windows.Forms.PaintEventHandler(this.picBoxPapel_Paint);
            this.picBoxPapel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxPapel_MouseDown);
            this.picBoxPapel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxPapel_MouseMove);
            this.picBoxPapel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBoxPapel_MouseUp);
            // 
            // picBoxNegro
            // 
            this.picBoxNegro.BackColor = System.Drawing.Color.Black;
            this.picBoxNegro.Location = new System.Drawing.Point(12, 492);
            this.picBoxNegro.Name = "picBoxNegro";
            this.picBoxNegro.Size = new System.Drawing.Size(27, 27);
            this.picBoxNegro.TabIndex = 1;
            this.picBoxNegro.TabStop = false;
            this.picBoxNegro.Click += new System.EventHandler(this.picBoxNegro_Click);
            // 
            // picBoxColores
            // 
            this.picBoxColores.Location = new System.Drawing.Point(45, 492);
            this.picBoxColores.Name = "picBoxColores";
            this.picBoxColores.Size = new System.Drawing.Size(27, 27);
            this.picBoxColores.TabIndex = 2;
            this.picBoxColores.TabStop = false;
            this.picBoxColores.Click += new System.EventHandler(this.picBoxColores_Click);
            // 
            // trackBarTamanioPincel
            // 
            this.trackBarTamanioPincel.LargeChange = 1;
            this.trackBarTamanioPincel.Location = new System.Drawing.Point(14, 215);
            this.trackBarTamanioPincel.Maximum = 20;
            this.trackBarTamanioPincel.Minimum = 1;
            this.trackBarTamanioPincel.Name = "trackBarTamanioPincel";
            this.trackBarTamanioPincel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTamanioPincel.Size = new System.Drawing.Size(45, 242);
            this.trackBarTamanioPincel.TabIndex = 3;
            this.trackBarTamanioPincel.Value = 3;
            this.trackBarTamanioPincel.Scroll += new System.EventHandler(this.trackBarTamanioPincel_Scroll);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(28, 525);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(44, 23);
            this.txtR.TabIndex = 5;
            this.txtR.Text = "0";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(28, 554);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(44, 23);
            this.txtG.TabIndex = 6;
            this.txtG.Text = "0";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(28, 583);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(44, 23);
            this.txtB.TabIndex = 7;
            this.txtB.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "B";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(14, 186);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(74, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrador
            // 
            this.btnBorrador.Location = new System.Drawing.Point(9, 128);
            this.btnBorrador.Name = "btnBorrador";
            this.btnBorrador.Size = new System.Drawing.Size(80, 23);
            this.btnBorrador.TabIndex = 12;
            this.btnBorrador.Text = "Borrador";
            this.btnBorrador.UseVisualStyleBackColor = true;
            this.btnBorrador.Click += new System.EventHandler(this.btnBorrador_Click);
            // 
            // btnPincel
            // 
            this.btnPincel.Location = new System.Drawing.Point(9, 157);
            this.btnPincel.Name = "btnPincel";
            this.btnPincel.Size = new System.Drawing.Size(80, 23);
            this.btnPincel.TabIndex = 13;
            this.btnPincel.Text = "Pincel";
            this.btnPincel.UseVisualStyleBackColor = true;
            this.btnPincel.Click += new System.EventHandler(this.btnPincel_Click);
            // 
            // lblTamanioPincel
            // 
            this.lblTamanioPincel.AutoSize = true;
            this.lblTamanioPincel.Location = new System.Drawing.Point(14, 460);
            this.lblTamanioPincel.Name = "lblTamanioPincel";
            this.lblTamanioPincel.Size = new System.Drawing.Size(13, 15);
            this.lblTamanioPincel.TabIndex = 14;
            this.lblTamanioPincel.Text = "3";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(9, 99);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(79, 23);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(10, 70);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(79, 23);
            this.Line.TabIndex = 16;
            this.Line.Text = "Línea";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Cuadrado
            // 
            this.Cuadrado.Location = new System.Drawing.Point(12, 12);
            this.Cuadrado.Name = "Cuadrado";
            this.Cuadrado.Size = new System.Drawing.Size(79, 23);
            this.Cuadrado.TabIndex = 17;
            this.Cuadrado.Text = "Cuadrado";
            this.Cuadrado.UseVisualStyleBackColor = true;
            this.Cuadrado.Click += new System.EventHandler(this.Cuadrado_Click);
            // 
            // Elipse
            // 
            this.Elipse.Location = new System.Drawing.Point(10, 41);
            this.Elipse.Name = "Elipse";
            this.Elipse.Size = new System.Drawing.Size(81, 23);
            this.Elipse.TabIndex = 18;
            this.Elipse.Text = "Elípse";
            this.Elipse.UseVisualStyleBackColor = true;
            this.Elipse.Click += new System.EventHandler(this.Elipse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 638);
            this.Controls.Add(this.Elipse);
            this.Controls.Add(this.Cuadrado);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.lblTamanioPincel);
            this.Controls.Add(this.btnPincel);
            this.Controls.Add(this.btnBorrador);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.trackBarTamanioPincel);
            this.Controls.Add(this.picBoxColores);
            this.Controls.Add(this.picBoxNegro);
            this.Controls.Add(this.picBoxPapel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNegro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxColores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTamanioPincel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picBoxPapel;
        private PictureBox picBoxNegro;
        private PictureBox picBoxColores;
        private TrackBar trackBarTamanioPincel;
        private TextBox txtR;
        private TextBox txtG;
        private TextBox txtB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGuardar;
        private Button btnBorrador;
        private Button btnPincel;
        private Label lblTamanioPincel;
        private ColorDialog colorDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button Clear;
        private Button Line;
        private Button Cuadrado;
        private Button Elipse;
    }
}