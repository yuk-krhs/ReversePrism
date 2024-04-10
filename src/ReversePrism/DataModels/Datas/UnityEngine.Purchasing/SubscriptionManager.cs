using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Receipt                                  000186672F10 ModelPrimitiveType string string string String
    // 018 ProductId                                000186672F10 ModelPrimitiveType string string string String
    // 020 Intro_json                               000186672F10 ModelPrimitiveType string string string String
    public partial class SubscriptionManager : DataModel
    {
        public string                                   Receipt                                 { get; set; }
        public string                                   ProductId                               { get; set; }
        public string                                   Intro_json                              { get; set; }

        public static SubscriptionManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubscriptionManager() { Pointer= p0 };

            value.Receipt                                   = GetString(new IntPtr(p + 0x010)); // 0245A68E0070 0x10 Receipt                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.ProductId                                 = GetString(new IntPtr(p + 0x018)); // 0245A68E0090 0x18 ProductId                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.Intro_json                                = GetString(new IntPtr(p + 0x020)); // 0245A68E00B0 0x20 Intro_json                  ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
