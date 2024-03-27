using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 AppId                                    0001866722E0 ModelPrimitiveType string string string String
    // 030 Method                                   0001866722E0 ModelPrimitiveType string string string String
    // 038 TextId                                   0001866722E0 ModelPrimitiveType string string string String
    // 040 Text                                     0001866722E0 ModelPrimitiveType string string string String
    public partial class InspectionParameter
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
            var value   = new InspectionParameter();

            value.AppId                                     = GetString(new IntPtr(p + 0x028)); // 0270DB499470 0x28 AppId                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Method                                    = GetString(new IntPtr(p + 0x030)); // 0270DB499490 0x30 Method                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TextId                                    = GetString(new IntPtr(p + 0x038)); // 0270DB4994B0 0x38 TextId                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Text                                      = GetString(new IntPtr(p + 0x040)); // 0270DB4994D0 0x40 Text                        ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
