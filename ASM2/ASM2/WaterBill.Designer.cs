namespace ASM2
{
    partial class WaterBill
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
            label1 = new Label();
            btnLogout = new Button();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtCurrentMonth = new TextBox();
            label6 = new Label();
            txtLastMonthWater = new TextBox();
            label5 = new Label();
            txtMember = new TextBox();
            label4 = new Label();
            cobCustomerType = new ComboBox();
            label3 = new Label();
            txtFullName = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            lstVBill = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(268, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Water Bill";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(741, 1);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(109, 32);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtCurrentMonth);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtLastMonthWater);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMember);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cobCustomerType);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(29, 81);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(798, 144);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information of customer";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(701, 108);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 22);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(492, 108);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(80, 22);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(593, 110);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 22);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(389, 108);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 22);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCurrentMonth
            // 
            txtCurrentMonth.Location = new Point(593, 70);
            txtCurrentMonth.Margin = new Padding(2);
            txtCurrentMonth.Name = "txtCurrentMonth";
            txtCurrentMonth.Size = new Size(190, 23);
            txtCurrentMonth.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(389, 74);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(175, 15);
            label6.TabIndex = 8;
            label6.Text = "Current Month Water's Number";
            label6.Click += label6_Click;
            // 
            // txtLastMonthWater
            // 
            txtLastMonthWater.Location = new Point(591, 20);
            txtLastMonthWater.Margin = new Padding(2);
            txtLastMonthWater.Name = "txtLastMonthWater";
            txtLastMonthWater.Size = new Size(190, 23);
            txtLastMonthWater.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(389, 32);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(156, 15);
            label5.TabIndex = 6;
            label5.Text = "Last Month Water's Number";
            // 
            // txtMember
            // 
            txtMember.Enabled = false;
            txtMember.Location = new Point(124, 108);
            txtMember.Margin = new Padding(2);
            txtMember.Name = "txtMember";
            txtMember.Size = new Size(234, 23);
            txtMember.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 110);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 4;
            label4.Text = "Member";
            // 
            // cobCustomerType
            // 
            cobCustomerType.FormattingEnabled = true;
            cobCustomerType.Items.AddRange(new object[] { "Household customer", "Public services", "Production units", "Business services" });
            cobCustomerType.Location = new Point(124, 68);
            cobCustomerType.Margin = new Padding(2);
            cobCustomerType.Name = "cobCustomerType";
            cobCustomerType.Size = new Size(233, 23);
            cobCustomerType.TabIndex = 3;
            cobCustomerType.SelectedIndexChanged += cobCustomerType_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 71);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 2;
            label3.Text = "Customer Type";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(124, 28);
            txtFullName.Margin = new Padding(2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(233, 23);
            txtFullName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 31);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Full name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstVBill);
            groupBox2.Location = new Point(15, 242);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(831, 214);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // lstVBill
            // 
            lstVBill.Location = new Point(12, 26);
            lstVBill.Margin = new Padding(2);
            lstVBill.Name = "lstVBill";
            lstVBill.Size = new Size(810, 182);
            lstVBill.TabIndex = 0;
            lstVBill.UseCompatibleStateImageBehavior = false;
            lstVBill.SelectedIndexChanged += lstVBill_SelectedIndexChanged;
            // 
            // WaterBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 460);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "WaterBill";
            Text = "WaterBill";
            Load += WaterBill_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private GroupBox groupBox1;
        private ComboBox cobCustomerType;
        private Label label3;
        private TextBox txtFullName;
        private Label label2;
        private TextBox txtCurrentMonth;
        private Label label6;
        private TextBox txtLastMonthWater;
        private Label label5;
        private TextBox txtMember;
        private Label label4;
        private Button btnClear;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private GroupBox groupBox2;
        private ListView lstVBill;
    }
}