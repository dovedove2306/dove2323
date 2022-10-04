namespace project
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAlloteRoom = new Guna.UI2.WinForms.Guna2Button();
            this.txtRoomNo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDProof = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNatinolity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcontact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.txtRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Registration";
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(746, 349);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(331, 36);
            this.txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPrice.TabIndex = 54;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(755, 307);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 53;
            this.label13.Text = "Price";
            // 
            // btnAlloteRoom
            // 
            this.btnAlloteRoom.BorderRadius = 25;
            this.btnAlloteRoom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnAlloteRoom.BorderThickness = 1;
            this.btnAlloteRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAlloteRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAlloteRoom.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAlloteRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAlloteRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAlloteRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlloteRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAlloteRoom.FillColor = System.Drawing.Color.White;
            this.btnAlloteRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlloteRoom.ForeColor = System.Drawing.Color.Black;
            this.btnAlloteRoom.Location = new System.Drawing.Point(854, 403);
            this.btnAlloteRoom.Name = "btnAlloteRoom";
            this.btnAlloteRoom.Size = new System.Drawing.Size(180, 45);
            this.btnAlloteRoom.TabIndex = 52;
            this.btnAlloteRoom.Text = "Allote Room";
            this.btnAlloteRoom.Click += new System.EventHandler(this.btnAlloteRoom_Click);
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRoomNo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRoomNo.ItemHeight = 30;
            this.txtRoomNo.Location = new System.Drawing.Point(745, 253);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(331, 36);
            this.txtRoomNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRoomNo.TabIndex = 51;
            this.txtRoomNo.SelectedIndexChanged += new System.EventHandler(this.txtRoomNo_SelectedIndexChanged);
            this.txtRoomNo.Click += new System.EventHandler(this.txtRoomNo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(742, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 50;
            this.label12.Text = "Room No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(741, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Room Type";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtBed
            // 
            this.txtBed.BackColor = System.Drawing.Color.Transparent;
            this.txtBed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBed.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtBed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBed.ItemHeight = 30;
            this.txtBed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.txtBed.Location = new System.Drawing.Point(745, 70);
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(331, 36);
            this.txtBed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtBed.TabIndex = 47;
            this.txtBed.SelectedIndexChanged += new System.EventHandler(this.txtBed_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(741, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Bed";
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.Checked = true;
            this.txtCheckIn.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.txtCheckIn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.txtCheckIn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtCheckIn.Location = new System.Drawing.Point(377, 349);
            this.txtCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(331, 36);
            this.txtCheckIn.TabIndex = 45;
            this.txtCheckIn.Value = new System.DateTime(2022, 6, 27, 10, 51, 35, 90);
            this.txtCheckIn.ValueChanged += new System.EventHandler(this.txtCheckIn_ValueChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(377, 253);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "Complete Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(331, 36);
            this.txtAddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddress.TabIndex = 44;
            // 
            // txtIDProof
            // 
            this.txtIDProof.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDProof.DefaultText = "";
            this.txtIDProof.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDProof.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDProof.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProof.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProof.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProof.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProof.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDProof.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProof.Location = new System.Drawing.Point(377, 159);
            this.txtIDProof.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDProof.MaxLength = 13;
            this.txtIDProof.Name = "txtIDProof";
            this.txtIDProof.PasswordChar = '\0';
            this.txtIDProof.PlaceholderText = "Enter id";
            this.txtIDProof.SelectedText = "";
            this.txtIDProof.Size = new System.Drawing.Size(331, 26);
            this.txtIDProof.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtIDProof.TabIndex = 43;
            this.txtIDProof.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDProof_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "ID Proof";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(393, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Check in ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(393, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Address";
            // 
            // txtdate
            // 
            this.txtdate.Checked = true;
            this.txtdate.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.txtdate.CheckedState.ForeColor = System.Drawing.Color.White;
            this.txtdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(377, 53);
            this.txtdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(331, 36);
            this.txtdate.TabIndex = 39;
            this.txtdate.Value = new System.DateTime(2022, 6, 27, 11, 8, 58, 718);
            this.txtdate.ValueChanged += new System.EventHandler(this.txtdate_ValueChanged);
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.Transparent;
            this.txtGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGender.ItemHeight = 30;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.txtGender.Location = new System.Drawing.Point(16, 445);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(331, 36);
            this.txtGender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtGender.TabIndex = 38;
            // 
            // txtNatinolity
            // 
            this.txtNatinolity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNatinolity.DefaultText = "";
            this.txtNatinolity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNatinolity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNatinolity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNatinolity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNatinolity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNatinolity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNatinolity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNatinolity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNatinolity.Location = new System.Drawing.Point(16, 349);
            this.txtNatinolity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNatinolity.Name = "txtNatinolity";
            this.txtNatinolity.PasswordChar = '\0';
            this.txtNatinolity.PlaceholderText = "Nationality";
            this.txtNatinolity.SelectedText = "";
            this.txtNatinolity.Size = new System.Drawing.Size(331, 36);
            this.txtNatinolity.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNatinolity.TabIndex = 37;
            // 
            // txtcontact
            // 
            this.txtcontact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontact.DefaultText = "";
            this.txtcontact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcontact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcontact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcontact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcontact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcontact.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcontact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcontact.Location = new System.Drawing.Point(16, 255);
            this.txtcontact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcontact.MaxLength = 10;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.PasswordChar = '\0';
            this.txtcontact.PlaceholderText = "Enter Contact No";
            this.txtcontact.SelectedText = "";
            this.txtcontact.Size = new System.Drawing.Size(331, 36);
            this.txtcontact.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtcontact.TabIndex = 36;
            this.txtcontact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontact_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(16, 149);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Enter Full Name";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(331, 36);
            this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Date of Birth";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nationality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mobile No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // txtRoomType
            // 
            this.txtRoomType.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRoomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRoomType.ItemHeight = 30;
            this.txtRoomType.Items.AddRange(new object[] {
            "Ac",
            ""});
            this.txtRoomType.Location = new System.Drawing.Point(745, 149);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(331, 36);
            this.txtRoomType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRoomType.TabIndex = 55;
            this.txtRoomType.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAlloteRoom);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCheckIn);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtIDProof);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtNatinolity);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1081, 514);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Leave += new System.EventHandler(this.UserControl1_Leave);
            this.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.UserControl1_ChangeUICues);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Button btnAlloteRoom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtCheckIn;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtIDProof;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdate;
        private Guna.UI2.WinForms.Guna2ComboBox txtGender;
        private Guna.UI2.WinForms.Guna2TextBox txtNatinolity;
        private Guna.UI2.WinForms.Guna2TextBox txtcontact;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        public Guna.UI2.WinForms.Guna2ComboBox txtBed;
        public Guna.UI2.WinForms.Guna2TextBox txtPrice;
        public Guna.UI2.WinForms.Guna2ComboBox txtRoomNo;
        public Guna.UI2.WinForms.Guna2ComboBox txtRoomType;
    }
}
