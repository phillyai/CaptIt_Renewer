﻿namespace CaptIt.SettingPanels
{
    partial class AutosaveSetting
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHelpFormat = new System.Windows.Forms.Button();
            this.tbNameFormat = new System.Windows.Forms.TextBox();
            this.lbNameFormat = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.cbAutosave = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.rbHeight = new System.Windows.Forms.RadioButton();
            this.rbWidth = new System.Windows.Forms.RadioButton();
            this.lbMulti = new System.Windows.Forms.Label();
            this.tbrResize = new System.Windows.Forms.TrackBar();
            this.rbMulti = new System.Windows.Forms.RadioButton();
            this.rbNoResize = new System.Windows.Forms.RadioButton();
            this.lbSize = new System.Windows.Forms.Label();
            this.cbExtension = new System.Windows.Forms.ComboBox();
            this.lbExtension = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrResize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHelpFormat);
            this.groupBox1.Controls.Add(this.tbNameFormat);
            this.groupBox1.Controls.Add(this.lbNameFormat);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.tbPath);
            this.groupBox1.Controls.Add(this.cbAutosave);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "자동 저장";
            // 
            // btnHelpFormat
            // 
            this.btnHelpFormat.Location = new System.Drawing.Point(469, 51);
            this.btnHelpFormat.Name = "btnHelpFormat";
            this.btnHelpFormat.Size = new System.Drawing.Size(86, 23);
            this.btnHelpFormat.TabIndex = 8;
            this.btnHelpFormat.Text = "도움말";
            this.btnHelpFormat.UseVisualStyleBackColor = true;
            // 
            // tbNameFormat
            // 
            this.tbNameFormat.Location = new System.Drawing.Point(253, 51);
            this.tbNameFormat.Name = "tbNameFormat";
            this.tbNameFormat.Size = new System.Drawing.Size(210, 23);
            this.tbNameFormat.TabIndex = 7;
            // 
            // lbNameFormat
            // 
            this.lbNameFormat.AutoSize = true;
            this.lbNameFormat.Location = new System.Drawing.Point(181, 54);
            this.lbNameFormat.Name = "lbNameFormat";
            this.lbNameFormat.Size = new System.Drawing.Size(66, 15);
            this.lbNameFormat.TabIndex = 6;
            this.lbNameFormat.Text = "파일 이름 :";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(469, 22);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(86, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "찾아 보기";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(253, 22);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(210, 23);
            this.tbPath.TabIndex = 4;
            // 
            // cbAutosave
            // 
            this.cbAutosave.AutoSize = true;
            this.cbAutosave.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAutosave.Location = new System.Drawing.Point(125, 24);
            this.cbAutosave.Name = "cbAutosave";
            this.cbAutosave.Size = new System.Drawing.Size(122, 19);
            this.cbAutosave.TabIndex = 0;
            this.cbAutosave.Text = "캡쳐 후 자동 저장";
            this.cbAutosave.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbHeight);
            this.groupBox2.Controls.Add(this.tbWidth);
            this.groupBox2.Controls.Add(this.rbHeight);
            this.groupBox2.Controls.Add(this.rbWidth);
            this.groupBox2.Controls.Add(this.lbMulti);
            this.groupBox2.Controls.Add(this.tbrResize);
            this.groupBox2.Controls.Add(this.rbMulti);
            this.groupBox2.Controls.Add(this.rbNoResize);
            this.groupBox2.Controls.Add(this.lbSize);
            this.groupBox2.Controls.Add(this.cbExtension);
            this.groupBox2.Controls.Add(this.lbExtension);
            this.groupBox2.Location = new System.Drawing.Point(3, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 171);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "이미지 설정";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(390, 126);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(210, 23);
            this.tbHeight.TabIndex = 16;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(390, 101);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(210, 23);
            this.tbWidth.TabIndex = 9;
            // 
            // rbHeight
            // 
            this.rbHeight.AutoSize = true;
            this.rbHeight.Location = new System.Drawing.Point(253, 127);
            this.rbHeight.Name = "rbHeight";
            this.rbHeight.Size = new System.Drawing.Size(105, 19);
            this.rbHeight.TabIndex = 15;
            this.rbHeight.TabStop = true;
            this.rbHeight.Text = "세로 크기 고정";
            this.rbHeight.UseVisualStyleBackColor = true;
            // 
            // rbWidth
            // 
            this.rbWidth.AutoSize = true;
            this.rbWidth.Location = new System.Drawing.Point(253, 102);
            this.rbWidth.Name = "rbWidth";
            this.rbWidth.Size = new System.Drawing.Size(105, 19);
            this.rbWidth.TabIndex = 14;
            this.rbWidth.TabStop = true;
            this.rbWidth.Text = "가로 크기 고정";
            this.rbWidth.UseVisualStyleBackColor = true;
            // 
            // lbMulti
            // 
            this.lbMulti.AutoSize = true;
            this.lbMulti.Location = new System.Drawing.Point(561, 79);
            this.lbMulti.Name = "lbMulti";
            this.lbMulti.Size = new System.Drawing.Size(39, 15);
            this.lbMulti.TabIndex = 13;
            this.lbMulti.Text = "label1";
            // 
            // tbrResize
            // 
            this.tbrResize.LargeChange = 3;
            this.tbrResize.Location = new System.Drawing.Point(390, 75);
            this.tbrResize.Maximum = 12;
            this.tbrResize.Minimum = 1;
            this.tbrResize.Name = "tbrResize";
            this.tbrResize.Size = new System.Drawing.Size(165, 45);
            this.tbrResize.TabIndex = 12;
            this.tbrResize.TickFrequency = 3;
            this.tbrResize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrResize.Value = 1;
            // 
            // rbMulti
            // 
            this.rbMulti.AutoSize = true;
            this.rbMulti.Location = new System.Drawing.Point(253, 77);
            this.rbMulti.Name = "rbMulti";
            this.rbMulti.Size = new System.Drawing.Size(49, 19);
            this.rbMulti.TabIndex = 11;
            this.rbMulti.TabStop = true;
            this.rbMulti.Text = "배율";
            this.rbMulti.UseVisualStyleBackColor = true;
            // 
            // rbNoResize
            // 
            this.rbNoResize.AutoSize = true;
            this.rbNoResize.Location = new System.Drawing.Point(253, 52);
            this.rbNoResize.Name = "rbNoResize";
            this.rbNoResize.Size = new System.Drawing.Size(117, 19);
            this.rbNoResize.TabIndex = 10;
            this.rbNoResize.TabStop = true;
            this.rbNoResize.Text = "이미지 변경 없음";
            this.rbNoResize.UseVisualStyleBackColor = true;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(169, 54);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(78, 15);
            this.lbSize.TabIndex = 9;
            this.lbSize.Text = "이미지 크기 :";
            // 
            // cbExtension
            // 
            this.cbExtension.FormattingEnabled = true;
            this.cbExtension.Items.AddRange(new object[] {
            "PNG",
            "JPEG",
            "BMP",
            "GIF"});
            this.cbExtension.Location = new System.Drawing.Point(253, 22);
            this.cbExtension.Name = "cbExtension";
            this.cbExtension.Size = new System.Drawing.Size(210, 23);
            this.cbExtension.TabIndex = 8;
            // 
            // lbExtension
            // 
            this.lbExtension.AutoSize = true;
            this.lbExtension.Location = new System.Drawing.Point(157, 25);
            this.lbExtension.Name = "lbExtension";
            this.lbExtension.Size = new System.Drawing.Size(90, 15);
            this.lbExtension.TabIndex = 6;
            this.lbExtension.Text = "이미지 확장자 :";
            // 
            // AutosaveSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AutosaveSetting";
            this.Size = new System.Drawing.Size(640, 474);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrResize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbAutosave;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label lbNameFormat;
        private System.Windows.Forms.Button btnHelpFormat;
        private System.Windows.Forms.TextBox tbNameFormat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbExtension;
        private System.Windows.Forms.Label lbExtension;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbMulti;
        private System.Windows.Forms.TrackBar tbrResize;
        private System.Windows.Forms.RadioButton rbMulti;
        private System.Windows.Forms.RadioButton rbNoResize;
        private System.Windows.Forms.RadioButton rbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.RadioButton rbHeight;
    }
}
