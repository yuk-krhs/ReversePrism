using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 AppId                                    ModelPrimitiveType string string string String
    // 030 Method                                   ModelPrimitiveType string string string String
    // 038 TextId                                   ModelPrimitiveType string string string String
    // 040 Text                                     ModelPrimitiveType string string string String
    public partial class InspectionParameter : DataModel
    {
        public string                                   AppId                                   { get; set; }
        public string                                   Method                                  { get; set; }
        public string                                   TextId                                  { get; set; }
        public string                                   Text                                    { get; set; }

        public static InspectionParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InspectionParameter() { Pointer= p0 };

            value.AppId                                     = GetString(new IntPtr(p + 0x028)); // 0x28 AppId                       ( ModelPrimitiveType string string string String )
            value.Method                                    = GetString(new IntPtr(p + 0x030)); // 0x30 Method                      ( ModelPrimitiveType string string string String )
            value.TextId                                    = GetString(new IntPtr(p + 0x038)); // 0x38 TextId                      ( ModelPrimitiveType string string string String )
            value.Text                                      = GetString(new IntPtr(p + 0x040)); // 0x40 Text                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
