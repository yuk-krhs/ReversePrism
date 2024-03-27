using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 T                                        000186671910 ModelPrimitiveType string string string String
    // 000 MaxSubtypeLength                         int IL2CPP_TYPE_I4
    // 018 St                                       000186671910 ModelPrimitiveType string string string String
    // 020 Q                                        0001865C2950 ModelPrimitiveType double double double Double
    // 000 MaxDataLength                            int IL2CPP_TYPE_I4
    // 028 D                                        000186671910 ModelPrimitiveType string string string String
    public partial class ProductCatalogPayout
    {
        public string                                   T                                       { get; set; }
        public string                                   St                                      { get; set; }
        public double                                   Q                                       { get; set; }
        public string                                   D                                       { get; set; }

        public static ProductCatalogPayout? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductCatalogPayout();

            value.T                                         = GetString(new IntPtr(p + 0x010)); // 02700691A8D0 0x10 T                           ( 000186671910 ModelPrimitiveType string string string String )
            value.St                                        = GetString(new IntPtr(p + 0x018)); // 02700691A910 0x18 St                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Q                                         = GetDouble(new IntPtr(p + 0x020)); // 02700691A930 0x20 Q                           ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.D                                         = GetString(new IntPtr(p + 0x028)); // 02700691A970 0x28 D                           ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
