
namespace TeamSourceControl_Group4
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
            this.ratingCmbBxox = new System.Windows.Forms.ComboBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gameLstBox = new System.Windows.Forms.ListBox();
            this.deleteGameBtn = new System.Windows.Forms.Button();
            this.addGameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ratingCmbBxox
            // 
            this.ratingCmbBxox.FormattingEnabled = true;
            this.ratingCmbBxox.Items.AddRange(new object[] {
            "Everyone",
            "Teen",
            "Mature"});
            this.ratingCmbBxox.Location = new System.Drawing.Point(241, 205);
            this.ratingCmbBxox.Name = "ratingCmbBxox";
            this.ratingCmbBxox.Size = new System.Drawing.Size(100, 21);
            this.ratingCmbBxox.TabIndex = 18;
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(241, 144);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(100, 20);
            this.priceTxt.TabIndex = 17;
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(241, 86);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(100, 20);
            this.titleTxt.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rating:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Title:";
            // 
            // gameLstBox
            // 
            this.gameLstBox.FormattingEnabled = true;
            this.gameLstBox.Location = new System.Drawing.Point(473, 90);
            this.gameLstBox.Name = "gameLstBox";
            this.gameLstBox.Size = new System.Drawing.Size(157, 147);
            this.gameLstBox.TabIndex = 12;
            this.gameLstBox.SelectedIndexChanged += new System.EventHandler(this.gameLstBox_SelectedIndexChanged);
            // 
            // deleteGameBtn
            // 
            this.deleteGameBtn.Location = new System.Drawing.Point(510, 341);
            this.deleteGameBtn.Name = "deleteGameBtn";
            this.deleteGameBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteGameBtn.TabIndex = 11;
            this.deleteGameBtn.Text = "Delete Game";
            this.deleteGameBtn.UseVisualStyleBackColor = true;
            // 
            // addGameBtn
            // 
            this.addGameBtn.Location = new System.Drawing.Point(204, 341);
            this.addGameBtn.Name = "addGameBtn";
            this.addGameBtn.Size = new System.Drawing.Size(112, 23);
            this.addGameBtn.TabIndex = 10;
            this.addGameBtn.Text = "Add Game";
            this.addGameBtn.UseVisualStyleBackColor = true;
            this.addGameBtn.Click += new System.EventHandler(this.addGameBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ratingCmbBxox);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameLstBox);
            this.Controls.Add(this.deleteGameBtn);
            this.Controls.Add(this.addGameBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ratingCmbBxox;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox gameLstBox;
        private System.Windows.Forms.Button deleteGameBtn;
        private System.Windows.Forms.Button addGameBtn;
    }
}

