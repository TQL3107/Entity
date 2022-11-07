namespace Entity.C_GUI.View
{
    partial class SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.tbt_Username = new System.Windows.Forms.TextBox();
            this.tbt_RePassword = new System.Windows.Forms.TextBox();
            this.tbt_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 3;
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(313, 300);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(138, 43);
            this.btn_Create.TabIndex = 4;
            this.btn_Create.Text = "Tạo Tài Khoản ";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click_1);
            // 
            // tbt_Username
            // 
            this.tbt_Username.Location = new System.Drawing.Point(226, 87);
            this.tbt_Username.Name = "tbt_Username";
            this.tbt_Username.Size = new System.Drawing.Size(511, 27);
            this.tbt_Username.TabIndex = 5;
            // 
            // tbt_RePassword
            // 
            this.tbt_RePassword.Location = new System.Drawing.Point(226, 218);
            this.tbt_RePassword.Name = "tbt_RePassword";
            this.tbt_RePassword.Size = new System.Drawing.Size(511, 27);
            this.tbt_RePassword.TabIndex = 6;
            // 
            // tbt_Password
            // 
            this.tbt_Password.Location = new System.Drawing.Point(226, 151);
            this.tbt_Password.Name = "tbt_Password";
            this.tbt_Password.Size = new System.Drawing.Size(511, 27);
            this.tbt_Password.TabIndex = 7;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbt_Password);
            this.Controls.Add(this.tbt_RePassword);
            this.Controls.Add(this.tbt_Username);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_Create;
        private TextBox tbt_Username;
        private TextBox tbt_RePassword;
        private TextBox tbt_Password;
    }
}