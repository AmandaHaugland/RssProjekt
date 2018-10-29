namespace RssProjekt
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
            this.lvPodcast = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLaggTillPod = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.URLLable = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUpdate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.läggTillKategorie = new System.Windows.Forms.Button();
            this.ändraKtegori = new System.Windows.Forms.Button();
            this.taBortKategorie = new System.Windows.Forms.Button();
            this.btnAndraPod = new System.Windows.Forms.Button();
            this.btnTaBortPod = new System.Windows.Forms.Button();
            this.lVFeed = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvPodcast
            // 
            this.lvPodcast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvPodcast.Location = new System.Drawing.Point(11, 10);
            this.lvPodcast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvPodcast.Name = "lvPodcast";
            this.lvPodcast.Size = new System.Drawing.Size(519, 190);
            this.lvPodcast.TabIndex = 0;
            this.lvPodcast.UseCompatibleStateImageBehavior = false;
            this.lvPodcast.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Url";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Namn";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Avsnitt";
            // 
            // btnLaggTillPod
            // 
            this.btnLaggTillPod.Location = new System.Drawing.Point(15, 245);
            this.btnLaggTillPod.Name = "btnLaggTillPod";
            this.btnLaggTillPod.Size = new System.Drawing.Size(75, 23);
            this.btnLaggTillPod.TabIndex = 1;
            this.btnLaggTillPod.Text = "Lägg till";
            this.btnLaggTillPod.UseVisualStyleBackColor = true;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(11, 220);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(172, 20);
            this.tbUrl.TabIndex = 2;
            this.tbUrl.TextChanged += new System.EventHandler(this.tbUrl_TextChanged);
            // 
            // URLLable
            // 
            this.URLLable.AutoSize = true;
            this.URLLable.Location = new System.Drawing.Point(13, 206);
            this.URLLable.Name = "URLLable";
            this.URLLable.Size = new System.Drawing.Size(29, 13);
            this.URLLable.TabIndex = 3;
            this.URLLable.Text = "URL";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(188, 220);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(152, 20);
            this.tbName.TabIndex = 4;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(343, 220);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(92, 21);
            this.cbCategory.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kategori";
            // 
            // cbUpdate
            // 
            this.cbUpdate.FormattingEnabled = true;
            this.cbUpdate.Items.AddRange(new object[] {
            "",
            "15 minuter",
            "30 minuter",
            "1 timme",
            "3 timmar"});
            this.cbUpdate.Location = new System.Drawing.Point(438, 220);
            this.cbUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(92, 21);
            this.cbUpdate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Uppdateringsintervall";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(574, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(288, 161);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(574, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kategorier";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(574, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 20);
            this.textBox1.TabIndex = 12;
            // 
            // läggTillKategorie
            // 
            this.läggTillKategorie.Location = new System.Drawing.Point(577, 262);
            this.läggTillKategorie.Name = "läggTillKategorie";
            this.läggTillKategorie.Size = new System.Drawing.Size(75, 23);
            this.läggTillKategorie.TabIndex = 13;
            this.läggTillKategorie.Text = "Lägg till";
            this.läggTillKategorie.UseVisualStyleBackColor = true;
            this.läggTillKategorie.Click += new System.EventHandler(this.button2_Click);
            // 
            // ändraKtegori
            // 
            this.ändraKtegori.Location = new System.Drawing.Point(692, 262);
            this.ändraKtegori.Name = "ändraKtegori";
            this.ändraKtegori.Size = new System.Drawing.Size(75, 23);
            this.ändraKtegori.TabIndex = 14;
            this.ändraKtegori.Text = "Ändra";
            this.ändraKtegori.UseVisualStyleBackColor = true;
            // 
            // taBortKategorie
            // 
            this.taBortKategorie.Location = new System.Drawing.Point(787, 262);
            this.taBortKategorie.Name = "taBortKategorie";
            this.taBortKategorie.Size = new System.Drawing.Size(75, 23);
            this.taBortKategorie.TabIndex = 15;
            this.taBortKategorie.Text = "Ta bort";
            this.taBortKategorie.UseVisualStyleBackColor = true;
            // 
            // btnAndraPod
            // 
            this.btnAndraPod.Location = new System.Drawing.Point(95, 249);
            this.btnAndraPod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAndraPod.Name = "btnAndraPod";
            this.btnAndraPod.Size = new System.Drawing.Size(56, 19);
            this.btnAndraPod.TabIndex = 16;
            this.btnAndraPod.Text = "Ändra";
            this.btnAndraPod.UseVisualStyleBackColor = true;
            // 
            // btnTaBortPod
            // 
            this.btnTaBortPod.Location = new System.Drawing.Point(156, 249);
            this.btnTaBortPod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaBortPod.Name = "btnTaBortPod";
            this.btnTaBortPod.Size = new System.Drawing.Size(56, 19);
            this.btnTaBortPod.TabIndex = 17;
            this.btnTaBortPod.Text = "Ta bort";
            this.btnTaBortPod.UseVisualStyleBackColor = true;
            // 
            // lVFeed
            // 
            this.lVFeed.Location = new System.Drawing.Point(11, 314);
            this.lVFeed.Name = "lVFeed";
            this.lVFeed.Size = new System.Drawing.Size(377, 157);
            this.lVFeed.TabIndex = 18;
            this.lVFeed.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Feed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 483);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lVFeed);
            this.Controls.Add(this.btnTaBortPod);
            this.Controls.Add(this.btnAndraPod);
            this.Controls.Add(this.taBortKategorie);
            this.Controls.Add(this.ändraKtegori);
            this.Controls.Add(this.läggTillKategorie);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.URLLable);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.btnLaggTillPod);
            this.Controls.Add(this.lvPodcast);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Podcast";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPodcast;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnLaggTillPod;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label URLLable;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button läggTillKategorie;
        private System.Windows.Forms.Button ändraKtegori;
        private System.Windows.Forms.Button taBortKategorie;
        private System.Windows.Forms.Button btnAndraPod;
        private System.Windows.Forms.Button btnTaBortPod;
        private System.Windows.Forms.ListView lVFeed;
        private System.Windows.Forms.Label label5;
    }
}

