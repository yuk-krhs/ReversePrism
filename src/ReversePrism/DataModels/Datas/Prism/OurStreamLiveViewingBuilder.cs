using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     0001866F7940 ModelClassType OurStreamLiveViewingView OurStreamLiveViewingView OurStreamLiveViewingView Pointer
    // 028 ReconnectingPopupViewFactory             0001866F5960 ModelClassType OurStreamLiveReconnectingPopupViewFactory OurStreamLiveReconnectingPopupViewFactory OurStreamLiveReconnectingPopupViewFactory Pointer
    public partial class OurStreamLiveViewingBuilder
    {
        public OurStreamLiveViewingView?                View                                    { get; set; }
        public OurStreamLiveReconnectingPopupViewFactory? ReconnectingPopupViewFactory            { get; set; }

        public static OurStreamLiveViewingBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamLiveViewingBuilder();

            value.View                                      = GetObject<OurStreamLiveViewingView>(new IntPtr(p + 0x020), ReversePrism.DataModels.OurStreamLiveViewingView.FromPointer); // 0270DB61CB98 0x20 View                        ( 0001866F7940 ModelClassType OurStreamLiveViewingView OurStreamLiveViewingView OurStreamLiveViewingView Pointer )
            value.ReconnectingPopupViewFactory              = GetObject<OurStreamLiveReconnectingPopupViewFactory>(new IntPtr(p + 0x028), ReversePrism.DataModels.OurStreamLiveReconnectingPopupViewFactory.FromPointer); // 0270DB61CBB8 0x28 ReconnectingPopupViewFactory ( 0001866F5960 ModelClassType OurStreamLiveReconnectingPopupViewFactory OurStreamLiveReconnectingPopupViewFactory OurStreamLiveReconnectingPopupViewFactory Pointer )

            return value;
        }
    }
}
