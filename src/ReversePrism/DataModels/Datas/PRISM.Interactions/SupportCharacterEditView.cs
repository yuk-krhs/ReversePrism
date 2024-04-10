using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SelfSCharaIconViews                      000185CA2A68 ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer
    // 028 SelfSCharaIconBlankButtons               000185CADC58 ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer
    // 030 FriendSCharaIconView                     0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 038 FriendSCharaIconBlankButton              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 SkillSlotCountText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 RecommendEditButton                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 UnitIcon                                 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 058 UnitNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 SupportEffectAndPotentialSkillTabGroup   0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 068 SupportEffectListView                    0001866A89C0 ModelClassType SCharaEditSupportEffectContentListView SCharaEditSupportEffectContentListView SCharaEditSupportEffectContentListView Pointer
    // 070 PotentialSupportSkillListView            0001866A6C10 ModelClassType SCharaEditPotentialSupportSkillContentListView SCharaEditPotentialSupportSkillContentListView SCharaEditPotentialSupportSkillContentListView Pointer
    // 078 onClickSelfSCharaIcon                    Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 080 onLongPressSelfSCharaIcon                Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 088 onClickFriendSCharaIcon                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 onLongPressFriendSCharaIcon              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class SupportCharacterEditView : DataModel
    {
        public List<SCharaIconView>?                    SelfSCharaIconViews                     { get; set; }
        public List<UIButton>?                          SelfSCharaIconBlankButtons              { get; set; }
        public SCharaIconView?                          FriendSCharaIconView                    { get; set; }
        public UIButton?                                FriendSCharaIconBlankButton             { get; set; }
        public UITextMeshProUGUI?                       SkillSlotCountText                      { get; set; }
        public UIButton?                                RecommendEditButton                     { get; set; }
        public UIImage?                                 UnitIcon                                { get; set; }
        public UITextMeshProUGUI?                       UnitNameText                            { get; set; }
        public UITabGroup?                              SupportEffectAndPotentialSkillTabGroup  { get; set; }
        public SCharaEditSupportEffectContentListView?  SupportEffectListView                   { get; set; }
        public SCharaEditPotentialSupportSkillContentListView? PotentialSupportSkillListView           { get; set; }

        public static SupportCharacterEditView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharacterEditView() { Pointer= p0 };

            value.SelfSCharaIconViews                       = GetObjectList<SCharaIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaIconView.FromPointer); // 02466A199188 0x20 SelfSCharaIconViews         ( 000185CA2A68 ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer )
            value.SelfSCharaIconBlankButtons                = GetObjectList<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 02466A1991A8 0x28 SelfSCharaIconBlankButtons  ( 000185CADC58 ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer )
            value.FriendSCharaIconView                      = GetObject<SCharaIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SCharaIconView.FromPointer); // 02466A1991C8 0x30 FriendSCharaIconView        ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.FriendSCharaIconBlankButton               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466A1991E8 0x38 FriendSCharaIconBlankButton ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.SkillSlotCountText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A199208 0x40 SkillSlotCountText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RecommendEditButton                       = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 02466A199228 0x48 RecommendEditButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.UnitIcon                                  = GetObject<UIImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIImage.FromPointer); // 02466A199248 0x50 UnitIcon                    ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.UnitNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A199268 0x58 UnitNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportEffectAndPotentialSkillTabGroup    = GetObject<UITabGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITabGroup.FromPointer); // 02466A199288 0x60 SupportEffectAndPotentialSkillTabGroup ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.SupportEffectListView                     = GetObject<SCharaEditSupportEffectContentListView>(new IntPtr(p + 0x068), ReversePrism.DataModels.SCharaEditSupportEffectContentListView.FromPointer); // 02466A1992A8 0x68 SupportEffectListView       ( 0001866A89C0 ModelClassType SCharaEditSupportEffectContentListView SCharaEditSupportEffectContentListView SCharaEditSupportEffectContentListView Pointer )
            value.PotentialSupportSkillListView             = GetObject<SCharaEditPotentialSupportSkillContentListView>(new IntPtr(p + 0x070), ReversePrism.DataModels.SCharaEditPotentialSupportSkillContentListView.FromPointer); // 02466A1992C8 0x70 PotentialSupportSkillListView ( 0001866A6C10 ModelClassType SCharaEditPotentialSupportSkillContentListView SCharaEditPotentialSupportSkillContentListView SCharaEditPotentialSupportSkillContentListView Pointer )

            return value;
        }
    }
}
