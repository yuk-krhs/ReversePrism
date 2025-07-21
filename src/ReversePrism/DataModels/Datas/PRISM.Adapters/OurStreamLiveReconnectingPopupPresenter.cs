using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IOurStreamLiveReconnectingPopupView IOurStreamLiveReconnectingPopupView IOurStreamLiveReconnectingPopupView Pointer
    // 018 IsShowing                                ModelPrimitiveType bool bool bool Bool
    public partial class OurStreamLiveReconnectingPopupPresenter : DataModel
    {
        public IOurStreamLiveReconnectingPopupView?     View                                    { get; set; }
        public bool                                     IsShowing                               { get; set; }

        public static OurStreamLiveReconnectingPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamLiveReconnectingPopupPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IOurStreamLiveReconnectingPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IOurStreamLiveReconnectingPopupView.FromPointer); // 0x10 View                        ( ModelClassType IOurStreamLiveReconnectingPopupView IOurStreamLiveReconnectingPopupView IOurStreamLiveReconnectingPopupView Pointer )
            value.IsShowing                                 = GetBool(new IntPtr(p + 0x018)); // 0x18 IsShowing                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
