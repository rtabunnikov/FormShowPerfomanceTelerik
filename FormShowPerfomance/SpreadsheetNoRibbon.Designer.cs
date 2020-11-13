
namespace FormShowPerfomance {
    partial class SpreadsheetNoRibbon {
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
            Telerik.Windows.Documents.Spreadsheet.Model.Workbook workbook1 = new Telerik.Windows.Documents.Spreadsheet.Model.Workbook();
            this.radSpreadsheet1 = new Telerik.WinControls.UI.RadSpreadsheet();
            ((System.ComponentModel.ISupportInitialize)(this.radSpreadsheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // radSpreadsheet1
            // 
            this.radSpreadsheet1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radSpreadsheet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSpreadsheet1.Location = new System.Drawing.Point(0, 0);
            this.radSpreadsheet1.Name = "radSpreadsheet1";
            // 
            // 
            // 
            this.radSpreadsheet1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 480, 320);
            this.radSpreadsheet1.Size = new System.Drawing.Size(600, 366);
            this.radSpreadsheet1.TabIndex = 0;
            workbook1.ActiveTabIndex = -1;
            workbook1.Name = "Book1";
            workbook1.WorkbookContentChangedInterval = System.TimeSpan.Parse("00:00:00.0300000");
            this.radSpreadsheet1.Workbook = workbook1;
            // 
            // SpreadsheetNoRibbon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.radSpreadsheet1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SpreadsheetNoRibbon";
            this.Text = "SpreadsheetNoRibbon";
            this.Shown += new System.EventHandler(this.SpreadsheetNoRibbon_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.radSpreadsheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadSpreadsheet radSpreadsheet1;
    }
}