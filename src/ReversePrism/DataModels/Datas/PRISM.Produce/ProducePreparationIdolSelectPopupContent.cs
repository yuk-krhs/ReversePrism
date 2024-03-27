using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 IdolImage                                000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 068 IdolPrefabList                           000185D16058 ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer
    // 070 CharaName                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 NickName                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 Rarity                                   0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 088 Vocal                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 Dance                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 Visual                                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 Hp                                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 Cost                                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B0 SkillIcon                                0001866BCF80 ModelClassType IdolSkillIcon IdolSkillIcon IdolSkillIcon Pointer
    // 0B8 SkillName                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C0 SkillDiscription                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C8 SkillCost                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D0 IdolButtonRoot                           0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 0D8 IdolButtonPrefab                         000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 0E0 SkillButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0E8 IdolSkillIconView                        0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 0F0 SkillChangeButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0F8 EvolutionLevel                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 100 PresetList                               000185D11968 ModelClassListType List`1<TMP_ColorGradient> List`1<TMP_ColorGradient> List<TMP_ColorGradient> Pointer
    // 108 StarBaseObjectList                       000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 110 StarObjectList                           000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 118 SkillVoDaViMeView                        000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 120 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 128 ProducePreparationIdolSkillSelectPopupCaller 00018656E630 ModelClassType ProducePreparationIdolSkillSelectPopupCaller ProducePreparationIdolSkillSelectPopupCaller ProducePreparationIdolSkillSelectPopupCaller Pointer
    // 130 IdolIconList                             000185CF7528 ModelClassListType List`1<PFIdolIconView> List`1<PFIdolIconView> List<PFIdolIconView> Pointer
    // 138 onClickClose                             Action`1<ProduceIdol> IL2CPP_TYPE_GENERICINST
    // 140 SelectedIdol                             0001865467F0 ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer
    // 148 ChangeTargetId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 14C IsLoadingCharacter                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 150 UiCharacterVoiceInfo                     0001866E3400 ModelClassType UICharacterVoiceInfo UICharacterVoiceInfo UICharacterVoiceInfo Pointer
    // 158 ScheduleConnection                       0001866D1810 ModelClassType ScheduleConnection ScheduleConnection ScheduleConnection Pointer
    // 160 onChangeIdolSkillSubject                 Subject`1<ValueTuple`2<IProduceIdolStatus, IIdolSkillStatus>> IL2CPP_TYPE_GENERICINST
    public partial class ProducePreparationIdolSelectPopupContent
    {
        public RawImage?                                IdolImage                               { get; set; }
        public List<Transform>?                         IdolPrefabList                          { get; set; }
        public UITextMeshProUGUI?                       CharaName                               { get; set; }
        public UITextMeshProUGUI?                       NickName                                { get; set; }
        public UIRawImage?                              Rarity                                  { get; set; }
        public UITextMeshProUGUI?                       Vocal                                   { get; set; }
        public UITextMeshProUGUI?                       Dance                                   { get; set; }
        public UITextMeshProUGUI?                       Visual                                  { get; set; }
        public UITextMeshProUGUI?                       Hp                                      { get; set; }
        public UITextMeshProUGUI?                       Cost                                    { get; set; }
        public IdolSkillIcon?                           SkillIcon                               { get; set; }
        public UITextMeshProUGUI?                       SkillName                               { get; set; }
        public UITextMeshProUGUI?                       SkillDiscription                        { get; set; }
        public UITextMeshProUGUI?                       SkillCost                               { get; set; }
        public Transform?                               IdolButtonRoot                          { get; set; }
        public PFIdolIconView?                          IdolButtonPrefab                        { get; set; }
        public UIButton?                                SkillButton                             { get; set; }
        public IdolSkillIconView?                       IdolSkillIconView                       { get; set; }
        public UIButton?                                SkillChangeButton                       { get; set; }
        public UITextMeshProUGUI?                       EvolutionLevel                          { get; set; }
        public List<TMP_ColorGradient>?                 PresetList                              { get; set; }
        public List<GameObject>?                        StarBaseObjectList                      { get; set; }
        public List<GameObject>?                        StarObjectList                          { get; set; }
        public VoDaViMeMultiView?                       SkillVoDaViMeView                       { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public ProducePreparationIdolSkillSelectPopupCaller? ProducePreparationIdolSkillSelectPopupCaller { get; set; }
        public List<PFIdolIconView>?                    IdolIconList                            { get; set; }
        public ProduceIdol?                             SelectedIdol                            { get; set; }
        public int                                      ChangeTargetId                          { get; set; }
        public bool                                     IsLoadingCharacter                      { get; set; }
        public UICharacterVoiceInfo?                    UiCharacterVoiceInfo                    { get; set; }
        public ScheduleConnection?                      ScheduleConnection                      { get; set; }

        public static ProducePreparationIdolSelectPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationIdolSelectPopupContent();

            value.IdolImage                                 = GetObject<RawImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.RawImage.FromPointer); // 0270D5A0F2A8 0x60 IdolImage                   ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.IdolPrefabList                            = GetObjectList<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 0270D5A0F2C8 0x68 IdolPrefabList              ( 000185D16058 ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer )
            value.CharaName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A0F2E8 0x70 CharaName                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NickName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A0F308 0x78 NickName                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Rarity                                    = GetObject<UIRawImage>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D5A0F328 0x80 Rarity                      ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.Vocal                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A0F348 0x88 Vocal                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Dance                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A0F368 0x90 Dance                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Visual                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A0F388 0x98 Visual                      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Hp                                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A0F3A8 0xA0 Hp                          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Cost                                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A0F3C8 0xA8 Cost                        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillIcon                                 = GetObject<IdolSkillIcon>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IdolSkillIcon.FromPointer); // 0270D5A0F3E8 0xB0 SkillIcon                   ( 0001866BCF80 ModelClassType IdolSkillIcon IdolSkillIcon IdolSkillIcon Pointer )
            value.SkillName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A0F408 0xB8 SkillName                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillDiscription                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A0F428 0xC0 SkillDiscription            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillCost                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A0F448 0xC8 SkillCost                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdolButtonRoot                            = GetObject<Transform>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Transform.FromPointer); // 0270D5A0F468 0xD0 IdolButtonRoot              ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.IdolButtonPrefab                          = GetObject<PFIdolIconView>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270D5A0F488 0xD8 IdolButtonPrefab            ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SkillButton                               = GetObject<UIButton>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5A0F4A8 0xE0 SkillButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.IdolSkillIconView                         = GetObject<IdolSkillIconView>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0270D5A0F4C8 0xE8 IdolSkillIconView           ( 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.SkillChangeButton                         = GetObject<UIButton>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5A0F4E8 0xF0 SkillChangeButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.EvolutionLevel                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A0F508 0xF8 EvolutionLevel              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PresetList                                = GetObjectList<TMP_ColorGradient>(new IntPtr(p + 0x100), ReversePrism.DataModels.TMP_ColorGradient.FromPointer); // 0270D5A0F528 0x100 PresetList                  ( 000185D11968 ModelClassListType List`1<TMP_ColorGradient> List`1<TMP_ColorGradient> List<TMP_ColorGradient> Pointer )
            value.StarBaseObjectList                        = GetObjectList<GameObject>(new IntPtr(p + 0x108), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A0F548 0x108 StarBaseObjectList          ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.StarObjectList                            = GetObjectList<GameObject>(new IntPtr(p + 0x110), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A0F568 0x110 StarObjectList              ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.SkillVoDaViMeView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x118), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0270D5A0F588 0x118 SkillVoDaViMeView           ( 000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x120), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270D5A0F5A8 0x120 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.ProducePreparationIdolSkillSelectPopupCaller = GetObject<ProducePreparationIdolSkillSelectPopupCaller>(new IntPtr(p + 0x128), ReversePrism.DataModels.ProducePreparationIdolSkillSelectPopupCaller.FromPointer); // 0270D5A0F5C8 0x128 ProducePreparationIdolSkillSelectPopupCaller ( 00018656E630 ModelClassType ProducePreparationIdolSkillSelectPopupCaller ProducePreparationIdolSkillSelectPopupCaller ProducePreparationIdolSkillSelectPopupCaller Pointer )
            value.IdolIconList                              = GetObjectList<PFIdolIconView>(new IntPtr(p + 0x130), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270D5A0F5E8 0x130 IdolIconList                ( 000185CF7528 ModelClassListType List`1<PFIdolIconView> List`1<PFIdolIconView> List<PFIdolIconView> Pointer )
            value.SelectedIdol                              = GetObject<ProduceIdol>(new IntPtr(p + 0x140), ReversePrism.DataModels.ProduceIdol.FromPointer); // 0270D5A0F628 0x140 SelectedIdol                ( 0001865467F0 ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer )
            value.ChangeTargetId                            = GetInt32(new IntPtr(p + 0x148)); // 0270D5A0F648 0x148 ChangeTargetId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsLoadingCharacter                        = GetBool(new IntPtr(p + 0x14C)); // 0270D5A0F668 0x14C IsLoadingCharacter          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UiCharacterVoiceInfo                      = GetObject<UICharacterVoiceInfo>(new IntPtr(p + 0x150), ReversePrism.DataModels.UICharacterVoiceInfo.FromPointer); // 0270D5A0F688 0x150 UiCharacterVoiceInfo        ( 0001866E3400 ModelClassType UICharacterVoiceInfo UICharacterVoiceInfo UICharacterVoiceInfo Pointer )
            value.ScheduleConnection                        = GetObject<ScheduleConnection>(new IntPtr(p + 0x158), ReversePrism.DataModels.ScheduleConnection.FromPointer); // 0270D5A0F6A8 0x158 ScheduleConnection          ( 0001866D1810 ModelClassType ScheduleConnection ScheduleConnection ScheduleConnection Pointer )

            return value;
        }
    }
}
