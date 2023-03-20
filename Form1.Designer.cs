namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.wishlist = new System.Windows.Forms.ListBox();
            this.fillbtn = new System.Windows.Forms.Button();
            this.sortbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.countbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.selectionOutputBox = new System.Windows.Forms.TextBox();
            this.countOutputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wish List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selection";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // wishlist
            // 
            this.wishlist.FormattingEnabled = true;
            this.wishlist.Location = new System.Drawing.Point(17, 39);
            this.wishlist.Name = "wishlist";
            this.wishlist.Size = new System.Drawing.Size(120, 212);
            this.wishlist.TabIndex = 3;
            this.wishlist.SelectedIndexChanged += new System.EventHandler(this.wishlist_SelectedIndexChanged);
            // 
            // fillbtn
            // 
            this.fillbtn.Location = new System.Drawing.Point(157, 39);
            this.fillbtn.Name = "fillbtn";
            this.fillbtn.Size = new System.Drawing.Size(75, 23);
            this.fillbtn.TabIndex = 4;
            this.fillbtn.Text = "Fill";
            this.fillbtn.UseVisualStyleBackColor = true;
            this.fillbtn.Click += new System.EventHandler(this.fillbtn_Click);
            // 
            // sortbtn
            // 
            this.sortbtn.Location = new System.Drawing.Point(157, 87);
            this.sortbtn.Name = "sortbtn";
            this.sortbtn.Size = new System.Drawing.Size(75, 23);
            this.sortbtn.TabIndex = 5;
            this.sortbtn.Text = "Sort";
            this.sortbtn.UseVisualStyleBackColor = true;
            this.sortbtn.Click += new System.EventHandler(this.sortbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(157, 132);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 23);
            this.clearbtn.TabIndex = 6;
            this.clearbtn.Text = "clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // countbtn
            // 
            this.countbtn.Location = new System.Drawing.Point(157, 179);
            this.countbtn.Name = "countbtn";
            this.countbtn.Size = new System.Drawing.Size(75, 23);
            this.countbtn.TabIndex = 7;
            this.countbtn.Text = "Count";
            this.countbtn.UseVisualStyleBackColor = true;
            this.countbtn.Click += new System.EventHandler(this.countbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(157, 223);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(75, 23);
            this.closebtn.TabIndex = 8;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // selectionOutputBox
            // 
            this.selectionOutputBox.Location = new System.Drawing.Point(70, 289);
            this.selectionOutputBox.Name = "selectionOutputBox";
            this.selectionOutputBox.Size = new System.Drawing.Size(100, 20);
            this.selectionOutputBox.TabIndex = 9;
            this.selectionOutputBox.TextChanged += new System.EventHandler(this.selectionOutputBox_TextChanged);
            // 
            // countOutputBox
            // 
            this.countOutputBox.Location = new System.Drawing.Point(70, 331);
            this.countOutputBox.Name = "countOutputBox";
            this.countOutputBox.Size = new System.Drawing.Size(100, 20);
            this.countOutputBox.TabIndex = 10;
            this.countOutputBox.TextChanged += new System.EventHandler(this.countOutputBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 417);
            this.Controls.Add(this.countOutputBox);
            this.Controls.Add(this.selectionOutputBox);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.countbtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.sortbtn);
            this.Controls.Add(this.fillbtn);
            this.Controls.Add(this.wishlist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox wishlist;
        private System.Windows.Forms.Button fillbtn;
        private System.Windows.Forms.Button sortbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button countbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.TextBox selectionOutputBox;
        private System.Windows.Forms.TextBox countOutputBox;
    }
}

