using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Enabled                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 M_LegacyAdapter                          0001866F1BF0 ModelClassType IAnalyticsAdapter IAnalyticsAdapter IAnalyticsAdapter Pointer
    // 020 M_EmptyAdapter                           0001866F1BF0 ModelClassType IAnalyticsAdapter IAnalyticsAdapter IAnalyticsAdapter Pointer
    public partial class LegacyAnalyticsWrapper : DataModel
    {
        public bool                                     M_Enabled                               { get; set; }
        public IAnalyticsAdapter?                       M_LegacyAdapter                         { get; set; }
        public IAnalyticsAdapter?                       M_EmptyAdapter                          { get; set; }

        public static LegacyAnalyticsWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyAnalyticsWrapper() { Pointer= p0 };

            value.M_Enabled                                 = GetBool(new IntPtr(p + 0x010)); // 0245A4C10840 0x10 M_Enabled                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_LegacyAdapter                           = GetObject<IAnalyticsAdapter>(new IntPtr(p + 0x018), ReversePrism.DataModels.IAnalyticsAdapter.FromPointer); // 0245A4C10860 0x18 M_LegacyAdapter             ( 0001866F1BF0 ModelClassType IAnalyticsAdapter IAnalyticsAdapter IAnalyticsAdapter Pointer )
            value.M_EmptyAdapter                            = GetObject<IAnalyticsAdapter>(new IntPtr(p + 0x020), ReversePrism.DataModels.IAnalyticsAdapter.FromPointer); // 0245A4C10880 0x20 M_EmptyAdapter              ( 0001866F1BF0 ModelClassType IAnalyticsAdapter IAnalyticsAdapter IAnalyticsAdapter Pointer )

            return value;
        }
    }
}
