namespace SchedulerApp
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            nameLabel = new Label();
            addressLine1Label = new Label();
            phoneNumberLabel = new Label();
            addressLine2Label = new Label();
            cityLabel = new Label();
            postalCodeLabel = new Label();
            countryLabel = new Label();
            activeCheckBox = new CheckBox();
            nameTextBox = new TextBox();
            addressLine1TextBox = new TextBox();
            addressLine2TextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            cityTextBox = new TextBox();
            postalCodeTextBox = new TextBox();
            countryTextBox = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            resources.ApplyResources(nameLabel, "nameLabel");
            nameLabel.Name = "nameLabel";
            // 
            // addressLine1Label
            // 
            resources.ApplyResources(addressLine1Label, "addressLine1Label");
            addressLine1Label.Name = "addressLine1Label";
            // 
            // phoneNumberLabel
            // 
            resources.ApplyResources(phoneNumberLabel, "phoneNumberLabel");
            phoneNumberLabel.Name = "phoneNumberLabel";
            // 
            // addressLine2Label
            // 
            resources.ApplyResources(addressLine2Label, "addressLine2Label");
            addressLine2Label.Name = "addressLine2Label";
            // 
            // cityLabel
            // 
            resources.ApplyResources(cityLabel, "cityLabel");
            cityLabel.Name = "cityLabel";
            // 
            // postalCodeLabel
            // 
            resources.ApplyResources(postalCodeLabel, "postalCodeLabel");
            postalCodeLabel.Name = "postalCodeLabel";
            // 
            // countryLabel
            // 
            resources.ApplyResources(countryLabel, "countryLabel");
            countryLabel.Name = "countryLabel";
            // 
            // activeCheckBox
            // 
            resources.ApplyResources(activeCheckBox, "activeCheckBox");
            activeCheckBox.Name = "activeCheckBox";
            activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            resources.ApplyResources(nameTextBox, "nameTextBox");
            nameTextBox.Name = "nameTextBox";
            nameTextBox.TextChanged += Control_Changed;
            // 
            // addressLine1TextBox
            // 
            resources.ApplyResources(addressLine1TextBox, "addressLine1TextBox");
            addressLine1TextBox.Name = "addressLine1TextBox";
            addressLine1TextBox.TextChanged += Control_Changed;
            // 
            // addressLine2TextBox
            // 
            resources.ApplyResources(addressLine2TextBox, "addressLine2TextBox");
            addressLine2TextBox.Name = "addressLine2TextBox";
            // 
            // phoneNumberTextBox
            // 
            resources.ApplyResources(phoneNumberTextBox, "phoneNumberTextBox");
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.TextChanged += phoneNumberTextBox_TextChanged;
            // 
            // cityTextBox
            // 
            resources.ApplyResources(cityTextBox, "cityTextBox");
            cityTextBox.Name = "cityTextBox";
            cityTextBox.TextChanged += Control_Changed;
            // 
            // postalCodeTextBox
            // 
            resources.ApplyResources(postalCodeTextBox, "postalCodeTextBox");
            postalCodeTextBox.Name = "postalCodeTextBox";
            postalCodeTextBox.TextChanged += Control_Changed;
            // 
            // countryTextBox
            // 
            resources.ApplyResources(countryTextBox, "countryTextBox");
            countryTextBox.Name = "countryTextBox";
            countryTextBox.TextChanged += Control_Changed;
            // 
            // saveButton
            // 
            resources.ApplyResources(saveButton, "saveButton");
            saveButton.Name = "saveButton";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            resources.ApplyResources(cancelButton, "cancelButton");
            cancelButton.Name = "cancelButton";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // CustomerForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(countryTextBox);
            Controls.Add(postalCodeTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(addressLine2TextBox);
            Controls.Add(addressLine1TextBox);
            Controls.Add(nameTextBox);
            Controls.Add(activeCheckBox);
            Controls.Add(countryLabel);
            Controls.Add(postalCodeLabel);
            Controls.Add(cityLabel);
            Controls.Add(addressLine2Label);
            Controls.Add(phoneNumberLabel);
            Controls.Add(addressLine1Label);
            Controls.Add(nameLabel);
            Name = "CustomerForm";
            Load += CustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label addressLine1Label;
        private Label phoneNumberLabel;
        private Label addressLine2Label;
        private Label cityLabel;
        private Label postalCodeLabel;
        private Label countryLabel;
        private CheckBox activeCheckBox;
        private TextBox nameTextBox;
        private TextBox addressLine1TextBox;
        private TextBox addressLine2TextBox;
        private TextBox phoneNumberTextBox;
        private TextBox cityTextBox;
        private TextBox postalCodeTextBox;
        private TextBox countryTextBox;
        private Button saveButton;
        private Button cancelButton;
    }
}