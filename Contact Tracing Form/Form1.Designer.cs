namespace Contact_Tracing_Form
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtboxTime = new System.Windows.Forms.TextBox();
            this.lblPersonalInfo = new System.Windows.Forms.Label();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.lblMI = new System.Windows.Forms.Label();
            this.txtboxMiddleInitial = new System.Windows.Forms.TextBox();
            this.lblSN = new System.Windows.Forms.Label();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.txtboxSuffix = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.txtboxBirthdate = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtboxAge = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtboxSex = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtboxProvince = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtboxCity = new System.Windows.Forms.TextBox();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.txtboxStreetName = new System.Windows.Forms.TextBox();
            this.txtboxBarangay = new System.Windows.Forms.TextBox();
            this.lblBarangay = new System.Windows.Forms.Label();
            this.lblEmailAdd = new System.Windows.Forms.Label();
            this.txtboxEmailAdd = new System.Windows.Forms.TextBox();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.txtboxMobileNum = new System.Windows.Forms.TextBox();
            this.bttnSubmit = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.bttnAdminSignIn = new System.Windows.Forms.Button();
            this.bttnGenerate = new System.Windows.Forms.Button();
            this.bttnScan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(275, 19);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(193, 23);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Contact Tracing Form";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(13, 66);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(378, 16);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Kindly provide the needed information accurately and honestly.";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 107);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(146, 15);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date (MM//DD//YY):";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxDate
            // 
            this.txtboxDate.Location = new System.Drawing.Point(164, 102);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.Size = new System.Drawing.Size(260, 20);
            this.txtboxDate.TabIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(500, 104);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 15);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time:";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxTime
            // 
            this.txtboxTime.Location = new System.Drawing.Point(549, 102);
            this.txtboxTime.Name = "txtboxTime";
            this.txtboxTime.Size = new System.Drawing.Size(168, 20);
            this.txtboxTime.TabIndex = 6;
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.AutoSize = true;
            this.lblPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalInfo.Location = new System.Drawing.Point(13, 145);
            this.lblPersonalInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.Size = new System.Drawing.Size(153, 16);
            this.lblPersonalInfo.TabIndex = 7;
            this.lblPersonalInfo.Text = "Personal Information:\r\n";
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction1.Location = new System.Drawing.Point(174, 147);
            this.lblInstruction1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(124, 13);
            this.lblInstruction1.TabIndex = 45;
            this.lblInstruction1.Text = "(Put NA if not applicable)\r\n";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.BackColor = System.Drawing.Color.Transparent;
            this.lblFN.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.Location = new System.Drawing.Point(13, 177);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(71, 15);
            this.lblFN.TabIndex = 46;
            this.lblFN.Text = "First Name:";
            this.lblFN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Location = new System.Drawing.Point(90, 172);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(177, 20);
            this.txtboxFirstName.TabIndex = 47;
            // 
            // lblMI
            // 
            this.lblMI.AutoSize = true;
            this.lblMI.BackColor = System.Drawing.Color.Transparent;
            this.lblMI.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMI.Location = new System.Drawing.Point(306, 177);
            this.lblMI.Name = "lblMI";
            this.lblMI.Size = new System.Drawing.Size(85, 15);
            this.lblMI.TabIndex = 48;
            this.lblMI.Text = "Middle Initial:";
            this.lblMI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxMiddleInitial
            // 
            this.txtboxMiddleInitial.Location = new System.Drawing.Point(397, 172);
            this.txtboxMiddleInitial.Name = "txtboxMiddleInitial";
            this.txtboxMiddleInitial.Size = new System.Drawing.Size(48, 20);
            this.txtboxMiddleInitial.TabIndex = 49;
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.BackColor = System.Drawing.Color.Transparent;
            this.lblSN.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSN.Location = new System.Drawing.Point(470, 177);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(58, 15);
            this.lblSN.TabIndex = 50;
            this.lblSN.Text = "Surname:";
            this.lblSN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.Location = new System.Drawing.Point(535, 172);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(111, 20);
            this.txtboxSurname.TabIndex = 51;
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.BackColor = System.Drawing.Color.Transparent;
            this.lblSuffix.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuffix.Location = new System.Drawing.Point(662, 177);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(41, 15);
            this.lblSuffix.TabIndex = 52;
            this.lblSuffix.Text = "Suffix:";
            this.lblSuffix.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxSuffix
            // 
            this.txtboxSuffix.Location = new System.Drawing.Point(709, 172);
            this.txtboxSuffix.Name = "txtboxSuffix";
            this.txtboxSuffix.Size = new System.Drawing.Size(72, 20);
            this.txtboxSuffix.TabIndex = 53;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthdate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(13, 209);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(153, 15);
            this.lblBirthdate.TabIndex = 54;
            this.lblBirthdate.Text = "Birth Date (mm//dd//yy):";
            this.lblBirthdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxBirthdate
            // 
            this.txtboxBirthdate.Location = new System.Drawing.Point(172, 204);
            this.txtboxBirthdate.Name = "txtboxBirthdate";
            this.txtboxBirthdate.Size = new System.Drawing.Size(157, 20);
            this.txtboxBirthdate.TabIndex = 55;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(421, 209);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(30, 15);
            this.lblAge.TabIndex = 56;
            this.lblAge.Text = "Age:";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxAge
            // 
            this.txtboxAge.Location = new System.Drawing.Point(457, 204);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.Size = new System.Drawing.Size(86, 20);
            this.txtboxAge.TabIndex = 57;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            this.lblSex.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(631, 209);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(28, 15);
            this.lblSex.TabIndex = 58;
            this.lblSex.Text = "Sex:";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxSex
            // 
            this.txtboxSex.Location = new System.Drawing.Point(665, 204);
            this.txtboxSex.Name = "txtboxSex";
            this.txtboxSex.Size = new System.Drawing.Size(116, 20);
            this.txtboxSex.TabIndex = 59;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.BackColor = System.Drawing.Color.Transparent;
            this.lblProvince.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(13, 238);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(59, 15);
            this.lblProvince.TabIndex = 60;
            this.lblProvince.Text = "Province:";
            this.lblProvince.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxProvince
            // 
            this.txtboxProvince.Location = new System.Drawing.Point(78, 233);
            this.txtboxProvince.Name = "txtboxProvince";
            this.txtboxProvince.Size = new System.Drawing.Size(114, 20);
            this.txtboxProvince.TabIndex = 61;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(201, 238);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 15);
            this.lblCity.TabIndex = 62;
            this.lblCity.Text = "City:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxCity
            // 
            this.txtboxCity.Location = new System.Drawing.Point(236, 233);
            this.txtboxCity.Name = "txtboxCity";
            this.txtboxCity.Size = new System.Drawing.Size(138, 20);
            this.txtboxCity.TabIndex = 63;
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.BackColor = System.Drawing.Color.Transparent;
            this.lblStreetName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.Location = new System.Drawing.Point(382, 238);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(76, 15);
            this.lblStreetName.TabIndex = 64;
            this.lblStreetName.Text = "Street Name:";
            this.lblStreetName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxStreetName
            // 
            this.txtboxStreetName.Location = new System.Drawing.Point(461, 233);
            this.txtboxStreetName.Name = "txtboxStreetName";
            this.txtboxStreetName.Size = new System.Drawing.Size(122, 20);
            this.txtboxStreetName.TabIndex = 65;
            // 
            // txtboxBarangay
            // 
            this.txtboxBarangay.Location = new System.Drawing.Point(670, 233);
            this.txtboxBarangay.Name = "txtboxBarangay";
            this.txtboxBarangay.Size = new System.Drawing.Size(111, 20);
            this.txtboxBarangay.TabIndex = 66;
            // 
            // lblBarangay
            // 
            this.lblBarangay.AutoSize = true;
            this.lblBarangay.BackColor = System.Drawing.Color.Transparent;
            this.lblBarangay.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarangay.Location = new System.Drawing.Point(598, 238);
            this.lblBarangay.Name = "lblBarangay";
            this.lblBarangay.Size = new System.Drawing.Size(61, 15);
            this.lblBarangay.TabIndex = 67;
            this.lblBarangay.Text = "Barangay:";
            this.lblBarangay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmailAdd
            // 
            this.lblEmailAdd.AutoSize = true;
            this.lblEmailAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailAdd.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAdd.Location = new System.Drawing.Point(12, 266);
            this.lblEmailAdd.Name = "lblEmailAdd";
            this.lblEmailAdd.Size = new System.Drawing.Size(90, 15);
            this.lblEmailAdd.TabIndex = 68;
            this.lblEmailAdd.Text = "Email Address:";
            this.lblEmailAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxEmailAdd
            // 
            this.txtboxEmailAdd.Location = new System.Drawing.Point(108, 261);
            this.txtboxEmailAdd.Name = "txtboxEmailAdd";
            this.txtboxEmailAdd.Size = new System.Drawing.Size(239, 20);
            this.txtboxEmailAdd.TabIndex = 69;
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblMobileNumber.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileNumber.Location = new System.Drawing.Point(500, 266);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(97, 15);
            this.lblMobileNumber.TabIndex = 70;
            this.lblMobileNumber.Text = "Mobile Number:";
            this.lblMobileNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMobileNumber.Click += new System.EventHandler(this.lblMobileNumber_Click);
            // 
            // txtboxMobileNum
            // 
            this.txtboxMobileNum.Location = new System.Drawing.Point(613, 261);
            this.txtboxMobileNum.Name = "txtboxMobileNum";
            this.txtboxMobileNum.Size = new System.Drawing.Size(167, 20);
            this.txtboxMobileNum.TabIndex = 71;
            // 
            // bttnSubmit
            // 
            this.bttnSubmit.BackColor = System.Drawing.Color.RosyBrown;
            this.bttnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubmit.Location = new System.Drawing.Point(164, 309);
            this.bttnSubmit.Name = "bttnSubmit";
            this.bttnSubmit.Size = new System.Drawing.Size(165, 32);
            this.bttnSubmit.TabIndex = 72;
            this.bttnSubmit.Text = "Submit";
            this.bttnSubmit.UseVisualStyleBackColor = false;
            this.bttnSubmit.Click += new System.EventHandler(this.bttnSubmit_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAdmin.Location = new System.Drawing.Point(430, 309);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(98, 32);
            this.lblAdmin.TabIndex = 73;
            this.lblAdmin.Text = "For admin only:\r\n\r\n";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(441, 341);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 15);
            this.lblUsername.TabIndex = 74;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(521, 336);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(125, 20);
            this.txtboxUsername.TabIndex = 75;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(442, 369);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 15);
            this.lblPassword.TabIndex = 76;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(521, 367);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(125, 20);
            this.txtboxPassword.TabIndex = 77;
            // 
            // bttnAdminSignIn
            // 
            this.bttnAdminSignIn.BackColor = System.Drawing.Color.DimGray;
            this.bttnAdminSignIn.Location = new System.Drawing.Point(642, 406);
            this.bttnAdminSignIn.Name = "bttnAdminSignIn";
            this.bttnAdminSignIn.Size = new System.Drawing.Size(138, 32);
            this.bttnAdminSignIn.TabIndex = 78;
            this.bttnAdminSignIn.Text = "Sign In";
            this.bttnAdminSignIn.UseVisualStyleBackColor = false;
            this.bttnAdminSignIn.Click += new System.EventHandler(this.bttnAdminSignIn_Click);
            // 
            // bttnGenerate
            // 
            this.bttnGenerate.BackColor = System.Drawing.Color.Salmon;
            this.bttnGenerate.Location = new System.Drawing.Point(16, 379);
            this.bttnGenerate.Name = "bttnGenerate";
            this.bttnGenerate.Size = new System.Drawing.Size(176, 32);
            this.bttnGenerate.TabIndex = 79;
            this.bttnGenerate.Text = "Generate Qr Code";
            this.bttnGenerate.UseVisualStyleBackColor = false;
            this.bttnGenerate.Click += new System.EventHandler(this.bttnGenerate_Click);
            // 
            // bttnScan
            // 
            this.bttnScan.BackColor = System.Drawing.Color.Salmon;
            this.bttnScan.Location = new System.Drawing.Point(221, 379);
            this.bttnScan.Name = "bttnScan";
            this.bttnScan.Size = new System.Drawing.Size(170, 32);
            this.bttnScan.TabIndex = 80;
            this.bttnScan.Text = "Scan Qr Code";
            this.bttnScan.UseVisualStyleBackColor = false;
            this.bttnScan.Click += new System.EventHandler(this.bttnScan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnScan);
            this.Controls.Add(this.bttnGenerate);
            this.Controls.Add(this.bttnAdminSignIn);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.bttnSubmit);
            this.Controls.Add(this.txtboxMobileNum);
            this.Controls.Add(this.lblMobileNumber);
            this.Controls.Add(this.txtboxEmailAdd);
            this.Controls.Add(this.lblEmailAdd);
            this.Controls.Add(this.lblBarangay);
            this.Controls.Add(this.txtboxBarangay);
            this.Controls.Add(this.txtboxStreetName);
            this.Controls.Add(this.lblStreetName);
            this.Controls.Add(this.txtboxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtboxProvince);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.txtboxSex);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtboxBirthdate);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.txtboxSuffix);
            this.Controls.Add(this.lblSuffix);
            this.Controls.Add(this.txtboxSurname);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.txtboxMiddleInitial);
            this.Controls.Add(this.lblMI);
            this.Controls.Add(this.txtboxFirstName);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.lblInstruction1);
            this.Controls.Add(this.lblPersonalInfo);
            this.Controls.Add(this.txtboxTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lbltitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Contact Tracing Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtboxTime;
        private System.Windows.Forms.Label lblPersonalInfo;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.Label lblMI;
        private System.Windows.Forms.TextBox txtboxMiddleInitial;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.TextBox txtboxSurname;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.TextBox txtboxSuffix;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.TextBox txtboxBirthdate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtboxAge;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtboxSex;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtboxProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtboxCity;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.TextBox txtboxStreetName;
        private System.Windows.Forms.TextBox txtboxBarangay;
        private System.Windows.Forms.Label lblBarangay;
        private System.Windows.Forms.Label lblEmailAdd;
        private System.Windows.Forms.TextBox txtboxEmailAdd;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.TextBox txtboxMobileNum;
        private System.Windows.Forms.Button bttnSubmit;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Button bttnAdminSignIn;
        private System.Windows.Forms.Button bttnGenerate;
        private System.Windows.Forms.Button bttnScan;
    }
}

