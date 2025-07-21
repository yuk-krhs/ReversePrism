using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OffsetX                                  ModelPrimitiveType float float float Single
    // 014 OffsetY                                  ModelPrimitiveType float float float Single
    // 018 ScaleX                                   ModelPrimitiveType float float float Single
    // 01C ScaleY                                   ModelPrimitiveType float float float Single
    // 020 LnA                                      ModelPrimitiveType float float float Single
    // 024 B                                        ModelPrimitiveType float float float Single
    public partial class Segment : DataModel
    {
        public float                                    OffsetX                                 { get; set; }
        public float                                    OffsetY                                 { get; set; }
        public float                                    ScaleX                                  { get; set; }
        public float                                    ScaleY                                  { get; set; }
        public float                                    LnA                                     { get; set; }
        public float                                    B                                       { get; set; }

        public static Segment? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Segment() { Pointer= p0 };

            value.OffsetX                                   = GetSingle(new IntPtr(p + 0x010)); // 0x10 OffsetX                     ( ModelPrimitiveType float float float Single )
            value.OffsetY                                   = GetSingle(new IntPtr(p + 0x014)); // 0x14 OffsetY                     ( ModelPrimitiveType float float float Single )
            value.ScaleX                                    = GetSingle(new IntPtr(p + 0x018)); // 0x18 ScaleX                      ( ModelPrimitiveType float float float Single )
            value.ScaleY                                    = GetSingle(new IntPtr(p + 0x01C)); // 0x1C ScaleY                      ( ModelPrimitiveType float float float Single )
            value.LnA                                       = GetSingle(new IntPtr(p + 0x020)); // 0x20 LnA                         ( ModelPrimitiveType float float float Single )
            value.B                                         = GetSingle(new IntPtr(p + 0x024)); // 0x24 B                           ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
