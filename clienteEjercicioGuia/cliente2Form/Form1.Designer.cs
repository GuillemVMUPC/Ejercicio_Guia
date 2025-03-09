namespace cliente2Form
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
            groupBox1 = new GroupBox();
            button3 = new Button();
            FaC = new RadioButton();
            CaF = new RadioButton();
            temperatura = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(FaC);
            groupBox1.Controls.Add(CaF);
            groupBox1.Controls.Add(temperatura);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(58, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(590, 333);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(395, 30);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "Enviar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FaC
            // 
            FaC.AutoSize = true;
            FaC.Location = new Point(201, 127);
            FaC.Name = "FaC";
            FaC.Size = new Size(191, 29);
            FaC.TabIndex = 3;
            FaC.TabStop = true;
            FaC.Text = "Fahrenheit a Celsius";
            FaC.UseVisualStyleBackColor = true;
            // 
            // CaF
            // 
            CaF.AutoSize = true;
            CaF.Location = new Point(201, 82);
            CaF.Name = "CaF";
            CaF.Size = new Size(191, 29);
            CaF.TabIndex = 2;
            CaF.TabStop = true;
            CaF.Text = "Celsius a Fahrenheit";
            CaF.UseVisualStyleBackColor = true;
            // 
            // temperatura
            // 
            temperatura.Location = new Point(201, 30);
            temperatura.Name = "temperatura";
            temperatura.Size = new Size(150, 31);
            temperatura.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 33);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 0;
            label1.Text = "Temperatura";
            // 
            // button1
            // 
            button1.Location = new Point(175, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Conectar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(361, 12);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Desconectar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private TextBox temperatura;
        private Label label1;
        private RadioButton FaC;
        private RadioButton CaF;
        private Button button3;
    }
}