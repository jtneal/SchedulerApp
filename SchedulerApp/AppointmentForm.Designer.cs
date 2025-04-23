namespace SchedulerApp
{
    partial class AppointmentForm
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
            cancelButton = new Button();
            saveButton = new Button();
            customerLabel = new Label();
            customerComboBox = new ComboBox();
            typeTextBox = new TextBox();
            typeLabel = new Label();
            startLabel = new Label();
            startDateTimePicker = new DateTimePicker();
            endDateTimePicker = new DateTimePicker();
            endLabel = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 12F);
            cancelButton.ImeMode = ImeMode.NoControl;
            cancelButton.Location = new Point(330, 164);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 44);
            cancelButton.TabIndex = 35;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Enabled = false;
            saveButton.Font = new Font("Segoe UI", 12F);
            saveButton.ImeMode = ImeMode.NoControl;
            saveButton.Location = new Point(426, 164);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 44);
            saveButton.TabIndex = 34;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new Font("Segoe UI", 12F);
            customerLabel.ImeMode = ImeMode.NoControl;
            customerLabel.Location = new Point(21, 17);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(78, 21);
            customerLabel.TabIndex = 19;
            customerLabel.Text = "Customer";
            // 
            // customerComboBox
            // 
            customerComboBox.Font = new Font("Segoe UI", 12F);
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(21, 41);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(228, 29);
            customerComboBox.TabIndex = 36;
            customerComboBox.SelectedIndexChanged += Control_Changed;
            // 
            // typeTextBox
            // 
            typeTextBox.Font = new Font("Segoe UI", 12F);
            typeTextBox.Location = new Point(273, 41);
            typeTextBox.MaxLength = 50;
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(228, 29);
            typeTextBox.TabIndex = 42;
            typeTextBox.TextChanged += Control_Changed;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Segoe UI", 12F);
            typeLabel.ImeMode = ImeMode.NoControl;
            typeLabel.Location = new Point(273, 17);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(42, 21);
            typeLabel.TabIndex = 41;
            typeLabel.Text = "Type";
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Segoe UI", 12F);
            startLabel.ImeMode = ImeMode.NoControl;
            startLabel.Location = new Point(21, 90);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(118, 21);
            startLabel.TabIndex = 43;
            startLabel.Text = "Start Date/Time";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            startDateTimePicker.Font = new Font("Segoe UI", 12F);
            startDateTimePicker.Format = DateTimePickerFormat.Custom;
            startDateTimePicker.Location = new Point(21, 114);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(228, 29);
            startDateTimePicker.TabIndex = 44;
            startDateTimePicker.ValueChanged += Control_Changed;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            endDateTimePicker.Font = new Font("Segoe UI", 12F);
            endDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateTimePicker.Location = new Point(273, 114);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(228, 29);
            endDateTimePicker.TabIndex = 46;
            endDateTimePicker.ValueChanged += Control_Changed;
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Font = new Font("Segoe UI", 12F);
            endLabel.ImeMode = ImeMode.NoControl;
            endLabel.Location = new Point(273, 90);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(112, 21);
            endLabel.TabIndex = 45;
            endLabel.Text = "End Date/Time";
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(523, 229);
            Controls.Add(endDateTimePicker);
            Controls.Add(endLabel);
            Controls.Add(startDateTimePicker);
            Controls.Add(startLabel);
            Controls.Add(typeTextBox);
            Controls.Add(typeLabel);
            Controls.Add(customerComboBox);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(customerLabel);
            Name = "AppointmentForm";
            Text = "Appointment";
            Load += AppointmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button saveButton;
        private TextBox phoneNumberTextBox;
        private TextBox addressLine2TextBox;
        private TextBox addressLine1TextBox;
        private TextBox nameTextBox;
        private Label descriptionLabel;
        private Label phoneNumberLabel;
        private Label titleLabel;
        private Label customerLabel;
        private ComboBox customerComboBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox typeTextBox;
        private Label typeLabel;
        private Label startLabel;
        private DateTimePicker startDateTimePicker;
        private DateTimePicker endDateTimePicker;
        private Label endLabel;
        private TextBox textBox4;
        private Label label4;
    }
}