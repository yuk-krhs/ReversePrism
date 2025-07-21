using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CueSheet                                 ModelPrimitiveType string string string String
    // 018 CueName                                  ModelPrimitiveType string string string String
    // 020 Start                                    ModelPrimitiveType double double double Double
    // 028 OffsetTime                               ModelPrimitiveType double double double Double
    // 030 Volume                                   ModelPrimitiveType float float float Single
    // 034 Played                                   ModelPrimitiveType bool bool bool Bool
    public partial class VoiceRequest : DataModel
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
            var value   = new VoiceRequest() { Pointer= p0 };

            value.CueSheet                                  = GetString(new IntPtr(p + 0x010)); // 0x10 CueSheet                    ( ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x018)); // 0x18 CueName                     ( ModelPrimitiveType string string string String )
            value.Start                                     = GetDouble(new IntPtr(p + 0x020)); // 0x20 Start                       ( ModelPrimitiveType double double double Double )
            value.OffsetTime                                = GetDouble(new IntPtr(p + 0x028)); // 0x28 OffsetTime                  ( ModelPrimitiveType double double double Double )
            value.Volume                                    = GetSingle(new IntPtr(p + 0x030)); // 0x30 Volume                      ( ModelPrimitiveType float float float Single )
            value.Played                                    = GetBool(new IntPtr(p + 0x034)); // 0x34 Played                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
