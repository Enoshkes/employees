namespace Employees
{
    partial class Form1 : Form
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
            btSearchWorkerByCode = new Button();
            familyStatusGroup = new Panel();
            rdbWidowed = new RadioButton();
            rdbDivorce = new RadioButton();
            rdbMarride = new RadioButton();
            rdbSingle = new RadioButton();
            genderGroup = new Panel();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            dtpDateOfBirth = new DateTimePicker();
            txtAge = new TextBox();
            lblAge = new Label();
            lblDateOfBirth = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtId = new TextBox();
            lblId = new Label();
            txtCode = new TextBox();
            lblCode = new Label();
            appTitle = new Label();
            btSearchWorkerByID = new Button();
            btDelete = new Button();
            btnUpdate = new Button();
            btAddWorker = new Button();
            btNewWorker = new Button();
            btForward = new Button();
            btBack = new Button();
            txtCity = new TextBox();
            txtStreetNumber = new TextBox();
            lblCity = new Label();
            txtCellphone = new TextBox();
            lblStreetNumber = new Label();
            lblCellphone = new Label();
            txtStreet = new TextBox();
            lblStreet = new Label();
            txtTelephone = new TextBox();
            lblTelephone = new Label();
            familyStatusGroup.SuspendLayout();
            genderGroup.SuspendLayout();
            SuspendLayout();
            // 
            // btSearchWorkerByCode
            // 
            btSearchWorkerByCode.Location = new Point(720, 590);
            btSearchWorkerByCode.Name = "btSearchWorkerByCode";
            btSearchWorkerByCode.Size = new Size(159, 42);
            btSearchWorkerByCode.TabIndex = 72;
            btSearchWorkerByCode.Text = "חיפוש עובד לפי קוד";
            btSearchWorkerByCode.UseVisualStyleBackColor = true;
            // 
            // familyStatusGroup
            // 
            familyStatusGroup.BackColor = Color.White;
            familyStatusGroup.BorderStyle = BorderStyle.Fixed3D;
            familyStatusGroup.Controls.Add(rdbWidowed);
            familyStatusGroup.Controls.Add(rdbDivorce);
            familyStatusGroup.Controls.Add(rdbMarride);
            familyStatusGroup.Controls.Add(rdbSingle);
            familyStatusGroup.Location = new Point(560, 249);
            familyStatusGroup.Name = "familyStatusGroup";
            familyStatusGroup.Size = new Size(117, 167);
            familyStatusGroup.TabIndex = 64;
            // 
            // rdbWidowed
            // 
            rdbWidowed.AutoSize = true;
            rdbWidowed.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            rdbWidowed.Location = new Point(24, 115);
            rdbWidowed.Name = "rdbWidowed";
            rdbWidowed.Size = new Size(68, 26);
            rdbWidowed.TabIndex = 0;
            rdbWidowed.TabStop = true;
            rdbWidowed.Text = "אלמן";
            rdbWidowed.UseVisualStyleBackColor = true;
            // 
            // rdbDivorce
            // 
            rdbDivorce.AutoSize = true;
            rdbDivorce.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            rdbDivorce.Location = new Point(24, 83);
            rdbDivorce.Name = "rdbDivorce";
            rdbDivorce.Size = new Size(67, 26);
            rdbDivorce.TabIndex = 0;
            rdbDivorce.TabStop = true;
            rdbDivorce.Text = "גרוש";
            rdbDivorce.UseVisualStyleBackColor = true;
            // 
            // rdbMarride
            // 
            rdbMarride.AutoSize = true;
            rdbMarride.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            rdbMarride.Location = new Point(28, 51);
            rdbMarride.Name = "rdbMarride";
            rdbMarride.Size = new Size(63, 26);
            rdbMarride.TabIndex = 0;
            rdbMarride.TabStop = true;
            rdbMarride.Text = "נשוי";
            rdbMarride.UseVisualStyleBackColor = true;
            // 
            // rdbSingle
            // 
            rdbSingle.AutoSize = true;
            rdbSingle.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            rdbSingle.Location = new Point(27, 19);
            rdbSingle.Name = "rdbSingle";
            rdbSingle.Size = new Size(64, 26);
            rdbSingle.TabIndex = 0;
            rdbSingle.TabStop = true;
            rdbSingle.Text = "רווק";
            rdbSingle.UseVisualStyleBackColor = true;
            // 
            // genderGroup
            // 
            genderGroup.BackColor = Color.White;
            genderGroup.BorderStyle = BorderStyle.Fixed3D;
            genderGroup.Controls.Add(rdbFemale);
            genderGroup.Controls.Add(rdbMale);
            genderGroup.Location = new Point(729, 248);
            genderGroup.Name = "genderGroup";
            genderGroup.Size = new Size(153, 167);
            genderGroup.TabIndex = 65;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            rdbFemale.Location = new Point(59, 56);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(69, 26);
            rdbFemale.TabIndex = 0;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "נקבה";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            rdbMale.Location = new Point(72, 24);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(56, 26);
            rdbMale.TabIndex = 0;
            rdbMale.TabStop = true;
            rdbMale.Text = "זכר";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(261, 154);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(160, 27);
            dtpDateOfBirth.TabIndex = 63;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(143, 155);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(88, 27);
            txtAge.TabIndex = 58;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            lblAge.Location = new Point(198, 116);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(33, 22);
            lblAge.TabIndex = 46;
            lblAge.Text = "גיל";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            lblDateOfBirth.Location = new Point(325, 116);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(96, 22);
            lblDateOfBirth.TabIndex = 45;
            lblDateOfBirth.Text = "תאריך לידה";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(449, 155);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(88, 27);
            txtLastName.TabIndex = 56;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            lblLastName.Location = new Point(449, 116);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(93, 22);
            lblLastName.TabIndex = 44;
            lblLastName.Text = "שם משפחה";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(589, 155);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(88, 27);
            txtFirstName.TabIndex = 55;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            lblFirstName.Location = new Point(602, 116);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(74, 22);
            lblFirstName.TabIndex = 43;
            lblFirstName.Text = "שם פרטי";
            // 
            // txtId
            // 
            txtId.Location = new Point(715, 155);
            txtId.Name = "txtId";
            txtId.Size = new Size(88, 27);
            txtId.TabIndex = 54;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            lblId.Location = new Point(715, 116);
            lblId.Name = "lblId";
            lblId.Size = new Size(92, 22);
            lblId.TabIndex = 42;
            lblId.Text = "מספר זהות";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(833, 155);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(49, 27);
            txtCode.TabIndex = 53;
            txtCode.Text = "1";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            lblCode.Location = new Point(846, 116);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(36, 22);
            lblCode.TabIndex = 47;
            lblCode.Text = "קוד";
            // 
            // appTitle
            // 
            appTitle.AutoSize = true;
            appTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 177);
            appTitle.Location = new Point(360, 18);
            appTitle.Name = "appTitle";
            appTitle.Size = new Size(241, 46);
            appTitle.TabIndex = 41;
            appTitle.Text = "רשימת עובדים";
            appTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btSearchWorkerByID
            // 
            btSearchWorkerByID.Location = new Point(512, 590);
            btSearchWorkerByID.Name = "btSearchWorkerByID";
            btSearchWorkerByID.Size = new Size(192, 42);
            btSearchWorkerByID.TabIndex = 73;
            btSearchWorkerByID.Text = "חיפוש עובד לפי מספר זהות";
            btSearchWorkerByID.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(311, 444);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(137, 52);
            btDelete.TabIndex = 71;
            btDelete.Text = "מחיקה";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += DeleteEmployee;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(459, 444);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 52);
            btnUpdate.TabIndex = 70;
            btnUpdate.Text = "עדכון";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += UpdateEmployee;
            // 
            // btAddWorker
            // 
            btAddWorker.Location = new Point(602, 444);
            btAddWorker.Name = "btAddWorker";
            btAddWorker.Size = new Size(137, 52);
            btAddWorker.TabIndex = 69;
            btAddWorker.Text = "הוספת עובד";
            btAddWorker.UseVisualStyleBackColor = true;
            btAddWorker.Click += SaveEmployee;
            // 
            // btNewWorker
            // 
            btNewWorker.Location = new Point(745, 444);
            btNewWorker.Name = "btNewWorker";
            btNewWorker.Size = new Size(137, 52);
            btNewWorker.TabIndex = 68;
            btNewWorker.Text = "חדש";
            btNewWorker.UseVisualStyleBackColor = true;
            btNewWorker.Click += NewEmployee;
            // 
            // btForward
            // 
            btForward.Location = new Point(635, 525);
            btForward.Name = "btForward";
            btForward.Size = new Size(117, 46);
            btForward.TabIndex = 67;
            btForward.Text = ">>>>";
            btForward.UseVisualStyleBackColor = true;
            btForward.Click += NextClick;
            // 
            // btBack
            // 
            btBack.Enabled = false;
            btBack.Location = new Point(771, 525);
            btBack.Name = "btBack";
            btBack.Size = new Size(111, 49);
            btBack.TabIndex = 66;
            btBack.Text = "<<<<";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += PrevClick;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(76, 249);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(88, 27);
            txtCity.TabIndex = 60;
            // 
            // txtStreetNumber
            // 
            txtStreetNumber.Location = new Point(170, 248);
            txtStreetNumber.Name = "txtStreetNumber";
            txtStreetNumber.Size = new Size(88, 27);
            txtStreetNumber.TabIndex = 62;
            txtStreetNumber.KeyPress += OnNumericTextBoxKeyPress;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            lblCity.Location = new Point(128, 224);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(36, 22);
            lblCity.TabIndex = 52;
            lblCity.Text = "עיר";
            // 
            // txtCellphone
            // 
            txtCellphone.Location = new Point(360, 249);
            txtCellphone.Name = "txtCellphone";
            txtCellphone.Size = new Size(88, 27);
            txtCellphone.TabIndex = 57;
            // 
            // lblStreetNumber
            // 
            lblStreetNumber.AutoSize = true;
            lblStreetNumber.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            lblStreetNumber.Location = new Point(207, 222);
            lblStreetNumber.Name = "lblStreetNumber";
            lblStreetNumber.Size = new Size(51, 22);
            lblStreetNumber.TabIndex = 50;
            lblStreetNumber.Text = "מספר";
            // 
            // lblCellphone
            // 
            lblCellphone.AutoSize = true;
            lblCellphone.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            lblCellphone.Location = new Point(410, 222);
            lblCellphone.Name = "lblCellphone";
            lblCellphone.Size = new Size(38, 22);
            lblCellphone.TabIndex = 49;
            lblCellphone.Text = "נייד";
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(266, 249);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(88, 27);
            txtStreet.TabIndex = 61;
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            lblStreet.Location = new Point(307, 222);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(47, 22);
            lblStreet.TabIndex = 48;
            lblStreet.Text = "רחוב";
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(454, 249);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(88, 27);
            txtTelephone.TabIndex = 59;
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 177);
            lblTelephone.Location = new Point(489, 222);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(53, 22);
            lblTelephone.TabIndex = 51;
            lblTelephone.Text = "טלפון";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 663);
            Controls.Add(btSearchWorkerByCode);
            Controls.Add(familyStatusGroup);
            Controls.Add(genderGroup);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(lblDateOfBirth);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtCode);
            Controls.Add(lblCode);
            Controls.Add(appTitle);
            Controls.Add(btSearchWorkerByID);
            Controls.Add(btDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btAddWorker);
            Controls.Add(btNewWorker);
            Controls.Add(btForward);
            Controls.Add(btBack);
            Controls.Add(txtCity);
            Controls.Add(txtStreetNumber);
            Controls.Add(lblCity);
            Controls.Add(txtCellphone);
            Controls.Add(lblStreetNumber);
            Controls.Add(lblCellphone);
            Controls.Add(txtStreet);
            Controls.Add(lblStreet);
            Controls.Add(txtTelephone);
            Controls.Add(lblTelephone);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(935, 710);
            MinimumSize = new Size(935, 710);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "רשימת עובדים";
            familyStatusGroup.ResumeLayout(false);
            familyStatusGroup.PerformLayout();
            genderGroup.ResumeLayout(false);
            genderGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btSearchWorkerByCode;
        private System.Windows.Forms.Panel familyStatusGroup;
        private System.Windows.Forms.RadioButton rdbWidowed;
        private System.Windows.Forms.RadioButton rdbDivorce;
        private System.Windows.Forms.RadioButton rdbMarride;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.Panel genderGroup;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Button btSearchWorkerByID;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btAddWorker;
        private System.Windows.Forms.Button btNewWorker;
        private System.Windows.Forms.Button btForward;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreetNumber;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label lblStreetNumber;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
    }
}