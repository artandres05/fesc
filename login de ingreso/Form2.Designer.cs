namespace login_de_ingreso
{
    partial class Form2
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(251, 24);
            label1.Name = "label1";
            label1.Size = new Size(290, 45);
            label1.TabIndex = 0;
            label1.Text = "INICIO DE SESION\r\n";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(54, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(621, 266);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "REQUERIMIENTO DE DATOS";
            // 
            // button2
            // 
            button2.Location = new Point(412, 167);
            button2.Name = "button2";
            button2.Size = new Size(84, 33);
            button2.TabIndex = 4;
            button2.Text = "VER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 29);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 29);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(272, 221);
            button1.Name = "button1";
            button1.Size = new Size(91, 39);
            button1.TabIndex = 2;
            button1.Text = "ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 173);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 0;
            label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 110);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 0;
            label2.Text = "USUARIO";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 412);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "inicio ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
    }
}