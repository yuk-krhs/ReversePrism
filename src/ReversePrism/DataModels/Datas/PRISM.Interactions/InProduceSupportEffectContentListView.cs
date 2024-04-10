using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoContent                                0001866DD260 ModelClassType InProduceSupportEffectContentView InProduceSupportEffectContentView InProduceSupportEffectContentView Pointer
    // 030 ContentParent                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 ContentList                              000185CEB098 ModelClassListType List`1<InProduceSupportEffectContentView> List`1<InProduceSupportEffectContentView> List<InProduceSupportEffectContentView> Pointer
    public partial class InProduceSupportEffectContentListView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public InProduceSupportEffectContentView?       GoContent                               { get; set; }
        public Transform?                               ContentParent                           { get; set; }
        public List<InProduceSupportEffectContentView>? ContentList                             { get; set; }

        public static InProduceSupportEffectContentListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InProduceSupportEffectContentListView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A145F80 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoContent                                 = GetObject<InProduceSupportEffectContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.InProduceSupportEffectContentView.FromPointer); // 02466A145FA0 0x28 GoContent                   ( 0001866DD260 ModelClassType InProduceSupportEffectContentView InProduceSupportEffectContentView InProduceSupportEffectContentView Pointer )
            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 02466A145FC0 0x30 ContentParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ContentList                               = GetObjectList<InProduceSupportEffectContentView>(new IntPtr(p + 0x038), ReversePrism.DataModels.InProduceSupportEffectContentView.FromPointer); // 02466A145FE0 0x38 ContentList                 ( 000185CEB098 ModelClassListType List`1<InProduceSupportEffectContentView> List`1<InProduceSupportEffectContentView> List<InProduceSupportEffectContentView> Pointer )

            return value;
        }
    }
}
