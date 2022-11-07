namespace Entity.C_GUI.View
{
    partial class Login
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
            this.tbt_Username = new System.Windows.Forms.TextBox();
            this.tbt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lb_Create = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đăng Nhập";
            // 
            // tbt_Username
            // 
            this.tbt_Username.Location = new System.Drawing.Point(269, 103);
            this.tbt_Username.Name = "tbt_Username";
            this.tbt_Username.Size = new System.Drawing.Size(451, 27);
            this.tbt_Username.TabIndex = 2;
            // 
            // tbt_Password
            // 
            this.tbt_Password.Location = new System.Drawing.Point(269, 194);
            this.tbt_Password.Name = "tbt_Password";
            this.tbt_Password.Size = new System.Drawing.Size(451, 27);
            this.tbt_Password.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(142, 311);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(194, 50);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Đăng Nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // lb_Create
            // 
            this.lb_Create.AutoSize = true;
            this.lb_Create.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_Create.Location = new System.Drawing.Point(541, 327);
            this.lb_Create.Name = "lb_Create";
            this.lb_Create.Size = new System.Drawing.Size(114, 20);
            this.lb_Create.TabIndex = 5;
            this.lb_Create.Text = "Tạo Tài Khoản";
            this.lb_Create.Click += new System.EventHandler(this.lb_Create_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Create);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tbt_Password);
            this.Controls.Add(this.tbt_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbt_Username;
        private TextBox tbt_Password;
        private Button btn_Login;
        private Label lb_Create;
    }
}