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
    public partial class PageInfo
    {
        public int                                      FirstCharacterIndex                     { get; set; }
        public int                                      LastCharacterIndex                      { get; set; }
        public float                                    Ascender                                { get; set; }
        public float                                    BaseLine                                { get; set; }
        public float                                    Descender                               { get; set; }

        public static PageInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PageInfo();

            value.FirstCharacterIndex                       = GetInt32(new IntPtr(p + 0x010)); // 0270068F96E8 0x10 FirstCharacterIndex         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LastCharacterIndex                        = GetInt32(new IntPtr(p + 0x014)); // 0270068F9708 0x14 LastCharacterIndex          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Ascender                                  = GetSingle(new IntPtr(p + 0x018)); // 0270068F9728 0x18 Ascender                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.BaseLine                                  = GetSingle(new IntPtr(p + 0x01C)); // 0270068F9748 0x1C BaseLine                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Descender                                 = GetSingle(new IntPtr(p + 0x020)); // 0270068F9768 0x20 Descender                   ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
