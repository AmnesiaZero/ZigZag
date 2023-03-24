
namespace ZigZag
{
    partial class ResizeBitmapDialog
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
            this.WidthValue = new System.Windows.Forms.NumericUpDown();
            this.HeightValue = new System.Windows.Forms.NumericUpDown();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.KeepRatio_CB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightValue)).BeginInit();
            this.SuspendLayout();
            // 
            // WidthValue
            // 
            this.WidthValue.Location = new System.Drawing.Point(154, 12);
            this.WidthValue.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.WidthValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthValue.Name = "WidthValue";
            this.WidthValue.Size = new System.Drawing.Size(87, 20);
            this.WidthValue.TabIndex = 0;
            this.WidthValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthValue.ValueChanged += new System.EventHandler(this.WidthValue_ValueChanged);
            // 
            // HeightValue
            // 
            this.HeightValue.Location = new System.Drawing.Point(154, 55);
            this.HeightValue.Maximum = new decimal(new int[] {
            3072,
            0,
            0,
            0});
            this.HeightValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightValue.Name = "HeightValue";
            this.HeightValue.Size = new System.Drawing.Size(87, 20);
            this.HeightValue.TabIndex = 1;
            this.HeightValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightValue.ValueChanged += new System.EventHandler(this.HeightValue_ValueChanged);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(12, 14);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(111, 13);
            this.WidthLabel.TabIndex = 0;
            this.WidthLabel.Text = "Ширина (макс. 4096)";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(13, 57);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(110, 13);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Высота (макс. 3072)";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateBtn.Location = new System.Drawing.Point(154, 91);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(87, 25);
            this.CreateBtn.TabIndex = 3;
            this.CreateBtn.Text = "Ок";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // KeepRatio_CB
            // 
            this.KeepRatio_CB.AutoSize = true;
            this.KeepRatio_CB.Location = new System.Drawing.Point(16, 96);
            this.KeepRatio_CB.Name = "KeepRatio_CB";
            this.KeepRatio_CB.Size = new System.Drawing.Size(136, 17);
            this.KeepRatio_CB.TabIndex = 2;
            this.KeepRatio_CB.Text = "Сохранить пропорции";
            this.KeepRatio_CB.UseVisualStyleBackColor = true;
            this.KeepRatio_CB.CheckedChanged += new System.EventHandler(this.KeepRatio_CB_CheckedChanged);
            // 
            // ResizeBitmapDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 217);
            this.Controls.Add(this.KeepRatio_CB);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightValue);
            this.Controls.Add(this.WidthValue);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResizeBitmapDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Изменить размер";
            this.Load += new System.EventHandler(this.CreateBitmapDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown WidthValue;
        private System.Windows.Forms.NumericUpDown HeightValue;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.CheckBox KeepRatio_CB;
    }
}