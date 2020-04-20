namespace WinForms
{
	partial class MainForm
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
			if(disposing && (components != null))
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
			this._pnlMain = new System.Windows.Forms.Panel();
			this._txtYourName = new System.Windows.Forms.Label();
			this._btnSave = new System.Windows.Forms.Button();
			this._btnOpenDirectory = new System.Windows.Forms.Button();
			this._txtFile = new System.Windows.Forms.TextBox();
			this._btnOpenFile = new System.Windows.Forms.Button();
			this._txtH20 = new System.Windows.Forms.Label();
			this._cmbEnterH20 = new System.Windows.Forms.ComboBox();
			this._txtHistory = new System.Windows.Forms.Label();
			this._cmbEnterHistory = new System.Windows.Forms.ComboBox();
			this._txtRus = new System.Windows.Forms.Label();
			this._cmbEnterRus = new System.Windows.Forms.ComboBox();
			this._txtMath = new System.Windows.Forms.Label();
			this._cmbEnterMath = new System.Windows.Forms.ComboBox();
			this._rdiPeople = new System.Windows.Forms.RadioButton();
			this._rdiTeeneger = new System.Windows.Forms.RadioButton();
			this._rdiKids = new System.Windows.Forms.RadioButton();
			this._txtEnterLastName = new System.Windows.Forms.TextBox();
			this._txtEnterName = new System.Windows.Forms.TextBox();
			this._txtName = new System.Windows.Forms.Label();
			this._txtLastName = new System.Windows.Forms.Label();
			this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this._pnlMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// _pnlMain
			// 
			this._pnlMain.Controls.Add(this._txtYourName);
			this._pnlMain.Controls.Add(this._btnSave);
			this._pnlMain.Controls.Add(this._btnOpenDirectory);
			this._pnlMain.Controls.Add(this._txtFile);
			this._pnlMain.Controls.Add(this._btnOpenFile);
			this._pnlMain.Controls.Add(this._txtH20);
			this._pnlMain.Controls.Add(this._cmbEnterH20);
			this._pnlMain.Controls.Add(this._txtHistory);
			this._pnlMain.Controls.Add(this._cmbEnterHistory);
			this._pnlMain.Controls.Add(this._txtRus);
			this._pnlMain.Controls.Add(this._cmbEnterRus);
			this._pnlMain.Controls.Add(this._txtMath);
			this._pnlMain.Controls.Add(this._cmbEnterMath);
			this._pnlMain.Controls.Add(this._rdiPeople);
			this._pnlMain.Controls.Add(this._rdiTeeneger);
			this._pnlMain.Controls.Add(this._rdiKids);
			this._pnlMain.Controls.Add(this._txtEnterLastName);
			this._pnlMain.Controls.Add(this._txtEnterName);
			this._pnlMain.Controls.Add(this._txtName);
			this._pnlMain.Controls.Add(this._txtLastName);
			this._pnlMain.Location = new System.Drawing.Point(12, 12);
			this._pnlMain.Name = "_pnlMain";
			this._pnlMain.Size = new System.Drawing.Size(480, 282);
			this._pnlMain.TabIndex = 0;
			// 
			// _txtYourName
			// 
			this._txtYourName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._txtYourName.AutoSize = true;
			this._txtYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtYourName.Location = new System.Drawing.Point(21, 12);
			this._txtYourName.Name = "_txtYourName";
			this._txtYourName.Size = new System.Drawing.Size(40, 20);
			this._txtYourName.TabIndex = 18;
			this._txtYourName.Text = "Имя";
			// 
			// _btnSave
			// 
			this._btnSave.Location = new System.Drawing.Point(315, 242);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(111, 23);
			this._btnSave.TabIndex = 17;
			this._btnSave.Text = "Записать";
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// _btnOpenDirectory
			// 
			this._btnOpenDirectory.Location = new System.Drawing.Point(285, 51);
			this._btnOpenDirectory.Name = "_btnOpenDirectory";
			this._btnOpenDirectory.Size = new System.Drawing.Size(111, 23);
			this._btnOpenDirectory.TabIndex = 16;
			this._btnOpenDirectory.Text = "Открыть папку";
			this._btnOpenDirectory.UseVisualStyleBackColor = true;
			this._btnOpenDirectory.Click += new System.EventHandler(this.OpenDirectory);
			// 
			// _txtFile
			// 
			this._txtFile.Location = new System.Drawing.Point(285, 82);
			this._txtFile.Name = "_txtFile";
			this._txtFile.Size = new System.Drawing.Size(179, 20);
			this._txtFile.TabIndex = 15;
			// 
			// _btnOpenFile
			// 
			this._btnOpenFile.Location = new System.Drawing.Point(285, 15);
			this._btnOpenFile.Name = "_btnOpenFile";
			this._btnOpenFile.Size = new System.Drawing.Size(111, 23);
			this._btnOpenFile.TabIndex = 1;
			this._btnOpenFile.Text = "Открыть файл";
			this._btnOpenFile.UseVisualStyleBackColor = true;
			this._btnOpenFile.Click += new System.EventHandler(this.OpenFile);
			// 
			// _txtH20
			// 
			this._txtH20.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._txtH20.AutoSize = true;
			this._txtH20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtH20.Location = new System.Drawing.Point(155, 216);
			this._txtH20.Name = "_txtH20";
			this._txtH20.Size = new System.Drawing.Size(58, 20);
			this._txtH20.TabIndex = 14;
			this._txtH20.Text = "Химия";
			// 
			// _cmbEnterH20
			// 
			this._cmbEnterH20.FormattingEnabled = true;
			this._cmbEnterH20.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this._cmbEnterH20.Location = new System.Drawing.Point(150, 244);
			this._cmbEnterH20.Name = "_cmbEnterH20";
			this._cmbEnterH20.Size = new System.Drawing.Size(121, 21);
			this._cmbEnterH20.TabIndex = 13;
			// 
			// _txtHistory
			// 
			this._txtHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._txtHistory.AutoSize = true;
			this._txtHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtHistory.Location = new System.Drawing.Point(19, 216);
			this._txtHistory.Name = "_txtHistory";
			this._txtHistory.Size = new System.Drawing.Size(73, 20);
			this._txtHistory.TabIndex = 12;
			this._txtHistory.Text = "История";
			// 
			// _cmbEnterHistory
			// 
			this._cmbEnterHistory.FormattingEnabled = true;
			this._cmbEnterHistory.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this._cmbEnterHistory.Location = new System.Drawing.Point(14, 244);
			this._cmbEnterHistory.Name = "_cmbEnterHistory";
			this._cmbEnterHistory.Size = new System.Drawing.Size(121, 21);
			this._cmbEnterHistory.TabIndex = 11;
			// 
			// _txtRus
			// 
			this._txtRus.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._txtRus.AutoSize = true;
			this._txtRus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtRus.Location = new System.Drawing.Point(157, 155);
			this._txtRus.Name = "_txtRus";
			this._txtRus.Size = new System.Drawing.Size(108, 20);
			this._txtRus.TabIndex = 10;
			this._txtRus.Text = "Русский язык";
			// 
			// _cmbEnterRus
			// 
			this._cmbEnterRus.FormattingEnabled = true;
			this._cmbEnterRus.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this._cmbEnterRus.Location = new System.Drawing.Point(152, 183);
			this._cmbEnterRus.Name = "_cmbEnterRus";
			this._cmbEnterRus.Size = new System.Drawing.Size(121, 21);
			this._cmbEnterRus.TabIndex = 9;
			// 
			// _txtMath
			// 
			this._txtMath.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._txtMath.AutoSize = true;
			this._txtMath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtMath.Location = new System.Drawing.Point(21, 155);
			this._txtMath.Name = "_txtMath";
			this._txtMath.Size = new System.Drawing.Size(104, 20);
			this._txtMath.TabIndex = 8;
			this._txtMath.Text = "Математика";
			// 
			// _cmbEnterMath
			// 
			this._cmbEnterMath.FormattingEnabled = true;
			this._cmbEnterMath.Location = new System.Drawing.Point(16, 183);
			this._cmbEnterMath.Name = "_cmbEnterMath";
			this._cmbEnterMath.Size = new System.Drawing.Size(121, 21);
			this._cmbEnterMath.TabIndex = 7;
			// 
			// _rdiPeople
			// 
			this._rdiPeople.AutoSize = true;
			this._rdiPeople.Location = new System.Drawing.Point(16, 129);
			this._rdiPeople.Name = "_rdiPeople";
			this._rdiPeople.Size = new System.Drawing.Size(79, 17);
			this._rdiPeople.TabIndex = 6;
			this._rdiPeople.TabStop = true;
			this._rdiPeople.Text = "8-11 класс";
			this._rdiPeople.UseVisualStyleBackColor = true;
			// 
			// _rdiTeeneger
			// 
			this._rdiTeeneger.AutoSize = true;
			this._rdiTeeneger.Location = new System.Drawing.Point(16, 106);
			this._rdiTeeneger.Name = "_rdiTeeneger";
			this._rdiTeeneger.Size = new System.Drawing.Size(73, 17);
			this._rdiTeeneger.TabIndex = 5;
			this._rdiTeeneger.TabStop = true;
			this._rdiTeeneger.Text = "5-7 класс";
			this._rdiTeeneger.UseVisualStyleBackColor = true;
			// 
			// _rdiKids
			// 
			this._rdiKids.AutoSize = true;
			this._rdiKids.Location = new System.Drawing.Point(16, 83);
			this._rdiKids.Name = "_rdiKids";
			this._rdiKids.Size = new System.Drawing.Size(73, 17);
			this._rdiKids.TabIndex = 4;
			this._rdiKids.TabStop = true;
			this._rdiKids.Text = "1-4 класс";
			this._rdiKids.UseVisualStyleBackColor = true;
			// 
			// _txtEnterLastName
			// 
			this._txtEnterLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._txtEnterLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtEnterLastName.Location = new System.Drawing.Point(108, 38);
			this._txtEnterLastName.Name = "_txtEnterLastName";
			this._txtEnterLastName.Size = new System.Drawing.Size(100, 22);
			this._txtEnterLastName.TabIndex = 3;
			// 
			// _txtEnterName
			// 
			this._txtEnterName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._txtEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtEnterName.Location = new System.Drawing.Point(108, 10);
			this._txtEnterName.Name = "_txtEnterName";
			this._txtEnterName.Size = new System.Drawing.Size(100, 22);
			this._txtEnterName.TabIndex = 1;
			this._txtEnterName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtEnterName_KeyPress);
			// 
			// _txtName
			// 
			this._txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._txtName.AutoSize = true;
			this._txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtName.Location = new System.Drawing.Point(21, 10);
			this._txtName.Name = "_txtName";
			this._txtName.Size = new System.Drawing.Size(0, 20);
			this._txtName.TabIndex = 0;
			// 
			// _txtLastName
			// 
			this._txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._txtLastName.AutoSize = true;
			this._txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtLastName.Location = new System.Drawing.Point(21, 38);
			this._txtLastName.Name = "_txtLastName";
			this._txtLastName.Size = new System.Drawing.Size(81, 20);
			this._txtLastName.TabIndex = 2;
			this._txtLastName.Text = "Фамилия";
			// 
			// _openFileDialog
			// 
			this._openFileDialog.FileName = "openFileDialog1";
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(12, 323);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(749, 150);
			this.dataGridView.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(773, 530);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this._pnlMain);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this._pnlMain.ResumeLayout(false);
			this._pnlMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel _pnlMain;
		private System.Windows.Forms.TextBox _txtEnterLastName;
		private System.Windows.Forms.Label _txtLastName;
		private System.Windows.Forms.TextBox _txtEnterName;
		private System.Windows.Forms.Label _txtName;
		private System.Windows.Forms.RadioButton _rdiPeople;
		private System.Windows.Forms.RadioButton _rdiTeeneger;
		private System.Windows.Forms.RadioButton _rdiKids;
		private System.Windows.Forms.Label _txtMath;
		private System.Windows.Forms.ComboBox _cmbEnterMath;
		private System.Windows.Forms.Label _txtH20;
		private System.Windows.Forms.ComboBox _cmbEnterH20;
		private System.Windows.Forms.Label _txtHistory;
		private System.Windows.Forms.ComboBox _cmbEnterHistory;
		private System.Windows.Forms.Label _txtRus;
		private System.Windows.Forms.ComboBox _cmbEnterRus;
		private System.Windows.Forms.OpenFileDialog _openFileDialog;
		private System.Windows.Forms.Button _btnOpenFile;
		private System.Windows.Forms.TextBox _txtFile;
		private System.Windows.Forms.Button _btnOpenDirectory;
		private System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button _btnSave;
		private System.Windows.Forms.Label _txtYourName;
	}
}

