using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DescriptionSeparateStr                   string IL2CPP_TYPE_STRING
    // 048 VoDaViMeMultiView                        ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 050 ProduceCard                              ModelClassType InGamePCardContent InGamePCardContent InGamePCardContent Pointer
    // 058 SkillArea                                ModelClassType GameObject GameObject GameObject Pointer
    // 060 IdolSkillIcon                            ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 068 TrainerSkillIcon                         ModelClassType TrainerSkillIconView TrainerSkillIconView TrainerSkillIconView Pointer
    // 070 SkillLimitPanel                          ModelClassType SkillLimitPanel SkillLimitPanel SkillLimitPanel Pointer
    // 078 SkillUsableCountUI                       ModelClassType GameObject GameObject GameObject Pointer
    // 080 NotPhaseDescriptionBlendColor            ModelEnumType Color Color Color Int32
    // 090 ShowDetailType                           ModelEnumType ShowDetailType ShowDetailType ShowDetailType Int32
    // 098 ProduceCardModel                         ModelClassType IngamePCardModel IngamePCardModel IngamePCardModel Pointer
    // 0A0 getCardPredictionFunc                    Func`2<ShowProduceCardDetailParam, CardAndSkillPredictionModel> IL2CPP_TYPE_GENERICINST
    // 0A8 IdolSkillModel                           ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer
    // 0B0 getSkillPredictionFunc                   Func`3<IngameSkillModel, IngameActionEffectModel, CardAndSkillPredictionModel> IL2CPP_TYPE_GENERICINST
    // 0B8 TrainerSkillModel                        ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer
    public partial class ProduceCardAndCharaSkillDetailPanel : DataModel
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
            var value   = new ProduceCardAndCharaSkillDetailPanel() { Pointer= p0 };

            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x048), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0x48 VoDaViMeMultiView           ( ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.ProduceCard                               = GetObject<InGamePCardContent>(new IntPtr(p + 0x050), ReversePrism.DataModels.InGamePCardContent.FromPointer); // 0x50 ProduceCard                 ( ModelClassType InGamePCardContent InGamePCardContent InGamePCardContent Pointer )
            value.SkillArea                                 = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 SkillArea                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.IdolSkillIcon                             = GetObject<IdolSkillIconView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0x60 IdolSkillIcon               ( ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.TrainerSkillIcon                          = GetObject<TrainerSkillIconView>(new IntPtr(p + 0x068), ReversePrism.DataModels.TrainerSkillIconView.FromPointer); // 0x68 TrainerSkillIcon            ( ModelClassType TrainerSkillIconView TrainerSkillIconView TrainerSkillIconView Pointer )
            value.SkillLimitPanel                           = GetObject<SkillLimitPanel>(new IntPtr(p + 0x070), ReversePrism.DataModels.SkillLimitPanel.FromPointer); // 0x70 SkillLimitPanel             ( ModelClassType SkillLimitPanel SkillLimitPanel SkillLimitPanel Pointer )
            value.SkillUsableCountUI                        = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 SkillUsableCountUI          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NotPhaseDescriptionBlendColor             = (Color)GetInt32(new IntPtr(p + 0x080)); // 0x80 NotPhaseDescriptionBlendColor ( ModelEnumType Color Color Color Int32 )
            value.ShowDetailType                            = (ShowDetailType)GetInt32(new IntPtr(p + 0x090)); // 0x90 ShowDetailType              ( ModelEnumType ShowDetailType ShowDetailType ShowDetailType Int32 )
            value.ProduceCardModel                          = GetObject<IngamePCardModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0x98 ProduceCardModel            ( ModelClassType IngamePCardModel IngamePCardModel IngamePCardModel Pointer )
            value.IdolSkillModel                            = GetObject<IngameSkillModel>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IngameSkillModel.FromPointer); // 0xA8 IdolSkillModel              ( ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer )
            value.TrainerSkillModel                         = GetObject<IngameSkillModel>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IngameSkillModel.FromPointer); // 0xB8 TrainerSkillModel           ( ModelClassType IngameSkillModel IngameSkillModel IngameSkillModel Pointer )

            return value;
        }
    }
}
