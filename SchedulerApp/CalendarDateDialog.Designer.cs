namespace SchedulerApp
{
    partial class CalendarDateDialog
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
            dateTable = new TableLayoutPanel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            monthDayYearLabel = new Label();
            closeButton = new Button();
            dateTable.SuspendLayout();
            SuspendLayout();
            // 
            // dateTable
            // 
            dateTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            dateTable.ColumnCount = 4;
            dateTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            dateTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            dateTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            dateTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            dateTable.Controls.Add(label4, 3, 0);
            dateTable.Controls.Add(label3, 2, 0);
            dateTable.Controls.Add(label2, 1, 0);
            dateTable.Controls.Add(label1, 0, 0);
            dateTable.Location = new Point(24, 61);
            dateTable.Name = "dateTable";
            dateTable.RowCount = 1;
            dateTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            dateTable.Size = new Size(532, 26);
            dateTable.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(375, 1);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 3;
            label4.Text = "Customer";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(216, 1);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 2;
            label3.Text = "Type";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 1);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 1;
            label2.Text = "End";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 0;
            label1.Text = "Start";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // monthDayYearLabel
            // 
            monthDayYearLabel.AutoSize = true;
            monthDayYearLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            monthDayYearLabel.ImeMode = ImeMode.NoControl;
            monthDayYearLabel.Location = new Point(216, 18);
            monthDayYearLabel.Name = "monthDayYearLabel";
            monthDayYearLabel.Size = new Size(158, 25);
            monthDayYearLabel.TabIndex = 13;
            monthDayYearLabel.Text = "Month Day, Year";
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Segoe UI", 12F);
            closeButton.Location = new Point(481, 279);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 44);
            closeButton.TabIndex = 14;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            // 
            // CalendarDateDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = closeButton;
            ClientSize = new Size(580, 348);
            Controls.Add(closeButton);
            Controls.Add(monthDayYearLabel);
            Controls.Add(dateTable);
            Name = "CalendarDateDialog";
            Text = "CalendarDateDialog";
            dateTable.ResumeLayout(false);
            dateTable.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel dateTable;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label monthDayYearLabel;
        private Button closeButton;
    }
}