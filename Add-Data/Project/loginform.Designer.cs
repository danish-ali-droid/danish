
namespace AfaqProject
{
    partial class loginform
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
            this.logintxt = new System.Windows.Forms.Label();
            this.useridtxt = new System.Windows.Forms.Label();
            this.useridtxtbox = new System.Windows.Forms.TextBox();
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logintxt
            // 
            this.logintxt.AutoSize = true;
            this.logintxt.Font = new System.Drawing.Font("Magneto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logintxt.Location = new System.Drawing.Point(84, 59);
            this.logintxt.Name = "logintxt";
            this.logintxt.Size = new System.Drawing.Size(242, 78);
            this.logintxt.TabIndex = 0;
            this.logintxt.Text = "Login";
            // 
            // useridtxt
            // 
            this.useridtxt.AutoSize = true;
            this.useridtxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useridtxt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.useridtxt.Location = new System.Drawing.Point(62, 175);
            this.useridtxt.Name = "useridtxt";
            this.useridtxt.Size = new System.Drawing.Size(57, 21);
            this.useridtxt.TabIndex = 1;
            this.useridtxt.Text = "UserID";
            // 
            // useridtxtbox
            // 
            this.useridtxtbox.Location = new System.Drawing.Point(169, 176);
            this.useridtxtbox.Name = "useridtxtbox";
            this.useridtxtbox.Size = new System.Drawing.Size(138, 20);
            this.useridtxtbox.TabIndex = 2;
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Location = new System.Drawing.Point(169, 225);
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.Size = new System.Drawing.Size(138, 20);
            this.passwordtxtbox.TabIndex = 4;
            this.passwordtxtbox.UseSystemPasswordChar = true;
            // 
            // passwordtxt
            // 
            this.passwordtxt.AutoSize = true;
            this.passwordtxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordtxt.Location = new System.Drawing.Point(62, 224);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(76, 21);
            this.passwordtxt.TabIndex = 3;
            this.passwordtxt.Text = "Password";
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(162, 279);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 32);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(407, 397);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passwordtxtbox);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.useridtxtbox);
            this.Controls.Add(this.useridtxt);
            this.Controls.Add(this.logintxt);
            this.Name = "loginform";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logintxt;
        private System.Windows.Forms.Label useridtxt;
        private System.Windows.Forms.TextBox useridtxtbox;
        private System.Windows.Forms.TextBox passwordtxtbox;
        private System.Windows.Forms.Label passwordtxt;
        private System.Windows.Forms.Button loginbtn;
    }
}

