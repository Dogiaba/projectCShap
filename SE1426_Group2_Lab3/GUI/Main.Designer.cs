
namespace SE1426_Group2_Lab3
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.screen = new System.Windows.Forms.Panel();
            this.musicStoreDataSet = new SE1426_Group2_Lab3.MusicStoreDataSet();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new SE1426_Group2_Lab3.MusicStoreDataSetTableAdapters.AlbumsTableAdapter();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeToolStripMenuItem,
            this.cartToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(814, 58);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("storeToolStripMenuItem.Image")));
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(108, 54);
            this.storeToolStripMenuItem.Text = "Store";
            // 
            // cartToolStripMenuItem
            // 
            this.cartToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cartToolStripMenuItem.Image")));
            this.cartToolStripMenuItem.Name = "cartToolStripMenuItem";
            this.cartToolStripMenuItem.Size = new System.Drawing.Size(100, 54);
            this.cartToolStripMenuItem.Text = "Cart";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripMenuItem.Image")));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(110, 54);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 54);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 58);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(814, 426);
            this.screen.TabIndex = 2;
            this.screen.Paint += new System.Windows.Forms.PaintEventHandler(this.screen_Paint);
            // 
            // musicStoreDataSet
            // 
            this.musicStoreDataSet.DataSetName = "MusicStoreDataSet";
            this.musicStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.musicStoreDataSet;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 484);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Main";
            this.Text = "Music store";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel screen;
        private MusicStoreDataSet musicStoreDataSet;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private MusicStoreDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
    }
}

