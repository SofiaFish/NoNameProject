namespace WindowsFormsApplication10
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
            this.tbPath = new System.Windows.Forms.TextBox();
            this.bFolder = new System.Windows.Forms.Button();
            this.bFind = new System.Windows.Forms.Button();
            this.lvResult = new System.Windows.Forms.ListView();
            this.Name1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Folders = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Files = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "path:";
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPath.Location = new System.Drawing.Point(57, 8);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(144, 22);
            this.tbPath.TabIndex = 1;
            // 
            // bFolder
            // 
            this.bFolder.Location = new System.Drawing.Point(207, 6);
            this.bFolder.Name = "bFolder";
            this.bFolder.Size = new System.Drawing.Size(25, 23);
            this.bFolder.TabIndex = 2;
            this.bFolder.Text = "...";
            this.bFolder.UseVisualStyleBackColor = true;
            this.bFolder.Click += new System.EventHandler(this.bFolder_Click);
            // 
            // bFind
            // 
            this.bFind.Location = new System.Drawing.Point(57, 36);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(144, 23);
            this.bFind.TabIndex = 3;
            this.bFind.Text = "Find";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // lvResult
            // 
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name1,
            this.Size1,
            this.Folders,
            this.Files});
            this.lvResult.Location = new System.Drawing.Point(16, 65);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(216, 166);
            this.lvResult.TabIndex = 4;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            this.lvResult.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Name1
            // 
            this.Name1.Text = "Name";
            this.Name1.Width = 54;
            // 
            // Size1
            // 
            this.Size1.Text = "Size";
            this.Size1.Width = 53;
            // 
            // Folders
            // 
            this.Folders.Text = "Folders";
            this.Folders.Width = 53;
            // 
            // Files
            // 
            this.Files.Text = "Files";
            this.Files.Width = 53;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 244);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.bFind);
            this.Controls.Add(this.bFolder);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button bFolder;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ColumnHeader Name1;
        private System.Windows.Forms.ColumnHeader Size1;
        private System.Windows.Forms.ColumnHeader Folders;
        private System.Windows.Forms.ColumnHeader Files;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

