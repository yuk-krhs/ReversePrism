using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PeriodTimeDescription                    0001866722E0 ModelPrimitiveType string string string String
    // 018 TermOfDelivery                           0001866722E0 ModelPrimitiveType string string string String
    // 020 TermOfPayment                            0001866722E0 ModelPrimitiveType string string string String
    // 028 ReturnPolicy                             0001866722E0 ModelPrimitiveType string string string String
    public partial class DmmGamesTerms : DataModel
    {
        public string                                   PeriodTimeDescription                   { get; set; }
        public string                                   TermOfDelivery                          { get; set; }
        public string                                   TermOfPayment                           { get; set; }
        public string                                   ReturnPolicy                            { get; set; }

        public static DmmGamesTerms? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DmmGamesTerms() { Pointer= p0 };

            value.PeriodTimeDescription                     = GetString(new IntPtr(p + 0x010)); // 02466B510090 0x10 PeriodTimeDescription       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TermOfDelivery                            = GetString(new IntPtr(p + 0x018)); // 02466B5100B0 0x18 TermOfDelivery              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TermOfPayment                             = GetString(new IntPtr(p + 0x020)); // 02466B5100D0 0x20 TermOfPayment               ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ReturnPolicy                              = GetString(new IntPtr(p + 0x028)); // 02466B5100F0 0x28 ReturnPolicy                ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
