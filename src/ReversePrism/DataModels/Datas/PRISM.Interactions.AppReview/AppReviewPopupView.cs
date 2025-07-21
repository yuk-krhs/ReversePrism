using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 028 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class AppReviewPopupView : DataModel
    {
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static AppReviewPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppReviewPopupView() { Pointer= p0 };

            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x28 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
