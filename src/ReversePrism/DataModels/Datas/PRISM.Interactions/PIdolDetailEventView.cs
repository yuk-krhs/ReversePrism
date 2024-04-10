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
    public partial class PIdolDetailEventView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public EventContentView?                        GoContent                               { get; set; }
        public Transform?                               ContentParent                           { get; set; }

        public static PIdolDetailEventView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolDetailEventView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A358F00 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoContent                                 = GetObject<EventContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.EventContentView.FromPointer); // 02466A358F20 0x28 GoContent                   ( 0001867530A0 ModelClassType EventContentView EventContentView EventContentView Pointer )
            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 02466A358F40 0x30 ContentParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
