using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharaName                                0001866722E0 ModelPrimitiveType string string string String
    // 018 CharaID                                  0001866722E0 ModelPrimitiveType string string string String
    // 020 Height                                   000186666050 ModelPrimitiveType float float float Single
    // 024 Bust                                     000186666050 ModelPrimitiveType float float float Single
    // 028 Head                                     000186666050 ModelPrimitiveType float float float Single
    // 02C Thin                                     000186666050 ModelPrimitiveType float float float Single
    // 030 Shoulder                                 000186666050 ModelPrimitiveType float float float Single
    // 034 Hip                                      000186666050 ModelPrimitiveType float float float Single
    // 038 Skin                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 03C Color                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 SkinBright                               0001866722E0 ModelPrimitiveType string string string String
    // 048 SkinDark                                 0001866722E0 ModelPrimitiveType string string string String
    public partial class BodyParameter
    {
        public string                                   CharaName                               { get; set; }
        public string                                   CharaID                                 { get; set; }
        public float                                    Height                                  { get; set; }
        public float                                    Bust                                    { get; set; }
        public float                                    Head                                    { get; set; }
        public float                                    Thin                                    { get; set; }
        public float                                    Shoulder                                { get; set; }
        public float                                    Hip                                     { get; set; }
        public int                                      Skin                                    { get; set; }
        public int                                      Color                                   { get; set; }
        public string                                   SkinBright                              { get; set; }
        public string                                   SkinDark                                { get; set; }

        public static BodyParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BodyParameter();

            value.CharaName                                 = GetString(new IntPtr(p + 0x010)); // 0270069E3268 0x10 CharaName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CharaID                                   = GetString(new IntPtr(p + 0x018)); // 0270069E3288 0x18 CharaID                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Height                                    = GetSingle(new IntPtr(p + 0x020)); // 0270069E32A8 0x20 Height                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Bust                                      = GetSingle(new IntPtr(p + 0x024)); // 0270069E32C8 0x24 Bust                        ( 000186666050 ModelPrimitiveType float float float Single )
            value.Head                                      = GetSingle(new IntPtr(p + 0x028)); // 0270069E32E8 0x28 Head                        ( 000186666050 ModelPrimitiveType float float float Single )
            value.Thin                                      = GetSingle(new IntPtr(p + 0x02C)); // 0270069E3308 0x2C Thin                        ( 000186666050 ModelPrimitiveType float float float Single )
            value.Shoulder                                  = GetSingle(new IntPtr(p + 0x030)); // 0270069E3328 0x30 Shoulder                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Hip                                       = GetSingle(new IntPtr(p + 0x034)); // 0270069E3348 0x34 Hip                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.Skin                                      = GetInt32(new IntPtr(p + 0x038)); // 0270069E3368 0x38 Skin                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Color                                     = GetInt32(new IntPtr(p + 0x03C)); // 0270069E3388 0x3C Color                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SkinBright                                = GetString(new IntPtr(p + 0x040)); // 0270069E33A8 0x40 SkinBright                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SkinDark                                  = GetString(new IntPtr(p + 0x048)); // 0270069E33C8 0x48 SkinDark                    ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
