using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SelfSCharaIconViews                      000185CA2A68 ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer
    // 028 FriendSCharaIconView                     0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 030 SlotCountText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 SupportEffectListView                    0001866DCD80 ModelClassType InProduceSupportEffectContentListView InProduceSupportEffectContentListView InProduceSupportEffectContentListView Pointer
    // 040 onShowSelfSCharaDetailPopup              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 048 onShowFriendSCharaDetailPopup            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class SupportEffectTabView
    {
        public List<SCharaIconView>?                    SelfSCharaIconViews                     { get; set; }
        public SCharaIconView?                          FriendSCharaIconView                    { get; set; }
        public UITextMeshProUGUI?                       SlotCountText                           { get; set; }
        public InProduceSupportEffectContentListView?   SupportEffectListView                   { get; set; }

        public static SupportEffectTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportEffectTabView();

            value.SelfSCharaIconViews                       = GetObjectList<SCharaIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0270DA0FA318 0x20 SelfSCharaIconViews         ( 000185CA2A68 ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer )
            value.FriendSCharaIconView                      = GetObject<SCharaIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0270DA0FA338 0x28 FriendSCharaIconView        ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.SlotCountText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0FA358 0x30 SlotCountText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportEffectListView                     = GetObject<InProduceSupportEffectContentListView>(new IntPtr(p + 0x038), ReversePrism.DataModels.InProduceSupportEffectContentListView.FromPointer); // 0270DA0FA378 0x38 SupportEffectListView       ( 0001866DCD80 ModelClassType InProduceSupportEffectContentListView InProduceSupportEffectContentListView InProduceSupportEffectContentListView Pointer )

            return value;
        }
    }
}
