
namespace DataGridView
{
    partial class TextAlbum
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
            this.dataGridViewDemo = new System.Windows.Forms.DataGridView();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Track = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Button();
            this.btnCustomPopulate = new System.Windows.Forms.Button();
            this.btnDeleteAllrow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lAlabum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.abtext = new System.Windows.Forms.TextBox();
            this.TextArtist = new System.Windows.Forms.TextBox();
            this.TextTitle = new System.Windows.Forms.TextBox();
            this.TextTrack = new System.Windows.Forms.TextBox();
            this.btnNewpopulate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDemo
            // 
            this.dataGridViewDemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDemo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Album,
            this.Artist,
            this.Title,
            this.Track,
            this.ReleaseDate});
            this.dataGridViewDemo.Location = new System.Drawing.Point(12, 54);
            this.dataGridViewDemo.Name = "dataGridViewDemo";
            this.dataGridViewDemo.Size = new System.Drawing.Size(677, 315);
            this.dataGridViewDemo.TabIndex = 0;
            this.dataGridViewDemo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Album
            // 
            this.Album.HeaderText = "Album";
            this.Album.Name = "Album";
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Track
            // 
            this.Track.HeaderText = "Track";
            this.Track.Name = "Track";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "ReleaseDate";
            this.ReleaseDate.Name = "ReleaseDate";
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(53, 487);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(104, 39);
            this.btnPopulate.TabIndex = 1;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(176, 487);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(305, 487);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 39);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPanel
            // 
            this.btnPanel.Location = new System.Drawing.Point(438, 487);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(104, 39);
            this.btnPanel.TabIndex = 4;
            this.btnPanel.Text = "Panel";
            this.btnPanel.UseVisualStyleBackColor = true;
            // 
            // btnCustomPopulate
            // 
            this.btnCustomPopulate.Location = new System.Drawing.Point(735, 479);
            this.btnCustomPopulate.Name = "btnCustomPopulate";
            this.btnCustomPopulate.Size = new System.Drawing.Size(332, 47);
            this.btnCustomPopulate.TabIndex = 5;
            this.btnCustomPopulate.Text = "Custom Populate";
            this.btnCustomPopulate.UseVisualStyleBackColor = true;
            this.btnCustomPopulate.Click += new System.EventHandler(this.btnCustomPopulate_Click);
            // 
            // btnDeleteAllrow
            // 
            this.btnDeleteAllrow.Location = new System.Drawing.Point(319, 532);
            this.btnDeleteAllrow.Name = "btnDeleteAllrow";
            this.btnDeleteAllrow.Size = new System.Drawing.Size(76, 29);
            this.btnDeleteAllrow.TabIndex = 6;
            this.btnDeleteAllrow.Text = "Delete All";
            this.btnDeleteAllrow.UseVisualStyleBackColor = true;
            this.btnDeleteAllrow.Click += new System.EventHandler(this.btnDeleteAllrow_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1148, 532);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 37);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lAlabum
            // 
            this.lAlabum.AutoSize = true;
            this.lAlabum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lAlabum.Location = new System.Drawing.Point(744, 69);
            this.lAlabum.Name = "lAlabum";
            this.lAlabum.Size = new System.Drawing.Size(91, 25);
            this.lAlabum.TabIndex = 8;
            this.lAlabum.Text = "Album :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(744, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Artist :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(744, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Title  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(744, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Track :";
            // 
            // abtext
            // 
            this.abtext.Location = new System.Drawing.Point(841, 74);
            this.abtext.Name = "abtext";
            this.abtext.Size = new System.Drawing.Size(156, 20);
            this.abtext.TabIndex = 13;
            this.abtext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextArtist
            // 
            this.TextArtist.Location = new System.Drawing.Point(841, 115);
            this.TextArtist.Name = "TextArtist";
            this.TextArtist.Size = new System.Drawing.Size(156, 20);
            this.TextArtist.TabIndex = 14;
            // 
            // TextTitle
            // 
            this.TextTitle.Location = new System.Drawing.Point(841, 153);
            this.TextTitle.Name = "TextTitle";
            this.TextTitle.Size = new System.Drawing.Size(156, 20);
            this.TextTitle.TabIndex = 15;
            // 
            // TextTrack
            // 
            this.TextTrack.Location = new System.Drawing.Point(841, 187);
            this.TextTrack.Name = "TextTrack";
            this.TextTrack.Size = new System.Drawing.Size(156, 20);
            this.TextTrack.TabIndex = 16;
            // 
            // btnNewpopulate
            // 
            this.btnNewpopulate.Location = new System.Drawing.Point(841, 237);
            this.btnNewpopulate.Name = "btnNewpopulate";
            this.btnNewpopulate.Size = new System.Drawing.Size(166, 39);
            this.btnNewpopulate.TabIndex = 17;
            this.btnNewpopulate.Text = "New Populate";
            this.btnNewpopulate.UseVisualStyleBackColor = true;
            this.btnNewpopulate.Click += new System.EventHandler(this.btnNewpopulate_Click);
            // 
            // TextAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 581);
            this.Controls.Add(this.btnNewpopulate);
            this.Controls.Add(this.TextTrack);
            this.Controls.Add(this.TextTitle);
            this.Controls.Add(this.TextArtist);
            this.Controls.Add(this.abtext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lAlabum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteAllrow);
            this.Controls.Add(this.btnCustomPopulate);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.dataGridViewDemo);
            this.Name = "TextAlbum";
            this.Text = "from1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDemo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDemo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Track;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Button btnCustomPopulate;
        private System.Windows.Forms.Button btnDeleteAllrow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lAlabum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox abtext;
        private System.Windows.Forms.TextBox TextArtist;
        private System.Windows.Forms.TextBox TextTitle;
        private System.Windows.Forms.TextBox TextTrack;
        private System.Windows.Forms.Button btnNewpopulate;
    }
}

