using System;
using System.Data;

namespace LoanDebitLibrary
{
	public static class LoanAndDeposit
	{
		// get DataTable for Loan with received parameters
		public static DataTable GetLoanDataTable(bool isPaymentSchemeAnnuity, double loanSize, double interestRatePerYear, double downPayment, bool isDownPaymentPct, double oneTimeCommission, bool isOneTimeCommissionPct, double monthCommissionFixed, bool isMonthCommissionFixedPctOfLoan, double monthCommissionInPctOfBalance, int termInMonths)
		{
			// protection from loanSize or termInMonths values = zero
			if (loanSize <= 0 || termInMonths <= 0)
			{
				DataTable errorDataTable = new DataTable("Error table");
				DataColumn colError = new DataColumn("Error", Type.GetType("System.String"));
				errorDataTable.Columns.Add(colError);
				if (loanSize <= 0)
				{
					DataRow rowError = errorDataTable.NewRow();
					rowError["Error"] = "Loan amount must be greater than 0.";
					errorDataTable.Rows.Add(rowError);
				}
				if (termInMonths <= 0)
				{
					DataRow rowError = errorDataTable.NewRow();
					rowError["Error"] = "Term must be greater than 0.";
					errorDataTable.Rows.Add(rowError);

				}
				return errorDataTable;
			}
			// create DataTable
			DataTable table = new DataTable("Loan table");
			// create some table variables
			DataColumn column;
			DataRow row;

			// set some parameters in fixed value
			downPayment = GetFixedValue(loanSize, downPayment, isDownPaymentPct);
			// OLD downPayment = Math.Round(GetFixedValue(loanSize, downPayment, isDownPaymentPct), 2);
			oneTimeCommission = GetFixedValue(loanSize, oneTimeCommission, isOneTimeCommissionPct);
			// OLD oneTimeCommission = Math.Round(GetFixedValue(loanSize, oneTimeCommission, isOneTimeCommissionPct), 2);
			monthCommissionFixed = GetFixedValue(loanSize, monthCommissionFixed, isMonthCommissionFixedPctOfLoan);
			//OLD monthCommissionFixed = Math.Round(GetFixedValue(loanSize, monthCommissionFixed, isMonthCommissionFixedPctOfLoan), 2);
			monthCommissionInPctOfBalance = monthCommissionInPctOfBalance * 0.01; // cast to a fractional view
			interestRatePerYear *= 0.01; // cast to a fractional view

			// Set columns, their names, captions and add them to table 
			{
				// add first column
				column = new DataColumn("period", Type.GetType("System.String"));
				column.Caption = "Month #";
				table.Columns.Add(column);

				// add second column
				column = new DataColumn("pctPayment", Type.GetType("System.String"));
				column.Caption = "Interest payment";
				table.Columns.Add(column);

				// add third column
				column = new DataColumn("bodyPayment", Type.GetType("System.String"));
				column.Caption = "Principal payment";
				table.Columns.Add(column);

				// add fourth column
				column = new DataColumn("monthlyCommission", Type.GetType("System.String"));
				column.Caption = "Commission payment";
				table.Columns.Add(column);

				// add fifrh column
				column = new DataColumn("commonPayment", Type.GetType("System.String"));
				column.Caption = "Common payment";
				table.Columns.Add(column);

				// add sixth column
				column = new DataColumn("debtBalance", Type.GetType("System.String"));
				column.Caption = "Debt balance";
				table.Columns.Add(column);
			}

			// start month count
			int period = 0;
			// set current debt balance
			double debtBalance = loanSize - downPayment;
			// declare variables for calculating current month parameters
			double oneMonthInterestRate = interestRatePerYear / 12;
			// body payment for one month
			double oneMonthBodyPayment = 0;
			double oneMonthAnnuityPayment = 0;
			// if annuity scheme
			if (isPaymentSchemeAnnuity)
			{
				oneMonthAnnuityPayment = Math.Round(debtBalance * (oneMonthInterestRate + (oneMonthInterestRate / (Math.Pow((1 + oneMonthInterestRate), termInMonths) - 1))), 2);
			}
			else
			// if classic scheme
			{
				oneMonthBodyPayment = Math.Round(debtBalance / termInMonths, 2);
			}
			// declare variables for the totals row
			string monthlyPaymentMin = "";
			string monthlyPaymentMax = "";
			double totalOverpay = oneTimeCommission;
			// all full payments array
			double[] allPayments = new double[termInMonths + 1];
			allPayments[0] = (debtBalance - oneTimeCommission) * -1;

			// add and fill rows
			while (debtBalance > 0)
			{
				// increase current payment month number
				period++;
				double pctPayment = 0;

				row = table.NewRow();
				row["period"] = period;
				pctPayment = Math.Round(debtBalance * oneMonthInterestRate, 2);

				row["pctPayment"] = string.Format("{0:F}", pctPayment);
				// add current interest payment to full sum of interest payments
				totalOverpay += pctPayment;

				//principal
				// if annuity scheme
				if (isPaymentSchemeAnnuity)
				{
					// if there comes overpay, cut this "tail"
					if (oneMonthAnnuityPayment - pctPayment > debtBalance)
					{
						oneMonthAnnuityPayment -= Math.Round(oneMonthAnnuityPayment - debtBalance - pctPayment, 2);
					}
					oneMonthBodyPayment = Math.Round(oneMonthAnnuityPayment - pctPayment, 2);
				}
				// if there will left less than 5% after next payment, add this "tail" to current payment
				if (debtBalance - oneMonthBodyPayment < oneMonthBodyPayment * 0.05)
				{
					oneMonthBodyPayment += Math.Round(debtBalance - oneMonthBodyPayment, 2);
				}

				row["bodyPayment"] = string.Format("{0:F}", oneMonthBodyPayment);

				// month commission
				double monthCommissionFull = Math.Round((monthCommissionFixed + (monthCommissionInPctOfBalance * debtBalance)), 2);
				row["monthlyCommission"] = string.Format("{0:F}", monthCommissionFull);
				// add current commission payment to total commission paid
				totalOverpay += monthCommissionFull;
				// full payment value
				double commonPayment = Math.Round((monthCommissionFull + pctPayment + oneMonthBodyPayment), 2);
				row["commonPayment"] = string.Format("{0:F}", commonPayment);
				allPayments[period] = commonPayment;

				// lower loan body size by current payment
				debtBalance = Math.Round(debtBalance - oneMonthBodyPayment, 2);
				row["debtBalance"] = string.Format("{0:F}", debtBalance);

				table.Rows.Add(row);
			}

			// add totals row 1
			row = table.NewRow();
			row["period"] = "Credit cost ($):";
			row["pctPayment"] = string.Format("{0:F}", totalOverpay);
			row["bodyPayment"] = "Credit cost (%):";
			row["monthlyCommission"] = string.Format("{0:F}", totalOverpay / loanSize * 100);
			row["commonPayment"] = "Total paid:";
			row["debtBalance"] = string.Format("{0:F}", loanSize + totalOverpay);
			table.Rows.Add(row);

			// add totals row 2
			row = table.NewRow();
			row["period"] = "Start payment:";
			row["pctPayment"] = string.Format("{0:F}", downPayment + oneTimeCommission);
			// set min & max payment 
			monthlyPaymentMax = table.Rows[0]["commonPayment"].ToString();
			monthlyPaymentMin = table.Rows[(table.Rows.Count - 2)]["commonPayment"].ToString();
			row["bodyPayment"] = "Monthly payment:";
			row["monthlyCommission"] = monthlyPaymentMax + "... " + monthlyPaymentMin;
			row["commonPayment"] = "Effective rate:";
			row["debtBalance"] = string.Format("{0:F}", EffectiveRate(allPayments) * 12 * 100);
			table.Rows.Add(row);

			return table;
		}

