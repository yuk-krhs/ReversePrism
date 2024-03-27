using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CueSheet                                 0001866722E0 ModelPrimitiveType string string string String
    // 018 CueName                                  0001866722E0 ModelPrimitiveType string string string String
    // 020 Start                                    0001865C2E50 ModelPrimitiveType double double double Double
    // 028 OffsetTime                               0001865C2E50 ModelPrimitiveType double double double Double
    // 030 Volume                                   000186666050 ModelPrimitiveType float float float Single
    // 034 Played                                   000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class VoiceRequest
    {
        public string                                   CueSheet                                { get; set; }
        public string                                   CueName                                 { get; set; }
        public double                                   Start                                   { get; set; }
        public double                                   OffsetTime                              { get; set; }
        public float                                    Volume                                  { get; set; }
        public bool                                     Played                                  { get; set; }

        public static VoiceRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoiceRequest();

            value.CueSheet                                  = GetString(new IntPtr(p + 0x010)); // 027006F4C6E0 0x10 CueSheet                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x018)); // 027006F4C700 0x18 CueName                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Start                                     = GetDouble(new IntPtr(p + 0x020)); // 027006F4C720 0x20 Start                       ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.OffsetTime                                = GetDouble(new IntPtr(p + 0x028)); // 027006F4C740 0x28 OffsetTime                  ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Volume                                    = GetSingle(new IntPtr(p + 0x030)); // 027006F4C760 0x30 Volume                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Played                                    = GetBool(new IntPtr(p + 0x034)); // 027006F4C780 0x34 Played                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
