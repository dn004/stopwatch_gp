namespace stopwatch_gp
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
            label1 = new Label();
            StartBTN = new Button();
            StopBTN = new Button();
            ResetBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 46);
            label1.Name = "label1";
            label1.Size = new Size(807, 183);
            label1.TabIndex = 0;
            label1.Text = "00:00:00:00";
            label1.Click += label1_Click;
            // 
            // StartBTN
            // 
            StartBTN.BackColor = Color.DarkGreen;
            StartBTN.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            StartBTN.Location = new Point(30, 270);
            StartBTN.Name = "StartBTN";
            StartBTN.Size = new Size(228, 76);
            StartBTN.TabIndex = 1;
            StartBTN.Text = "Start";
            StartBTN.UseVisualStyleBackColor = false;
            StartBTN.Click += StartBTN_Click;
            // 
            // StopBTN
            // 
            StopBTN.BackColor = Color.Red;
            StopBTN.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            StopBTN.Location = new Point(317, 270);
            StopBTN.Name = "StopBTN";
            StopBTN.Size = new Size(206, 76);
            StopBTN.TabIndex = 2;
            StopBTN.Text = "Stop";
            StopBTN.UseVisualStyleBackColor = false;
            StopBTN.Click += StopBTN_Click;
            // 
            // ResetBTN
            // 
            ResetBTN.BackColor = Color.Fuchsia;
            ResetBTN.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ResetBTN.Location = new Point(597, 270);
            ResetBTN.Name = "ResetBTN";
            ResetBTN.Size = new Size(175, 76);
            ResetBTN.TabIndex = 3;
            ResetBTN.Text = "Reset";
            ResetBTN.UseVisualStyleBackColor = false;
            ResetBTN.Click += ResetBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(828, 444);
            Controls.Add(ResetBTN);
            Controls.Add(StopBTN);
            Controls.Add(StartBTN);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button StartBTN;
        private Button StopBTN;
        private Button ResetBTN;
    }
}