		// count effective rate (full credit value)
		private static double EffectiveRate(double[] allPayments)
		{
			// step for increasing effective rate
			double step = 0.1;
			double effectiveRate = step;
			// start to look for equality
			while (true)
			{
				// saves row sum
				double value = 0;
				// count equality for each period
				for (int i = 0; i < allPayments.Length; i++)
				{
					// formula 
					value += allPayments[i] / Math.Pow((1 + effectiveRate), (i));
				}
				// quit search and exit if equality value is nearly zero
				if (Math.Round(value, 3) == 0)
				{
					break;
				}
				// if equality value dropped below zero
				if (value < -0.0001)
				{
					// return a step back
					effectiveRate -= step;
					// decrease step size
					step /= 10;
				}
				// next step for effective rate
				effectiveRate += step;
			}

			return effectiveRate;
		}

		/************************** DEPOSIT ******************************/

		// get DataTable for Deposit with received parameters
		public static DataTable GetDepositDataTable(double depositAmount, double annualInterestPct, int termInMonths, int capitalizationPeriodInMonths, int replenishmentAmount, int replenishmentPeriodInMonths, double taxes)
		{
			DataTable table = new DataTable("Deposit table");
			// create some table variables
			DataColumn column;
			DataRow row;

			// protection from depositAmount or termInMonths values = zero
			if (depositAmount <= 0 || termInMonths <= 0)
			{
				DataTable errorDataTable = new DataTable("Error table");
				DataColumn colError = new DataColumn("Error", Type.GetType("System.String"));
				errorDataTable.Columns.Add(colError);
				if (depositAmount <= 0)
				{
					DataRow rowError = errorDataTable.NewRow();
					rowError["Error"] = "Deposit amount must be greater than 0.";
					errorDataTable.Rows.Add(rowError);
				}
				if (termInMonths <= 0)
				{
					DataRow rowError = errorDataTable.NewRow();
					rowError["Error"] = "Term must be greater than 0.";
					errorDataTable.Rows.Add(rowError);

				}
				return errorDataTable;
			}


			// convert percent into fractional view and count month enterest rate
			double monthInterestPct = (annualInterestPct * 0.01) / 12;

			// Set columns, their names, captions and add them to table 
			{
				// add first column
				column = new DataColumn("period", Type.GetType("System.String"));
				column.Caption = "Month #";
				table.Columns.Add(column);

				// add second column
				column = new DataColumn("pctIncome", Type.GetType("System.String"));
				column.Caption = "% income";
				table.Columns.Add(column);

				// add third column
				column = new DataColumn("replenishment", Type.GetType("System.String"));
				column.Caption = "Replenishment";
				table.Columns.Add(column);

				// add fourth column
				column = new DataColumn("bodySize", Type.GetType("System.String"));
				column.Caption = "Deposit amount";
				table.Columns.Add(column);

			}

			// declare variables for filling the table
			// start month count
			int period = 0;
			// count total income
			double totalPctIncome = 0;
			// count replenishments sum
			double replenishments = 0;
			// this will decrease mature value by capitalized percents
			double matureValueReduction = 0;

			// add and fill rows
			while (period < termInMonths)
			{
				// next month
				period++;
				//start to fill a new row 
				row = table.NewRow();

				row["period"] = period;

				double pctIncome = depositAmount * monthInterestPct;
				row["pctIncome"] = $"{Math.Round(pctIncome, 2):F}";
				totalPctIncome += pctIncome;

				// replenish deposit every replenishment period except last
				if (replenishmentPeriodInMonths == 0 || period % replenishmentPeriodInMonths != 0 || period == termInMonths)
				{
					row["replenishment"] = 0;
				}
				else
				{
					row["replenishment"] = replenishmentAmount;
					depositAmount += replenishmentAmount;
					replenishments += replenishmentAmount;
				}

				//check for capitalization
				if (capitalizationPeriodInMonths != 0 && period % capitalizationPeriodInMonths == 0)
				{
					depositAmount += pctIncome * capitalizationPeriodInMonths;
					// this will correct maturity value at the end
					matureValueReduction += pctIncome * capitalizationPeriodInMonths;
				}
				row["bodySize"] = $"{depositAmount:F}";
				table.Rows.Add(row);
			}


			// add totals row 1
			row = table.NewRow();
			row["period"] = "Month income:";
			if (table.Rows[0]["pctIncome"].ToString() == table.Rows[table.Rows.Count - 1]["pctIncome"].ToString())
			{
				row["pctIncome"] = $"{table.Rows[0]["pctIncome"]}";
			}
			else
			{
				row["pctIncome"] = $"{table.Rows[0]["pctIncome"]}... {table.Rows[table.Rows.Count - 1]["pctIncome"]}";
			}
			row["replenishment"] = "Replenishments:";
			row["bodySize"] = $"{replenishments:F}";
			table.Rows.Add(row);

			// add totals row 2
			row = table.NewRow();
			if (taxes == 0)
			{
				row["period"] = "Total income:";
			}
			else
			{
				row["period"] = "Income excluding taxes:";
			}
			row["pctIncome"] = $"{(totalPctIncome - (totalPctIncome * taxes * 0.01)):F}";
			row["replenishment"] = "Maturity value:";
			row["bodySize"] = $"{(depositAmount + totalPctIncome - matureValueReduction):F}";
			table.Rows.Add(row);

			return table;
		}

		// get a fixed loan parameter value either it is set in percents or it is set in fixed value
		private static double GetFixedValue(double fullSize, double value, bool isPct)
		{
			if (isPct)
			{
				double fixedValue = (value * 0.01) * fullSize;
				return fixedValue;
			}
			return value;
		}
	}
}
