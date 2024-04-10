using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 EpisodeMessage                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 AutoPlayInfoText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 DifficultyObjectArray                    000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 078 UnitIdolButtonArray                      000185B99BC0 ModelClassListType PFIdolIconRectView[] PFIdolIconRectView[] List<PFIdolIconRectView> Pointer
    // 080 UnitIdolEmptyArray                       000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 088 SupportButtonArray                       000185CA2A68 ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer
    // 090 FriendButton                             0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 098 FUnitIconEmptyUI                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 FUnitObjectRoot                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 FUnitIcon                                00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 0B0 InheritanceCount                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B8 ConfirmMessage                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C0 StaminaGaugeView                         000186568B40 ModelClassType StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView Pointer
    // 0C8 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 0D0 SCharaDetailPopupCaller                  0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 0D8 Prm                                      000186566BE0 ModelClassType ProducePreparationConfirmPopupParam ProducePreparationConfirmPopupParam ProducePreparationConfirmPopupParam Pointer
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
        public StaminaRecoveryTypeItemContentView?      StaminaGaugeView                        { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }
        public ProducePreparationConfirmPopupParam?     Prm                                     { get; set; }

        public static ProducePreparationConfirmPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationConfirmPopupContent() { Pointer= p0 };

            value.EpisodeMessage                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665A68EE8 0x60 EpisodeMessage              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AutoPlayInfoText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665A68F08 0x68 AutoPlayInfoText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DifficultyObjectArray                     = GetObjectList<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 024665A68F28 0x70 DifficultyObjectArray       ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.UnitIdolButtonArray                       = GetObjectList<PFIdolIconRectView>(new IntPtr(p + 0x078), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 024665A68F48 0x78 UnitIdolButtonArray         ( 000185B99BC0 ModelClassListType PFIdolIconRectView[] PFIdolIconRectView[] List<PFIdolIconRectView> Pointer )
            value.UnitIdolEmptyArray                        = GetObjectList<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 024665A68F68 0x80 UnitIdolEmptyArray          ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.SupportButtonArray                        = GetObjectList<SCharaIconView>(new IntPtr(p + 0x088), ReversePrism.DataModels.SCharaIconView.FromPointer); // 024665A68F88 0x88 SupportButtonArray          ( 000185CA2A68 ModelClassListType SCharaIconView[] SCharaIconView[] List<SCharaIconView> Pointer )
            value.FriendButton                              = GetObject<SCharaIconView>(new IntPtr(p + 0x090), ReversePrism.DataModels.SCharaIconView.FromPointer); // 024665A68FA8 0x90 FriendButton                ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.FUnitIconEmptyUI                          = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 024665A68FC8 0x98 FUnitIconEmptyUI            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FUnitObjectRoot                           = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 024665A68FE8 0xA0 FUnitObjectRoot             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FUnitIcon                                 = GetObject<FUnitIconView>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.FUnitIconView.FromPointer); // 024665A69008 0xA8 FUnitIcon                   ( 00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.InheritanceCount                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665A69028 0xB0 InheritanceCount            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ConfirmMessage                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665A69048 0xB8 ConfirmMessage              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StaminaGaugeView                          = GetObject<StaminaRecoveryTypeItemContentView>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.StaminaRecoveryTypeItemContentView.FromPointer); // 024665A69068 0xC0 StaminaGaugeView            ( 000186568B40 ModelClassType StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView StaminaRecoveryTypeItemContentView Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 024665A69088 0xC8 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 024665A690A8 0xD0 SCharaDetailPopupCaller     ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.Prm                                       = GetObject<ProducePreparationConfirmPopupParam>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ProducePreparationConfirmPopupParam.FromPointer); // 024665A690C8 0xD8 Prm                         ( 000186566BE0 ModelClassType ProducePreparationConfirmPopupParam ProducePreparationConfirmPopupParam ProducePreparationConfirmPopupParam Pointer )

            return value;
        }
    }
}
