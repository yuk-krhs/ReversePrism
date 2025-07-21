using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 T                                        ModelPrimitiveType string string string String
    // 000 MaxSubtypeLength                         int IL2CPP_TYPE_I4
    // 018 St                                       ModelPrimitiveType string string string String
    // 020 Q                                        ModelPrimitiveType double double double Double
    // 000 MaxDataLength                            int IL2CPP_TYPE_I4
    // 028 D                                        ModelPrimitiveType string string string String
    public partial class ProductCatalogPayout : DataModel
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
            var value   = new ProductCatalogPayout() { Pointer= p0 };

            value.T                                         = GetString(new IntPtr(p + 0x010)); // 0x10 T                           ( ModelPrimitiveType string string string String )
            value.St                                        = GetString(new IntPtr(p + 0x018)); // 0x18 St                          ( ModelPrimitiveType string string string String )
            value.Q                                         = GetDouble(new IntPtr(p + 0x020)); // 0x20 Q                           ( ModelPrimitiveType double double double Double )
            value.D                                         = GetString(new IntPtr(p + 0x028)); // 0x28 D                           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
