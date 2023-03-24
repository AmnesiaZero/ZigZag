
namespace ZigZag
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
            this.PenTool = new System.Windows.Forms.Button();
            this.BrushTool = new System.Windows.Forms.Button();
            this.EraserTool = new System.Windows.Forms.Button();
            this.FillTool = new System.Windows.Forms.Button();
            this.SelectTool = new System.Windows.Forms.Button();
            this.ToolWidthLabel = new System.Windows.Forms.Label();
            this.ToolWidthBar = new System.Windows.Forms.TrackBar();
            this.CurrentColorBtn = new System.Windows.Forms.Button();
            this.ColorTable = new System.Windows.Forms.TableLayoutPanel();
            this.DefaultColorBtn = new System.Windows.Forms.Button();
            this.ColorDialogBtn = new System.Windows.Forms.Button();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Project_TS = new System.Windows.Forms.ToolStripMenuItem();
            this.Create_TS = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_TS = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_TS = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs_TS = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentPicture_TS = new System.Windows.Forms.ToolStripMenuItem();
            this.Resize_TS = new System.Windows.Forms.ToolStripMenuItem();
            this.TabPage = new System.Windows.Forms.TabPage();
            this.TabPagesControl = new System.Windows.Forms.TabControl();
            this.PictureEditZone = new ZigZag.BitmapEditor();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToolWidthBar)).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.TabPage.SuspendLayout();
            this.TabPagesControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEditZone)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(800, 147);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(this.PenTool);
            flowLayoutPanel2.Controls.Add(this.BrushTool);
            flowLayoutPanel2.Controls.Add(this.EraserTool);
            flowLayoutPanel2.Controls.Add(this.FillTool);
            flowLayoutPanel2.Controls.Add(this.SelectTool);
            flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(418, 28);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // PenTool
            // 
            this.PenTool.Location = new System.Drawing.Point(3, 3);
            this.PenTool.Name = "PenTool";
            this.PenTool.Size = new System.Drawing.Size(70, 20);
            this.PenTool.TabIndex = 0;
            this.PenTool.Text = "Карандаш";
            this.PenTool.UseVisualStyleBackColor = true;
            this.PenTool.Click += new System.EventHandler(this.PenTool_Click);
            // 
            // BrushTool
            // 
            this.BrushTool.Location = new System.Drawing.Point(79, 3);
            this.BrushTool.Name = "BrushTool";
            this.BrushTool.Size = new System.Drawing.Size(60, 20);
            this.BrushTool.TabIndex = 1;
            this.BrushTool.Text = "Кисть";
            this.BrushTool.UseVisualStyleBackColor = true;
            this.BrushTool.Click += new System.EventHandler(this.BrushTool_Click);
            // 
            // EraserTool
            // 
            this.EraserTool.Location = new System.Drawing.Point(145, 3);
            this.EraserTool.Name = "EraserTool";
            this.EraserTool.Size = new System.Drawing.Size(60, 20);
            this.EraserTool.TabIndex = 2;
            this.EraserTool.Text = "Ластик";
            this.EraserTool.UseVisualStyleBackColor = true;
            this.EraserTool.Click += new System.EventHandler(this.EraserTool_Click);
            // 
            // FillTool
            // 
            this.FillTool.Location = new System.Drawing.Point(211, 3);
            this.FillTool.Name = "FillTool";
            this.FillTool.Size = new System.Drawing.Size(60, 20);
            this.FillTool.TabIndex = 4;
            this.FillTool.Text = "Заливка";
            this.FillTool.UseVisualStyleBackColor = true;
            this.FillTool.Click += new System.EventHandler(this.FillTool_Click);
            // 
            // SelectTool
            // 
            this.SelectTool.Location = new System.Drawing.Point(277, 3);
            this.SelectTool.Name = "SelectTool";
            this.SelectTool.Size = new System.Drawing.Size(136, 20);
            this.SelectTool.TabIndex = 3;
            this.SelectTool.Text = "Выделение области";
            this.SelectTool.UseVisualStyleBackColor = true;
            this.SelectTool.Click += new System.EventHandler(this.SelectTool_Click);
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanel3.Controls.Add(this.ToolWidthLabel);
            flowLayoutPanel3.Controls.Add(this.ToolWidthBar);
            flowLayoutPanel3.Location = new System.Drawing.Point(427, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new System.Drawing.Size(171, 53);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // ToolWidthLabel
            // 
            this.ToolWidthLabel.AutoSize = true;
            this.ToolWidthLabel.Location = new System.Drawing.Point(3, 0);
            this.ToolWidthLabel.Name = "ToolWidthLabel";
            this.ToolWidthLabel.Size = new System.Drawing.Size(53, 13);
            this.ToolWidthLabel.TabIndex = 0;
            this.ToolWidthLabel.Text = "Толщина";
            // 
            // ToolWidthBar
            // 
            this.ToolWidthBar.LargeChange = 4;
            this.ToolWidthBar.Location = new System.Drawing.Point(62, 3);
            this.ToolWidthBar.Maximum = 24;
            this.ToolWidthBar.Minimum = 1;
            this.ToolWidthBar.Name = "ToolWidthBar";
            this.ToolWidthBar.Size = new System.Drawing.Size(104, 45);
            this.ToolWidthBar.TabIndex = 0;
            this.ToolWidthBar.Value = 6;
            this.ToolWidthBar.Scroll += new System.EventHandler(this.WidthPropBar_Scroll);
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanel4.Controls.Add(this.CurrentColorBtn);
            flowLayoutPanel4.Controls.Add(this.ColorTable);
            flowLayoutPanel4.Controls.Add(this.DefaultColorBtn);
            flowLayoutPanel4.Controls.Add(this.ColorDialogBtn);
            flowLayoutPanel4.Location = new System.Drawing.Point(3, 62);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new System.Drawing.Size(364, 80);
            flowLayoutPanel4.TabIndex = 2;
            // 
            // CurrentColorBtn
            // 
            this.CurrentColorBtn.BackColor = System.Drawing.Color.White;
            this.CurrentColorBtn.Location = new System.Drawing.Point(3, 3);
            this.CurrentColorBtn.Name = "CurrentColorBtn";
            this.CurrentColorBtn.Size = new System.Drawing.Size(60, 60);
            this.CurrentColorBtn.TabIndex = 0;
            this.CurrentColorBtn.UseVisualStyleBackColor = true;
            // 
            // ColorTable
            // 
            this.ColorTable.BackColor = System.Drawing.SystemColors.Control;
            this.ColorTable.ColumnCount = 5;
            this.ColorTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ColorTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ColorTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ColorTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ColorTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ColorTable.Location = new System.Drawing.Point(69, 3);
            this.ColorTable.Name = "ColorTable";
            this.ColorTable.RowCount = 3;
            this.ColorTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ColorTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ColorTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ColorTable.Size = new System.Drawing.Size(120, 72);
            this.ColorTable.TabIndex = 1;
            // 
            // DefaultColorBtn
            // 
            this.DefaultColorBtn.Location = new System.Drawing.Point(195, 3);
            this.DefaultColorBtn.Name = "DefaultColorBtn";
            this.DefaultColorBtn.Size = new System.Drawing.Size(98, 47);
            this.DefaultColorBtn.TabIndex = 2;
            this.DefaultColorBtn.Text = "По умолчанию";
            this.DefaultColorBtn.UseVisualStyleBackColor = true;
            this.DefaultColorBtn.Click += new System.EventHandler(this.DefaultColorBtn_Click);
            // 
            // ColorDialogBtn
            // 
            this.ColorDialogBtn.Location = new System.Drawing.Point(299, 3);
            this.ColorDialogBtn.Name = "ColorDialogBtn";
            this.ColorDialogBtn.Size = new System.Drawing.Size(60, 47);
            this.ColorDialogBtn.TabIndex = 3;
            this.ColorDialogBtn.Text = "Палитра";
            this.ColorDialogBtn.UseVisualStyleBackColor = true;
            this.ColorDialogBtn.Click += new System.EventHandler(this.ColorDialogBtn_Click);
            // 
            // ColorDialog
            // 
            this.ColorDialog.FullOpen = true;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Project_TS,
            this.CurrentPicture_TS});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // Project_TS
            // 
            this.Project_TS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create_TS,
            this.Open_TS,
            this.Save_TS,
            this.SaveAs_TS});
            this.Project_TS.Name = "Project_TS";
            this.Project_TS.Size = new System.Drawing.Size(59, 20);
            this.Project_TS.Text = "Проект";
            // 
            // Create_TS
            // 
            this.Create_TS.Name = "Create_TS";
            this.Create_TS.Size = new System.Drawing.Size(154, 22);
            this.Create_TS.Text = "Создать";
            this.Create_TS.Click += new System.EventHandler(this.Create_TS_Click);
            // 
            // Open_TS
            // 
            this.Open_TS.Name = "Open_TS";
            this.Open_TS.Size = new System.Drawing.Size(154, 22);
            this.Open_TS.Text = "Открыть";
            this.Open_TS.Click += new System.EventHandler(this.Open_TS_Click);
            // 
            // Save_TS
            // 
            this.Save_TS.Name = "Save_TS";
            this.Save_TS.Size = new System.Drawing.Size(154, 22);
            this.Save_TS.Text = "Сохранить";
            this.Save_TS.Click += new System.EventHandler(this.Save_TS_Click);
            // 
            // SaveAs_TS
            // 
            this.SaveAs_TS.Name = "SaveAs_TS";
            this.SaveAs_TS.Size = new System.Drawing.Size(154, 22);
            this.SaveAs_TS.Text = "Сохранить как";
            this.SaveAs_TS.Click += new System.EventHandler(this.SaveAs_TS_Click);
            // 
            // CurrentPicture_TS
            // 
            this.CurrentPicture_TS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Resize_TS});
            this.CurrentPicture_TS.Name = "CurrentPicture_TS";
            this.CurrentPicture_TS.Size = new System.Drawing.Size(95, 20);
            this.CurrentPicture_TS.Text = "Изображение";
            // 
            // Resize_TS
            // 
            this.Resize_TS.Name = "Resize_TS";
            this.Resize_TS.Size = new System.Drawing.Size(180, 22);
            this.Resize_TS.Text = "Изменить размер";
            this.Resize_TS.Click += new System.EventHandler(this.Resize_TS_Click);
            // 
            // TabPage
            // 
            this.TabPage.AutoScroll = true;
            this.TabPage.AutoScrollMargin = new System.Drawing.Size(40, 40);
            this.TabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPage.Controls.Add(this.PictureEditZone);
            this.TabPage.Location = new System.Drawing.Point(4, 22);
            this.TabPage.Name = "TabPage";
            this.TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage.Size = new System.Drawing.Size(792, 253);
            this.TabPage.TabIndex = 1;
            this.TabPage.Text = "TabPage";
            this.TabPage.UseVisualStyleBackColor = true;
            this.TabPage.Layout += new System.Windows.Forms.LayoutEventHandler(this.LoadedFileTabPage_Layout);
            // 
            // TabPagesControl
            // 
            this.TabPagesControl.Controls.Add(this.TabPage);
            this.TabPagesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPagesControl.Location = new System.Drawing.Point(0, 171);
            this.TabPagesControl.Name = "TabPagesControl";
            this.TabPagesControl.SelectedIndex = 0;
            this.TabPagesControl.ShowToolTips = true;
            this.TabPagesControl.Size = new System.Drawing.Size(800, 279);
            this.TabPagesControl.TabIndex = 1;
            // 
            // PictureEditZone
            // 
            this.PictureEditZone.BackColor = System.Drawing.Color.Gainsboro;
            this.PictureEditZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureEditZone.CurrentTool = null;
            this.PictureEditZone.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PictureEditZone.Location = new System.Drawing.Point(7, 6);
            this.PictureEditZone.Name = "PictureEditZone";
            this.PictureEditZone.Size = new System.Drawing.Size(256, 256);
            this.PictureEditZone.TabIndex = 0;
            this.PictureEditZone.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabPagesControl);
            this.Controls.Add(flowLayoutPanel1);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "ZigZag";
            this.Load += new System.EventHandler(this.MainForm_Load);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToolWidthBar)).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.TabPage.ResumeLayout(false);
            this.TabPagesControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureEditZone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ToolWidthLabel;
        private System.Windows.Forms.TrackBar ToolWidthBar;
        private System.Windows.Forms.Button CurrentColorBtn;
        private System.Windows.Forms.Button ColorDialogBtn;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Project_TS;
        private System.Windows.Forms.ToolStripMenuItem Create_TS;
        private System.Windows.Forms.ToolStripMenuItem Open_TS;
        private System.Windows.Forms.ToolStripMenuItem Save_TS;
        private System.Windows.Forms.ToolStripMenuItem SaveAs_TS;
        private System.Windows.Forms.Button EraserTool;
        private System.Windows.Forms.Button PenTool;
        private System.Windows.Forms.Button BrushTool;
        private System.Windows.Forms.Button DefaultColorBtn;
        private System.Windows.Forms.Button SelectTool;
        private System.Windows.Forms.TableLayoutPanel ColorTable;
        private System.Windows.Forms.TabPage TabPage;
        private System.Windows.Forms.TabControl TabPagesControl;
        private BitmapEditor PictureEditZone;
        private System.Windows.Forms.Button FillTool;
        private System.Windows.Forms.ToolStripMenuItem CurrentPicture_TS;
        private System.Windows.Forms.ToolStripMenuItem Resize_TS;
    }
}

