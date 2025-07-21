using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 R                                        ModelPrimitiveType float float float Single
    // 014 G                                        ModelPrimitiveType float float float Single
    // 018 B                                        ModelPrimitiveType float float float Single
    // 01C A                                        ModelPrimitiveType float float float Single
    public partial class Color : DataModel
    {
        public float                                    R                                       { get; set; }
        public float                                    G                                       { get; set; }
        public float                                    B                                       { get; set; }
        public float                                    A                                       { get; set; }

        public static Color? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Color() { Pointer= p0 };

            value.R                                         = GetSingle(new IntPtr(p + 0x010)); // 0x10 R                           ( ModelPrimitiveType float float float Single )
            value.G                                         = GetSingle(new IntPtr(p + 0x014)); // 0x14 G                           ( ModelPrimitiveType float float float Single )
            value.B                                         = GetSingle(new IntPtr(p + 0x018)); // 0x18 B                           ( ModelPrimitiveType float float float Single )
            value.A                                         = GetSingle(new IntPtr(p + 0x01C)); // 0x1C A                           ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
