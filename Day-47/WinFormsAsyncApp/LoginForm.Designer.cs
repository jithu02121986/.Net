namespace WinFormsAsyncApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            txtuser = new TextBox();
            label2 = new Label();
            txtpass = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            Login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label1.Location = new Point(147, 61);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "User Name :";
            label1.Click += label1_Click;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(276, 53);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(220, 23);
            txtuser.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label2.Location = new Point(147, 132);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // txtpass
            // 
            txtpass.Location = new Point(276, 124);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(217, 23);
            txtpass.TabIndex = 3;
            txtpass.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtpass.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(514, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            Login.Location = new Point(276, 225);
            Login.Name = "Login";
            Login.Size = new Size(184, 38);
            Login.TabIndex = 4;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Login);
            Controls.Add(pictureBox1);
            Controls.Add(txtpass);
            Controls.Add(label2);
            Controls.Add(txtuser);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtuser;
        private Label label2;
        private MaskedTextBox txtpass;
        private PictureBox pictureBox1;
        private Button Login;
    }
}