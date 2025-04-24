namespace SchedulerApp
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            addCustomerButton = new Button();
            updateCustomerButton = new Button();
            deleteCustomerButton = new Button();
            customersLabel = new Label();
            customersDataGridView = new DataGridView();
            appointmentsDataGridView = new DataGridView();
            appointmentsLabel = new Label();
            appointmentsDeleteButton = new Button();
            appointmentsUpdateButton = new Button();
            appointmentsAddButton = new Button();
            calendarTable = new TableLayoutPanel();
            calendarLabel = new Label();
            monthYearLabel = new Label();
            nextYear = new Button();
            nextMonth = new Button();
            prevYear = new Button();
            prevMonth = new Button();
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // addCustomerButton
            // 
            resources.ApplyResources(addCustomerButton, "addCustomerButton");
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.UseVisualStyleBackColor = true;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // updateCustomerButton
            // 
            resources.ApplyResources(updateCustomerButton, "updateCustomerButton");
            updateCustomerButton.Name = "updateCustomerButton";
            updateCustomerButton.UseVisualStyleBackColor = true;
            updateCustomerButton.Click += updateCustomerButton_Click;
            // 
            // deleteCustomerButton
            // 
            resources.ApplyResources(deleteCustomerButton, "deleteCustomerButton");
            deleteCustomerButton.Name = "deleteCustomerButton";
            deleteCustomerButton.UseVisualStyleBackColor = true;
            deleteCustomerButton.Click += deleteCustomerButton_Click;
            // 
            // customersLabel
            // 
            resources.ApplyResources(customersLabel, "customersLabel");
            customersLabel.Name = "customersLabel";
            // 
            // customersDataGridView
            // 
            customersDataGridView.AllowUserToAddRows = false;
            customersDataGridView.AllowUserToDeleteRows = false;
            customersDataGridView.AllowUserToResizeColumns = false;
            customersDataGridView.AllowUserToResizeRows = false;
            customersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(customersDataGridView, "customersDataGridView");
            customersDataGridView.MultiSelect = false;
            customersDataGridView.Name = "customersDataGridView";
            customersDataGridView.RowHeadersVisible = false;
            customersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customersDataGridView.ShowEditingIcon = false;
            // 
            // appointmentsDataGridView
            // 
            appointmentsDataGridView.AllowUserToAddRows = false;
            appointmentsDataGridView.AllowUserToDeleteRows = false;
            appointmentsDataGridView.AllowUserToResizeColumns = false;
            appointmentsDataGridView.AllowUserToResizeRows = false;
            appointmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(appointmentsDataGridView, "appointmentsDataGridView");
            appointmentsDataGridView.MultiSelect = false;
            appointmentsDataGridView.Name = "appointmentsDataGridView";
            appointmentsDataGridView.RowHeadersVisible = false;
            appointmentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentsDataGridView.ShowEditingIcon = false;
            // 
            // appointmentsLabel
            // 
            resources.ApplyResources(appointmentsLabel, "appointmentsLabel");
            appointmentsLabel.Name = "appointmentsLabel";
            // 
            // appointmentsDeleteButton
            // 
            resources.ApplyResources(appointmentsDeleteButton, "appointmentsDeleteButton");
            appointmentsDeleteButton.Name = "appointmentsDeleteButton";
            appointmentsDeleteButton.UseVisualStyleBackColor = true;
            appointmentsDeleteButton.Click += appointmentsDeleteButton_Click;
            // 
            // appointmentsUpdateButton
            // 
            resources.ApplyResources(appointmentsUpdateButton, "appointmentsUpdateButton");
            appointmentsUpdateButton.Name = "appointmentsUpdateButton";
            appointmentsUpdateButton.UseVisualStyleBackColor = true;
            appointmentsUpdateButton.Click += appointmentsUpdateButton_Click;
            // 
            // appointmentsAddButton
            // 
            resources.ApplyResources(appointmentsAddButton, "appointmentsAddButton");
            appointmentsAddButton.Name = "appointmentsAddButton";
            appointmentsAddButton.UseVisualStyleBackColor = true;
            appointmentsAddButton.Click += appointmentsAddButton_Click;
            // 
            // calendarTable
            // 
            resources.ApplyResources(calendarTable, "calendarTable");
            calendarTable.Name = "calendarTable";
            // 
            // calendarLabel
            // 
            resources.ApplyResources(calendarLabel, "calendarLabel");
            calendarLabel.Name = "calendarLabel";
            // 
            // monthYearLabel
            // 
            resources.ApplyResources(monthYearLabel, "monthYearLabel");
            monthYearLabel.Name = "monthYearLabel";
            // 
            // nextYear
            // 
            resources.ApplyResources(nextYear, "nextYear");
            nextYear.Name = "nextYear";
            nextYear.UseVisualStyleBackColor = true;
            nextYear.Click += nextYear_Click;
            // 
            // nextMonth
            // 
            resources.ApplyResources(nextMonth, "nextMonth");
            nextMonth.Name = "nextMonth";
            nextMonth.UseVisualStyleBackColor = true;
            nextMonth.Click += nextMonth_Click;
            // 
            // prevYear
            // 
            resources.ApplyResources(prevYear, "prevYear");
            prevYear.Name = "prevYear";
            prevYear.UseVisualStyleBackColor = true;
            prevYear.Click += prevYear_Click;
            // 
            // prevMonth
            // 
            resources.ApplyResources(prevMonth, "prevMonth");
            prevMonth.Name = "prevMonth";
            prevMonth.UseVisualStyleBackColor = true;
            prevMonth.Click += prevMonth_Click;
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(prevYear);
            Controls.Add(prevMonth);
            Controls.Add(nextMonth);
            Controls.Add(nextYear);
            Controls.Add(monthYearLabel);
            Controls.Add(calendarLabel);
            Controls.Add(calendarTable);
            Controls.Add(appointmentsDataGridView);
            Controls.Add(appointmentsLabel);
            Controls.Add(appointmentsDeleteButton);
            Controls.Add(appointmentsUpdateButton);
            Controls.Add(appointmentsAddButton);
            Controls.Add(customersDataGridView);
            Controls.Add(customersLabel);
            Controls.Add(deleteCustomerButton);
            Controls.Add(updateCustomerButton);
            Controls.Add(addCustomerButton);
            Name = "MainScreen";
            Load += MainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addCustomerButton;
        private Button updateCustomerButton;
        private Button deleteCustomerButton;
        private Label customersLabel;
        private DataGridView customersDataGridView;
        private DataGridView appointmentsDataGridView;
        private Label appointmentsLabel;
        private Button appointmentsDeleteButton;
        private Button appointmentsUpdateButton;
        private Button appointmentsAddButton;
        private TableLayoutPanel calendarTable;
        private Label calendarLabel;
        private Label monthYearLabel;
        private Button nextYear;
        private Button nextMonth;
        private Button prevYear;
        private Button prevMonth;
    }
}