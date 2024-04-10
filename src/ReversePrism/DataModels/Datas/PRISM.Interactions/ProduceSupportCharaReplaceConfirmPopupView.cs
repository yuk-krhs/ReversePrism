using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeforeSChara                             0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 028 AfterSChara                              0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 030 sCharaDetailPopupViewFactory             SerializableInterface`1<ISCharaDetailPopupViewFactory> IL2CPP_TYPE_GENERICINST
    // 038 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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

            value.BeforeSChara                              = GetObject<SCharaIconRectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 02466A17BA60 0x20 BeforeSChara                ( 0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.AfterSChara                               = GetObject<SCharaIconRectView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 02466A17BA80 0x28 AfterSChara                 ( 0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A17BAE0 0x40 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
