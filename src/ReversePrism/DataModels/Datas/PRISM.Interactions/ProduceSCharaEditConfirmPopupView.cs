using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 028 AndroidBackKeyDisableScope               ModelClassType IDisposable IDisposable IDisposable Pointer
    // 030 EditView                                 ModelClassType SupportCharacterEditView SupportCharacterEditView SupportCharacterEditView Pointer
    // 038 PopupFrameParameter                      ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer
    // 040 onClickSelfSCharaIcon                    Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 048 onLongPressSelfSCharaIcon                Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 050 onLongPressFriendSCharaIcon              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceSCharaEditConfirmPopupView : DataModel
    {
        public IDisposable?                             AndroidBackKeyDisableScope              { get; set; }
        public SupportCharacterEditView?                EditView                                { get; set; }
        public PopupFrameParameter?                     PopupFrameParameter                     { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceSCharaEditConfirmPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSCharaEditConfirmPopupView() { Pointer= p0 };

            value.AndroidBackKeyDisableScope                = GetObject<IDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDisposable.FromPointer); // 0x28 AndroidBackKeyDisableScope  ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.EditView                                  = GetObject<SupportCharacterEditView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SupportCharacterEditView.FromPointer); // 0x30 EditView                    ( ModelClassType SupportCharacterEditView SupportCharacterEditView SupportCharacterEditView Pointer )
            value.PopupFrameParameter                       = GetObject<PopupFrameParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.PopupFrameParameter.FromPointer); // 0x38 PopupFrameParameter         ( ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x58 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
