using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SelfSCharaIconViews                      ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer
    // 028 FriendSCharaIconView                     ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 030 SlotCountText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 SupportSkillSlotGridView                 ModelClassType SupportSkillSlotGridView SupportSkillSlotGridView SupportSkillSlotGridView Pointer
    // 040 onShowSelfSCharaDetailPopup              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 048 onShowFriendSCharaDetailPopup            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class SupportSkillTabView : DataModel
    {
        public List<SCharaIconView>?                    SelfSCharaIconViews                     { get; set; }
        public SCharaIconView?                          FriendSCharaIconView                    { get; set; }
        public UITextMeshProUGUI?                       SlotCountText                           { get; set; }
        public SupportSkillSlotGridView?                SupportSkillSlotGridView                { get; set; }

        public static SupportSkillTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportSkillTabView() { Pointer= p0 };

            value.SelfSCharaIconViews                       = GetObjectList<SCharaIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x20 SelfSCharaIconViews         ( ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer )
            value.FriendSCharaIconView                      = GetObject<SCharaIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x28 FriendSCharaIconView        ( ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.SlotCountText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 SlotCountText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportSkillSlotGridView                  = GetObject<SupportSkillSlotGridView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SupportSkillSlotGridView.FromPointer); // 0x38 SupportSkillSlotGridView    ( ModelClassType SupportSkillSlotGridView SupportSkillSlotGridView SupportSkillSlotGridView Pointer )

            return value;
        }
    }
}
