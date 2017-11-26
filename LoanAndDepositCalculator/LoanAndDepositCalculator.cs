using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LoanDebitLibrary;

namespace LoanAndDepositCalculator
{
	public partial class LoanAndDepositCalculator : Form
	{
		public LoanAndDepositCalculator()
		{
			InitializeComponent();
			// set defaults
			cbxScheme.SelectedIndex = 0;
			cbxCapitalization.SelectedIndex = 0;
			cbxReplenishmentPeriod.SelectedIndex = 0;
		}
		
		// disable column sorting on column header click
		private void DisableColumnSorting(DataGridView dataGridView)
		{
			foreach (DataGridViewColumn column in dataGridView.Columns)
			{
				column.SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}

		// handle unnecessary symbols
		private void txtLoanAmount_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = eHandlerForDouble(e);
		}

		// handle all keys except carachters for double type
		private bool eHandlerForDouble(KeyPressEventArgs e)
		{
			if (e.KeyChar != 127 && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 44 && e.KeyChar != 46)
			{
				return true;
			}
			return false;
		}

		// handle all keys except carachters for int type
		private bool eHandlerForInt(KeyPressEventArgs e)
		{
			if (e.KeyChar != 127 && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
			{
				return true;
			}
			return false;
		}


		// try to parse double from string (if not successfull return 0 and shows message box with errorMessage)
		private double GetDoubleFromString(string text, string errorMessage)
		{
			double result;
			// change all poins with commas
			text = text.Replace(".", ",");
			// if failed to parse double, show error message
			if (!double.TryParse(text, out result))
			{
				MessageBox.Show(errorMessage);
			}
			// this will throw exeption if failed
			result = double.Parse(text);
			return result;
		}

		// try to parse int from string (if not successfull return 0 and shows message box with errorMessage)
		private int GetIntFromString(string text, string errorMessage)
		{
			int result;
			// if failed to parse int, show error message
			if (!int.TryParse(text, out result))
			{
				MessageBox.Show(errorMessage);
			}
			// this will throw exeption if failed
			result = int.Parse(text);
			return result;
		}


		private void btnCalculateLoan_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable table = GetLoanParamsAndReceiveTable();
				dgvLoanCalculation.DataSource = null;
				dgvLoanCalculation.DataSource = table;
				foreach (DataGridViewColumn col in dgvLoanCalculation.Columns)
				{
					col.HeaderText = table.Columns[col.Name].Caption;
				}
				// make last two strings italic
				dgvLoanCalculation.Rows[dgvLoanCalculation.RowCount - 1].DefaultCellStyle.Font = dgvLoanCalculation.Rows[dgvLoanCalculation.RowCount - 2].DefaultCellStyle.Font = new Font(Font, FontStyle.Italic);
				// disabling column sorting on column header click
				DisableColumnSorting(dgvLoanCalculation);
			}
			catch (Exception)
			{
				// ignored
			}
		}

		// collecting needed parameters and calling DLL-method to receive and return the table
		private DataTable GetLoanParamsAndReceiveTable()
		{
			bool isPaymentSchemeAnnuity = (cbxScheme.SelectedItem.ToString() == "Annuity");
			double loanSize = GetDoubleFromString(txtLoanAmount.Text, "Invalid loan amount value.");
			CheckNoZero(loanSize, "Loan amount must be greater than zero");
			double interestRatePerYear = GetDoubleFromString(mtbxInterestRate.Text, "Invalid interest rate value.");
			double downPayment = GetDoubleFromString(txtDownPayment.Text, "Invalid down payment value.");
			bool isDownPaymentPct = rbtnPercentDownPayment.Checked;
			double oneTimeCommission = GetDoubleFromString(txtOneTimeCommission.Text, "Invalid one-time commission value.");
			bool isOneTimeCommissionPct = rbtnPercentOneTimeCommission.Checked;
			double monthlyCommissionFixed = GetDoubleFromString(txtMonthlyCommissionFixed.Text, "Invalid fixed monthly commission value.");
			bool isMonthlyCommissionFixedPctOfLoan = rbtnPercentMonthlyCommissionFixed.Checked;
			double monthlyCommissionInPctOfBalance = GetDoubleFromString(mtbxMonthlyCommissionVarying.Text, "Invalid varying monthly commission value.");
			int term = GetIntFromString(mtbxTerm.Text, "Invalid term value.");
			CheckNoZero(term, "Term must be greater than zero");
			if (rbtnYears.Checked)
			{
				term *= 12;
			}

			DataTable table = LoanAndDeposit.GetLoanDataTable(isPaymentSchemeAnnuity, loanSize, interestRatePerYear, downPayment, isDownPaymentPct, oneTimeCommission, isOneTimeCommissionPct, monthlyCommissionFixed, isMonthlyCommissionFixedPctOfLoan, monthlyCommissionInPctOfBalance, term);

			return table;
		}

