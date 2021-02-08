/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

//------------------------------------------------------------------------------
// This code was generated by a tool.
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

// To get up to date fundamental definition files for your hedgefund contact sales@quantconnect.com

namespace QuantConnect.Data.Fundamental
{
	/// <summary>
	/// Definition of the FineFundamental class
	/// </summary>
	public partial class FineFundamental : BaseData
	{
		/// <summary>
		/// The instance of the CompanyReference class
		/// </summary>
		public CompanyReference CompanyReference { get; set; }

		/// <summary>
		/// The instance of the SecurityReference class
		/// </summary>
		public SecurityReference SecurityReference { get; set; }

		/// <summary>
		/// The instance of the FinancialStatements class
		/// </summary>
		public FinancialStatements FinancialStatements { get; set; }

		/// <summary>
		/// The instance of the EarningReports class
		/// </summary>
		public EarningReports EarningReports { get; set; }

		/// <summary>
		/// The instance of the OperationRatios class
		/// </summary>
		public OperationRatios OperationRatios { get; set; }

		/// <summary>
		/// The instance of the EarningRatios class
		/// </summary>
		public EarningRatios EarningRatios { get; set; }

		/// <summary>
		/// The instance of the ValuationRatios class
		/// </summary>
		public ValuationRatios ValuationRatios { get; set; }

		/// <summary>
		/// The instance of the CompanyProfile class
		/// </summary>
		public CompanyProfile CompanyProfile { get; set; }

		/// <summary>
		/// The instance of the AssetClassification class
		/// </summary>
		public AssetClassification AssetClassification { get; set; }

		/// <summary>
		/// Creates an instance of the FineFundamental class
		/// </summary>
		public FineFundamental()
		{
			DataType = MarketDataType.Auxiliary;

			CompanyReference = new CompanyReference();
			SecurityReference = new SecurityReference();
			FinancialStatements = new FinancialStatements();
			EarningReports = new EarningReports();
			OperationRatios = new OperationRatios();
			EarningRatios = new EarningRatios();
			ValuationRatios = new ValuationRatios();
			CompanyProfile = new CompanyProfile();
			AssetClassification = new AssetClassification();
		}

		/// <summary>
		/// Applies updated values from <paramref name="update"/> to this instance
		/// </summary>
		/// <remarks>Used to apply data updates to the current instance. This WILL overwrite existing values. Default update values are ignored.</remarks>
		/// <param name="update">The next data update for this instance</param>
		public void UpdateValues(FineFundamental update)
		{
			if (update == null) return;

			CompanyReference?.UpdateValues(update.CompanyReference);
			SecurityReference?.UpdateValues(update.SecurityReference);
			FinancialStatements?.UpdateValues(update.FinancialStatements);
			EarningReports?.UpdateValues(update.EarningReports);
			OperationRatios?.UpdateValues(update.OperationRatios);
			EarningRatios?.UpdateValues(update.EarningRatios);
			ValuationRatios?.UpdateValues(update.ValuationRatios);
			CompanyProfile?.UpdateValues(update.CompanyProfile);
			AssetClassification?.UpdateValues(update.AssetClassification);
		}
	}
}