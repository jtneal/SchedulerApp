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
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).BeginInit();
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
            customersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(customersDataGridView, "customersDataGridView");
            customersDataGridView.MultiSelect = false;
            customersDataGridView.Name = "customersDataGridView";
            customersDataGridView.RowHeadersVisible = false;
            customersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customersDataGridView.ShowEditingIcon = false;
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(customersDataGridView);
            Controls.Add(customersLabel);
            Controls.Add(deleteCustomerButton);
            Controls.Add(updateCustomerButton);
            Controls.Add(addCustomerButton);
            Name = "MainScreen";
            Load += MainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addCustomerButton;
        private Button updateCustomerButton;
        private Button deleteCustomerButton;
        private Label customersLabel;
        private DataGridView customersDataGridView;
    }
}