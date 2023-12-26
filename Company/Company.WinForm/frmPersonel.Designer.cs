namespace Company.WinForm
{
    partial class frmPersonel
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
            panel1 = new Panel();
            btnClear = new Button();
            lblId = new Label();
            btnGetList = new Button();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            label17 = new Label();
            label15 = new Label();
            txtCity = new TextBox();
            label16 = new Label();
            label5 = new Label();
            txtSurName = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtNo = new TextBox();
            label1 = new Label();
            dgPersonel = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPersonel).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(btnGetList);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnInsert);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(txtCity);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSurName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 285);
            panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(420, 221);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 43);
            btnClear.TabIndex = 33;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblId
            // 
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(12, 45);
            lblId.Name = "lblId";
            lblId.Size = new Size(31, 21);
            lblId.TabIndex = 32;
            lblId.Visible = false;
            // 
            // btnGetList
            // 
            btnGetList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetList.Location = new Point(420, 141);
            btnGetList.Name = "btnGetList";
            btnGetList.Size = new Size(95, 43);
            btnGetList.TabIndex = 31;
            btnGetList.Text = "GetList";
            btnGetList.UseVisualStyleBackColor = true;
            btnGetList.Click += btnGetList_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(565, 221);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(95, 43);
            btnClose.TabIndex = 30;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(565, 141);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 43);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(565, 57);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 43);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(420, 59);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(95, 43);
            btnInsert.TabIndex = 27;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(205, 14);
            label17.Name = "label17";
            label17.Size = new Size(338, 28);
            label17.TabIndex = 26;
            label17.Text = "PERSONEL INFORMATION SCREEN";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(92, 232);
            label15.Name = "label15";
            label15.Size = new Size(13, 21);
            label15.TabIndex = 24;
            label15.Text = ":";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.Location = new Point(139, 229);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(224, 29);
            txtCity.TabIndex = 23;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(12, 232);
            label16.Name = "label16";
            label16.Size = new Size(37, 21);
            label16.TabIndex = 22;
            label16.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(92, 180);
            label5.Name = "label5";
            label5.Size = new Size(13, 21);
            label5.TabIndex = 9;
            label5.Text = ":";
            // 
            // txtSurName
            // 
            txtSurName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSurName.Location = new Point(139, 177);
            txtSurName.Name = "txtSurName";
            txtSurName.Size = new Size(224, 29);
            txtSurName.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 182);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 7;
            label6.Text = "SurName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(92, 124);
            label3.Name = "label3";
            label3.Size = new Size(13, 21);
            label3.TabIndex = 6;
            label3.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(92, 68);
            label4.Name = "label4";
            label4.Size = new Size(13, 21);
            label4.TabIndex = 5;
            label4.Text = ":";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(139, 121);
            txtName.Name = "txtName";
            txtName.Size = new Size(224, 29);
            txtName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // txtNo
            // 
            txtNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNo.Location = new Point(139, 67);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(224, 29);
            txtNo.TabIndex = 2;
            txtNo.KeyPress += txtNo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 1;
            label1.Text = "No";
            // 
            // dgPersonel
            // 
            dgPersonel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPersonel.Dock = DockStyle.Bottom;
            dgPersonel.Location = new Point(0, 283);
            dgPersonel.Name = "dgPersonel";
            dgPersonel.RowTemplate.Height = 25;
            dgPersonel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPersonel.Size = new Size(704, 250);
            dgPersonel.TabIndex = 1;
            dgPersonel.CellClick += dgPersonel_CellClick;
            // 
            // frmPersonel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 533);
            Controls.Add(dgPersonel);
            Controls.Add(panel1);
            Name = "frmPersonel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Form";
            Load += frmPersonel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPersonel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private TextBox txtSurName;
        private Label label6;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private Label label2;
        private TextBox txtNo;
        private Label label1;
        private Label label15;
        private TextBox txtCity;
        private Label label16;
        private Label label17;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private DataGridView dgPersonel;
        private Button btnClose;
        private Button btnGetList;
        private Label lblId;
        private Button btnClear;
    }
}