using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 FetchPurchasesError                      string IL2CPP_TYPE_STRING
    // 000 InvalidProductError                      string IL2CPP_TYPE_STRING
    // 000 ParseReceiptTransactionError             string IL2CPP_TYPE_STRING
    // 000 QueryAsyncSkuError                       string IL2CPP_TYPE_STRING
    // 000 SkuDetailsResponseConsolidatorError      string IL2CPP_TYPE_STRING
    // 000 SkuDetailsResponseError                  string IL2CPP_TYPE_STRING
    public partial class TelemetryDiagnosticNames : DataModel
    {

        public static TelemetryDiagnosticNames? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TelemetryDiagnosticNames() { Pointer= p0 };


            return value;
        }
    }
}
