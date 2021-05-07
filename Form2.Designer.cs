
namespace PhotoGraph
{
    partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.colorValue = new System.Windows.Forms.Label();
            this.colorBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.contrastValue = new System.Windows.Forms.Label();
            this.contrastBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.brightnessBar = new System.Windows.Forms.TrackBar();
            this.brightnessValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Controls.Add(this.colorValue, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.colorBar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.contrastValue, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.contrastBar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.brightnessBar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.brightnessValue, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 274);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // colorValue
            // 
            this.colorValue.AutoSize = true;
            this.colorValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorValue.Location = new System.Drawing.Point(617, 204);
            this.colorValue.Name = "colorValue";
            this.colorValue.Size = new System.Drawing.Size(50, 70);
            this.colorValue.TabIndex = 14;
            this.colorValue.Text = "100";
            this.colorValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorBar
            // 
            this.colorBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorBar.Location = new System.Drawing.Point(310, 207);
            this.colorBar.Maximum = 100;
            this.colorBar.Name = "colorBar";
            this.colorBar.Size = new System.Drawing.Size(301, 64);
            this.colorBar.TabIndex = 13;
            this.colorBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.colorBar.Value = 100;
            this.colorBar.Scroll += new System.EventHandler(this.colorBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 70);
            this.label5.TabIndex = 12;
            this.label5.Text = "Обесцвечивание";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contrastValue
            // 
            this.contrastValue.AutoSize = true;
            this.contrastValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contrastValue.Location = new System.Drawing.Point(617, 68);
            this.contrastValue.Name = "contrastValue";
            this.contrastValue.Size = new System.Drawing.Size(50, 68);
            this.contrastValue.TabIndex = 6;
            this.contrastValue.Text = "0";
            this.contrastValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contrastBar
            // 
            this.contrastBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contrastBar.Location = new System.Drawing.Point(310, 71);
            this.contrastBar.Maximum = 100;
            this.contrastBar.Minimum = -100;
            this.contrastBar.Name = "contrastBar";
            this.contrastBar.Size = new System.Drawing.Size(301, 62);
            this.contrastBar.TabIndex = 5;
            this.contrastBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.contrastBar.Scroll += new System.EventHandler(this.contrastBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Яркость";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = "Контрастность";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 68);
            this.label3.TabIndex = 2;
            this.label3.Text = "Размытие";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brightnessBar
            // 
            this.brightnessBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brightnessBar.Location = new System.Drawing.Point(310, 3);
            this.brightnessBar.Maximum = 255;
            this.brightnessBar.Minimum = -255;
            this.brightnessBar.Name = "brightnessBar";
            this.brightnessBar.Size = new System.Drawing.Size(301, 62);
            this.brightnessBar.TabIndex = 3;
            this.brightnessBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.brightnessBar.Scroll += new System.EventHandler(this.brightness_trackBar_Scroll);
            // 
            // brightnessValue
            // 
            this.brightnessValue.AutoSize = true;
            this.brightnessValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brightnessValue.Location = new System.Drawing.Point(617, 0);
            this.brightnessValue.Name = "brightnessValue";
            this.brightnessValue.Size = new System.Drawing.Size(50, 68);
            this.brightnessValue.TabIndex = 4;
            this.brightnessValue.Text = "100";
            this.brightnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(310, 139);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(301, 62);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(82, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Применить размытие";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 68);
            this.label4.TabIndex = 8;
            this.label4.Text = "%";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 274);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.form_shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label contrastValue;
        private System.Windows.Forms.TrackBar contrastBar;
        private System.Windows.Forms.TrackBar brightnessBar;
        private System.Windows.Forms.Label brightnessValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label colorValue;
        private System.Windows.Forms.TrackBar colorBar;
        private System.Windows.Forms.Label label5;
    }
}