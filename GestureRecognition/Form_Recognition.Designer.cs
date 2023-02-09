
namespace GestureRecognition
{
    partial class Form_Recognition
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

        public void InitializeComponent()
        {
            this.tbl_lay_circul_top = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbl_lay_bacis = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbl_lay_bottom = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbl_lay_predic = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbl_lay_circul_center = new System.Windows.Forms.TableLayoutPanel();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label_res = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoad_Rec = new System.Windows.Forms.Button();
            this.tbl_lay_circul_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tbl_lay_bacis.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tbl_lay_bottom.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbl_lay_predic.SuspendLayout();
            this.tbl_lay_circul_center.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_lay_circul_top
            // 
            this.tbl_lay_circul_top.ColumnCount = 2;
            this.tbl_lay_circul_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_lay_circul_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_lay_circul_top.Controls.Add(this.pictureBox1, 0, 0);
            this.tbl_lay_circul_top.Controls.Add(this.pictureBox2, 1, 0);
            this.tbl_lay_circul_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_lay_circul_top.Location = new System.Drawing.Point(0, 0);
            this.tbl_lay_circul_top.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_lay_circul_top.Name = "tbl_lay_circul_top";
            this.tbl_lay_circul_top.RowCount = 1;
            this.tbl_lay_circul_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_lay_circul_top.Size = new System.Drawing.Size(560, 210);
            this.tbl_lay_circul_top.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(280, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(280, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tbl_lay_bacis
            // 
            this.tbl_lay_bacis.ColumnCount = 1;
            this.tbl_lay_bacis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_lay_bacis.Controls.Add(this.panel9, 0, 1);
            this.tbl_lay_bacis.Controls.Add(this.tbl_lay_circul_top, 0, 0);
            this.tbl_lay_bacis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_lay_bacis.Location = new System.Drawing.Point(0, 0);
            this.tbl_lay_bacis.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_lay_bacis.Name = "tbl_lay_bacis";
            this.tbl_lay_bacis.RowCount = 2;
            this.tbl_lay_bacis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
            this.tbl_lay_bacis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.25F));
            this.tbl_lay_bacis.Size = new System.Drawing.Size(560, 480);
            this.tbl_lay_bacis.TabIndex = 30;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.panel9.Controls.Add(this.tbl_lay_bottom);
            this.panel9.Controls.Add(this.label_res);
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 210);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(560, 270);
            this.panel9.TabIndex = 29;
            // 
            // tbl_lay_bottom
            // 
            this.tbl_lay_bottom.ColumnCount = 2;
            this.tbl_lay_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.32143F));
            this.tbl_lay_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.67857F));
            this.tbl_lay_bottom.Controls.Add(this.groupBox2, 1, 0);
            this.tbl_lay_bottom.Controls.Add(this.tbl_lay_predic, 0, 0);
            this.tbl_lay_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_lay_bottom.Location = new System.Drawing.Point(0, 0);
            this.tbl_lay_bottom.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_lay_bottom.Name = "tbl_lay_bottom";
            this.tbl_lay_bottom.RowCount = 1;
            this.tbl_lay_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_lay_bottom.Size = new System.Drawing.Size(560, 220);
            this.tbl_lay_bottom.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.groupBox2.Location = new System.Drawing.Point(293, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 220);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(3, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(261, 186);
            this.textBox1.TabIndex = 13;
            // 
            // tbl_lay_predic
            // 
            this.tbl_lay_predic.ColumnCount = 2;
            this.tbl_lay_predic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_lay_predic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_lay_predic.Controls.Add(this.label12, 0, 0);
            this.tbl_lay_predic.Controls.Add(this.label16, 0, 1);
            this.tbl_lay_predic.Controls.Add(this.label5, 1, 0);
            this.tbl_lay_predic.Controls.Add(this.tbl_lay_circul_center, 1, 1);
            this.tbl_lay_predic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_lay_predic.Location = new System.Drawing.Point(0, 0);
            this.tbl_lay_predic.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_lay_predic.Name = "tbl_lay_predic";
            this.tbl_lay_predic.RowCount = 2;
            this.tbl_lay_predic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_lay_predic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_lay_predic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_lay_predic.Size = new System.Drawing.Size(293, 220);
            this.tbl_lay_predic.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 110);
            this.label12.TabIndex = 0;
            this.label12.Text = "Predicted value: ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(140, 110);
            this.label16.TabIndex = 0;
            this.label16.Text = "Predicted score: ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(149, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 110);
            this.label5.TabIndex = 1;
            this.label5.Text = "----------";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbl_lay_circul_center
            // 
            this.tbl_lay_circul_center.ColumnCount = 3;
            this.tbl_lay_circul_center.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_lay_circul_center.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tbl_lay_circul_center.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_lay_circul_center.Controls.Add(this.circularProgressBar1, 1, 1);
            this.tbl_lay_circul_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_lay_circul_center.Location = new System.Drawing.Point(146, 110);
            this.tbl_lay_circul_center.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_lay_circul_center.Name = "tbl_lay_circul_center";
            this.tbl_lay_circul_center.RowCount = 3;
            this.tbl_lay_circul_center.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_lay_circul_center.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tbl_lay_circul_center.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_lay_circul_center.Size = new System.Drawing.Size(147, 110);
            this.tbl_lay_circul_center.TabIndex = 2;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.circularProgressBar1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.circularProgressBar1.InnerMargin = 0;
            this.circularProgressBar1.InnerWidth = 0;
            this.circularProgressBar1.Location = new System.Drawing.Point(19, 8);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.circularProgressBar1.ProgressWidth = 10;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.Size = new System.Drawing.Size(109, 94);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 3;
            this.circularProgressBar1.Text = "0%";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.Value = 68;
            // 
            // label_res
            // 
            this.label_res.AutoSize = true;
            this.label_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_res.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_res.ForeColor = System.Drawing.Color.DimGray;
            this.label_res.Location = new System.Drawing.Point(14, 146);
            this.label_res.Name = "label_res";
            this.label_res.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label_res.Size = new System.Drawing.Size(15, 17);
            this.label_res.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoad_Rec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 50);
            this.panel1.TabIndex = 3;
            // 
            // btnLoad_Rec
            // 
            this.btnLoad_Rec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.btnLoad_Rec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad_Rec.FlatAppearance.BorderSize = 0;
            this.btnLoad_Rec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad_Rec.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad_Rec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLoad_Rec.Image = global::GestureRecognition.Properties.Resources.home;
            this.btnLoad_Rec.Location = new System.Drawing.Point(0, 0);
            this.btnLoad_Rec.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoad_Rec.Name = "btnLoad_Rec";
            this.btnLoad_Rec.Size = new System.Drawing.Size(560, 50);
            this.btnLoad_Rec.TabIndex = 2;
            this.btnLoad_Rec.Text = "Load Model";
            this.btnLoad_Rec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad_Rec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoad_Rec.UseVisualStyleBackColor = false;
            this.btnLoad_Rec.Click += new System.EventHandler(this.btnLoadMod_Click);
            // 
            // Form_Recognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(560, 480);
            this.Controls.Add(this.tbl_lay_bacis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Recognition";
            this.Text = "frm_rec";
            this.Load += new System.EventHandler(this.Form_Recognition_Load);
            this.tbl_lay_circul_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tbl_lay_bacis.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tbl_lay_bottom.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbl_lay_predic.ResumeLayout(false);
            this.tbl_lay_predic.PerformLayout();
            this.tbl_lay_circul_center.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.TableLayoutPanel tbl_lay_circul_top;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tbl_lay_bacis;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnLoad_Rec;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label_res;
        private System.Windows.Forms.TableLayoutPanel tbl_lay_bottom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tbl_lay_predic;
        private System.Windows.Forms.TableLayoutPanel tbl_lay_circul_center;
        public CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}