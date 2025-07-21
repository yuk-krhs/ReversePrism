using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeforeSChara                             ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 028 AfterSChara                              ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 030 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceSupportCharaReplaceConfirmPopupView : DataModel
    {
        public SCharaIconRectView?                      BeforeSChara                            { get; set; }
        public SCharaIconRectView?                      AfterSChara                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceSupportCharaReplaceConfirmPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSupportCharaReplaceConfirmPopupView() { Pointer= p0 };

            value.BeforeSChara                              = GetObject<SCharaIconRectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0x20 BeforeSChara                ( ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.AfterSChara                               = GetObject<SCharaIconRectView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0x28 AfterSChara                 ( ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
