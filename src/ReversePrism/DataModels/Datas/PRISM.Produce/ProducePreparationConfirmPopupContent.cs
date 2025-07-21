using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 EpisodeMessage                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 AutoPlayInfoText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 DifficultyObjectArray                    ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 078 UnitIdolButtonArray                      ModelClassListType PFIdolIconRectView[] PFIdolIconRectView[] List<PFIdolIconRectView> Pointer
    // 080 UnitIdolEmptyArray                       ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 088 SupportButtonArray                       ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer
    // 090 FriendButton                             ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 098 FUnitIconEmptyUI                         ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 FUnitObjectRoot                          ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 FUnitIcon                                ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 0B0 InheritanceCount                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B8 ConfirmMessage                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C0 StaminaGaugeViewCaller                   ModelClassType StaminaRecoveryTypeItemPanelViewCaller StaminaRecoveryTypeItemPanelViewCaller StaminaRecoveryTypeItemPanelViewCaller Pointer
    // 0C8 PIdolDetailPopupCaller                   ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 0D0 SCharaDetailPopupCaller                  ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 0D8 Prm                                      ModelClassType ProducePreparationConfirmPopupParam ProducePreparationConfirmPopupParam ProducePreparationConfirmPopupParam Pointer
    // 0E0 OnChangedFavoriteMark                    Action`2<ISupportCharacterStatus, int> IL2CPP_TYPE_GENERICINST
    public partial class ProducePreparationConfirmPopupContent : DataModel
    {
        public UITextMeshProUGUI?                       EpisodeMessage                          { get; set; }
        public UITextMeshProUGUI?                       AutoPlayInfoText                        { get; set; }
        public List<GameObject>?                        DifficultyObjectArray                   { get; set; }
        public List<PFIdolIconRectView>?                UnitIdolButtonArray                     { get; set; }
        public List<GameObject>?                        UnitIdolEmptyArray                      { get; set; }
        public List<SCharaIconView>?                    SupportButtonArray                      { get; set; }
        public SCharaIconView?                          FriendButton                            { get; set; }
        public GameObject?                              FUnitIconEmptyUI                        { get; set; }
        public GameObject?                              FUnitObjectRoot                         { get; set; }
        public FUnitIconView?                           FUnitIcon                               { get; set; }
        public UITextMeshProUGUI?                       InheritanceCount                        { get; set; }
        public UITextMeshProUGUI?                       ConfirmMessage                          { get; set; }
        public StaminaRecoveryTypeItemPanelViewCaller?  StaminaGaugeViewCaller                  { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }
        public ProducePreparationConfirmPopupParam?     Prm                                     { get; set; }

        public static ProducePreparationConfirmPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationConfirmPopupContent() { Pointer= p0 };

            value.EpisodeMessage                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 EpisodeMessage              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AutoPlayInfoText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 AutoPlayInfoText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DifficultyObjectArray                     = GetObjectList<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 DifficultyObjectArray       ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.UnitIdolButtonArray                       = GetObjectList<PFIdolIconRectView>(new IntPtr(p + 0x078), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0x78 UnitIdolButtonArray         ( ModelClassListType PFIdolIconRectView[] PFIdolIconRectView[] List<PFIdolIconRectView> Pointer )
            value.UnitIdolEmptyArray                        = GetObjectList<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 UnitIdolEmptyArray          ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.SupportButtonArray                        = GetObjectList<SCharaIconView>(new IntPtr(p + 0x088), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x88 SupportButtonArray          ( ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer )
            value.FriendButton                              = GetObject<SCharaIconView>(new IntPtr(p + 0x090), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x90 FriendButton                ( ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.FUnitIconEmptyUI                          = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 FUnitIconEmptyUI            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FUnitObjectRoot                           = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 FUnitObjectRoot             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FUnitIcon                                 = GetObject<FUnitIconView>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0xA8 FUnitIcon                   ( ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.InheritanceCount                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB0 InheritanceCount            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ConfirmMessage                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB8 ConfirmMessage              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StaminaGaugeViewCaller                    = GetObject<StaminaRecoveryTypeItemPanelViewCaller>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.StaminaRecoveryTypeItemPanelViewCaller.FromPointer); // 0xC0 StaminaGaugeViewCaller      ( ModelClassType StaminaRecoveryTypeItemPanelViewCaller StaminaRecoveryTypeItemPanelViewCaller StaminaRecoveryTypeItemPanelViewCaller Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0xC8 PIdolDetailPopupCaller      ( ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0xD0 SCharaDetailPopupCaller     ( ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.Prm                                       = GetObject<ProducePreparationConfirmPopupParam>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ProducePreparationConfirmPopupParam.FromPointer); // 0xD8 Prm                         ( ModelClassType ProducePreparationConfirmPopupParam ProducePreparationConfirmPopupParam ProducePreparationConfirmPopupParam Pointer )

            return value;
        }
    }
}
