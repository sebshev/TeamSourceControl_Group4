
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
            this.updateGameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ratingCmbBxox
            // 
            this.ratingCmbBxox.FormattingEnabled = true;
            this.ratingCmbBxox.Items.AddRange(new object[] {
            "Everyone",
            "Teen",
            "Mature"});
            this.ratingCmbBxox.Location = new System.Drawing.Point(281, 189);
            this.ratingCmbBxox.Name = "ratingCmbBxox";
            this.ratingCmbBxox.Size = new System.Drawing.Size(116, 20);
            this.ratingCmbBxox.TabIndex = 18;
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(281, 133);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(116, 21);
            this.priceTxt.TabIndex = 17;
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(281, 79);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(116, 21);
            this.titleTxt.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rating:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Title:";
            // 
            // gameLstBox
            // 
            this.gameLstBox.FormattingEnabled = true;
            this.gameLstBox.ItemHeight = 12;
            this.gameLstBox.Location = new System.Drawing.Point(454, 65);
            this.gameLstBox.Name = "gameLstBox";
            this.gameLstBox.Size = new System.Drawing.Size(182, 136);
            this.gameLstBox.TabIndex = 12;
            this.gameLstBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gameLstBox_MouseClick);
            this.gameLstBox.SelectedIndexChanged += new System.EventHandler(this.gameLstBox_SelectedIndexChanged);
            // 
            // deleteGameBtn
            // 
            this.deleteGameBtn.Location = new System.Drawing.Point(595, 315);
            this.deleteGameBtn.Name = "deleteGameBtn";
            this.deleteGameBtn.Size = new System.Drawing.Size(87, 21);
            this.deleteGameBtn.TabIndex = 11;
            this.deleteGameBtn.Text = "Delete Game";
            this.deleteGameBtn.UseVisualStyleBackColor = true;
            this.deleteGameBtn.Click += new System.EventHandler(this.deleteGameBtn_Click);
            // 
            // addGameBtn
            // 
            this.addGameBtn.Location = new System.Drawing.Point(238, 315);
            this.addGameBtn.Name = "addGameBtn";
            this.addGameBtn.Size = new System.Drawing.Size(131, 21);
            this.addGameBtn.TabIndex = 10;
            this.addGameBtn.Text = "Add Game";
            this.addGameBtn.UseVisualStyleBackColor = true;
            this.addGameBtn.Click += new System.EventHandler(this.addGameBtn_Click);
            // 
            // updateGameBtn
            // 
            this.updateGameBtn.Location = new System.Drawing.Point(420, 315);
            this.updateGameBtn.Name = "updateGameBtn";
            this.updateGameBtn.Size = new System.Drawing.Size(113, 21);
            this.updateGameBtn.TabIndex = 19;
            this.updateGameBtn.Text = "Update";
            this.updateGameBtn.UseVisualStyleBackColor = true;
            this.updateGameBtn.Click += new System.EventHandler(this.updateGameBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 415);
            this.Controls.Add(this.updateGameBtn);
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
        private System.Windows.Forms.Button updateGameBtn;
    }
}

