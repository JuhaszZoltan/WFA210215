
namespace WFA210215
{
    partial class FrmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbKV = new System.Windows.Forms.RadioButton();
            this.rbTea = new System.Windows.Forms.RadioButton();
            this.rbCsoki = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.lblAr = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbPohar = new System.Windows.Forms.CheckBox();
            this.cbTej = new System.Windows.Forms.CheckBox();
            this.cbCukor = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "termék";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rbKV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbTea, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbCsoki, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(342, 171);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rbKV
            // 
            this.rbKV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbKV.AutoSize = true;
            this.rbKV.Checked = true;
            this.rbKV.Location = new System.Drawing.Point(23, 3);
            this.rbKV.Name = "rbKV";
            this.rbKV.Size = new System.Drawing.Size(64, 51);
            this.rbKV.TabIndex = 0;
            this.rbKV.TabStop = true;
            this.rbKV.Text = "kávé";
            this.rbKV.UseVisualStyleBackColor = true;
            this.rbKV.CheckedChanged += new System.EventHandler(this.AlapTermekCheckedChanged);
            // 
            // rbTea
            // 
            this.rbTea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbTea.AutoSize = true;
            this.rbTea.Location = new System.Drawing.Point(23, 60);
            this.rbTea.Name = "rbTea";
            this.rbTea.Size = new System.Drawing.Size(53, 51);
            this.rbTea.TabIndex = 1;
            this.rbTea.Text = "tea";
            this.rbTea.UseVisualStyleBackColor = true;
            this.rbTea.CheckedChanged += new System.EventHandler(this.AlapTermekCheckedChanged);
            // 
            // rbCsoki
            // 
            this.rbCsoki.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbCsoki.AutoSize = true;
            this.rbCsoki.Location = new System.Drawing.Point(23, 117);
            this.rbCsoki.Name = "rbCsoki";
            this.rbCsoki.Size = new System.Drawing.Size(104, 51);
            this.rbCsoki.TabIndex = 2;
            this.rbCsoki.Text = "forrócsoki";
            this.rbCsoki.UseVisualStyleBackColor = true;
            this.rbCsoki.CheckedChanged += new System.EventHandler(this.AlapTermekCheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.Location = new System.Drawing.Point(184, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "100 Ft";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.Location = new System.Drawing.Point(184, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 57);
            this.label2.TabIndex = 4;
            this.label2.Text = "80 Ft";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.Location = new System.Drawing.Point(184, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 57);
            this.label3.TabIndex = 5;
            this.label3.Text = "120 Ft";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSzamol
            // 
            this.btnSzamol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzamol.Location = new System.Drawing.Point(12, 420);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(354, 56);
            this.btnSzamol.TabIndex = 2;
            this.btnSzamol.Text = "Ezt kérem!";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.BtnSzamolClick);
            // 
            // lblAr
            // 
            this.lblAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAr.Location = new System.Drawing.Point(12, 495);
            this.lblAr.Name = "lblAr";
            this.lblAr.Size = new System.Drawing.Size(354, 48);
            this.lblAr.TabIndex = 3;
            this.lblAr.Text = "###";
            this.lblAr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 198);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "extra";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cbPohar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbTej, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbCukor, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(342, 171);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cbPohar
            // 
            this.cbPohar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPohar.AutoSize = true;
            this.cbPohar.Location = new System.Drawing.Point(23, 3);
            this.cbPohar.Name = "cbPohar";
            this.cbPohar.Size = new System.Drawing.Size(114, 51);
            this.cbPohar.TabIndex = 0;
            this.cbPohar.Text = "saját pohár";
            this.cbPohar.UseVisualStyleBackColor = true;
            this.cbPohar.CheckedChanged += new System.EventHandler(this.ExtraCheckedChanged);
            // 
            // cbTej
            // 
            this.cbTej.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTej.AutoSize = true;
            this.cbTej.Location = new System.Drawing.Point(23, 60);
            this.cbTej.Name = "cbTej";
            this.cbTej.Size = new System.Drawing.Size(91, 51);
            this.cbTej.TabIndex = 1;
            this.cbTej.Text = "extra tej";
            this.cbTej.UseVisualStyleBackColor = true;
            this.cbTej.CheckedChanged += new System.EventHandler(this.ExtraCheckedChanged);
            // 
            // cbCukor
            // 
            this.cbCukor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCukor.AutoSize = true;
            this.cbCukor.Location = new System.Drawing.Point(23, 117);
            this.cbCukor.Name = "cbCukor";
            this.cbCukor.Size = new System.Drawing.Size(114, 51);
            this.cbCukor.TabIndex = 2;
            this.cbCukor.Text = "extra cukor";
            this.cbCukor.UseVisualStyleBackColor = true;
            this.cbCukor.CheckedChanged += new System.EventHandler(this.ExtraCheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.Location = new System.Drawing.Point(184, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 57);
            this.label4.TabIndex = 3;
            this.label4.Text = "- 10 ft";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.Location = new System.Drawing.Point(184, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 57);
            this.label5.TabIndex = 4;
            this.label5.Text = "+ 10 Ft";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.Location = new System.Drawing.Point(184, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 57);
            this.label6.TabIndex = 5;
            this.label6.Text = "+ 20 Ft";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 561);
            this.Controls.Add(this.lblAr);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "KV gép";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Label lblAr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rbKV;
        private System.Windows.Forms.RadioButton rbTea;
        private System.Windows.Forms.RadioButton rbCsoki;
        private System.Windows.Forms.CheckBox cbPohar;
        private System.Windows.Forms.CheckBox cbTej;
        private System.Windows.Forms.CheckBox cbCukor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

