using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rect                                     00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 020 Uv                                       00018664FAF0 ModelEnumType Rect Rect Rect Int32
    public partial class RepeatRectUV : DataModel
    {
        public Rect                                     Rect                                    { get; set; }
        public Rect                                     Uv                                      { get; set; }

        public static RepeatRectUV? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RepeatRectUV() { Pointer= p0 };

            value.Rect                                      = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0245A68417C8 0x10 Rect                        ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.Uv                                        = (Rect)GetInt32(new IntPtr(p + 0x020)); // 0245A68417E8 0x20 Uv                          ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )

            return value;
        }
    }
}
