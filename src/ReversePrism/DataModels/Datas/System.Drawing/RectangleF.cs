using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        ModelPrimitiveType float float float Single
    // 014 Y                                        ModelPrimitiveType float float float Single
    // 018 Width                                    ModelPrimitiveType float float float Single
    // 01C Height                                   ModelPrimitiveType float float float Single
    public partial class RectangleF : DataModel
    {
        public float                                    X                                       { get; set; }
        public float                                    Y                                       { get; set; }
        public float                                    Width                                   { get; set; }
        public float                                    Height                                  { get; set; }

        public static RectangleF? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RectangleF() { Pointer= p0 };

            value.X                                         = GetSingle(new IntPtr(p + 0x010)); // 0x10 X                           ( ModelPrimitiveType float float float Single )
            value.Y                                         = GetSingle(new IntPtr(p + 0x014)); // 0x14 Y                           ( ModelPrimitiveType float float float Single )
            value.Width                                     = GetSingle(new IntPtr(p + 0x018)); // 0x18 Width                       ( ModelPrimitiveType float float float Single )
            value.Height                                    = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Height                      ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
