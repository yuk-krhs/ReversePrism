using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Init                                     string IL2CPP_TYPE_STRING
    // 000 IsInit                                   string IL2CPP_TYPE_STRING
    // 000 Menu                                     string IL2CPP_TYPE_STRING
    // 000 OpenPayment                              string IL2CPP_TYPE_STRING
    // 000 ReceiptAuthData                          string IL2CPP_TYPE_STRING
    // 000 SendSpendEvent                           string IL2CPP_TYPE_STRING
    public partial class SdkCommand : DataModel
    {

        public static SdkCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SdkCommand() { Pointer= p0 };


            return value;
        }
    }
}
