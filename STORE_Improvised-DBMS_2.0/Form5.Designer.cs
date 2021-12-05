
namespace STORE_Improvised
{
    partial class Form5
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
            this.enter = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.Label();
            this.am = new System.Windows.Forms.TextBox();
            this.account = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(626, 259);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 0;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(95, 96);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 1;
            this.Amount.Text = "Amount";
            // 
            // am
            // 
            this.am.Location = new System.Drawing.Point(175, 89);
            this.am.Name = "am";
            this.am.Size = new System.Drawing.Size(100, 20);
            this.am.TabIndex = 2;
            this.am.TextChanged += new System.EventHandler(this.am_TextChanged);
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.Location = new System.Drawing.Point(623, 37);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(67, 13);
            this.account.TabIndex = 3;
            this.account.TabStop = true;
            this.account.Text = "userAccount";
            this.account.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.account_LinkClicked);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.account);
            this.Controls.Add(this.am);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.enter);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.TextBox am;
        public System.Windows.Forms.LinkLabel account;
    }
}