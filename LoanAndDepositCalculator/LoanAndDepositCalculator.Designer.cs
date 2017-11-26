namespace LoanAndDepositCalculator
{
	partial class LoanAndDepositCalculator
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanAndDepositCalculator));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabLoan = new System.Windows.Forms.TabPage();
			this.btnCalculateLoan = new System.Windows.Forms.Button();
			this.gbxLoanCalculation = new System.Windows.Forms.GroupBox();
			this.dgvLoanCalculation = new System.Windows.Forms.DataGridView();
			this.gbxLoanParameters = new System.Windows.Forms.GroupBox();
			this.pnlMonthlyCommissionVarying = new System.Windows.Forms.Panel();
			this.lblMonthlyCommissionVarying2 = new System.Windows.Forms.Label();
			this.lblMonthlyCommissionVarying1 = new System.Windows.Forms.Label();
			this.mtbxMonthlyCommissionVarying = new System.Windows.Forms.MaskedTextBox();
			this.pnlMonthlyCommissionFixed = new System.Windows.Forms.Panel();
			this.rbtnPercentMonthlyCommissionFixed = new System.Windows.Forms.RadioButton();
			this.lblMonthlyCommissionFixed2 = new System.Windows.Forms.Label();
			this.txtMonthlyCommissionFixed = new System.Windows.Forms.TextBox();
			this.lblMonthlyCommissionFixed1 = new System.Windows.Forms.Label();
			this.rbtnBucksMonthlyCommissionFixed = new System.Windows.Forms.RadioButton();
			this.pnlOneTimeCommission = new System.Windows.Forms.Panel();
			this.rbtnPercentOneTimeCommission = new System.Windows.Forms.RadioButton();
			this.rbtnBucksOneTimeCommission = new System.Windows.Forms.RadioButton();
			this.lblOneTimeCommission2 = new System.Windows.Forms.Label();
			this.lblOneTimeCommission1 = new System.Windows.Forms.Label();
			this.txtOneTimeCommission = new System.Windows.Forms.TextBox();
			this.pnlDownPayment = new System.Windows.Forms.Panel();
			this.rbtnPercentDownPayment = new System.Windows.Forms.RadioButton();
			this.lblDownPayment2 = new System.Windows.Forms.Label();
			this.lblDownPayment1 = new System.Windows.Forms.Label();
			this.txtDownPayment = new System.Windows.Forms.TextBox();
			this.rbtnBucksDownPayment = new System.Windows.Forms.RadioButton();
			this.txtLoanAmount = new System.Windows.Forms.TextBox();
			this.mtbxInterestRate = new System.Windows.Forms.MaskedTextBox();
			this.pnlTerm = new System.Windows.Forms.Panel();
			this.rbtnYears = new System.Windows.Forms.RadioButton();
			this.rbtnMonths = new System.Windows.Forms.RadioButton();
			this.lblTerm = new System.Windows.Forms.Label();
			this.mtbxTerm = new System.Windows.Forms.MaskedTextBox();
			this.lblInterestRate = new System.Windows.Forms.Label();
			this.lblLoanAmount = new System.Windows.Forms.Label();
			this.lblScheme = new System.Windows.Forms.Label();
			this.cbxScheme = new System.Windows.Forms.ComboBox();
			this.tabDeposit = new System.Windows.Forms.TabPage();
			this.btnCalculateDeposit = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.gbxDepositParameters = new System.Windows.Forms.GroupBox();
			this.lblEvery = new System.Windows.Forms.Label();
			this.cbxReplenishmentPeriod = new System.Windows.Forms.ComboBox();
			this.cbxCapitalization = new System.Windows.Forms.ComboBox();
			this.lblCapitalization = new System.Windows.Forms.Label();
			this.pnlDepositTerm = new System.Windows.Forms.Panel();
			this.rbtnYearsDeposit = new System.Windows.Forms.RadioButton();
			this.rbtnMonthsDeposit = new System.Windows.Forms.RadioButton();
			this.lblDepositTerm = new System.Windows.Forms.Label();
			this.mtbxDepositTerm = new System.Windows.Forms.MaskedTextBox();
			this.txtTaxes = new System.Windows.Forms.TextBox();
			this.lblTaxes = new System.Windows.Forms.Label();
			this.txtAnnualInterestRate = new System.Windows.Forms.TextBox();
			this.lblAnnualInterestRate = new System.Windows.Forms.Label();
			this.txtReplenishment = new System.Windows.Forms.TextBox();
			this.txtDepositAmount = new System.Windows.Forms.TextBox();
			this.lblReplenishment = new System.Windows.Forms.Label();
			this.lblDepositAmount = new System.Windows.Forms.Label();
			this.gbxDepositCalculation = new System.Windows.Forms.GroupBox();
			this.dgvDepositCalculation = new System.Windows.Forms.DataGridView();
			this.tabControl.SuspendLayout();
			this.tabLoan.SuspendLayout();
			this.gbxLoanCalculation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLoanCalculation)).BeginInit();
			this.gbxLoanParameters.SuspendLayout();
			this.pnlMonthlyCommissionVarying.SuspendLayout();
			this.pnlMonthlyCommissionFixed.SuspendLayout();
			this.pnlOneTimeCommission.SuspendLayout();
			this.pnlDownPayment.SuspendLayout();
			this.pnlTerm.SuspendLayout();
			this.tabDeposit.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gbxDepositParameters.SuspendLayout();
			this.pnlDepositTerm.SuspendLayout();
			this.gbxDepositCalculation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDepositCalculation)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabLoan);
			this.tabControl.Controls.Add(this.tabDeposit);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(569, 529);
			this.tabControl.TabIndex = 0;
			this.tabControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl_KeyPress);
			// 
			// tabLoan
			// 
			this.tabLoan.Controls.Add(this.btnCalculateLoan);
			this.tabLoan.Controls.Add(this.gbxLoanCalculation);
			this.tabLoan.Controls.Add(this.gbxLoanParameters);
			this.tabLoan.Location = new System.Drawing.Point(4, 22);
			this.tabLoan.Name = "tabLoan";
			this.tabLoan.Padding = new System.Windows.Forms.Padding(3);
			this.tabLoan.Size = new System.Drawing.Size(561, 503);
			this.tabLoan.TabIndex = 0;
			this.tabLoan.Text = "Loan calculator";
			this.tabLoan.UseVisualStyleBackColor = true;
			// 
			// btnCalculateLoan
			// 
			this.btnCalculateLoan.Location = new System.Drawing.Point(253, 142);
			this.btnCalculateLoan.Name = "btnCalculateLoan";
			this.btnCalculateLoan.Size = new System.Drawing.Size(75, 23);
			this.btnCalculateLoan.TabIndex = 1;
			this.btnCalculateLoan.Text = "Calculate";
			this.btnCalculateLoan.UseVisualStyleBackColor = true;
			this.btnCalculateLoan.Click += new System.EventHandler(this.btnCalculateLoan_Click);
			// 
			// gbxLoanCalculation
			// 
			this.gbxLoanCalculation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbxLoanCalculation.Controls.Add(this.dgvLoanCalculation);
			this.gbxLoanCalculation.Location = new System.Drawing.Point(3, 156);
			this.gbxLoanCalculation.Name = "gbxLoanCalculation";
			this.gbxLoanCalculation.Size = new System.Drawing.Size(555, 344);
			this.gbxLoanCalculation.TabIndex = 26;
			this.gbxLoanCalculation.TabStop = false;
			this.gbxLoanCalculation.Text = "Calculation";
			// 
			// dgvLoanCalculation
			// 
			this.dgvLoanCalculation.AllowUserToAddRows = false;
			this.dgvLoanCalculation.AllowUserToDeleteRows = false;
			this.dgvLoanCalculation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvLoanCalculation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvLoanCalculation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvLoanCalculation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLoanCalculation.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvLoanCalculation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvLoanCalculation.Location = new System.Drawing.Point(3, 16);
			this.dgvLoanCalculation.Name = "dgvLoanCalculation";
			this.dgvLoanCalculation.ReadOnly = true;
			this.dgvLoanCalculation.RowHeadersVisible = false;
			this.dgvLoanCalculation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvLoanCalculation.Size = new System.Drawing.Size(549, 325);
			this.dgvLoanCalculation.StandardTab = true;
			this.dgvLoanCalculation.TabIndex = 50;
			// 
			// gbxLoanParameters
			// 
			this.gbxLoanParameters.Controls.Add(this.pnlMonthlyCommissionVarying);
			this.gbxLoanParameters.Controls.Add(this.pnlMonthlyCommissionFixed);
			this.gbxLoanParameters.Controls.Add(this.pnlOneTimeCommission);
			this.gbxLoanParameters.Controls.Add(this.pnlDownPayment);
			this.gbxLoanParameters.Controls.Add(this.txtLoanAmount);
			this.gbxLoanParameters.Controls.Add(this.mtbxInterestRate);
			this.gbxLoanParameters.Controls.Add(this.pnlTerm);
			this.gbxLoanParameters.Controls.Add(this.lblInterestRate);
			this.gbxLoanParameters.Controls.Add(this.lblLoanAmount);
			this.gbxLoanParameters.Controls.Add(this.lblScheme);
			this.gbxLoanParameters.Controls.Add(this.cbxScheme);
			this.gbxLoanParameters.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbxLoanParameters.Location = new System.Drawing.Point(3, 3);
			this.gbxLoanParameters.Name = "gbxLoanParameters";
			this.gbxLoanParameters.Size = new System.Drawing.Size(555, 147);
			this.gbxLoanParameters.TabIndex = 0;
			this.gbxLoanParameters.TabStop = false;
			this.gbxLoanParameters.Text = "Loan parameters";
			// 
			// pnlMonthlyCommissionVarying
			// 
			this.pnlMonthlyCommissionVarying.Controls.Add(this.lblMonthlyCommissionVarying2);
			this.pnlMonthlyCommissionVarying.Controls.Add(this.lblMonthlyCommissionVarying1);
			this.pnlMonthlyCommissionVarying.Controls.Add(this.mtbxMonthlyCommissionVarying);
			this.pnlMonthlyCommissionVarying.Location = new System.Drawing.Point(293, 90);
			this.pnlMonthlyCommissionVarying.Name = "pnlMonthlyCommissionVarying";
			this.pnlMonthlyCommissionVarying.Size = new System.Drawing.Size(255, 48);
			this.pnlMonthlyCommissionVarying.TabIndex = 25;
			// 
			// lblMonthlyCommissionVarying2
			// 
			this.lblMonthlyCommissionVarying2.AutoSize = true;
			this.lblMonthlyCommissionVarying2.Location = new System.Drawing.Point(3, 24);
			this.lblMonthlyCommissionVarying2.Name = "lblMonthlyCommissionVarying2";
			this.lblMonthlyCommissionVarying2.Size = new System.Drawing.Size(131, 13);
			this.lblMonthlyCommissionVarying2.TabIndex = 1;
			this.lblMonthlyCommissionVarying2.Text = "commission, % of balance ";
			// 
			// lblMonthlyCommissionVarying1
			// 
			this.lblMonthlyCommissionVarying1.AutoSize = true;
			this.lblMonthlyCommissionVarying1.Location = new System.Drawing.Point(3, 9);
			this.lblMonthlyCommissionVarying1.Name = "lblMonthlyCommissionVarying1";
			this.lblMonthlyCommissionVarying1.Size = new System.Drawing.Size(81, 13);
			this.lblMonthlyCommissionVarying1.TabIndex = 1;
			this.lblMonthlyCommissionVarying1.Text = "Varying monthly";
			// 
			// mtbxMonthlyCommissionVarying
			// 
			this.mtbxMonthlyCommissionVarying.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
			this.mtbxMonthlyCommissionVarying.Location = new System.Drawing.Point(140, 13);
			this.mtbxMonthlyCommissionVarying.Mask = "99.99";
			this.mtbxMonthlyCommissionVarying.Name = "mtbxMonthlyCommissionVarying";
			this.mtbxMonthlyCommissionVarying.PromptChar = ' ';
			this.mtbxMonthlyCommissionVarying.Size = new System.Drawing.Size(67, 20);
			this.mtbxMonthlyCommissionVarying.TabIndex = 45;
			this.mtbxMonthlyCommissionVarying.Text = "0000";
			// 
			// pnlMonthlyCommissionFixed
			// 
			this.pnlMonthlyCommissionFixed.Controls.Add(this.rbtnPercentMonthlyCommissionFixed);
			this.pnlMonthlyCommissionFixed.Controls.Add(this.lblMonthlyCommissionFixed2);
			this.pnlMonthlyCommissionFixed.Controls.Add(this.txtMonthlyCommissionFixed);
			this.pnlMonthlyCommissionFixed.Controls.Add(this.lblMonthlyCommissionFixed1);
			this.pnlMonthlyCommissionFixed.Controls.Add(this.rbtnBucksMonthlyCommissionFixed);
			this.pnlMonthlyCommissionFixed.Location = new System.Drawing.Point(3, 90);
			this.pnlMonthlyCommissionFixed.Name = "pnlMonthlyCommissionFixed";
			this.pnlMonthlyCommissionFixed.Size = new System.Drawing.Size(284, 48);
			this.pnlMonthlyCommissionFixed.TabIndex = 24;
			// 
			// rbtnPercentMonthlyCommissionFixed
			// 
			this.rbtnPercentMonthlyCommissionFixed.AutoSize = true;
			this.rbtnPercentMonthlyCommissionFixed.Location = new System.Drawing.Point(186, 5);
			this.rbtnPercentMonthlyCommissionFixed.Name = "rbtnPercentMonthlyCommissionFixed";
			this.rbtnPercentMonthlyCommissionFixed.Size = new System.Drawing.Size(94, 17);
			this.rbtnPercentMonthlyCommissionFixed.TabIndex = 41;
			this.rbtnPercentMonthlyCommissionFixed.Text = "% loan amount";
			this.rbtnPercentMonthlyCommissionFixed.UseVisualStyleBackColor = true;
			// 
			// lblMonthlyCommissionFixed2
			// 
			this.lblMonthlyCommissionFixed2.AutoSize = true;
			this.lblMonthlyCommissionFixed2.Location = new System.Drawing.Point(3, 24);
			this.lblMonthlyCommissionFixed2.Name = "lblMonthlyCommissionFixed2";
			this.lblMonthlyCommissionFixed2.Size = new System.Drawing.Size(61, 13);
			this.lblMonthlyCommissionFixed2.TabIndex = 1;
			this.lblMonthlyCommissionFixed2.Text = "commission";
			// 
			// txtMonthlyCommissionFixed
			// 
			this.txtMonthlyCommissionFixed.Location = new System.Drawing.Point(80, 13);
			this.txtMonthlyCommissionFixed.Name = "txtMonthlyCommissionFixed";
			this.txtMonthlyCommissionFixed.Size = new System.Drawing.Size(100, 20);
			this.txtMonthlyCommissionFixed.TabIndex = 40;
			this.txtMonthlyCommissionFixed.Text = "0";
			this.txtMonthlyCommissionFixed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoanAmount_KeyPress);
			// 
			// lblMonthlyCommissionFixed1
			// 
			this.lblMonthlyCommissionFixed1.AutoSize = true;
			this.lblMonthlyCommissionFixed1.Location = new System.Drawing.Point(3, 9);
			this.lblMonthlyCommissionFixed1.Name = "lblMonthlyCommissionFixed1";
			this.lblMonthlyCommissionFixed1.Size = new System.Drawing.Size(71, 13);
			this.lblMonthlyCommissionFixed1.TabIndex = 1;
			this.lblMonthlyCommissionFixed1.Text = "Fixed monthly";
			// 
			// rbtnBucksMonthlyCommissionFixed
			// 
			this.rbtnBucksMonthlyCommissionFixed.AutoSize = true;
			this.rbtnBucksMonthlyCommissionFixed.Checked = true;
			this.rbtnBucksMonthlyCommissionFixed.Location = new System.Drawing.Point(186, 28);
			this.rbtnBucksMonthlyCommissionFixed.Name = "rbtnBucksMonthlyCommissionFixed";
			this.rbtnBucksMonthlyCommissionFixed.Size = new System.Drawing.Size(31, 17);
			this.rbtnBucksMonthlyCommissionFixed.TabIndex = 42;
			this.rbtnBucksMonthlyCommissionFixed.TabStop = true;
			this.rbtnBucksMonthlyCommissionFixed.Text = "$";
			this.rbtnBucksMonthlyCommissionFixed.UseVisualStyleBackColor = true;
			// 
			// pnlOneTimeCommission
			// 
			this.pnlOneTimeCommission.Controls.Add(this.rbtnPercentOneTimeCommission);
			this.pnlOneTimeCommission.Controls.Add(this.rbtnBucksOneTimeCommission);
			this.pnlOneTimeCommission.Controls.Add(this.lblOneTimeCommission2);
			this.pnlOneTimeCommission.Controls.Add(this.lblOneTimeCommission1);
			this.pnlOneTimeCommission.Controls.Add(this.txtOneTimeCommission);
			this.pnlOneTimeCommission.Location = new System.Drawing.Point(353, 36);
			this.pnlOneTimeCommission.Name = "pnlOneTimeCommission";
			this.pnlOneTimeCommission.Size = new System.Drawing.Size(199, 48);
			this.pnlOneTimeCommission.TabIndex = 23;
			// 
			// rbtnPercentOneTimeCommission
			// 
			this.rbtnPercentOneTimeCommission.AutoSize = true;
			this.rbtnPercentOneTimeCommission.Checked = true;
			this.rbtnPercentOneTimeCommission.Location = new System.Drawing.Point(167, 3);
			this.rbtnPercentOneTimeCommission.Name = "rbtnPercentOneTimeCommission";
			this.rbtnPercentOneTimeCommission.Size = new System.Drawing.Size(33, 17);
			this.rbtnPercentOneTimeCommission.TabIndex = 36;
			this.rbtnPercentOneTimeCommission.TabStop = true;
			this.rbtnPercentOneTimeCommission.Text = "%";
			this.rbtnPercentOneTimeCommission.UseVisualStyleBackColor = true;
			// 
			// rbtnBucksOneTimeCommission
			// 
			this.rbtnBucksOneTimeCommission.AutoSize = true;
			this.rbtnBucksOneTimeCommission.Location = new System.Drawing.Point(167, 26);
			this.rbtnBucksOneTimeCommission.Name = "rbtnBucksOneTimeCommission";
			this.rbtnBucksOneTimeCommission.Size = new System.Drawing.Size(31, 17);
			this.rbtnBucksOneTimeCommission.TabIndex = 37;
			this.rbtnBucksOneTimeCommission.Text = "$";
			this.rbtnBucksOneTimeCommission.UseVisualStyleBackColor = true;
			// 
			// lblOneTimeCommission2
			// 
			this.lblOneTimeCommission2.AutoSize = true;
			this.lblOneTimeCommission2.Location = new System.Drawing.Point(3, 25);
			this.lblOneTimeCommission2.Name = "lblOneTimeCommission2";
			this.lblOneTimeCommission2.Size = new System.Drawing.Size(61, 13);
			this.lblOneTimeCommission2.TabIndex = 1;
			this.lblOneTimeCommission2.Text = "commission";
			// 
			// lblOneTimeCommission1
			// 
			this.lblOneTimeCommission1.AutoSize = true;
			this.lblOneTimeCommission1.Location = new System.Drawing.Point(3, 11);
			this.lblOneTimeCommission1.Name = "lblOneTimeCommission1";
			this.lblOneTimeCommission1.Size = new System.Drawing.Size(49, 13);
			this.lblOneTimeCommission1.TabIndex = 1;
			this.lblOneTimeCommission1.Text = "One-time";
			// 
			// txtOneTimeCommission
			// 
			this.txtOneTimeCommission.Location = new System.Drawing.Point(62, 13);
			this.txtOneTimeCommission.Name = "txtOneTimeCommission";
			this.txtOneTimeCommission.Size = new System.Drawing.Size(100, 20);
			this.txtOneTimeCommission.TabIndex = 35;
			this.txtOneTimeCommission.Text = "0";
			this.txtOneTimeCommission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoanAmount_KeyPress);
			// 
			// pnlDownPayment
			// 
			this.pnlDownPayment.Controls.Add(this.rbtnPercentDownPayment);
			this.pnlDownPayment.Controls.Add(this.lblDownPayment2);
			this.pnlDownPayment.Controls.Add(this.lblDownPayment1);
			this.pnlDownPayment.Controls.Add(this.txtDownPayment);
			this.pnlDownPayment.Controls.Add(this.rbtnBucksDownPayment);
			this.pnlDownPayment.Location = new System.Drawing.Point(151, 36);
			this.pnlDownPayment.Name = "pnlDownPayment";
			this.pnlDownPayment.Size = new System.Drawing.Size(200, 48);
			this.pnlDownPayment.TabIndex = 22;
			// 
			// rbtnPercentDownPayment
			// 
			this.rbtnPercentDownPayment.AutoSize = true;
			this.rbtnPercentDownPayment.Location = new System.Drawing.Point(163, 3);
			this.rbtnPercentDownPayment.Name = "rbtnPercentDownPayment";
			this.rbtnPercentDownPayment.Size = new System.Drawing.Size(33, 17);
			this.rbtnPercentDownPayment.TabIndex = 31;
			this.rbtnPercentDownPayment.Text = "%";
			this.rbtnPercentDownPayment.UseVisualStyleBackColor = true;
			// 
			// lblDownPayment2
			// 
			this.lblDownPayment2.AutoSize = true;
			this.lblDownPayment2.Location = new System.Drawing.Point(3, 24);
			this.lblDownPayment2.Name = "lblDownPayment2";
			this.lblDownPayment2.Size = new System.Drawing.Size(47, 13);
			this.lblDownPayment2.TabIndex = 1;
			this.lblDownPayment2.Text = "payment";
			// 
			// lblDownPayment1
			// 
			this.lblDownPayment1.AutoSize = true;
			this.lblDownPayment1.Location = new System.Drawing.Point(3, 11);
			this.lblDownPayment1.Name = "lblDownPayment1";
			this.lblDownPayment1.Size = new System.Drawing.Size(35, 13);
			this.lblDownPayment1.TabIndex = 1;
			this.lblDownPayment1.Text = "Down";
			// 
			// txtDownPayment
			// 
			this.txtDownPayment.Location = new System.Drawing.Point(57, 13);
			this.txtDownPayment.Name = "txtDownPayment";
			this.txtDownPayment.Size = new System.Drawing.Size(100, 20);
			this.txtDownPayment.TabIndex = 30;
			this.txtDownPayment.Text = "0";
			this.txtDownPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoanAmount_KeyPress);
			// 
			// rbtnBucksDownPayment
			// 
			this.rbtnBucksDownPayment.AutoSize = true;
			this.rbtnBucksDownPayment.Checked = true;
			this.rbtnBucksDownPayment.Location = new System.Drawing.Point(163, 26);
			this.rbtnBucksDownPayment.Name = "rbtnBucksDownPayment";
			this.rbtnBucksDownPayment.Size = new System.Drawing.Size(31, 17);
			this.rbtnBucksDownPayment.TabIndex = 32;
			this.rbtnBucksDownPayment.TabStop = true;
			this.rbtnBucksDownPayment.Text = "$";
			this.rbtnBucksDownPayment.UseVisualStyleBackColor = true;
			// 
			// txtLoanAmount
			// 
			this.txtLoanAmount.Location = new System.Drawing.Point(282, 13);
			this.txtLoanAmount.Name = "txtLoanAmount";
			this.txtLoanAmount.Size = new System.Drawing.Size(100, 20);
			this.txtLoanAmount.TabIndex = 15;
			this.txtLoanAmount.Text = "15000";
			this.txtLoanAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoanAmount_KeyPress);
			// 
			// mtbxInterestRate
			// 
			this.mtbxInterestRate.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
			this.mtbxInterestRate.Location = new System.Drawing.Point(481, 13);
			this.mtbxInterestRate.Mask = "99.99";
			this.mtbxInterestRate.Name = "mtbxInterestRate";
			this.mtbxInterestRate.PromptChar = ' ';
			this.mtbxInterestRate.Size = new System.Drawing.Size(67, 20);
			this.mtbxInterestRate.TabIndex = 20;
			this.mtbxInterestRate.Text = "1000";
			// 
			// pnlTerm
			// 
			this.pnlTerm.Controls.Add(this.rbtnYears);
			this.pnlTerm.Controls.Add(this.rbtnMonths);
			this.pnlTerm.Controls.Add(this.lblTerm);
			this.pnlTerm.Controls.Add(this.mtbxTerm);
			this.pnlTerm.Location = new System.Drawing.Point(3, 36);
			this.pnlTerm.Name = "pnlTerm";
			this.pnlTerm.Size = new System.Drawing.Size(143, 48);
			this.pnlTerm.TabIndex = 21;
			// 
			// rbtnYears
			// 
			this.rbtnYears.AutoSize = true;
			this.rbtnYears.Location = new System.Drawing.Point(82, 26);
			this.rbtnYears.Name = "rbtnYears";
			this.rbtnYears.Size = new System.Drawing.Size(52, 17);
			this.rbtnYears.TabIndex = 27;
			this.rbtnYears.Text = "Years";
			this.rbtnYears.UseVisualStyleBackColor = true;
			// 
			// rbtnMonths
			// 
			this.rbtnMonths.AutoSize = true;
			this.rbtnMonths.Checked = true;
			this.rbtnMonths.Location = new System.Drawing.Point(82, 3);
			this.rbtnMonths.Name = "rbtnMonths";
			this.rbtnMonths.Size = new System.Drawing.Size(60, 17);
			this.rbtnMonths.TabIndex = 26;
			this.rbtnMonths.TabStop = true;
			this.rbtnMonths.Text = "Months";
			this.rbtnMonths.UseVisualStyleBackColor = true;
			// 
			// lblTerm
			// 
			this.lblTerm.AutoSize = true;
			this.lblTerm.Location = new System.Drawing.Point(3, 16);
			this.lblTerm.Name = "lblTerm";
			this.lblTerm.Size = new System.Drawing.Size(31, 13);
			this.lblTerm.TabIndex = 1;
			this.lblTerm.Text = "Term";
			// 
			// mtbxTerm
			// 
			this.mtbxTerm.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
			this.mtbxTerm.Location = new System.Drawing.Point(40, 13);
			this.mtbxTerm.Mask = "999";
			this.mtbxTerm.Name = "mtbxTerm";
			this.mtbxTerm.PromptChar = ' ';
			this.mtbxTerm.Size = new System.Drawing.Size(36, 20);
			this.mtbxTerm.TabIndex = 25;
			this.mtbxTerm.Text = "12";
			// 
			// lblInterestRate
			// 
			this.lblInterestRate.AutoSize = true;
			this.lblInterestRate.Location = new System.Drawing.Point(398, 16);
			this.lblInterestRate.Name = "lblInterestRate";
			this.lblInterestRate.Size = new System.Drawing.Size(77, 13);
			this.lblInterestRate.TabIndex = 1;
			this.lblInterestRate.Text = "Interest rate, %";
			// 
			// lblLoanAmount
			// 
			this.lblLoanAmount.AutoSize = true;
			this.lblLoanAmount.Location = new System.Drawing.Point(195, 16);
			this.lblLoanAmount.Name = "lblLoanAmount";
			this.lblLoanAmount.Size = new System.Drawing.Size(81, 13);
			this.lblLoanAmount.TabIndex = 1;
			this.lblLoanAmount.Text = "Loan amount, $";
			// 
			// lblScheme
			// 
			this.lblScheme.AutoSize = true;
			this.lblScheme.Location = new System.Drawing.Point(6, 16);
			this.lblScheme.Name = "lblScheme";
			this.lblScheme.Size = new System.Drawing.Size(46, 13);
			this.lblScheme.TabIndex = 1;
			this.lblScheme.Text = "Scheme";
			// 
			// cbxScheme
			// 
			this.cbxScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxScheme.FormattingEnabled = true;
			this.cbxScheme.Items.AddRange(new object[] {
            "Classic",
            "Annuity"});
			this.cbxScheme.Location = new System.Drawing.Point(58, 13);
			this.cbxScheme.Name = "cbxScheme";
			this.cbxScheme.Size = new System.Drawing.Size(121, 21);
			this.cbxScheme.TabIndex = 10;
			// 
			// tabDeposit
			// 
			this.tabDeposit.Controls.Add(this.btnCalculateDeposit);
			this.tabDeposit.Controls.Add(this.panel1);
			this.tabDeposit.Controls.Add(this.gbxDepositCalculation);
			this.tabDeposit.Location = new System.Drawing.Point(4, 22);
			this.tabDeposit.Name = "tabDeposit";
			this.tabDeposit.Padding = new System.Windows.Forms.Padding(3);
			this.tabDeposit.Size = new System.Drawing.Size(561, 503);
			this.tabDeposit.TabIndex = 1;
			this.tabDeposit.Text = "Deposit calculator";
			this.tabDeposit.UseVisualStyleBackColor = true;
			// 
			// btnCalculateDeposit
			// 
			this.btnCalculateDeposit.Location = new System.Drawing.Point(239, 139);
			this.btnCalculateDeposit.Name = "btnCalculateDeposit";
			this.btnCalculateDeposit.Size = new System.Drawing.Size(75, 23);
			this.btnCalculateDeposit.TabIndex = 45;
			this.btnCalculateDeposit.Text = "Calculate";
			this.btnCalculateDeposit.UseVisualStyleBackColor = true;
			this.btnCalculateDeposit.Click += new System.EventHandler(this.btnCalculateDeposit_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.gbxDepositParameters);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(555, 144);
			this.panel1.TabIndex = 28;
			// 
			// gbxDepositParameters
			// 
			this.gbxDepositParameters.Controls.Add(this.lblEvery);
			this.gbxDepositParameters.Controls.Add(this.cbxReplenishmentPeriod);
			this.gbxDepositParameters.Controls.Add(this.cbxCapitalization);
			this.gbxDepositParameters.Controls.Add(this.lblCapitalization);
			this.gbxDepositParameters.Controls.Add(this.pnlDepositTerm);
			this.gbxDepositParameters.Controls.Add(this.txtTaxes);
			this.gbxDepositParameters.Controls.Add(this.lblTaxes);
			this.gbxDepositParameters.Controls.Add(this.txtAnnualInterestRate);
			this.gbxDepositParameters.Controls.Add(this.lblAnnualInterestRate);
			this.gbxDepositParameters.Controls.Add(this.txtReplenishment);
			this.gbxDepositParameters.Controls.Add(this.txtDepositAmount);
			this.gbxDepositParameters.Controls.Add(this.lblReplenishment);
			this.gbxDepositParameters.Controls.Add(this.lblDepositAmount);
			this.gbxDepositParameters.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbxDepositParameters.Location = new System.Drawing.Point(0, 0);
			this.gbxDepositParameters.Name = "gbxDepositParameters";
			this.gbxDepositParameters.Size = new System.Drawing.Size(555, 144);
			this.gbxDepositParameters.TabIndex = 0;
			this.gbxDepositParameters.TabStop = false;
			this.gbxDepositParameters.Text = "Deposit parameters";
			// 
			// lblEvery
			// 
			this.lblEvery.AutoSize = true;
			this.lblEvery.Location = new System.Drawing.Point(211, 96);
			this.lblEvery.Name = "lblEvery";
			this.lblEvery.Size = new System.Drawing.Size(33, 13);
			this.lblEvery.TabIndex = 25;
			this.lblEvery.Text = "every";
			// 
			// cbxReplenishmentPeriod
			// 
			this.cbxReplenishmentPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxReplenishmentPeriod.FormattingEnabled = true;
			this.cbxReplenishmentPeriod.Items.AddRange(new object[] {
            "None",
            "Month",
            "Quarter",
            "Half year",
            "Year"});
			this.cbxReplenishmentPeriod.Location = new System.Drawing.Point(250, 93);
			this.cbxReplenishmentPeriod.Name = "cbxReplenishmentPeriod";
			this.cbxReplenishmentPeriod.Size = new System.Drawing.Size(121, 21);
			this.cbxReplenishmentPeriod.TabIndex = 35;
			// 
			// cbxCapitalization
			// 
			this.cbxCapitalization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxCapitalization.FormattingEnabled = true;
			this.cbxCapitalization.Items.AddRange(new object[] {
            "None",
            "Monthly",
            "Quarterly",
            "Half yearly",
            "Yearly"});
			this.cbxCapitalization.Location = new System.Drawing.Point(224, 52);
			this.cbxCapitalization.Name = "cbxCapitalization";
			this.cbxCapitalization.Size = new System.Drawing.Size(121, 21);
			this.cbxCapitalization.TabIndex = 25;
			// 
			// lblCapitalization
			// 
			this.lblCapitalization.AutoSize = true;
			this.lblCapitalization.Location = new System.Drawing.Point(149, 55);
			this.lblCapitalization.Name = "lblCapitalization";
			this.lblCapitalization.Size = new System.Drawing.Size(69, 13);
			this.lblCapitalization.TabIndex = 23;
			this.lblCapitalization.Text = "Capitalization";
			// 
			// pnlDepositTerm
			// 
			this.pnlDepositTerm.Controls.Add(this.rbtnYearsDeposit);
			this.pnlDepositTerm.Controls.Add(this.rbtnMonthsDeposit);
			this.pnlDepositTerm.Controls.Add(this.lblDepositTerm);
			this.pnlDepositTerm.Controls.Add(this.mtbxDepositTerm);
			this.pnlDepositTerm.Location = new System.Drawing.Point(0, 39);
			this.pnlDepositTerm.Name = "pnlDepositTerm";
			this.pnlDepositTerm.Size = new System.Drawing.Size(143, 48);
			this.pnlDepositTerm.TabIndex = 20;
			// 
			// rbtnYearsDeposit
			// 
			this.rbtnYearsDeposit.AutoSize = true;
			this.rbtnYearsDeposit.Location = new System.Drawing.Point(82, 26);
			this.rbtnYearsDeposit.Name = "rbtnYearsDeposit";
			this.rbtnYearsDeposit.Size = new System.Drawing.Size(52, 17);
			this.rbtnYearsDeposit.TabIndex = 23;
			this.rbtnYearsDeposit.Text = "Years";
			this.rbtnYearsDeposit.UseVisualStyleBackColor = true;
			// 
			// rbtnMonthsDeposit
			// 
			this.rbtnMonthsDeposit.AutoSize = true;
			this.rbtnMonthsDeposit.Checked = true;
			this.rbtnMonthsDeposit.Location = new System.Drawing.Point(82, 3);
			this.rbtnMonthsDeposit.Name = "rbtnMonthsDeposit";
			this.rbtnMonthsDeposit.Size = new System.Drawing.Size(60, 17);
			this.rbtnMonthsDeposit.TabIndex = 22;
			this.rbtnMonthsDeposit.TabStop = true;
			this.rbtnMonthsDeposit.Text = "Months";
			this.rbtnMonthsDeposit.UseVisualStyleBackColor = true;
			// 
			// lblDepositTerm
			// 
			this.lblDepositTerm.AutoSize = true;
			this.lblDepositTerm.Location = new System.Drawing.Point(3, 16);
			this.lblDepositTerm.Name = "lblDepositTerm";
			this.lblDepositTerm.Size = new System.Drawing.Size(31, 13);
			this.lblDepositTerm.TabIndex = 1;
			this.lblDepositTerm.Text = "Term";
			// 
			// mtbxDepositTerm
			// 
			this.mtbxDepositTerm.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
			this.mtbxDepositTerm.Location = new System.Drawing.Point(40, 13);
			this.mtbxDepositTerm.Mask = "999";
			this.mtbxDepositTerm.Name = "mtbxDepositTerm";
			this.mtbxDepositTerm.PromptChar = ' ';
			this.mtbxDepositTerm.Size = new System.Drawing.Size(36, 20);
			this.mtbxDepositTerm.TabIndex = 21;
			this.mtbxDepositTerm.Text = "12";
			// 
			// txtTaxes
			// 
			this.txtTaxes.Location = new System.Drawing.Point(450, 93);
			this.txtTaxes.Name = "txtTaxes";
			this.txtTaxes.Size = new System.Drawing.Size(100, 20);
			this.txtTaxes.TabIndex = 40;
			this.txtTaxes.Text = "19.5";
			this.txtTaxes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxes_KeyPress);
			// 
			// lblTaxes
			// 
			this.lblTaxes.AutoSize = true;
			this.lblTaxes.Location = new System.Drawing.Point(394, 96);
			this.lblTaxes.Name = "lblTaxes";
			this.lblTaxes.Size = new System.Drawing.Size(50, 13);
			this.lblTaxes.TabIndex = 0;
			this.lblTaxes.Text = "Taxes, %";
			// 
			// txtAnnualInterestRate
			// 
			this.txtAnnualInterestRate.Location = new System.Drawing.Point(329, 13);
			this.txtAnnualInterestRate.Name = "txtAnnualInterestRate";
			this.txtAnnualInterestRate.Size = new System.Drawing.Size(100, 20);
			this.txtAnnualInterestRate.TabIndex = 15;
			this.txtAnnualInterestRate.Text = "12";
			this.txtAnnualInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnnualInterestRate_KeyPress);
			// 
			// lblAnnualInterestRate
			// 
			this.lblAnnualInterestRate.AutoSize = true;
			this.lblAnnualInterestRate.Location = new System.Drawing.Point(211, 16);
			this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
			this.lblAnnualInterestRate.Size = new System.Drawing.Size(112, 13);
			this.lblAnnualInterestRate.TabIndex = 0;
			this.lblAnnualInterestRate.Text = "Annual interest rate, %";
			// 
			// txtReplenishment
			// 
			this.txtReplenishment.Location = new System.Drawing.Point(105, 93);
			this.txtReplenishment.Name = "txtReplenishment";
			this.txtReplenishment.Size = new System.Drawing.Size(100, 20);
			this.txtReplenishment.TabIndex = 30;
			this.txtReplenishment.Text = "0";
			this.txtReplenishment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReplenishment_KeyPress);
			// 
			// txtDepositAmount
			// 
			this.txtDepositAmount.Location = new System.Drawing.Point(105, 13);
			this.txtDepositAmount.MaxLength = 10;
			this.txtDepositAmount.Name = "txtDepositAmount";
			this.txtDepositAmount.Size = new System.Drawing.Size(100, 20);
			this.txtDepositAmount.TabIndex = 10;
			this.txtDepositAmount.Text = "10000";
			this.txtDepositAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepositAmount_KeyPress);
			// 
			// lblReplenishment
			// 
			this.lblReplenishment.AutoSize = true;
			this.lblReplenishment.Location = new System.Drawing.Point(6, 96);
			this.lblReplenishment.Name = "lblReplenishment";
			this.lblReplenishment.Size = new System.Drawing.Size(89, 13);
			this.lblReplenishment.TabIndex = 0;
			this.lblReplenishment.Text = "Replenishment, $";
			// 
			// lblDepositAmount
			// 
			this.lblDepositAmount.AutoSize = true;
			this.lblDepositAmount.Location = new System.Drawing.Point(6, 16);
			this.lblDepositAmount.Name = "lblDepositAmount";
			this.lblDepositAmount.Size = new System.Drawing.Size(93, 13);
			this.lblDepositAmount.TabIndex = 0;
			this.lblDepositAmount.Text = "Deposit amount, $";
			// 
			// gbxDepositCalculation
			// 
			this.gbxDepositCalculation.Controls.Add(this.dgvDepositCalculation);
			this.gbxDepositCalculation.Location = new System.Drawing.Point(3, 153);
			this.gbxDepositCalculation.Name = "gbxDepositCalculation";
			this.gbxDepositCalculation.Size = new System.Drawing.Size(555, 347);
			this.gbxDepositCalculation.TabIndex = 50;
			this.gbxDepositCalculation.TabStop = false;
			this.gbxDepositCalculation.Text = "Calculation";
			// 
			// dgvDepositCalculation
			// 
			this.dgvDepositCalculation.AllowUserToAddRows = false;
			this.dgvDepositCalculation.AllowUserToDeleteRows = false;
			this.dgvDepositCalculation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDepositCalculation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvDepositCalculation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDepositCalculation.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvDepositCalculation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDepositCalculation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvDepositCalculation.Location = new System.Drawing.Point(3, 16);
			this.dgvDepositCalculation.Name = "dgvDepositCalculation";
			this.dgvDepositCalculation.ReadOnly = true;
			this.dgvDepositCalculation.RowHeadersVisible = false;
			this.dgvDepositCalculation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvDepositCalculation.Size = new System.Drawing.Size(549, 328);
			this.dgvDepositCalculation.StandardTab = true;
			this.dgvDepositCalculation.TabIndex = 51;
			// 
			// LoanAndDepositCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 529);
			this.Controls.Add(this.tabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(585, 468);
			this.Name = "LoanAndDepositCalculator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loan and deposit calculator";
			this.tabControl.ResumeLayout(false);
			this.tabLoan.ResumeLayout(false);
			this.gbxLoanCalculation.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLoanCalculation)).EndInit();
			this.gbxLoanParameters.ResumeLayout(false);
			this.gbxLoanParameters.PerformLayout();
			this.pnlMonthlyCommissionVarying.ResumeLayout(false);
			this.pnlMonthlyCommissionVarying.PerformLayout();
			this.pnlMonthlyCommissionFixed.ResumeLayout(false);
			this.pnlMonthlyCommissionFixed.PerformLayout();
			this.pnlOneTimeCommission.ResumeLayout(false);
			this.pnlOneTimeCommission.PerformLayout();
			this.pnlDownPayment.ResumeLayout(false);
			this.pnlDownPayment.PerformLayout();
			this.pnlTerm.ResumeLayout(false);
			this.pnlTerm.PerformLayout();
			this.tabDeposit.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.gbxDepositParameters.ResumeLayout(false);
			this.gbxDepositParameters.PerformLayout();
			this.pnlDepositTerm.ResumeLayout(false);
			this.pnlDepositTerm.PerformLayout();
			this.gbxDepositCalculation.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDepositCalculation)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabLoan;
		private System.Windows.Forms.TabPage tabDeposit;
		private System.Windows.Forms.GroupBox gbxLoanCalculation;
		private System.Windows.Forms.DataGridView dgvLoanCalculation;
		private System.Windows.Forms.GroupBox gbxLoanParameters;
		private System.Windows.Forms.Label lblScheme;
		private System.Windows.Forms.ComboBox cbxScheme;
		private System.Windows.Forms.Panel pnlTerm;
		private System.Windows.Forms.MaskedTextBox mtbxInterestRate;
		private System.Windows.Forms.Label lblLoanAmount;
		private System.Windows.Forms.TextBox txtLoanAmount;
		private System.Windows.Forms.Label lblInterestRate;
		private System.Windows.Forms.MaskedTextBox mtbxTerm;
		private System.Windows.Forms.Label lblTerm;
		private System.Windows.Forms.RadioButton rbtnYears;
		private System.Windows.Forms.RadioButton rbtnMonths;
		private System.Windows.Forms.Panel pnlDownPayment;
		private System.Windows.Forms.RadioButton rbtnPercentDownPayment;
		private System.Windows.Forms.RadioButton rbtnBucksDownPayment;
		private System.Windows.Forms.Label lblDownPayment1;
		private System.Windows.Forms.Panel pnlMonthlyCommissionFixed;
		private System.Windows.Forms.Label lblMonthlyCommissionFixed1;
		private System.Windows.Forms.Panel pnlOneTimeCommission;
		private System.Windows.Forms.RadioButton rbtnPercentOneTimeCommission;
		private System.Windows.Forms.RadioButton rbtnBucksOneTimeCommission;
		private System.Windows.Forms.Label lblOneTimeCommission1;
		private System.Windows.Forms.TextBox txtOneTimeCommission;
		private System.Windows.Forms.Label lblDownPayment2;
		private System.Windows.Forms.Label lblOneTimeCommission2;
		private System.Windows.Forms.Panel pnlMonthlyCommissionVarying;
		private System.Windows.Forms.Label lblMonthlyCommissionVarying1;
		private System.Windows.Forms.Button btnCalculateLoan;
		private System.Windows.Forms.TextBox txtDownPayment;
		private System.Windows.Forms.Label lblMonthlyCommissionFixed2;
		private System.Windows.Forms.RadioButton rbtnPercentMonthlyCommissionFixed;
		private System.Windows.Forms.TextBox txtMonthlyCommissionFixed;
		private System.Windows.Forms.RadioButton rbtnBucksMonthlyCommissionFixed;
		private System.Windows.Forms.Label lblMonthlyCommissionVarying2;
		private System.Windows.Forms.MaskedTextBox mtbxMonthlyCommissionVarying;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox gbxDepositCalculation;
		private System.Windows.Forms.DataGridView dgvDepositCalculation;
		private System.Windows.Forms.GroupBox gbxDepositParameters;
		private System.Windows.Forms.TextBox txtAnnualInterestRate;
		private System.Windows.Forms.Label lblAnnualInterestRate;
		private System.Windows.Forms.TextBox txtDepositAmount;
		private System.Windows.Forms.Label lblDepositAmount;
		private System.Windows.Forms.Label lblEvery;
		private System.Windows.Forms.ComboBox cbxReplenishmentPeriod;
		private System.Windows.Forms.ComboBox cbxCapitalization;
		private System.Windows.Forms.Label lblCapitalization;
		private System.Windows.Forms.Panel pnlDepositTerm;
		private System.Windows.Forms.RadioButton rbtnYearsDeposit;
		private System.Windows.Forms.RadioButton rbtnMonthsDeposit;
		private System.Windows.Forms.Label lblDepositTerm;
		private System.Windows.Forms.MaskedTextBox mtbxDepositTerm;
		private System.Windows.Forms.TextBox txtTaxes;
		private System.Windows.Forms.Label lblTaxes;
		private System.Windows.Forms.TextBox txtReplenishment;
		private System.Windows.Forms.Label lblReplenishment;
		private System.Windows.Forms.Button btnCalculateDeposit;
	}
}

