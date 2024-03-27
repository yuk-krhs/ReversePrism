using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 028 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class CopyrightPopupView
    {
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static CopyrightPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CopyrightPopupView();

            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DBE5BFA8 0x28 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
