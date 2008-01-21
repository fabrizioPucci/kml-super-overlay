using System.Drawing;
namespace KmlSuperOverlay
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnMake = new System.Windows.Forms.Button();
            this.lblTileSize = new System.Windows.Forms.Label();
            this.tilePreviewCtrl1 = new KmlSuperOverlay.TilePreviewCtrl();
            this.label2 = new System.Windows.Forms.Label();
            this.anchorSelectCtrl1 = new KmlSuperOverlay.AnchorSelectCtrl();
            this.label1 = new System.Windows.Forms.Label();
            this.sldLevel = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pbAlign = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pbox256 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.generateKMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sldLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlign)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox256)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(0, 27);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(624, 457);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.progressBar1);
            this.tabPage3.Controls.Add(this.btnMake);
            this.tabPage3.Controls.Add(this.lblTileSize);
            this.tabPage3.Controls.Add(this.tilePreviewCtrl1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.anchorSelectCtrl1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.sldLevel);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(616, 431);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Pyramid Tiling";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(353, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(253, 10);
            this.progressBar1.TabIndex = 11;
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(353, 387);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(96, 22);
            this.btnMake.TabIndex = 10;
            this.btnMake.Text = "Make Tiles";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // lblTileSize
            // 
            this.lblTileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTileSize.AutoSize = true;
            this.lblTileSize.Location = new System.Drawing.Point(354, 352);
            this.lblTileSize.Name = "lblTileSize";
            this.lblTileSize.Size = new System.Drawing.Size(102, 13);
            this.lblTileSize.TabIndex = 9;
            this.lblTileSize.Text = "Tile Size in Original: ";
            // 
            // tilePreviewCtrl1
            // 
            this.tilePreviewCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tilePreviewCtrl1.BackColor = System.Drawing.Color.Gray;
            this.tilePreviewCtrl1.EmptyColor = System.Drawing.Color.Purple;
            this.tilePreviewCtrl1.Image = null;
            this.tilePreviewCtrl1.Location = new System.Drawing.Point(0, 0);
            this.tilePreviewCtrl1.Name = "tilePreviewCtrl1";
            this.tilePreviewCtrl1.NumTiles = 1;
            this.tilePreviewCtrl1.Size = new System.Drawing.Size(348, 425);
            this.tilePreviewCtrl1.TabIndex = 8;
            this.tilePreviewCtrl1.Text = "tilePreviewCtrl1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Anchor";
            // 
            // anchorSelectCtrl1
            // 
            this.anchorSelectCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anchorSelectCtrl1.AnchorPos = System.Drawing.ContentAlignment.BottomRight;
            this.anchorSelectCtrl1.GapSize = new System.Drawing.SizeF(2F, 2F);
            this.anchorSelectCtrl1.HighlightColor = System.Drawing.Color.Chocolate;
            this.anchorSelectCtrl1.Location = new System.Drawing.Point(402, 305);
            this.anchorSelectCtrl1.Name = "anchorSelectCtrl1";
            this.anchorSelectCtrl1.Size = new System.Drawing.Size(26, 23);
            this.anchorSelectCtrl1.TabIndex = 6;
            this.anchorSelectCtrl1.Text = "anchorSelectCtrl1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Level";
            // 
            // sldLevel
            // 
            this.sldLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sldLevel.Location = new System.Drawing.Point(393, 265);
            this.sldLevel.Minimum = 1;
            this.sldLevel.Name = "sldLevel";
            this.sldLevel.Size = new System.Drawing.Size(217, 45);
            this.sldLevel.TabIndex = 4;
            this.sldLevel.Value = 1;
            this.sldLevel.Scroll += new System.EventHandler(this.sldLevel_Scroll);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox2.Location = new System.Drawing.Point(353, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 256);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pbAlign);
            this.tabPage4.Controls.Add(this.tabControl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(616, 431);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Georeference";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pbAlign
            // 
            this.pbAlign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAlign.BackColor = System.Drawing.Color.Gold;
            this.pbAlign.Location = new System.Drawing.Point(0, 0);
            this.pbAlign.Name = "pbAlign";
            this.pbAlign.Size = new System.Drawing.Size(348, 425);
            this.pbAlign.TabIndex = 4;
            this.pbAlign.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(348, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(4, 2);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(265, 284);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbox256);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(257, 257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pink";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pbox256
            // 
            this.pbox256.BackColor = System.Drawing.Color.HotPink;
            this.pbox256.Location = new System.Drawing.Point(0, 0);
            this.pbox256.Name = "pbox256";
            this.pbox256.Size = new System.Drawing.Size(256, 256);
            this.pbox256.TabIndex = 2;
            this.pbox256.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(257, 257);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Purple";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.MediumOrchid;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(256, 256);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imageFileToolStripMenuItem
            // 
            this.imageFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.generateKMLToolStripMenuItem});
            this.imageFileToolStripMenuItem.Name = "imageFileToolStripMenuItem";
            this.imageFileToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.imageFileToolStripMenuItem.Text = "Image File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.loadToolStripMenuItem.Text = "Load...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // generateKMLToolStripMenuItem
            // 
            this.generateKMLToolStripMenuItem.Name = "generateKMLToolStripMenuItem";
            this.generateKMLToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.generateKMLToolStripMenuItem.Text = "Generate KML...";
            this.generateKMLToolStripMenuItem.Click += new System.EventHandler(this.generateKMLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 482);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(440, 410);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sldLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlign)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox256)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imageFileToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbAlign;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pbox256;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.TrackBar sldLevel;
        private System.Windows.Forms.Label label1;
        private AnchorSelectCtrl anchorSelectCtrl1;
        private System.Windows.Forms.Label label2;
        private TilePreviewCtrl tilePreviewCtrl1;
        private System.Windows.Forms.Label lblTileSize;
        private System.Windows.Forms.Button btnMake;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem generateKMLToolStripMenuItem;
    }
}