		// 
		private static void CheckNoZero(double doubleValue, string errorMessage)
		{
			if (doubleValue != 0) return;
			MessageBox.Show(errorMessage);
			throw new NotImplementedException();
		}
		private static void CheckNoZero(int intValue, string errorMessage)
		{
			if (intValue != 0) return;
			MessageBox.Show(errorMessage);
			throw new NotImplementedException();
		}

		// start to count on Enter keypress
		private void tabControl_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				if (tabLoan == tabControl.SelectedTab)
				{
					btnCalculateLoan_Click(sender, e);
				}
				if (tabDeposit == tabControl.SelectedTab)
				{
					btnCalculateDeposit_Click(sender, e);
				}
			}

		}

		private void txtDepositAmount_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = eHandlerForInt(e);
		}

		private void txtReplenishment_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = eHandlerForInt(e);
		}

		private void txtAnnualInterestRate_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = eHandlerForDouble(e);
		}

		private void txtTaxes_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = eHandlerForDouble(e);
		}

		private void btnCalculateDeposit_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable table = GetDepositParamsAndReceiveTable();
				dgvDepositCalculation.DataSource = null;
				dgvDepositCalculation.DataSource = table;
				// set caption as a column header
				foreach (DataGridViewColumn column in dgvDepositCalculation.Columns)
				{
					column.HeaderText = table.Columns[column.Name].Caption;
				}
				// make last string italic
				dgvDepositCalculation.Rows[dgvDepositCalculation.RowCount - 1].DefaultCellStyle.Font = dgvDepositCalculation.Rows[dgvDepositCalculation.RowCount - 2].DefaultCellStyle.Font = new Font(Font, FontStyle.Italic);
				// disabling column sorting on column header click
				DisableColumnSorting(dgvDepositCalculation);
			}
			catch (Exception)
			{
				// ignored
			}
		}

		private DataTable GetDepositParamsAndReceiveTable()
		{
			double depositAmount = GetDoubleFromString(txtDepositAmount.Text, "Invalid deposit amount value.");
			CheckNoZero(depositAmount, "Deposit amount must be greater than zero");
			int termInMonths = GetIntFromString(mtbxDepositTerm.Text, "Invalid term value.");
			CheckNoZero(termInMonths, "Term must be greater than zero");
			if (rbtnYearsDeposit.Checked)
			{
				termInMonths *= 12;
			}
			double annualInterestPct = GetDoubleFromString(txtAnnualInterestRate.Text, "Invalid interest rate value.");
			int capitalizationPeriodInMonths;
			// turn capitalization period in months number
			switch (cbxCapitalization.SelectedItem.ToString())
			{
				case "None":
					capitalizationPeriodInMonths = 0;
					break;
				case "Monthly":
					capitalizationPeriodInMonths = 1;
					break;
				case "Quarterly":
					capitalizationPeriodInMonths = 3;
					break;
				case "Half yearly":
					capitalizationPeriodInMonths = 6;
					break;
				case "Yearly":
					capitalizationPeriodInMonths = 12;
					break;
				default:
					capitalizationPeriodInMonths = 0;
					break;
			}
			int replenishmentAmount = GetIntFromString(txtReplenishment.Text, "Invalid replenishment value.");
			int replenishmentPeriodInMonths;
			// turn replenishment period in months number
			switch (cbxReplenishmentPeriod.SelectedItem.ToString())
			{
				case "None":
					replenishmentPeriodInMonths = 0;
					break;
				case "Month":
					replenishmentPeriodInMonths = 1;
					break;
				case "Quarter":
					replenishmentPeriodInMonths = 3;
					break;
				case "Half year":
					replenishmentPeriodInMonths = 6;
					break;
				case "Year":
					replenishmentPeriodInMonths = 12;
					break;
				default:
					replenishmentPeriodInMonths = 0;
					break;
			}
			double taxes = GetDoubleFromString(txtTaxes.Text, "Invalid taxes value.\nSet zero if none.");
			DataTable table = LoanAndDeposit.GetDepositDataTable(depositAmount, annualInterestPct, termInMonths,
				capitalizationPeriodInMonths, replenishmentAmount, replenishmentPeriodInMonths, taxes);
			return table;
		}
	}
}
