﻿namespace RssProjekt
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
            this.PodId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLaggTillPod = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.URLLable = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUpdate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.läggTillKategorie = new System.Windows.Forms.Button();
            this.ändraKtegori = new System.Windows.Forms.Button();
            this.taBortKategorie = new System.Windows.Forms.Button();
            this.btnAndraPod = new System.Windows.Forms.Button();
            this.btnTaBortPod = new System.Windows.Forms.Button();
            this.lVFeed = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.lvCategory = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBeskrivning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvPodcast
            // 
            this.lvPodcast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PodId,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvPodcast.Location = new System.Drawing.Point(15, 12);
            this.lvPodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvPodcast.Name = "lvPodcast";
            this.lvPodcast.Size = new System.Drawing.Size(691, 233);
            this.lvPodcast.TabIndex = 0;
            this.lvPodcast.UseCompatibleStateImageBehavior = false;
            this.lvPodcast.View = System.Windows.Forms.View.Details;
            this.lvPodcast.SelectedIndexChanged += new System.EventHandler(this.lvPodcast_SelectedIndexChanged);
            // 
            // PodId
            // 
            this.PodId.Text = "PodId";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Url";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Namn";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Avsnitt";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kategori";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Uppdatering";
            this.columnHeader5.Width = 80;
            // 
            // btnLaggTillPod
            // 
            this.btnLaggTillPod.Location = new System.Drawing.Point(20, 302);
            this.btnLaggTillPod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLaggTillPod.Name = "btnLaggTillPod";
            this.btnLaggTillPod.Size = new System.Drawing.Size(100, 28);
            this.btnLaggTillPod.TabIndex = 1;
            this.btnLaggTillPod.Text = "Lägg till";
            this.btnLaggTillPod.UseVisualStyleBackColor = true;
            this.btnLaggTillPod.Click += new System.EventHandler(this.btnLaggTillPod_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(15, 271);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(228, 22);
            this.tbUrl.TabIndex = 2;
            this.tbUrl.TextChanged += new System.EventHandler(this.tbUrl_TextChanged);
            // 
            // URLLable
            // 
            this.URLLable.AutoSize = true;
            this.URLLable.Location = new System.Drawing.Point(17, 254);
            this.URLLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.URLLable.Name = "URLLable";
            this.URLLable.Size = new System.Drawing.Size(36, 17);
            this.URLLable.TabIndex = 3;
            this.URLLable.Text = "URL";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(251, 271);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(201, 22);
            this.tbName.TabIndex = 4;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(457, 271);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 24);
            this.cbCategory.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kategori";
            // 
            // cbUpdate
            // 
            this.cbUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdate.FormattingEnabled = true;
            this.cbUpdate.Items.AddRange(new object[] {
            "30 minuter",
            "1 timme",
            "3 timmar"});
            this.cbUpdate.Location = new System.Drawing.Point(584, 271);
            this.cbUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(121, 24);
            this.cbUpdate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Uppdateringsintervall";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(765, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kategorier";
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(765, 273);
            this.tbKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(320, 22);
            this.tbKategori.TabIndex = 12;
            // 
            // läggTillKategorie
            // 
            this.läggTillKategorie.Location = new System.Drawing.Point(769, 322);
            this.läggTillKategorie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.läggTillKategorie.Name = "läggTillKategorie";
            this.läggTillKategorie.Size = new System.Drawing.Size(100, 28);
            this.läggTillKategorie.TabIndex = 13;
            this.läggTillKategorie.Text = "Lägg till";
            this.läggTillKategorie.UseVisualStyleBackColor = true;
            this.läggTillKategorie.Click += new System.EventHandler(this.button2_Click);
            // 
            // ändraKtegori
            // 
            this.ändraKtegori.Location = new System.Drawing.Point(923, 322);
            this.ändraKtegori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ändraKtegori.Name = "ändraKtegori";
            this.ändraKtegori.Size = new System.Drawing.Size(100, 28);
            this.ändraKtegori.TabIndex = 14;
            this.ändraKtegori.Text = "Ändra";
            this.ändraKtegori.UseVisualStyleBackColor = true;
            this.ändraKtegori.Click += new System.EventHandler(this.ändraKtegori_Click);
            // 
            // taBortKategorie
            // 
            this.taBortKategorie.Location = new System.Drawing.Point(1049, 322);
            this.taBortKategorie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taBortKategorie.Name = "taBortKategorie";
            this.taBortKategorie.Size = new System.Drawing.Size(100, 28);
            this.taBortKategorie.TabIndex = 15;
            this.taBortKategorie.Text = "Ta bort";
            this.taBortKategorie.UseVisualStyleBackColor = true;
            this.taBortKategorie.Click += new System.EventHandler(this.taBortKategorie_Click);
            // 
            // btnAndraPod
            // 
            this.btnAndraPod.Location = new System.Drawing.Point(127, 306);
            this.btnAndraPod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAndraPod.Name = "btnAndraPod";
            this.btnAndraPod.Size = new System.Drawing.Size(75, 23);
            this.btnAndraPod.TabIndex = 16;
            this.btnAndraPod.Text = "Ändra";
            this.btnAndraPod.UseVisualStyleBackColor = true;
            this.btnAndraPod.Click += new System.EventHandler(this.btnAndraPod_Click);
            // 
            // btnTaBortPod
            // 
            this.btnTaBortPod.Location = new System.Drawing.Point(208, 306);
            this.btnTaBortPod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaBortPod.Name = "btnTaBortPod";
            this.btnTaBortPod.Size = new System.Drawing.Size(75, 23);
            this.btnTaBortPod.TabIndex = 17;
            this.btnTaBortPod.Text = "Ta bort";
            this.btnTaBortPod.UseVisualStyleBackColor = true;
            this.btnTaBortPod.Click += new System.EventHandler(this.btnTaBortPod_Click);
            // 
            // lVFeed
            // 
            this.lVFeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title});
            this.lVFeed.Location = new System.Drawing.Point(15, 386);
            this.lVFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lVFeed.Name = "lVFeed";
            this.lVFeed.Size = new System.Drawing.Size(501, 192);
            this.lVFeed.TabIndex = 18;
            this.lVFeed.UseCompatibleStateImageBehavior = false;
            this.lVFeed.View = System.Windows.Forms.View.Details;
            this.lVFeed.SelectedIndexChanged += new System.EventHandler(this.lVFeed_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 160;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 353);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Feed";
            // 
            // lvCategory
            // 
            this.lvCategory.Location = new System.Drawing.Point(765, 55);
            this.lvCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(320, 190);
            this.lvCategory.TabIndex = 20;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.List;
            this.lvCategory.SelectedIndexChanged += new System.EventHandler(this.lvCategory_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(304, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 334);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(592, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "För att ändra, tryck på podId, gör ändringarna, tryck ändra,  tryck på poId igen," +
    " tryck ändra";
            // 
            // lblBeskrivning
            // 
            this.lblBeskrivning.Location = new System.Drawing.Point(581, 386);
            this.lblBeskrivning.Name = "lblBeskrivning";
            this.lblBeskrivning.Size = new System.Drawing.Size(563, 192);
            this.lblBeskrivning.TabIndex = 24;
            this.lblBeskrivning.Text = "Klicka på ett avsnitt för att se beskrivning!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 594);
            this.Controls.Add(this.lblBeskrivning);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lVFeed);
            this.Controls.Add(this.btnTaBortPod);
            this.Controls.Add(this.btnAndraPod);
            this.Controls.Add(this.taBortKategorie);
            this.Controls.Add(this.ändraKtegori);
            this.Controls.Add(this.läggTillKategorie);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.label4);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKategori;
        private System.Windows.Forms.Button läggTillKategorie;
        private System.Windows.Forms.Button ändraKtegori;
        private System.Windows.Forms.Button taBortKategorie;
        private System.Windows.Forms.Button btnAndraPod;
        private System.Windows.Forms.Button btnTaBortPod;
        private System.Windows.Forms.ListView lVFeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader PodId;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.Label lblBeskrivning;
    }
}

