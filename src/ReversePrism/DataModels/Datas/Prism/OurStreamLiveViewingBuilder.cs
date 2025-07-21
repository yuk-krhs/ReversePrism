using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType OurStreamLiveViewingView OurStreamLiveViewingView OurStreamLiveViewingView Pointer
    public partial class OurStreamLiveViewingBuilder : DataModel
    {
        public OurStreamLiveViewingView?                View                                    { get; set; }

        public static OurStreamLiveViewingBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamLiveViewingBuilder() { Pointer= p0 };

            value.View                                      = GetObject<OurStreamLiveViewingView>(new IntPtr(p + 0x020), ReversePrism.DataModels.OurStreamLiveViewingView.FromPointer); // 0x20 View                        ( ModelClassType OurStreamLiveViewingView OurStreamLiveViewingView OurStreamLiveViewingView Pointer )

            return value;
        }
    }
}
