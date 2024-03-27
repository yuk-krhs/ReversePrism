using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DescriptionSeparateStr                   string IL2CPP_TYPE_STRING
    // 048 VoDaViMeMultiView                        000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 050 ProduceCard                              0001866D6110 ModelClassType InGamePCardContent InGamePCardContent InGamePCardContent Pointer
    // 058 SkillArea                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 IdolSkillIcon                            0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 068 TrainerSkillIcon                         00018669EBE0 ModelClassType TrainerSkillIconView TrainerSkillIconView TrainerSkillIconView Pointer
    // 070 SkillLimitPanel                          0001865135B0 ModelClassType SkillLimitPanel SkillLimitPanel SkillLimitPanel Pointer
    // 078 SkillUsableCountUI                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 NotPhaseDescriptionBlendColor            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 090 ShowDetailType                           0001865CBA80 ModelEnumType ShowDetailType ShowDetailType ShowDetailType Int32
    // 098 ProduceCardModel                         0001866E49A0 ModelClassType IngamePCardModel IngamePCardModel IngamePCardModel Pointer
    // 0A0 getCardPredictionFunc                    Func`4<IngamePCardModel, IngameActionEffectModel, bool, CardAndSkillPredictionModel> IL2CPP_TYPE_GENERICINST
    // 0A8 IdolSkillModel                           0001866E7FA0 ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer
    // 0B0 getSkillPredictionFunc                   Func`3<IngameSkillModel, IngameActionEffectModel, CardAndSkillPredictionModel> IL2CPP_TYPE_GENERICINST
    // 0B8 TrainerSkillModel                        0001866E7FA0 ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer
    public partial class ProduceCardAndCharaSkillDetailPanel
    {
        public VoDaViMeMultiView?                       VoDaViMeMultiView                       { get; set; }
        public InGamePCardContent?                      ProduceCard                             { get; set; }
        public GameObject?                              SkillArea                               { get; set; }
        public IdolSkillIconView?                       IdolSkillIcon                           { get; set; }
        public TrainerSkillIconView?                    TrainerSkillIcon                        { get; set; }
        public SkillLimitPanel?                         SkillLimitPanel                         { get; set; }
        public GameObject?                              SkillUsableCountUI                      { get; set; }
        public Color                                    NotPhaseDescriptionBlendColor           { get; set; }
        public ShowDetailType                           ShowDetailType                          { get; set; }
        public IngamePCardModel?                        ProduceCardModel                        { get; set; }
        public IngameSkillModel?                        IdolSkillModel                          { get; set; }
        public IngameSkillModel?                        TrainerSkillModel                       { get; set; }

        public static ProduceCardAndCharaSkillDetailPanel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceCardAndCharaSkillDetailPanel();

            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x048), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0270D5C4E0E0 0x48 VoDaViMeMultiView           ( 000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.ProduceCard                               = GetObject<InGamePCardContent>(new IntPtr(p + 0x050), ReversePrism.DataModels.InGamePCardContent.FromPointer); // 0270D5C4E100 0x50 ProduceCard                 ( 0001866D6110 ModelClassType InGamePCardContent InGamePCardContent InGamePCardContent Pointer )
            value.SkillArea                                 = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5C4E120 0x58 SkillArea                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IdolSkillIcon                             = GetObject<IdolSkillIconView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0270D5C4E140 0x60 IdolSkillIcon               ( 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.TrainerSkillIcon                          = GetObject<TrainerSkillIconView>(new IntPtr(p + 0x068), ReversePrism.DataModels.TrainerSkillIconView.FromPointer); // 0270D5C4E160 0x68 TrainerSkillIcon            ( 00018669EBE0 ModelClassType TrainerSkillIconView TrainerSkillIconView TrainerSkillIconView Pointer )
            value.SkillLimitPanel                           = GetObject<SkillLimitPanel>(new IntPtr(p + 0x070), ReversePrism.DataModels.SkillLimitPanel.FromPointer); // 0270D5C4E180 0x70 SkillLimitPanel             ( 0001865135B0 ModelClassType SkillLimitPanel SkillLimitPanel SkillLimitPanel Pointer )
            value.SkillUsableCountUI                        = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5C4E1A0 0x78 SkillUsableCountUI          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NotPhaseDescriptionBlendColor             = (Color)GetInt32(new IntPtr(p + 0x080)); // 0270D5C4E1C0 0x80 NotPhaseDescriptionBlendColor ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.ShowDetailType                            = (ShowDetailType)GetInt32(new IntPtr(p + 0x090)); // 0270D5C4E1E0 0x90 ShowDetailType              ( 0001865CBA80 ModelEnumType ShowDetailType ShowDetailType ShowDetailType Int32 )
            value.ProduceCardModel                          = GetObject<IngamePCardModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0270D5C4E200 0x98 ProduceCardModel            ( 0001866E49A0 ModelClassType IngamePCardModel IngamePCardModel IngamePCardModel Pointer )
            value.IdolSkillModel                            = GetObject<IngameSkillModel>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IngameSkillModel.FromPointer); // 0270D5C4E240 0xA8 IdolSkillModel              ( 0001866E7FA0 ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer )
            value.TrainerSkillModel                         = GetObject<IngameSkillModel>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IngameSkillModel.FromPointer); // 0270D5C4E280 0xB8 TrainerSkillModel           ( 0001866E7FA0 ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer )

            return value;
        }
    }
}
