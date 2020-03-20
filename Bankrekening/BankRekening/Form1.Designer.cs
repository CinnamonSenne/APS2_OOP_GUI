namespace BankRekening
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.storten = new System.Windows.Forms.Button();
            this.afhalen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(340, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // storten
            // 
            this.storten.Location = new System.Drawing.Point(244, 217);
            this.storten.Name = "storten";
            this.storten.Size = new System.Drawing.Size(75, 23);
            this.storten.TabIndex = 2;
            this.storten.Text = "storten";
            this.storten.UseVisualStyleBackColor = true;
            this.storten.Click += new System.EventHandler(this.storten_Click);
            // 
            // afhalen
            // 
            this.afhalen.Location = new System.Drawing.Point(486, 215);
            this.afhalen.Name = "afhalen";
            this.afhalen.Size = new System.Drawing.Size(75, 23);
            this.afhalen.TabIndex = 3;
            this.afhalen.Text = "afhalen";
            this.afhalen.UseVisualStyleBackColor = true;
            this.afhalen.Click += new System.EventHandler(this.afhalen_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.afhalen);
            this.Controls.Add(this.storten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button storten;
        private System.Windows.Forms.Button afhalen;
    }
}

