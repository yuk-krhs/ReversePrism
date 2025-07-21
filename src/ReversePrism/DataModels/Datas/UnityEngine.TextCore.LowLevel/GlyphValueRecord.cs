using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_XPlacement                             ModelPrimitiveType float float float Single
    // 014 M_YPlacement                             ModelPrimitiveType float float float Single
    // 018 M_XAdvance                               ModelPrimitiveType float float float Single
    // 01C M_YAdvance                               ModelPrimitiveType float float float Single
    public partial class GlyphValueRecord : DataModel
    {
        public float                                    M_XPlacement                            { get; set; }
        public float                                    M_YPlacement                            { get; set; }
        public float                                    M_XAdvance                              { get; set; }
        public float                                    M_YAdvance                              { get; set; }

        public static GlyphValueRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlyphValueRecord() { Pointer= p0 };

            value.M_XPlacement                              = GetSingle(new IntPtr(p + 0x010)); // 0x10 M_XPlacement                ( ModelPrimitiveType float float float Single )
            value.M_YPlacement                              = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_YPlacement                ( ModelPrimitiveType float float float Single )
            value.M_XAdvance                                = GetSingle(new IntPtr(p + 0x018)); // 0x18 M_XAdvance                  ( ModelPrimitiveType float float float Single )
            value.M_YAdvance                                = GetSingle(new IntPtr(p + 0x01C)); // 0x1C M_YAdvance                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
