namespace LAB1
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
            panel1 = new Panel();
            labelUsers = new Label();
            panel2 = new Panel();
            labelInfAboutUsers = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(labelUsers);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(684, 100);
            panel1.TabIndex = 0;
            // 
            // labelUsers
            // 
            labelUsers.Dock = DockStyle.Fill;
            labelUsers.Location = new Point(10, 10);
            labelUsers.Name = "labelUsers";
            labelUsers.Size = new Size(664, 80);
            labelUsers.TabIndex = 0;
            labelUsers.TextAlign = ContentAlignment.TopCenter;
            labelUsers.Click += labelUsers_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(labelInfAboutUsers);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(684, 461);
            panel2.TabIndex = 1;
            // 
            // labelInfAboutUsers
            // 
            labelInfAboutUsers.Dock = DockStyle.Fill;
            labelInfAboutUsers.Location = new Point(10, 10);
            labelInfAboutUsers.Name = "labelInfAboutUsers";
            labelInfAboutUsers.Size = new Size(664, 441);
            labelInfAboutUsers.TabIndex = 0;
            labelInfAboutUsers.Click += labelInfAboutUsers_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(684, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FormMain";
            Text = "Пользователи";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label labelUsers;
        private Label labelInfAboutUsers;
    }
}
