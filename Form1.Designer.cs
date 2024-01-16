namespace WinFormsApp
{
    partial class FormMain
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
            btInitial = new Button();
            lbMainFormClose = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 54);
            label1.Name = "label1";
            label1.Size = new Size(242, 24);
            label1.TabIndex = 0;
            label1.Text = "Let's get to know each other";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btInitial
            // 
            btInitial.Anchor = AnchorStyles.None;
            btInitial.Cursor = Cursors.Hand;
            btInitial.FlatStyle = FlatStyle.System;
            btInitial.Font = new Font("Segoe UI Historic", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btInitial.Location = new Point(319, 172);
            btInitial.Name = "btInitial";
            btInitial.Size = new Size(140, 49);
            btInitial.TabIndex = 1;
            btInitial.Text = "Let's go!";
            btInitial.UseVisualStyleBackColor = true;
            btInitial.Click += btInitial_Click;
            // 
            // lbMainFormClose
            // 
            lbMainFormClose.Anchor = AnchorStyles.None;
            lbMainFormClose.AutoSize = true;
            lbMainFormClose.Cursor = Cursors.Hand;
            lbMainFormClose.Font = new Font("Segoe UI Historic", 9.163636F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMainFormClose.ForeColor = SystemColors.HotTrack;
            lbMainFormClose.Location = new Point(305, 224);
            lbMainFormClose.Name = "lbMainFormClose";
            lbMainFormClose.Size = new Size(173, 19);
            lbMainFormClose.TabIndex = 2;
            lbMainFormClose.Text = "I dont wanna do that :(";
            lbMainFormClose.Click += lbMainFormClose_Click;
            // 
            // FormMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(lbMainFormClose);
            Controls.Add(btInitial);
            Controls.Add(label1);
            MinimumSize = new Size(818, 494);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btInitial;
        private Label lbMainFormClose;
    }
}
