using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SdkCommand                               0001866722E0 ModelPrimitiveType string string string String
    public partial class ReceiptAuthDataParameter : DataModel
    {
        public string                                   SdkCommand                              { get; set; }

        public static ReceiptAuthDataParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiptAuthDataParameter() { Pointer= p0 };

            value.SdkCommand                                = GetString(new IntPtr(p + 0x010)); // 02466B544A28 0x10 SdkCommand                  ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
