using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 IdolImage                                ModelClassType RawImage RawImage RawImage Pointer
    // 068 IdolPrefabList                           ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer
    // 070 CharaName                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 NickName                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 Rarity                                   ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 088 Vocal                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 Dance                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 Visual                                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 Hp                                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 Cost                                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B0 SkillIcon                                ModelClassType IdolSkillIcon IdolSkillIcon IdolSkillIcon Pointer
    // 0B8 SkillName                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C0 SkillDiscription                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C8 SkillCost                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D0 IdolButtonRoot                           ModelClassType Transform Transform Transform Pointer
    // 0D8 IdolButtonPrefab                         ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 0E0 SkillButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 0E8 IdolSkillIconView                        ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 0F0 SkillChangeButton                        ModelClassType UIButton UIButton UIButton Pointer
    // 0F8 EvolutionLevel                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 100 PresetList                               ModelClassListType List`1<TMP_ColorGradient> List`1<TMP_ColorGradient> List<TMP_ColorGradient> Pointer
    // 108 StarBaseObjectList                       ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 110 StarObjectList                           ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 118 SkillVoDaViMeView                        ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 120 ProducePreparationIdolSkillSelectPopupCaller ModelClassType ProducePreparationIdolSkillSelectPopupCaller ProducePreparationIdolSkillSelectPopupCaller ProducePreparationIdolSkillSelectPopupCaller Pointer
    // 128 PIdolList                                ModelClassListType List`1<ProduceIdol> List`1<ProduceIdol> List<ProduceIdol> Pointer
    // 130 IdolIconList                             ModelClassListType List`1<PFIdolIconView> List`1<PFIdolIconView> List<PFIdolIconView> Pointer
    // 138 onClickClose                             Action`1<ProduceIdol> IL2CPP_TYPE_GENERICINST
    // 140 SelectedIdol                             ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer
    // 148 ChangeTargetId                           ModelPrimitiveType int int int Int32
    // 14C IsLoadingCharacter                       ModelPrimitiveType bool bool bool Bool
    // 150 UiCharacterVoiceInfo                     ModelClassType UICharacterVoiceInfo UICharacterVoiceInfo UICharacterVoiceInfo Pointer
    // 158 ScheduleConnection                       ModelClassType ScheduleConnection ScheduleConnection ScheduleConnection Pointer
    // 160 onChangeIdolSkillSubject                 Subject`1<ValueTuple`2<IProduceIdolStatus, IIdolSkillStatus>> IL2CPP_TYPE_GENERICINST
    public partial class ProducePreparationIdolSelectPopupContent : DataModel
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
        public ProducePreparationIdolSkillSelectPopupCaller? ProducePreparationIdolSkillSelectPopupCaller { get; set; }
        public List<ProduceIdol>?                       PIdolList                               { get; set; }
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
            var value   = new ProducePreparationIdolSelectPopupContent() { Pointer= p0 };

            value.IdolImage                                 = GetObject<RawImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.RawImage.FromPointer); // 0x60 IdolImage                   ( ModelClassType RawImage RawImage RawImage Pointer )
            value.IdolPrefabList                            = GetObjectList<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 0x68 IdolPrefabList              ( ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer )
            value.CharaName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 CharaName                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NickName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 NickName                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Rarity                                    = GetObject<UIRawImage>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x80 Rarity                      ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.Vocal                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 Vocal                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Dance                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x90 Dance                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Visual                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 Visual                      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Hp                                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA0 Hp                          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Cost                                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA8 Cost                        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillIcon                                 = GetObject<IdolSkillIcon>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IdolSkillIcon.FromPointer); // 0xB0 SkillIcon                   ( ModelClassType IdolSkillIcon IdolSkillIcon IdolSkillIcon Pointer )
            value.SkillName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB8 SkillName                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillDiscription                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xC0 SkillDiscription            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillCost                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xC8 SkillCost                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdolButtonRoot                            = GetObject<Transform>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Transform.FromPointer); // 0xD0 IdolButtonRoot              ( ModelClassType Transform Transform Transform Pointer )
            value.IdolButtonPrefab                          = GetObject<PFIdolIconView>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0xD8 IdolButtonPrefab            ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SkillButton                               = GetObject<UIButton>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.UIButton.FromPointer); // 0xE0 SkillButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.IdolSkillIconView                         = GetObject<IdolSkillIconView>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0xE8 IdolSkillIconView           ( ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.SkillChangeButton                         = GetObject<UIButton>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.UIButton.FromPointer); // 0xF0 SkillChangeButton           ( ModelClassType UIButton UIButton UIButton Pointer )
            value.EvolutionLevel                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xF8 EvolutionLevel              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PresetList                                = GetObjectList<TMP_ColorGradient>(new IntPtr(p + 0x100), ReversePrism.DataModels.TMP_ColorGradient.FromPointer); // 0x100 PresetList                  ( ModelClassListType List`1<TMP_ColorGradient> List`1<TMP_ColorGradient> List<TMP_ColorGradient> Pointer )
            value.StarBaseObjectList                        = GetObjectList<GameObject>(new IntPtr(p + 0x108), ReversePrism.DataModels.GameObject.FromPointer); // 0x108 StarBaseObjectList          ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.StarObjectList                            = GetObjectList<GameObject>(new IntPtr(p + 0x110), ReversePrism.DataModels.GameObject.FromPointer); // 0x110 StarObjectList              ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.SkillVoDaViMeView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x118), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0x118 SkillVoDaViMeView           ( ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.ProducePreparationIdolSkillSelectPopupCaller = GetObject<ProducePreparationIdolSkillSelectPopupCaller>(new IntPtr(p + 0x120), ReversePrism.DataModels.ProducePreparationIdolSkillSelectPopupCaller.FromPointer); // 0x120 ProducePreparationIdolSkillSelectPopupCaller ( ModelClassType ProducePreparationIdolSkillSelectPopupCaller ProducePreparationIdolSkillSelectPopupCaller ProducePreparationIdolSkillSelectPopupCaller Pointer )
            value.PIdolList                                 = GetObjectList<ProduceIdol>(new IntPtr(p + 0x128), ReversePrism.DataModels.ProduceIdol.FromPointer); // 0x128 PIdolList                   ( ModelClassListType List`1<ProduceIdol> List`1<ProduceIdol> List<ProduceIdol> Pointer )
            value.IdolIconList                              = GetObjectList<PFIdolIconView>(new IntPtr(p + 0x130), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x130 IdolIconList                ( ModelClassListType List`1<PFIdolIconView> List`1<PFIdolIconView> List<PFIdolIconView> Pointer )
            value.SelectedIdol                              = GetObject<ProduceIdol>(new IntPtr(p + 0x140), ReversePrism.DataModels.ProduceIdol.FromPointer); // 0x140 SelectedIdol                ( ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer )
            value.ChangeTargetId                            = GetInt32(new IntPtr(p + 0x148)); // 0x148 ChangeTargetId              ( ModelPrimitiveType int int int Int32 )
            value.IsLoadingCharacter                        = GetBool(new IntPtr(p + 0x14C)); // 0x14C IsLoadingCharacter          ( ModelPrimitiveType bool bool bool Bool )
            value.UiCharacterVoiceInfo                      = GetObject<UICharacterVoiceInfo>(new IntPtr(p + 0x150), ReversePrism.DataModels.UICharacterVoiceInfo.FromPointer); // 0x150 UiCharacterVoiceInfo        ( ModelClassType UICharacterVoiceInfo UICharacterVoiceInfo UICharacterVoiceInfo Pointer )
            value.ScheduleConnection                        = GetObject<ScheduleConnection>(new IntPtr(p + 0x158), ReversePrism.DataModels.ScheduleConnection.FromPointer); // 0x158 ScheduleConnection          ( ModelClassType ScheduleConnection ScheduleConnection ScheduleConnection Pointer )

            return value;
        }
    }
}
