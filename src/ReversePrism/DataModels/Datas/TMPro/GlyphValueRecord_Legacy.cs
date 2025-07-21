using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 XPlacement                               ModelPrimitiveType float float float Single
    // 014 YPlacement                               ModelPrimitiveType float float float Single
    // 018 XAdvance                                 ModelPrimitiveType float float float Single
    // 01C YAdvance                                 ModelPrimitiveType float float float Single
    public partial class GlyphValueRecord_Legacy : DataModel
    {
        public float                                    XPlacement                              { get; set; }
        public float                                    YPlacement                              { get; set; }
        public float                                    XAdvance                                { get; set; }
        public float                                    YAdvance                                { get; set; }

        public static GlyphValueRecord_Legacy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlyphValueRecord_Legacy() { Pointer= p0 };

            value.XPlacement                                = GetSingle(new IntPtr(p + 0x010)); // 0x10 XPlacement                  ( ModelPrimitiveType float float float Single )
            value.YPlacement                                = GetSingle(new IntPtr(p + 0x014)); // 0x14 YPlacement                  ( ModelPrimitiveType float float float Single )
            value.XAdvance                                  = GetSingle(new IntPtr(p + 0x018)); // 0x18 XAdvance                    ( ModelPrimitiveType float float float Single )
            value.YAdvance                                  = GetSingle(new IntPtr(p + 0x01C)); // 0x1C YAdvance                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
