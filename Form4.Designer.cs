
namespace STORE_Improvised
{
    partial class Form4
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
            this.gameName = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gamePrice = new System.Windows.Forms.TextBox();
            this.upload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameName
            // 
            this.gameName.Location = new System.Drawing.Point(207, 93);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(100, 20);
            this.gameName.TabIndex = 0;
            this.gameName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.create.Location = new System.Drawing.Point(647, 362);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(119, 67);
            this.create.TabIndex = 1;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(57, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(57, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Game Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gameDescription
            // 
            this.gameDescription.Location = new System.Drawing.Point(207, 154);
            this.gameDescription.Name = "gameDescription";
            this.gameDescription.Size = new System.Drawing.Size(459, 20);
            this.gameDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(57, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Game Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gamePrice
            // 
            this.gamePrice.Location = new System.Drawing.Point(207, 216);
            this.gamePrice.Name = "gamePrice";
            this.gamePrice.Size = new System.Drawing.Size(100, 20);
            this.gamePrice.TabIndex = 5;
            // 
            // upload
            // 
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.upload.Location = new System.Drawing.Point(207, 362);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(129, 52);
            this.upload.TabIndex = 7;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gamePrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.create);
            this.Controls.Add(this.gameName);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gameName;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gameDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gamePrice;
        private System.Windows.Forms.Button upload;
    }
}