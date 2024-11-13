namespace INF_UE_StringManipulation
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
            tbInput = new TextBox();
            btStart = new Button();
            lblOutput1 = new Label();
            lblOutput2 = new Label();
            SuspendLayout();
            // 
            // tbInput
            // 
            tbInput.Location = new Point(267, 53);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(200, 39);
            tbInput.TabIndex = 0;
            // 
            // btStart
            // 
            btStart.Location = new Point(584, 46);
            btStart.Name = "btStart";
            btStart.Size = new Size(150, 46);
            btStart.TabIndex = 1;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // lblOutput1
            // 
            lblOutput1.AutoSize = true;
            lblOutput1.Location = new Point(341, 121);
            lblOutput1.Name = "lblOutput1";
            lblOutput1.Size = new Size(25, 32);
            lblOutput1.TabIndex = 2;
            lblOutput1.Text = "?";
            // 
            // lblOutput2
            // 
            lblOutput2.AutoSize = true;
            lblOutput2.Location = new Point(341, 168);
            lblOutput2.Name = "lblOutput2";
            lblOutput2.Size = new Size(25, 32);
            lblOutput2.TabIndex = 3;
            lblOutput2.Text = "?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 504);
            Controls.Add(lblOutput2);
            Controls.Add(lblOutput1);
            Controls.Add(btStart);
            Controls.Add(tbInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbInput;
        private Button btStart;
        private Label lblOutput1;
        private Label lblOutput2;
    }
}
