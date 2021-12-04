
namespace STORE_Improvised
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toStore = new System.Windows.Forms.Button();
            this.walletAmount = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(61, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.BackColor = System.Drawing.Color.Transparent;
            this.account.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.account.LinkColor = System.Drawing.Color.GhostWhite;
            this.account.Location = new System.Drawing.Point(822, 38);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(84, 19);
            this.account.TabIndex = 18;
            this.account.TabStop = true;
            this.account.Text = "UserAccount";
            this.account.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.account_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(63, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Current Balance:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Deposit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Withdraw";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(268, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 18);
            this.button4.TabIndex = 26;
            this.button4.Text = "PLAY";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // toStore
            // 
            this.toStore.Location = new System.Drawing.Point(809, 443);
            this.toStore.Name = "toStore";
            this.toStore.Size = new System.Drawing.Size(97, 38);
            this.toStore.TabIndex = 27;
            this.toStore.Text = "STORE";
            this.toStore.UseVisualStyleBackColor = true;
            this.toStore.Click += new System.EventHandler(this.button5_Click);
            // 
            // walletAmount
            // 
            this.walletAmount.AutoSize = true;
            this.walletAmount.BackColor = System.Drawing.Color.Transparent;
            this.walletAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletAmount.ForeColor = System.Drawing.Color.GhostWhite;
            this.walletAmount.Location = new System.Drawing.Point(179, 82);
            this.walletAmount.Name = "walletAmount";
            this.walletAmount.Size = new System.Drawing.Size(77, 21);
            this.walletAmount.TabIndex = 22;
            this.walletAmount.Text = "$635,354";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(67, 127);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(195, 370);
            this.dataGrid.TabIndex = 59;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 18);
            this.button3.TabIndex = 60;
            this.button3.Text = "PLAY";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(268, 175);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 18);
            this.button6.TabIndex = 61;
            this.button6.Text = "PLAY";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(268, 199);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 18);
            this.button7.TabIndex = 62;
            this.button7.Text = "PLAY";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(268, 223);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 18);
            this.button9.TabIndex = 63;
            this.button9.Text = "PLAY";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(268, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 18);
            this.button5.TabIndex = 64;
            this.button5.Text = "PLAY";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(268, 295);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 18);
            this.button8.TabIndex = 65;
            this.button8.Text = "PLAY";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(268, 319);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 18);
            this.button10.TabIndex = 66;
            this.button10.Text = "PLAY";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(268, 343);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 18);
            this.button11.TabIndex = 67;
            this.button11.Text = "PLAY";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(268, 367);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(55, 18);
            this.button12.TabIndex = 68;
            this.button12.Text = "PLAY";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(268, 391);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 18);
            this.button13.TabIndex = 69;
            this.button13.Text = "PLAY";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(268, 415);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(55, 18);
            this.button14.TabIndex = 70;
            this.button14.Text = "PLAY";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(268, 439);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(55, 18);
            this.button15.TabIndex = 71;
            this.button15.Text = "PLAY";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(268, 463);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(55, 18);
            this.button16.TabIndex = 72;
            this.button16.Text = "PLAY";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 509);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.toStore);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.walletAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.account);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Seller";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.LinkLabel account;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button toStore;
        public System.Windows.Forms.Label walletAmount;
        public System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}