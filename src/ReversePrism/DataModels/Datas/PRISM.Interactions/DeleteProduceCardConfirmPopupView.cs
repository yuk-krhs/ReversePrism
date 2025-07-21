using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 028 PopupFrameParameter                      ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer
    // 030 CardPrefab                               ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer
    // 038 CardArea                                 ModelClassType Transform Transform Transform Pointer
    // 040 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class DeleteProduceCardConfirmPopupView : DataModel
    {
        public PopupFrameParameter?                     PopupFrameParameter                     { get; set; }
        public ProduceCardContent?                      CardPrefab                              { get; set; }
        public Transform?                               CardArea                                { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static DeleteProduceCardConfirmPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeleteProduceCardConfirmPopupView() { Pointer= p0 };

            value.PopupFrameParameter                       = GetObject<PopupFrameParameter>(new IntPtr(p + 0x028), ReversePrism.DataModels.PopupFrameParameter.FromPointer); // 0x28 PopupFrameParameter         ( ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer )
            value.CardPrefab                                = GetObject<ProduceCardContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceCardContent.FromPointer); // 0x30 CardPrefab                  ( ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer )
            value.CardArea                                  = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0x38 CardArea                    ( ModelClassType Transform Transform Transform Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x40 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
