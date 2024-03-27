using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_XMin                                   0001866656B0 ModelPrimitiveType float float float Single
    // 014 M_YMin                                   0001866656B0 ModelPrimitiveType float float float Single
    // 018 M_Width                                  0001866656B0 ModelPrimitiveType float float float Single
    // 01C M_Height                                 0001866656B0 ModelPrimitiveType float float float Single
    public partial class Rect
    {
        public float                                    M_XMin                                  { get; set; }
        public float                                    M_YMin                                  { get; set; }
        public float                                    M_Width                                 { get; set; }
        public float                                    M_Height                                { get; set; }

        public static Rect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Rect();

            value.M_XMin                                    = GetSingle(new IntPtr(p + 0x010)); // 0270021C52B8 0x10 M_XMin                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_YMin                                    = GetSingle(new IntPtr(p + 0x014)); // 0270021C52D8 0x14 M_YMin                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Width                                   = GetSingle(new IntPtr(p + 0x018)); // 0270021C52F8 0x18 M_Width                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Height                                  = GetSingle(new IntPtr(p + 0x01C)); // 0270021C5318 0x1C M_Height                    ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
