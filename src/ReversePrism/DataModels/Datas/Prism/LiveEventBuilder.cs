using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType LiveEventView LiveEventView LiveEventView Pointer
    public partial class LiveEventBuilder : DataModel
    {
        public LiveEventView?                           View                                    { get; set; }

        public static LiveEventBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventBuilder() { Pointer= p0 };

            value.View                                      = GetObject<LiveEventView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveEventView.FromPointer); // 0x20 View                        ( ModelClassType LiveEventView LiveEventView LiveEventView Pointer )

            return value;
        }
    }
}
