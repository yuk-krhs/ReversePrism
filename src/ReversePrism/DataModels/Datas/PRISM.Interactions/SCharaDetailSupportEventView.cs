using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoContent                                0001867530A0 ModelClassType EventContentView EventContentView EventContentView Pointer
    // 030 ContentParent                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 onClick                                  Subject`1<ScenarioID> IL2CPP_TYPE_GENERICINST
    public partial class SCharaDetailSupportEventView
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public EventContentView?                        GoContent                               { get; set; }
        public Transform?                               ContentParent                           { get; set; }

        public static SCharaDetailSupportEventView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaDetailSupportEventView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA3364F0 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoContent                                 = GetObject<EventContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.EventContentView.FromPointer); // 0270DA336510 0x28 GoContent                   ( 0001867530A0 ModelClassType EventContentView EventContentView EventContentView Pointer )
            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0270DA336530 0x30 ContentParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
