namespace ImagePoster
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
            this.chkbVisualize = new System.Windows.Forms.CheckBox();
            this.chkbTransparent = new System.Windows.Forms.CheckBox();
            this.chkbWhiteBack = new System.Windows.Forms.CheckBox();
            this.chkbPassport = new System.Windows.Forms.CheckBox();
            this.rtxtResponse = new System.Windows.Forms.RichTextBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdobtnFolder = new System.Windows.Forms.RadioButton();
            this.rdobtnFile = new System.Windows.Forms.RadioButton();
            this.txtOutDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetDir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkbVisualize
            // 
            this.chkbVisualize.AutoSize = true;
            this.chkbVisualize.Location = new System.Drawing.Point(418, 80);
            this.chkbVisualize.Name = "chkbVisualize";
            this.chkbVisualize.Size = new System.Drawing.Size(67, 17);
            this.chkbVisualize.TabIndex = 0;
            this.chkbVisualize.Text = "Visualize";
            this.chkbVisualize.UseVisualStyleBackColor = true;
            this.chkbVisualize.Visible = false;
            // 
            // chkbTransparent
            // 
            this.chkbTransparent.AutoSize = true;
            this.chkbTransparent.Location = new System.Drawing.Point(39, 80);
            this.chkbTransparent.Name = "chkbTransparent";
            this.chkbTransparent.Size = new System.Drawing.Size(83, 17);
            this.chkbTransparent.TabIndex = 0;
            this.chkbTransparent.Text = "Transparent";
            this.chkbTransparent.UseVisualStyleBackColor = true;
            // 
            // chkbWhiteBack
            // 
            this.chkbWhiteBack.AutoSize = true;
            this.chkbWhiteBack.Location = new System.Drawing.Point(158, 80);
            this.chkbWhiteBack.Name = "chkbWhiteBack";
            this.chkbWhiteBack.Size = new System.Drawing.Size(115, 17);
            this.chkbWhiteBack.TabIndex = 0;
            this.chkbWhiteBack.Text = "White Background";
            this.chkbWhiteBack.UseVisualStyleBackColor = true;
            // 
            // chkbPassport
            // 
            this.chkbPassport.AutoSize = true;
            this.chkbPassport.Location = new System.Drawing.Point(317, 80);
            this.chkbPassport.Name = "chkbPassport";
            this.chkbPassport.Size = new System.Drawing.Size(67, 17);
            this.chkbPassport.TabIndex = 0;
            this.chkbPassport.Text = "Passport";
            this.chkbPassport.UseVisualStyleBackColor = true;
            // 
            // rtxtResponse
            // 
            this.rtxtResponse.Location = new System.Drawing.Point(400, 188);
            this.rtxtResponse.Name = "rtxtResponse";
            this.rtxtResponse.Size = new System.Drawing.Size(357, 314);
            this.rtxtResponse.TabIndex = 1;
            this.rtxtResponse.Text = "";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(65, 30);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.ReadOnly = true;
            this.txtImagePath.Size = new System.Drawing.Size(568, 20);
            this.txtImagePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image";
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(642, 28);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(75, 23);
            this.btnOpenImage.TabIndex = 4;
            this.btnOpenImage.Text = "Open Image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(642, 74);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 5;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // picImage
            // 
            this.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImage.Location = new System.Drawing.Point(12, 188);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(382, 314);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 6;
            this.picImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdobtnFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdobtnFile);
            this.groupBox1.Controls.Add(this.chkbTransparent);
            this.groupBox1.Controls.Add(this.chkbWhiteBack);
            this.groupBox1.Controls.Add(this.chkbPassport);
            this.groupBox1.Controls.Add(this.btnPost);
            this.groupBox1.Controls.Add(this.chkbVisualize);
            this.groupBox1.Controls.Add(this.btnOpenImage);
            this.groupBox1.Controls.Add(this.txtImagePath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 122);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Post";
            // 
            // rdobtnFolder
            // 
            this.rdobtnFolder.AutoSize = true;
            this.rdobtnFolder.Location = new System.Drawing.Point(548, 89);
            this.rdobtnFolder.Name = "rdobtnFolder";
            this.rdobtnFolder.Size = new System.Drawing.Size(54, 17);
            this.rdobtnFolder.TabIndex = 0;
            this.rdobtnFolder.TabStop = true;
            this.rdobtnFolder.Text = "Folder";
            this.rdobtnFolder.UseVisualStyleBackColor = true;
            this.rdobtnFolder.Visible = false;
            // 
            // rdobtnFile
            // 
            this.rdobtnFile.AutoSize = true;
            this.rdobtnFile.Location = new System.Drawing.Point(548, 66);
            this.rdobtnFile.Name = "rdobtnFile";
            this.rdobtnFile.Size = new System.Drawing.Size(41, 17);
            this.rdobtnFile.TabIndex = 0;
            this.rdobtnFile.TabStop = true;
            this.rdobtnFile.Text = "File";
            this.rdobtnFile.UseVisualStyleBackColor = true;
            this.rdobtnFile.Visible = false;
            // 
            // txtOutDir
            // 
            this.txtOutDir.Location = new System.Drawing.Point(77, 149);
            this.txtOutDir.Name = "txtOutDir";
            this.txtOutDir.ReadOnly = true;
            this.txtOutDir.Size = new System.Drawing.Size(568, 20);
            this.txtOutDir.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Out";
            // 
            // btnSetDir
            // 
            this.btnSetDir.Location = new System.Drawing.Point(654, 147);
            this.btnSetDir.Name = "btnSetDir";
            this.btnSetDir.Size = new System.Drawing.Size(75, 23);
            this.btnSetDir.TabIndex = 4;
            this.btnSetDir.Text = "Select";
            this.btnSetDir.UseVisualStyleBackColor = true;
            this.btnSetDir.Click += new System.EventHandler(this.btnSetDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.rtxtResponse);
            this.Controls.Add(this.txtOutDir);
            this.Controls.Add(this.btnSetDir);
            this.Name = "Form1";
            this.Text = "Image Poster";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbVisualize;
        private System.Windows.Forms.CheckBox chkbTransparent;
        private System.Windows.Forms.CheckBox chkbWhiteBack;
        private System.Windows.Forms.CheckBox chkbPassport;
        private System.Windows.Forms.RichTextBox rtxtResponse;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdobtnFolder;
        private System.Windows.Forms.RadioButton rdobtnFile;
        private System.Windows.Forms.TextBox txtOutDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetDir;
    }
}

