using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 M_InfiniteClipPreExtrapolation           ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32
    // 0AC M_InfiniteClipPostExtrapolation          ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32
    public partial class ShapeUguiTrack : DataModel
    {
        public ClipExtrapolation                        M_InfiniteClipPreExtrapolation          { get; set; }
        public ClipExtrapolation                        M_InfiniteClipPostExtrapolation         { get; set; }

        public static ShapeUguiTrack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShapeUguiTrack() { Pointer= p0 };

            value.M_InfiniteClipPreExtrapolation            = (ClipExtrapolation)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 M_InfiniteClipPreExtrapolation ( ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32 )
            value.M_InfiniteClipPostExtrapolation           = (ClipExtrapolation)GetInt32(new IntPtr(p + 0x0AC)); // 0xAC M_InfiniteClipPostExtrapolation ( ModelEnumType ClipExtrapolation ClipExtrapolation ClipExtrapolation Int32 )

            return value;
        }
    }
}
