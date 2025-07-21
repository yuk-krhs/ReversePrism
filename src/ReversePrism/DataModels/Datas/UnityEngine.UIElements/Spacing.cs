using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Left                                     ModelPrimitiveType float float float Single
    // 014 Top                                      ModelPrimitiveType float float float Single
    // 018 Right                                    ModelPrimitiveType float float float Single
    // 01C Bottom                                   ModelPrimitiveType float float float Single
    public partial class Spacing : DataModel
    {
        public float                                    Left                                    { get; set; }
        public float                                    Top                                     { get; set; }
        public float                                    Right                                   { get; set; }
        public float                                    Bottom                                  { get; set; }

        public static Spacing? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Spacing() { Pointer= p0 };

            value.Left                                      = GetSingle(new IntPtr(p + 0x010)); // 0x10 Left                        ( ModelPrimitiveType float float float Single )
            value.Top                                       = GetSingle(new IntPtr(p + 0x014)); // 0x14 Top                         ( ModelPrimitiveType float float float Single )
            value.Right                                     = GetSingle(new IntPtr(p + 0x018)); // 0x18 Right                       ( ModelPrimitiveType float float float Single )
            value.Bottom                                    = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Bottom                      ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
