namespace CST_150_DogClass.PresentationLayer
{
    partial class FrmMain
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
            btnAddDog = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbSit = new ComboBox();
            txtName = new TextBox();
            txtNeck = new TextBox();
            txtColor = new TextBox();
            grbAttributes = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            txtWeight = new TextBox();
            gvShowDogs = new DataGridView();
            lblErrorMessage = new Label();
            grbAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvShowDogs).BeginInit();
            SuspendLayout();
            // 
            // btnAddDog
            // 
            btnAddDog.AutoSize = true;
            btnAddDog.Location = new Point(103, 54);
            btnAddDog.Name = "btnAddDog";
            btnAddDog.Size = new Size(116, 28);
            btnAddDog.TabIndex = 0;
            btnAddDog.Text = "Add New Dog";
            btnAddDog.UseVisualStyleBackColor = true;
            btnAddDog.Click += BtnAddNewDog_ClickEvent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 46);
            label1.Name = "label1";
            label1.Size = new Size(84, 18);
            label1.TabIndex = 1;
            label1.Text = "Dog Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 85);
            label2.Name = "label2";
            label2.Size = new Size(97, 18);
            label2.TabIndex = 2;
            label2.Text = "Neck Radius";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 129);
            label3.Name = "label3";
            label3.Size = new Size(52, 18);
            label3.TabIndex = 3;
            label3.Text = "Sitting";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 171);
            label4.Name = "label4";
            label4.Size = new Size(46, 18);
            label4.TabIndex = 4;
            label4.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(262, 85);
            label5.Name = "label5";
            label5.Size = new Size(53, 18);
            label5.TabIndex = 5;
            label5.Text = "inches";
            // 
            // cmbSit
            // 
            cmbSit.FormattingEnabled = true;
            cmbSit.Items.AddRange(new object[] { "Yes", "No" });
            cmbSit.Location = new Point(137, 121);
            cmbSit.Name = "cmbSit";
            cmbSit.Size = new Size(121, 26);
            cmbSit.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(137, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 26);
            txtName.TabIndex = 7;
            // 
            // txtNeck
            // 
            txtNeck.Location = new Point(137, 77);
            txtNeck.Name = "txtNeck";
            txtNeck.Size = new Size(100, 26);
            txtNeck.TabIndex = 8;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(137, 163);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 26);
            txtColor.TabIndex = 9;
            // 
            // grbAttributes
            // 
            grbAttributes.Controls.Add(label7);
            grbAttributes.Controls.Add(label6);
            grbAttributes.Controls.Add(txtWeight);
            grbAttributes.Controls.Add(cmbSit);
            grbAttributes.Controls.Add(txtColor);
            grbAttributes.Controls.Add(label1);
            grbAttributes.Controls.Add(txtNeck);
            grbAttributes.Controls.Add(label2);
            grbAttributes.Controls.Add(txtName);
            grbAttributes.Controls.Add(label3);
            grbAttributes.Controls.Add(label4);
            grbAttributes.Controls.Add(label5);
            grbAttributes.Location = new Point(103, 100);
            grbAttributes.Name = "grbAttributes";
            grbAttributes.Size = new Size(345, 294);
            grbAttributes.TabIndex = 10;
            grbAttributes.TabStop = false;
            grbAttributes.Text = "Dog Attributes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(262, 215);
            label7.Name = "label7";
            label7.Size = new Size(59, 18);
            label7.TabIndex = 12;
            label7.Text = "pounds";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 215);
            label6.Name = "label6";
            label6.Size = new Size(57, 18);
            label6.TabIndex = 11;
            label6.Text = "Weight";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(137, 207);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 26);
            txtWeight.TabIndex = 10;
            // 
            // gvShowDogs
            // 
            gvShowDogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvShowDogs.Location = new Point(467, 100);
            gvShowDogs.Name = "gvShowDogs";
            gvShowDogs.RowTemplate.Height = 25;
            gvShowDogs.Size = new Size(550, 294);
            gvShowDogs.TabIndex = 11;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(101, 422);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(357, 18);
            lblErrorMessage.TabIndex = 12;
            lblErrorMessage.Text = "Please fix the incorrect data entry...Then try agian...";
            lblErrorMessage.Visible = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 540);
            Controls.Add(lblErrorMessage);
            Controls.Add(gvShowDogs);
            Controls.Add(grbAttributes);
            Controls.Add(btnAddDog);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmMain";
            Text = "FrmMain";
            grbAttributes.ResumeLayout(false);
            grbAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvShowDogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddDog;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbSit;
        private TextBox txtName;
        private TextBox txtNeck;
        private TextBox txtColor;
        private GroupBox grbAttributes;
        private DataGridView gvShowDogs;
        private Label label7;
        private Label label6;
        private TextBox txtWeight;
        private Label lblErrorMessage;
    }
}