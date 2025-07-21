using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharaName                                ModelPrimitiveType string string string String
    // 018 CharaID                                  ModelPrimitiveType string string string String
    // 020 Height                                   ModelPrimitiveType float float float Single
    // 024 Bust                                     ModelPrimitiveType float float float Single
    // 028 Head                                     ModelPrimitiveType float float float Single
    // 02C Thin                                     ModelPrimitiveType float float float Single
    // 030 Shoulder                                 ModelPrimitiveType float float float Single
    // 034 Hip                                      ModelPrimitiveType float float float Single
    // 038 Skin                                     ModelPrimitiveType int int int Int32
    // 03C Color                                    ModelPrimitiveType int int int Int32
    // 040 SkinBright                               ModelPrimitiveType string string string String
    // 048 SkinDark                                 ModelPrimitiveType string string string String
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

            value.CharaName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 CharaName                   ( ModelPrimitiveType string string string String )
            value.CharaID                                   = GetString(new IntPtr(p + 0x018)); // 0x18 CharaID                     ( ModelPrimitiveType string string string String )
            value.Height                                    = GetSingle(new IntPtr(p + 0x020)); // 0x20 Height                      ( ModelPrimitiveType float float float Single )
            value.Bust                                      = GetSingle(new IntPtr(p + 0x024)); // 0x24 Bust                        ( ModelPrimitiveType float float float Single )
            value.Head                                      = GetSingle(new IntPtr(p + 0x028)); // 0x28 Head                        ( ModelPrimitiveType float float float Single )
            value.Thin                                      = GetSingle(new IntPtr(p + 0x02C)); // 0x2C Thin                        ( ModelPrimitiveType float float float Single )
            value.Shoulder                                  = GetSingle(new IntPtr(p + 0x030)); // 0x30 Shoulder                    ( ModelPrimitiveType float float float Single )
            value.Hip                                       = GetSingle(new IntPtr(p + 0x034)); // 0x34 Hip                         ( ModelPrimitiveType float float float Single )
            value.Skin                                      = GetInt32(new IntPtr(p + 0x038)); // 0x38 Skin                        ( ModelPrimitiveType int int int Int32 )
            value.Color                                     = GetInt32(new IntPtr(p + 0x03C)); // 0x3C Color                       ( ModelPrimitiveType int int int Int32 )
            value.SkinBright                                = GetString(new IntPtr(p + 0x040)); // 0x40 SkinBright                  ( ModelPrimitiveType string string string String )
            value.SkinDark                                  = GetString(new IntPtr(p + 0x048)); // 0x48 SkinDark                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
