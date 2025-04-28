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
            reportPanel = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            reportPanel.SuspendLayout();
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
            // reportPanel
            // 
            reportPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            reportPanel.ColumnCount = 2;
            reportPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            reportPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            reportPanel.Controls.Add(label1, 0, 0);
            reportPanel.Controls.Add(label2, 1, 0);
            reportPanel.Location = new Point(20, 67);
            reportPanel.Name = "reportPanel";
            reportPanel.RowCount = 1;
            reportPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            reportPanel.Size = new Size(506, 20);
            reportPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 0;
            label1.Text = "Month";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(206, 1);
            label2.Name = "label2";
            label2.Size = new Size(238, 21);
            label2.TabIndex = 1;
            label2.Text = "Number of Appointment Types";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ReportDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = closeButton;
            ClientSize = new Size(555, 450);
            Controls.Add(reportPanel);
            Controls.Add(reportLabel);
            Controls.Add(closeButton);
            Name = "ReportDialog";
            Text = "ReportDialog";
            reportPanel.ResumeLayout(false);
            reportPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private Label reportLabel;
        private TableLayoutPanel reportPanel;
        private Label label1;
        private Label label2;
    }
}