using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Identifier                               0001866722E0 ModelPrimitiveType string string string String
    // 018 Country                                  0001866722E0 ModelPrimitiveType string string string String
    // 020 Region                                   0001866722E0 ModelPrimitiveType string string string String
    // 028 AgeGateLimit                             0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class GeoIPResponse
    {
        public string                                   Identifier                              { get; set; }
        public string                                   Country                                 { get; set; }
        public string                                   Region                                  { get; set; }
        public int                                      AgeGateLimit                            { get; set; }

        public static GeoIPResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GeoIPResponse();

            value.Identifier                                = GetString(new IntPtr(p + 0x010)); // 0270DB798E38 0x10 Identifier                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Country                                   = GetString(new IntPtr(p + 0x018)); // 0270DB798E58 0x18 Country                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Region                                    = GetString(new IntPtr(p + 0x020)); // 0270DB798E78 0x20 Region                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AgeGateLimit                              = GetInt32(new IntPtr(p + 0x028)); // 0270DB798E98 0x28 AgeGateLimit                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
