using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 UnitIcon                                 ModelClassType UIImage UIImage UIImage Pointer
    // 068 UnitName                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 SlotNum                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 PIdolIcons                               ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer
    // 080 SCharaIcons                              ModelClassListType SCharaIconRectView[] SCharaIconRectView[] List<SCharaIconRectView> Pointer
    // 088 FriendIcon                               ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 090 TabGroup                                 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 098 SupportEffectTabView                     ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 SupportSkillTabView                      ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 SupportEffectContentPrefab               ModelClassType SupportEffectContentViewWithSDCharaIcon SupportEffectContentViewWithSDCharaIcon SupportEffectContentViewWithSDCharaIcon Pointer
    // 0B0 SupportSkillContentPrefab                ModelClassType PotentialSupportSkillContentViewWithSDCharaIcon PotentialSupportSkillContentViewWithSDCharaIcon PotentialSupportSkillContentViewWithSDCharaIcon Pointer
    // 0B8 SupportEffectViewContent                 ModelClassType Transform Transform Transform Pointer
    // 0C0 SupportSkillViewContent                  ModelClassType Transform Transform Transform Pointer
    // 0C8 RecommendSupportButton                   ModelClassType UIButton UIButton UIButton Pointer
    // 0D0 SCharaDetailPopupCaller                  ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 0D8 SelectedPIdolIconDataList                ModelClassListType List`1<PIdolIcon> List`1<PIdolIcon> List<PIdolIcon> Pointer
    // 0E0 SelectedCharaIconDataList                ModelClassListType List`1<SCharaIcon> List`1<SCharaIcon> List<SCharaIcon> Pointer
    // 0E8 SelectedFriendSCharaIconData             ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer
    // 0F0 AllSCharaIconDataList                    ModelClassListType List`1<SCharaIcon> List`1<SCharaIcon> List<SCharaIcon> Pointer
    // 0F8 AllSCharaDataList                        ModelClassListType List`1<ISupportCharacterStatus> List`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 100 friendCharacterList                      IEnumerable`1<IFriendSupportStatus> IL2CPP_TYPE_GENERICINST
    // 108 InitialSelectedFriendModel               ModelClassType FriendSupportModel FriendSupportModel FriendSupportModel Pointer
    // 110 OnDecide                                 Action`2<List`1<SCharaIcon>, SCharaIcon> IL2CPP_TYPE_GENERICINST
    // 118 OnCancel                                 Action`2<List`1<SCharaIcon>, SCharaIcon> IL2CPP_TYPE_GENERICINST
    // 120 IsSupportEffectUpdate                    ModelPrimitiveType bool bool bool Bool
    // 121 IsSupportSkillUpdate                     ModelPrimitiveType bool bool bool Bool
    // 128 Ct                                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 130 UnitId                                   ModelPrimitiveType int int int Int32
    // 134 IsProduce                                ModelPrimitiveType bool bool bool Bool
    public partial class SupportCharaUnitSetupPopupContent : DataModel
    {
        public UIImage?                                 UnitIcon                                { get; set; }
        public UITextMeshProUGUI?                       UnitName                                { get; set; }
        public UITextMeshProUGUI?                       SlotNum                                 { get; set; }
        public List<PFIdolIconView>?                    PIdolIcons                              { get; set; }
        public List<SCharaIconRectView>?                SCharaIcons                             { get; set; }
        public SCharaIconRectView?                      FriendIcon                              { get; set; }
        public UITabGroup?                              TabGroup                                { get; set; }
        public GameObject?                              SupportEffectTabView                    { get; set; }
        public GameObject?                              SupportSkillTabView                     { get; set; }
        public SupportEffectContentViewWithSDCharaIcon? SupportEffectContentPrefab              { get; set; }
        public PotentialSupportSkillContentViewWithSDCharaIcon? SupportSkillContentPrefab               { get; set; }
        public Transform?                               SupportEffectViewContent                { get; set; }
        public Transform?                               SupportSkillViewContent                 { get; set; }
        public UIButton?                                RecommendSupportButton                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }
        public List<PIdolIcon>?                         SelectedPIdolIconDataList               { get; set; }
        public List<SCharaIcon>?                        SelectedCharaIconDataList               { get; set; }
        public SCharaIcon?                              SelectedFriendSCharaIconData            { get; set; }
        public List<SCharaIcon>?                        AllSCharaIconDataList                   { get; set; }
        public List<ISupportCharacterStatus>?           AllSCharaDataList                       { get; set; }
        public FriendSupportModel?                      InitialSelectedFriendModel              { get; set; }
        public bool                                     IsSupportEffectUpdate                   { get; set; }
        public bool                                     IsSupportSkillUpdate                    { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public int                                      UnitId                                  { get; set; }
        public bool                                     IsProduce                               { get; set; }

        public static SupportCharaUnitSetupPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaUnitSetupPopupContent() { Pointer= p0 };

            value.UnitIcon                                  = GetObject<UIImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIImage.FromPointer); // 0x60 UnitIcon                    ( ModelClassType UIImage UIImage UIImage Pointer )
            value.UnitName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 UnitName                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SlotNum                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 SlotNum                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PIdolIcons                                = GetObjectList<PFIdolIconView>(new IntPtr(p + 0x078), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x78 PIdolIcons                  ( ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer )
            value.SCharaIcons                               = GetObjectList<SCharaIconRectView>(new IntPtr(p + 0x080), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0x80 SCharaIcons                 ( ModelClassListType SCharaIconRectView[] SCharaIconRectView[] List<SCharaIconRectView> Pointer )
            value.FriendIcon                                = GetObject<SCharaIconRectView>(new IntPtr(p + 0x088), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0x88 FriendIcon                  ( ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x90 TabGroup                    ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.SupportEffectTabView                      = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 SupportEffectTabView        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportSkillTabView                       = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 SupportSkillTabView         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SupportEffectContentPrefab                = GetObject<SupportEffectContentViewWithSDCharaIcon>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.SupportEffectContentViewWithSDCharaIcon.FromPointer); // 0xA8 SupportEffectContentPrefab  ( ModelClassType SupportEffectContentViewWithSDCharaIcon SupportEffectContentViewWithSDCharaIcon SupportEffectContentViewWithSDCharaIcon Pointer )
            value.SupportSkillContentPrefab                 = GetObject<PotentialSupportSkillContentViewWithSDCharaIcon>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.PotentialSupportSkillContentViewWithSDCharaIcon.FromPointer); // 0xB0 SupportSkillContentPrefab   ( ModelClassType PotentialSupportSkillContentViewWithSDCharaIcon PotentialSupportSkillContentViewWithSDCharaIcon PotentialSupportSkillContentViewWithSDCharaIcon Pointer )
            value.SupportEffectViewContent                  = GetObject<Transform>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Transform.FromPointer); // 0xB8 SupportEffectViewContent    ( ModelClassType Transform Transform Transform Pointer )
            value.SupportSkillViewContent                   = GetObject<Transform>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Transform.FromPointer); // 0xC0 SupportSkillViewContent     ( ModelClassType Transform Transform Transform Pointer )
            value.RecommendSupportButton                    = GetObject<UIButton>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UIButton.FromPointer); // 0xC8 RecommendSupportButton      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0xD0 SCharaDetailPopupCaller     ( ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.SelectedPIdolIconDataList                 = GetObjectList<PIdolIcon>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0xD8 SelectedPIdolIconDataList   ( ModelClassListType List`1<PIdolIcon> List`1<PIdolIcon> List<PIdolIcon> Pointer )
            value.SelectedCharaIconDataList                 = GetObjectList<SCharaIcon>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0xE0 SelectedCharaIconDataList   ( ModelClassListType List`1<SCharaIcon> List`1<SCharaIcon> List<SCharaIcon> Pointer )
            value.SelectedFriendSCharaIconData              = GetObject<SCharaIcon>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0xE8 SelectedFriendSCharaIconData ( ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer )
            value.AllSCharaIconDataList                     = GetObjectList<SCharaIcon>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0xF0 AllSCharaIconDataList       ( ModelClassListType List`1<SCharaIcon> List`1<SCharaIcon> List<SCharaIcon> Pointer )
            value.AllSCharaDataList                         = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0xF8 AllSCharaDataList           ( ModelClassListType List`1<ISupportCharacterStatus> List`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.InitialSelectedFriendModel                = GetObject<FriendSupportModel>(new IntPtr(p + 0x108), ReversePrism.DataModels.FriendSupportModel.FromPointer); // 0x108 InitialSelectedFriendModel  ( ModelClassType FriendSupportModel FriendSupportModel FriendSupportModel Pointer )
            value.IsSupportEffectUpdate                     = GetBool(new IntPtr(p + 0x120)); // 0x120 IsSupportEffectUpdate       ( ModelPrimitiveType bool bool bool Bool )
            value.IsSupportSkillUpdate                      = GetBool(new IntPtr(p + 0x121)); // 0x121 IsSupportSkillUpdate        ( ModelPrimitiveType bool bool bool Bool )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x128)); // 0x128 Ct                          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x130)); // 0x130 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.IsProduce                                 = GetBool(new IntPtr(p + 0x134)); // 0x134 IsProduce                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
