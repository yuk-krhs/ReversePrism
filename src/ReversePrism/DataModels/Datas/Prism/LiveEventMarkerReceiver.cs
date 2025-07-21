using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LiveScene                                ModelClassType LiveScene LiveScene LiveScene Pointer
    public partial class LiveEventMarkerReceiver : DataModel
    {
        public LiveScene?                               LiveScene                               { get; set; }

        public static LiveEventMarkerReceiver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventMarkerReceiver() { Pointer= p0 };

            value.LiveScene                                 = GetObject<LiveScene>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveScene.FromPointer); // 0x20 LiveScene                   ( ModelClassType LiveScene LiveScene LiveScene Pointer )

            return value;
        }
    }
}
