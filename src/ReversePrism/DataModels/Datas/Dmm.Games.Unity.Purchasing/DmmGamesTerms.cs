using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PeriodTimeDescription                    ModelPrimitiveType string string string String
    // 018 TermOfDelivery                           ModelPrimitiveType string string string String
    // 020 TermOfPayment                            ModelPrimitiveType string string string String
    // 028 ReturnPolicy                             ModelPrimitiveType string string string String
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

            value.PeriodTimeDescription                     = GetString(new IntPtr(p + 0x010)); // 0x10 PeriodTimeDescription       ( ModelPrimitiveType string string string String )
            value.TermOfDelivery                            = GetString(new IntPtr(p + 0x018)); // 0x18 TermOfDelivery              ( ModelPrimitiveType string string string String )
            value.TermOfPayment                             = GetString(new IntPtr(p + 0x020)); // 0x20 TermOfPayment               ( ModelPrimitiveType string string string String )
            value.ReturnPolicy                              = GetString(new IntPtr(p + 0x028)); // 0x28 ReturnPolicy                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
