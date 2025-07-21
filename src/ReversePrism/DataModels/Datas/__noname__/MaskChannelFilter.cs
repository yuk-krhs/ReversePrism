using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mask                                     ModelEnumType Vector4 Vector4 Vector4 Int32
    // 020 Inverted                                 ModelEnumType Vector4 Vector4 Vector4 Int32
    public partial class MaskChannelFilter : DataModel
    {
        public Vector4                                  Mask                                    { get; set; }
        public Vector4                                  Inverted                                { get; set; }

        public static MaskChannelFilter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MaskChannelFilter() { Pointer= p0 };

            value.Mask                                      = (Vector4)GetInt32(new IntPtr(p + 0x010)); // 0x10 Mask                        ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Inverted                                  = (Vector4)GetInt32(new IntPtr(p + 0x020)); // 0x20 Inverted                    ( ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
