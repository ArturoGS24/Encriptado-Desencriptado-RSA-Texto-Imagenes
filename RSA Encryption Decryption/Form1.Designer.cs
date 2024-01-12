namespace RSA_Encryption_Decryption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlainTextInput = new System.Windows.Forms.TextBox();
            this.CipherText = new System.Windows.Forms.TextBox();
            this.PlainTextOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EncButton = new System.Windows.Forms.Button();
            this.DecButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.btnEncImg = new System.Windows.Forms.Button();
            this.pbImg2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStringImg = new System.Windows.Forms.TextBox();
            this.txtCPublic = new System.Windows.Forms.TextBox();
            this.txtCPrivada = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDesImg = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEncPass = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlainTextInput
            // 
            this.PlainTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainTextInput.Location = new System.Drawing.Point(278, 90);
            this.PlainTextInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlainTextInput.MaxLength = 1000000;
            this.PlainTextInput.Multiline = true;
            this.PlainTextInput.Name = "PlainTextInput";
            this.PlainTextInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PlainTextInput.Size = new System.Drawing.Size(429, 67);
            this.PlainTextInput.TabIndex = 0;
            this.PlainTextInput.TextChanged += new System.EventHandler(this.PlainTextInput_TextChanged);
            // 
            // CipherText
            // 
            this.CipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CipherText.Location = new System.Drawing.Point(278, 178);
            this.CipherText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CipherText.MaxLength = 1000000;
            this.CipherText.Multiline = true;
            this.CipherText.Name = "CipherText";
            this.CipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CipherText.Size = new System.Drawing.Size(429, 61);
            this.CipherText.TabIndex = 1;
            // 
            // PlainTextOutput
            // 
            this.PlainTextOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainTextOutput.Location = new System.Drawing.Point(401, 142);
            this.PlainTextOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlainTextOutput.MaxLength = 1000000;
            this.PlainTextOutput.Multiline = true;
            this.PlainTextOutput.Name = "PlainTextOutput";
            this.PlainTextOutput.Size = new System.Drawing.Size(429, 82);
            this.PlainTextOutput.TabIndex = 2;
            this.PlainTextOutput.TextChanged += new System.EventHandler(this.PlainTextOutput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(136, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mensaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(136, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 64);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mensaje \r\ncifrado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(228, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 58);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mensaje \r\ndesencriptado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(410, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Algoritmo RSA";
            // 
            // EncButton
            // 
            this.EncButton.BackColor = System.Drawing.Color.Gray;
            this.EncButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncButton.Location = new System.Drawing.Point(714, 97);
            this.EncButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EncButton.Name = "EncButton";
            this.EncButton.Size = new System.Drawing.Size(167, 51);
            this.EncButton.TabIndex = 7;
            this.EncButton.Text = "Encriptar";
            this.EncButton.UseVisualStyleBackColor = false;
            this.EncButton.Click += new System.EventHandler(this.EncButton_Click);
            // 
            // DecButton
            // 
            this.DecButton.BackColor = System.Drawing.Color.Gray;
            this.DecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DecButton.Location = new System.Drawing.Point(714, 181);
            this.DecButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DecButton.Name = "DecButton";
            this.DecButton.Size = new System.Drawing.Size(167, 51);
            this.DecButton.TabIndex = 8;
            this.DecButton.Text = "Desencriptar";
            this.DecButton.UseVisualStyleBackColor = false;
            this.DecButton.Click += new System.EventHandler(this.DecButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(217, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Imagen";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(82, 96);
            this.pbImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(243, 204);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 10;
            this.pbImage.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.Color.Gray;
            this.btnSelectImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImage.Location = new System.Drawing.Point(351, 21);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(167, 41);
            this.btnSelectImage.TabIndex = 12;
            this.btnSelectImage.Text = "Seleccionar\r\n";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            this.btnSelectImage.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEncImg
            // 
            this.btnEncImg.BackColor = System.Drawing.Color.Gray;
            this.btnEncImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncImg.Location = new System.Drawing.Point(351, 98);
            this.btnEncImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncImg.Name = "btnEncImg";
            this.btnEncImg.Size = new System.Drawing.Size(167, 41);
            this.btnEncImg.TabIndex = 13;
            this.btnEncImg.Text = "Encriptar";
            this.btnEncImg.UseVisualStyleBackColor = false;
            this.btnEncImg.Click += new System.EventHandler(this.btnEncImg_Click);
            // 
            // pbImg2
            // 
            this.pbImg2.Location = new System.Drawing.Point(784, 98);
            this.pbImg2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbImg2.Name = "pbImg2";
            this.pbImg2.Size = new System.Drawing.Size(243, 197);
            this.pbImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg2.TabIndex = 14;
            this.pbImg2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(825, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Mostrar Imagen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStringImg
            // 
            this.txtStringImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStringImg.Location = new System.Drawing.Point(337, 141);
            this.txtStringImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStringImg.MaxLength = 1000000;
            this.txtStringImg.Multiline = true;
            this.txtStringImg.Name = "txtStringImg";
            this.txtStringImg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStringImg.Size = new System.Drawing.Size(409, 152);
            this.txtStringImg.TabIndex = 16;
            // 
            // txtCPublic
            // 
            this.txtCPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPublic.Location = new System.Drawing.Point(205, 41);
            this.txtCPublic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPublic.MaxLength = 1000000;
            this.txtCPublic.Multiline = true;
            this.txtCPublic.Name = "txtCPublic";
            this.txtCPublic.ReadOnly = true;
            this.txtCPublic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCPublic.Size = new System.Drawing.Size(403, 85);
            this.txtCPublic.TabIndex = 17;
            // 
            // txtCPrivada
            // 
            this.txtCPrivada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPrivada.Location = new System.Drawing.Point(632, 41);
            this.txtCPrivada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPrivada.MaxLength = 1000000;
            this.txtCPrivada.Multiline = true;
            this.txtCPrivada.Name = "txtCPrivada";
            this.txtCPrivada.ReadOnly = true;
            this.txtCPrivada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCPrivada.Size = new System.Drawing.Size(403, 84);
            this.txtCPrivada.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnDesImg);
            this.panel1.Controls.Add(this.txtStringImg);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Controls.Add(this.btnSelectImage);
            this.panel1.Controls.Add(this.btnEncImg);
            this.panel1.Controls.Add(this.pbImg2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 304);
            this.panel1.TabIndex = 21;
            // 
            // btnDesImg
            // 
            this.btnDesImg.BackColor = System.Drawing.Color.Gray;
            this.btnDesImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesImg.Location = new System.Drawing.Point(565, 96);
            this.btnDesImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesImg.Name = "btnDesImg";
            this.btnDesImg.Size = new System.Drawing.Size(167, 41);
            this.btnDesImg.TabIndex = 17;
            this.btnDesImg.Text = "Desencriptar";
            this.btnDesImg.UseVisualStyleBackColor = false;
            this.btnDesImg.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Location = new System.Drawing.Point(28, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 29);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Texto";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton2.Location = new System.Drawing.Point(133, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 29);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Imagen";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(22, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 32);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tipo de archivo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 87);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.PlainTextOutput);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtCPublic);
            this.panel3.Controls.Add(this.txtCPrivada);
            this.panel3.Location = new System.Drawing.Point(3, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1227, 237);
            this.panel3.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(993, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 58);
            this.label9.TabIndex = 28;
            this.label9.Text = "Validar una \r\ncontraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(940, 80);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.MaxLength = 1000000;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPassword.Size = new System.Drawing.Size(251, 32);
            this.txtPassword.TabIndex = 27;
            // 
            // btnEncPass
            // 
            this.btnEncPass.BackColor = System.Drawing.Color.Gray;
            this.btnEncPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncPass.Location = new System.Drawing.Point(979, 116);
            this.btnEncPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncPass.Name = "btnEncPass";
            this.btnEncPass.Size = new System.Drawing.Size(167, 51);
            this.btnEncPass.TabIndex = 29;
            this.btnEncPass.Text = "Encriptar";
            this.btnEncPass.UseVisualStyleBackColor = false;
            this.btnEncPass.Click += new System.EventHandler(this.btnEncPass_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(935, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Debe contener:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(937, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "*Al menos 8 caracteres";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(937, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "*Un número";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(937, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "*Un caracter especial";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(937, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(248, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "*Una letra Mayuscula y una minúscula";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(717, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 29);
            this.label15.TabIndex = 20;
            this.label15.Text = "Clave Privada";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(295, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 29);
            this.label16.TabIndex = 19;
            this.label16.Text = "Clave Pública";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1227, 803);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnEncPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DecButton);
            this.Controls.Add(this.EncButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CipherText);
            this.Controls.Add(this.PlainTextInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Algoritmo de encriptado y desencriptado RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlainTextInput;
        private System.Windows.Forms.TextBox CipherText;
        private System.Windows.Forms.TextBox PlainTextOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EncButton;
        private System.Windows.Forms.Button DecButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Button btnEncImg;
        private System.Windows.Forms.PictureBox pbImg2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStringImg;
        private System.Windows.Forms.TextBox txtCPublic;
        private System.Windows.Forms.TextBox txtCPrivada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDesImg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEncPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}

