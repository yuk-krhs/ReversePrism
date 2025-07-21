using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        ModelEnumType Repeat Repeat Repeat Int32
    // 014 Y                                        ModelEnumType Repeat Repeat Repeat Int32
    public partial class BackgroundRepeat : DataModel
    {
        public Repeat                                   X                                       { get; set; }
        public Repeat                                   Y                                       { get; set; }

        public static BackgroundRepeat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BackgroundRepeat() { Pointer= p0 };

            value.X                                         = (Repeat)GetInt32(new IntPtr(p + 0x010)); // 0x10 X                           ( ModelEnumType Repeat Repeat Repeat Int32 )
            value.Y                                         = (Repeat)GetInt32(new IntPtr(p + 0x014)); // 0x14 Y                           ( ModelEnumType Repeat Repeat Repeat Int32 )

            return value;
        }
    }
}
