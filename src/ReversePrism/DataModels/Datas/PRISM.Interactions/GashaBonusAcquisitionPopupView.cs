using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CmnItems                                 000185B75410 ModelClassListType CmnItem[] CmnItem[] List<CmnItem> Pointer
    // 028 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaBonusAcquisitionPopupView
    {
        public List<CmnItem>?                           CmnItems                                { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaBonusAcquisitionPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaBonusAcquisitionPopupView();

            value.CmnItems                                  = GetObjectList<CmnItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.CmnItem.FromPointer); // 0270DB9DEFD8 0x20 CmnItems                    ( 000185B75410 ModelClassListType CmnItem[] CmnItem[] List<CmnItem> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB9DF018 0x30 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
