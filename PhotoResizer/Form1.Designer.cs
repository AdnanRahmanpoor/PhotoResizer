namespace PhotoResizer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnSave;

        private void InitializeComponent()
        {
            this.btnUpload = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            // btnUpload

            this.btnUpload.Location = new System.Drawing.Point(12, 12);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 23);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);

            // pictureBox
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 400);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;

            //btnSave

            this.btnSave.Location = new System.Drawing.Point(12, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Form1

            this.ClientSize = new System.Drawing.Size(424, 511);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnUpload);
            this.Name = "Form1";
            this.Text = "PhotoResizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }
    }
}