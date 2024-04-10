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
    public partial class BodyParameter : DataModel
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
            var value   = new BodyParameter() { Pointer= p0 };

            value.CharaName                                 = GetString(new IntPtr(p + 0x010)); // 0245A699F578 0x10 CharaName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CharaID                                   = GetString(new IntPtr(p + 0x018)); // 0245A699F598 0x18 CharaID                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Height                                    = GetSingle(new IntPtr(p + 0x020)); // 0245A699F5B8 0x20 Height                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Bust                                      = GetSingle(new IntPtr(p + 0x024)); // 0245A699F5D8 0x24 Bust                        ( 000186666050 ModelPrimitiveType float float float Single )
            value.Head                                      = GetSingle(new IntPtr(p + 0x028)); // 0245A699F5F8 0x28 Head                        ( 000186666050 ModelPrimitiveType float float float Single )
            value.Thin                                      = GetSingle(new IntPtr(p + 0x02C)); // 0245A699F618 0x2C Thin                        ( 000186666050 ModelPrimitiveType float float float Single )
            value.Shoulder                                  = GetSingle(new IntPtr(p + 0x030)); // 0245A699F638 0x30 Shoulder                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Hip                                       = GetSingle(new IntPtr(p + 0x034)); // 0245A699F658 0x34 Hip                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.Skin                                      = GetInt32(new IntPtr(p + 0x038)); // 0245A699F678 0x38 Skin                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Color                                     = GetInt32(new IntPtr(p + 0x03C)); // 0245A699F698 0x3C Color                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SkinBright                                = GetString(new IntPtr(p + 0x040)); // 0245A699F6B8 0x40 SkinBright                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SkinDark                                  = GetString(new IntPtr(p + 0x048)); // 0245A699F6D8 0x48 SkinDark                    ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
