namespace SchedulerApp
{
    partial class ReportDialog
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
            closeButton = new Button();
            reportLabel = new Label();
            reportGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)reportGrid).BeginInit();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Segoe UI", 12F);
            closeButton.Location = new Point(451, 380);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 44);
            closeButton.TabIndex = 0;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            // 
            // reportLabel
            // 
            reportLabel.AutoSize = true;
            reportLabel.Font = new Font("Segoe UI", 12F);
            reportLabel.Location = new Point(20, 21);
            reportLabel.Name = "reportLabel";
            reportLabel.Size = new Size(98, 21);
            reportLabel.TabIndex = 1;
            reportLabel.Text = "Report Label";
            // 
            // reportGrid
            // 
            reportGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportGrid.Location = new Point(20, 63);
            reportGrid.Name = "reportGrid";
            reportGrid.Size = new Size(506, 292);
            reportGrid.TabIndex = 3;
            // 
            // ReportDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = closeButton;
            ClientSize = new Size(555, 450);
            Controls.Add(reportGrid);
            Controls.Add(reportLabel);
            Controls.Add(closeButton);
            Name = "ReportDialog";
            Text = "ReportDialog";
            ((System.ComponentModel.ISupportInitialize)reportGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private Label reportLabel;
        private DataGridView reportGrid;
    }
}