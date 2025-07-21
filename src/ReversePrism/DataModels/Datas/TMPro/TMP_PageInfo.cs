using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FirstCharacterIndex                      ModelPrimitiveType int int int Int32
    // 014 LastCharacterIndex                       ModelPrimitiveType int int int Int32
    // 018 Ascender                                 ModelPrimitiveType float float float Single
    // 01C BaseLine                                 ModelPrimitiveType float float float Single
    // 020 Descender                                ModelPrimitiveType float float float Single
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

            value.FirstCharacterIndex                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 FirstCharacterIndex         ( ModelPrimitiveType int int int Int32 )
            value.LastCharacterIndex                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 LastCharacterIndex          ( ModelPrimitiveType int int int Int32 )
            value.Ascender                                  = GetSingle(new IntPtr(p + 0x018)); // 0x18 Ascender                    ( ModelPrimitiveType float float float Single )
            value.BaseLine                                  = GetSingle(new IntPtr(p + 0x01C)); // 0x1C BaseLine                    ( ModelPrimitiveType float float float Single )
            value.Descender                                 = GetSingle(new IntPtr(p + 0x020)); // 0x20 Descender                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
