using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SdkCommand                               0001866722E0 ModelPrimitiveType string string string String
    // 018 Parameter                                00018675D650 ModelClassType AmountParameter AmountParameter AmountParameter Pointer
    public partial class SendSpendEventParameter
    {
        public string                                   SdkCommand                              { get; set; }
        public AmountParameter?                         Parameter                               { get; set; }

        public static SendSpendEventParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SendSpendEventParameter();

            value.SdkCommand                                = GetString(new IntPtr(p + 0x010)); // 0270DB4B7358 0x10 SdkCommand                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Parameter                                 = GetObject<AmountParameter>(new IntPtr(p + 0x018), ReversePrism.DataModels.AmountParameter.FromPointer); // 0270DB4B7378 0x18 Parameter                   ( 00018675D650 ModelClassType AmountParameter AmountParameter AmountParameter Pointer )

            return value;
        }
    }
}
