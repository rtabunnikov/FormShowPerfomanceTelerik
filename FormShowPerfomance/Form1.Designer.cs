﻿namespace FormShowPerfomance {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.butNoRibbon = new System.Windows.Forms.Button();
            this.butRibbonDesigntime = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.chkWarmUp = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // butNoRibbon
            // 
            this.butNoRibbon.Location = new System.Drawing.Point(99, 11);
            this.butNoRibbon.Margin = new System.Windows.Forms.Padding(2);
            this.butNoRibbon.Name = "butNoRibbon";
            this.butNoRibbon.Size = new System.Drawing.Size(138, 37);
            this.butNoRibbon.TabIndex = 0;
            this.butNoRibbon.Text = "No ribbon";
            this.butNoRibbon.UseVisualStyleBackColor = true;
            this.butNoRibbon.Click += new System.EventHandler(this.butNoRibbon_Click);
            // 
            // butRibbonDesigntime
            // 
            this.butRibbonDesigntime.Location = new System.Drawing.Point(241, 11);
            this.butRibbonDesigntime.Margin = new System.Windows.Forms.Padding(2);
            this.butRibbonDesigntime.Name = "butRibbonDesigntime";
            this.butRibbonDesigntime.Size = new System.Drawing.Size(138, 37);
            this.butRibbonDesigntime.TabIndex = 3;
            this.butRibbonDesigntime.Text = "Ribbon designtime";
            this.butRibbonDesigntime.UseVisualStyleBackColor = true;
            this.butRibbonDesigntime.Click += new System.EventHandler(this.butRibbonDesigntime_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(9, 92);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(770, 264);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Spreadsheet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(755, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Switch OFF warm up pass and push one button per app run if you want to see cold s" +
    "tart time (max)! Copy result from text box below.";
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(383, 11);
            this.btnAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(105, 37);
            this.btnAll.TabIndex = 11;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // chkWarmUp
            // 
            this.chkWarmUp.AutoSize = true;
            this.chkWarmUp.Location = new System.Drawing.Point(512, 22);
            this.chkWarmUp.Name = "chkWarmUp";
            this.chkWarmUp.Size = new System.Drawing.Size(94, 17);
            this.chkWarmUp.TabIndex = 12;
            this.chkWarmUp.Text = "Warm up pass";
            this.chkWarmUp.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 55;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 366);
            this.Controls.Add(this.chkWarmUp);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butRibbonDesigntime);
            this.Controls.Add(this.butNoRibbon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Telerik FormShow performance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butNoRibbon;
        private System.Windows.Forms.Button butRibbonDesigntime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.CheckBox chkWarmUp;
        private System.Windows.Forms.Timer timer1;
    }
}

