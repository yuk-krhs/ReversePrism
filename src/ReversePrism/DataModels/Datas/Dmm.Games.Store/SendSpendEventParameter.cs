using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SdkCommand                               ModelPrimitiveType string string string String
    // 018 Parameter                                ModelClassType AmountParameter AmountParameter AmountParameter Pointer
    public partial class SendSpendEventParameter : DataModel
    {
        public string                                   SdkCommand                              { get; set; }
        public AmountParameter?                         Parameter                               { get; set; }

        public static SendSpendEventParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SendSpendEventParameter() { Pointer= p0 };

            value.SdkCommand                                = GetString(new IntPtr(p + 0x010)); // 0x10 SdkCommand                  ( ModelPrimitiveType string string string String )
            value.Parameter                                 = GetObject<AmountParameter>(new IntPtr(p + 0x018), ReversePrism.DataModels.AmountParameter.FromPointer); // 0x18 Parameter                   ( ModelClassType AmountParameter AmountParameter AmountParameter Pointer )

            return value;
        }
    }
}
