﻿
namespace TeknikServis.Formlar
{
    partial class FrmYeniUrun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniUrun));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.TxtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtMarka = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtKategotri = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtAlisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TxtSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TxtStok = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BtnVazgec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKategotri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(48, 197);
            this.pictureEdit1.Name = "pictureEdit1";
            // 
            // 
            // 
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(55, 55);
            this.pictureEdit1.TabIndex = 0;
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.EditValue = "Ürün Adı";
            this.TxtUrunAd.Location = new System.Drawing.Point(128, 207);
            this.TxtUrunAd.Name = "TxtUrunAd";
            // 
            // 
            // 
            this.TxtUrunAd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.TxtUrunAd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUrunAd.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUrunAd.Properties.Appearance.Options.UseBackColor = true;
            this.TxtUrunAd.Properties.Appearance.Options.UseFont = true;
            this.TxtUrunAd.Properties.Appearance.Options.UseForeColor = true;
            this.TxtUrunAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtUrunAd.Size = new System.Drawing.Size(150, 36);
            this.TxtUrunAd.TabIndex = 1;
            this.TxtUrunAd.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(105, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 2);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(105, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 2);
            this.panel2.TabIndex = 5;
            // 
            // TxtMarka
            // 
            this.TxtMarka.EditValue = "Marka";
            this.TxtMarka.Location = new System.Drawing.Point(128, 286);
            this.TxtMarka.Name = "TxtMarka";
            // 
            // 
            // 
            this.TxtMarka.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.TxtMarka.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarka.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.TxtMarka.Properties.Appearance.Options.UseBackColor = true;
            this.TxtMarka.Properties.Appearance.Options.UseFont = true;
            this.TxtMarka.Properties.Appearance.Options.UseForeColor = true;
            this.TxtMarka.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtMarka.Size = new System.Drawing.Size(150, 36);
            this.TxtMarka.TabIndex = 4;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(48, 276);
            this.pictureEdit2.Name = "pictureEdit2";
            // 
            // 
            // 
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(55, 55);
            this.pictureEdit2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(105, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 2);
            this.panel3.TabIndex = 8;
            // 
            // TxtKategotri
            // 
            this.TxtKategotri.EditValue = "Kategori";
            this.TxtKategotri.Location = new System.Drawing.Point(128, 364);
            this.TxtKategotri.Name = "TxtKategotri";
            // 
            // 
            // 
            this.TxtKategotri.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.TxtKategotri.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKategotri.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.TxtKategotri.Properties.Appearance.Options.UseBackColor = true;
            this.TxtKategotri.Properties.Appearance.Options.UseFont = true;
            this.TxtKategotri.Properties.Appearance.Options.UseForeColor = true;
            this.TxtKategotri.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtKategotri.Size = new System.Drawing.Size(150, 36);
            this.TxtKategotri.TabIndex = 7;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(48, 354);
            this.pictureEdit3.Name = "pictureEdit3";
            // 
            // 
            // 
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(55, 55);
            this.pictureEdit3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(105, 488);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 2);
            this.panel4.TabIndex = 11;
            // 
            // TxtAlisFiyat
            // 
            this.TxtAlisFiyat.EditValue = "Alış Fiyatı";
            this.TxtAlisFiyat.Location = new System.Drawing.Point(128, 446);
            this.TxtAlisFiyat.Name = "TxtAlisFiyat";
            // 
            // 
            // 
            this.TxtAlisFiyat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.TxtAlisFiyat.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAlisFiyat.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.TxtAlisFiyat.Properties.Appearance.Options.UseBackColor = true;
            this.TxtAlisFiyat.Properties.Appearance.Options.UseFont = true;
            this.TxtAlisFiyat.Properties.Appearance.Options.UseForeColor = true;
            this.TxtAlisFiyat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtAlisFiyat.Size = new System.Drawing.Size(150, 36);
            this.TxtAlisFiyat.TabIndex = 10;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(48, 436);
            this.pictureEdit4.Name = "pictureEdit4";
            // 
            // 
            // 
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(55, 55);
            this.pictureEdit4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(105, 563);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(324, 2);
            this.panel5.TabIndex = 14;
            // 
            // TxtSatisFiyat
            // 
            this.TxtSatisFiyat.EditValue = "Satış Fiyatı";
            this.TxtSatisFiyat.Location = new System.Drawing.Point(128, 521);
            this.TxtSatisFiyat.Name = "TxtSatisFiyat";
            // 
            // 
            // 
            this.TxtSatisFiyat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.TxtSatisFiyat.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSatisFiyat.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.TxtSatisFiyat.Properties.Appearance.Options.UseBackColor = true;
            this.TxtSatisFiyat.Properties.Appearance.Options.UseFont = true;
            this.TxtSatisFiyat.Properties.Appearance.Options.UseForeColor = true;
            this.TxtSatisFiyat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtSatisFiyat.Size = new System.Drawing.Size(150, 36);
            this.TxtSatisFiyat.TabIndex = 13;
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(48, 511);
            this.pictureEdit5.Name = "pictureEdit5";
            // 
            // 
            // 
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit5.Size = new System.Drawing.Size(55, 55);
            this.pictureEdit5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(105, 641);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(324, 2);
            this.panel6.TabIndex = 17;
            // 
            // TxtStok
            // 
            this.TxtStok.EditValue = "Stok";
            this.TxtStok.Location = new System.Drawing.Point(128, 599);
            this.TxtStok.Name = "TxtStok";
            // 
            // 
            // 
            this.TxtStok.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.TxtStok.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStok.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.TxtStok.Properties.Appearance.Options.UseBackColor = true;
            this.TxtStok.Properties.Appearance.Options.UseFont = true;
            this.TxtStok.Properties.Appearance.Options.UseForeColor = true;
            this.TxtStok.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtStok.Size = new System.Drawing.Size(150, 36);
            this.TxtStok.TabIndex = 16;
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(48, 589);
            this.pictureEdit6.Name = "pictureEdit6";
            // 
            // 
            // 
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit6.Size = new System.Drawing.Size(55, 55);
            this.pictureEdit6.TabIndex = 15;
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.EditValue = ((object)(resources.GetObject("pictureEdit7.EditValue")));
            this.pictureEdit7.Location = new System.Drawing.Point(48, 35);
            this.pictureEdit7.Name = "pictureEdit7";
            // 
            // 
            // 
            this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.StretchHorizontal;
            this.pictureEdit7.Size = new System.Drawing.Size(101, 102);
            this.pictureEdit7.TabIndex = 18;
            // 
            // textEdit7
            // 
            this.textEdit7.EditValue = "YENİ ÜRÜN EKLEME";
            this.textEdit7.Location = new System.Drawing.Point(166, 73);
            this.textEdit7.Name = "textEdit7";
            // 
            // 
            // 
            this.textEdit7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.textEdit7.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.textEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit7.Properties.Appearance.Options.UseFont = true;
            this.textEdit7.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit7.Size = new System.Drawing.Size(238, 36);
            this.textEdit7.TabIndex = 19;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.Appearance.Options.UseForeColor = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(31, 684);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnKaydet.Size = new System.Drawing.Size(173, 34);
            this.BtnKaydet.TabIndex = 20;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVazgec.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.BtnVazgec.Appearance.Options.UseFont = true;
            this.BtnVazgec.Appearance.Options.UseForeColor = true;
            this.BtnVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnVazgec.ImageOptions.Image")));
            this.BtnVazgec.Location = new System.Drawing.Point(243, 684);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnVazgec.Size = new System.Drawing.Size(173, 34);
            this.BtnVazgec.TabIndex = 21;
            this.BtnVazgec.Text = "VAZGEÇ";
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // FrmYeniUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(455, 760);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.pictureEdit7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.TxtStok);
            this.Controls.Add(this.pictureEdit6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.TxtSatisFiyat);
            this.Controls.Add(this.pictureEdit5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TxtAlisFiyat);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TxtKategotri);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtMarka);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtUrunAd);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmYeniUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYeniUrun";
            this.Load += new System.EventHandler(this.FrmYeniUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKategotri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit TxtUrunAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TxtMarka;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit TxtKategotri;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.TextEdit TxtAlisFiyat;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.TextEdit TxtSatisFiyat;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.TextEdit TxtStok;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnVazgec;
    }
}