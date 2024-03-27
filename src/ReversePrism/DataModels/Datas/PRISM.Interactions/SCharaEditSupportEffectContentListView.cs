using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoContent                                0001866A8E80 ModelClassType SCharaEditSupportEffectContentView SCharaEditSupportEffectContentView SCharaEditSupportEffectContentView Pointer
    // 030 ContentParent                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 ContentList                              000185D05638 ModelClassListType List`1<SCharaEditSupportEffectContentView> List`1<SCharaEditSupportEffectContentView> List<SCharaEditSupportEffectContentView> Pointer
    public partial class SCharaEditSupportEffectContentListView
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public SCharaEditSupportEffectContentView?      GoContent                               { get; set; }
        public Transform?                               ContentParent                           { get; set; }
        public List<SCharaEditSupportEffectContentView>? ContentList                             { get; set; }

        public static SCharaEditSupportEffectContentListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaEditSupportEffectContentListView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DB591E08 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoContent                                 = GetObject<SCharaEditSupportEffectContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaEditSupportEffectContentView.FromPointer); // 0270DB591E28 0x28 GoContent                   ( 0001866A8E80 ModelClassType SCharaEditSupportEffectContentView SCharaEditSupportEffectContentView SCharaEditSupportEffectContentView Pointer )
            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0270DB591E48 0x30 ContentParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ContentList                               = GetObjectList<SCharaEditSupportEffectContentView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SCharaEditSupportEffectContentView.FromPointer); // 0270DB591E68 0x38 ContentList                 ( 000185D05638 ModelClassListType List`1<SCharaEditSupportEffectContentView> List`1<SCharaEditSupportEffectContentView> List<SCharaEditSupportEffectContentView> Pointer )

            return value;
        }
    }
}
