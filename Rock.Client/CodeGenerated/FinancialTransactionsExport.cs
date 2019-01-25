//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Export result from ~/api/FinancialTransactions/Export
    /// </summary>
    public partial class FinancialTransactionsExportEntity
    {
        /// <summary />
        public List<FinancialTransactionExport> FinancialTransactions { get; set; }

        /// <summary />
        public int Page { get; set; }

        /// <summary />
        public int PageSize { get; set; }

        /// <summary />
        public int TotalCount { get; set; }

        /// <summary>
        /// Copies the base properties from a source FinancialTransactionsExport object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( FinancialTransactionsExport source )
        {
            this.FinancialTransactions = source.FinancialTransactions;
            this.Page = source.Page;
            this.PageSize = source.PageSize;
            this.TotalCount = source.TotalCount;

        }
    }

    /// <summary>
    /// Export result from ~/api/FinancialTransactions/Export
    /// </summary>
    public partial class FinancialTransactionsExport : FinancialTransactionsExportEntity
    {
    }
}
