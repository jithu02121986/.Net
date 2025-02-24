namespace WinFormsAsyncApp
{
    partial class WelcomeForm
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
            btnStart = new Button();
            btnStop = new Button();
            btnprintviathread = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.ControlLight;
            btnStart.Location = new Point(285, 50);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.TextAlign = ContentAlignment.TopCenter;
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += button1_handler_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(285, 193);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // btnprintviathread
            // 
            btnprintviathread.Location = new Point(285, 122);
            btnprintviathread.Name = "btnprintviathread";
            btnprintviathread.Size = new Size(100, 27);
            btnprintviathread.TabIndex = 2;
            btnprintviathread.Text = "PrintViaThread";
            btnprintviathread.UseVisualStyleBackColor = true;
            btnprintviathread.Click += PrintViaThreadController;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnprintviathread);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Button btnprintviathread;
    }
}