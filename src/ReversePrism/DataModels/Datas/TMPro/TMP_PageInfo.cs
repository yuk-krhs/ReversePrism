using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FirstCharacterIndex                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 LastCharacterIndex                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Ascender                                 000186666050 ModelPrimitiveType float float float Single
    // 01C BaseLine                                 000186666050 ModelPrimitiveType float float float Single
    // 020 Descender                                000186666050 ModelPrimitiveType float float float Single
    public partial class TMP_PageInfo : DataModel
    {
        public int                                      FirstCharacterIndex                     { get; set; }
        public int                                      LastCharacterIndex                      { get; set; }
        public float                                    Ascender                                { get; set; }
        public float                                    BaseLine                                { get; set; }
        public float                                    Descender                               { get; set; }

        public static TMP_PageInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_PageInfo() { Pointer= p0 };

            value.FirstCharacterIndex                       = GetInt32(new IntPtr(p + 0x010)); // 0245A3A17F60 0x10 FirstCharacterIndex         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LastCharacterIndex                        = GetInt32(new IntPtr(p + 0x014)); // 0245A3A17F80 0x14 LastCharacterIndex          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Ascender                                  = GetSingle(new IntPtr(p + 0x018)); // 0245A3A17FA0 0x18 Ascender                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.BaseLine                                  = GetSingle(new IntPtr(p + 0x01C)); // 0245A3A17FC0 0x1C BaseLine                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Descender                                 = GetSingle(new IntPtr(p + 0x020)); // 0245A3A17FE0 0x20 Descender                   ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
