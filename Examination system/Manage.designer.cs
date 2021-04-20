
namespace DBProject
{
    partial class Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            this.label1 = new System.Windows.Forms.Label();
            this.MngStd = new System.Windows.Forms.Button();
            this.btnins = new System.Windows.Forms.Button();
            this.btnex = new System.Windows.Forms.Button();
            this.MngCrs = new System.Windows.Forms.Button();
            this.MngDept = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(408, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exam System";
            // 
            // MngStd
            // 
            this.MngStd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MngStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngStd.ForeColor = System.Drawing.Color.Navy;
            this.MngStd.Location = new System.Drawing.Point(383, 252);
            this.MngStd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MngStd.Name = "MngStd";
            this.MngStd.Size = new System.Drawing.Size(185, 71);
            this.MngStd.TabIndex = 2;
            this.MngStd.Text = "Manage Student";
            this.MngStd.UseVisualStyleBackColor = false;
            this.MngStd.Click += new System.EventHandler(this.MngStd_Click);
            // 
            // btnins
            // 
            this.btnins.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnins.ForeColor = System.Drawing.Color.Navy;
            this.btnins.Location = new System.Drawing.Point(1072, 107);
            this.btnins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnins.Name = "btnins";
            this.btnins.Size = new System.Drawing.Size(185, 78);
            this.btnins.TabIndex = 3;
            this.btnins.Text = "Manage Instructor";
            this.btnins.UseVisualStyleBackColor = false;
            this.btnins.Click += new System.EventHandler(this.btnins_Click);
            // 
            // btnex
            // 
            this.btnex.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnex.ForeColor = System.Drawing.Color.Navy;
            this.btnex.Location = new System.Drawing.Point(52, 225);
            this.btnex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(161, 78);
            this.btnex.TabIndex = 4;
            this.btnex.Text = "Manage Exam";
            this.btnex.UseVisualStyleBackColor = false;
            this.btnex.Click += new System.EventHandler(this.btnex_Click);
            // 
            // MngCrs
            // 
            this.MngCrs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MngCrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngCrs.ForeColor = System.Drawing.Color.Navy;
            this.MngCrs.Location = new System.Drawing.Point(125, 107);
            this.MngCrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MngCrs.Name = "MngCrs";
            this.MngCrs.Size = new System.Drawing.Size(161, 73);
            this.MngCrs.TabIndex = 5;
            this.MngCrs.Text = "Manage Course";
            this.MngCrs.UseVisualStyleBackColor = false;
            this.MngCrs.Click += new System.EventHandler(this.MngCrs_Click);
            // 
            // MngDept
            // 
            this.MngDept.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MngDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDept.ForeColor = System.Drawing.Color.Navy;
            this.MngDept.Location = new System.Drawing.Point(1181, 226);
            this.MngDept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MngDept.Name = "MngDept";
            this.MngDept.Size = new System.Drawing.Size(185, 76);
            this.MngDept.TabIndex = 6;
            this.MngDept.Text = "Manage Department";
            this.MngDept.UseVisualStyleBackColor = false;
            this.MngDept.Click += new System.EventHandler(this.MngDept_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(580, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 71);
            this.button1.TabIndex = 7;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.report.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.Color.Navy;
            this.report.Location = new System.Drawing.Point(775, 252);
            this.report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(185, 71);
            this.report.TabIndex = 8;
            this.report.Text = "Reports";
            this.report.UseVisualStyleBackColor = false;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1445, 801);
            this.Controls.Add(this.report);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MngDept);
            this.Controls.Add(this.MngCrs);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.btnins);
            this.Controls.Add(this.MngStd);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Manage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MngStd;
        private System.Windows.Forms.Button btnins;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Button MngCrs;
        private System.Windows.Forms.Button MngDept;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button report;
    }
}

