using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E8 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0F0 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ExchangeSelectionCompletePopupView : DataModel
    {
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ExchangeSelectionCompletePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeSelectionCompletePopupView() { Pointer= p0 };

            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0xF0 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
