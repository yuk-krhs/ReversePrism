using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 UiCharacterView                          000186554FB0 ModelClassType ProduceIdolUpgradingUICharacterView ProduceIdolUpgradingUICharacterView ProduceIdolUpgradingUICharacterView Pointer
    // 030 View                                     0001865559F0 ModelClassType ProduceIdolUpgradingView ProduceIdolUpgradingView ProduceIdolUpgradingView Pointer
    // 038 StatusView                               0001865507F0 ModelClassType ProduceIdolStatusView ProduceIdolStatusView ProduceIdolStatusView Pointer
    // 040 AwakeningView                            0001865471D0 ModelClassType ProduceIdolAwakeningView ProduceIdolAwakeningView ProduceIdolAwakeningView Pointer
    // 048 TrainingView                             0001865519A0 ModelClassType ProduceIdolTrainingView ProduceIdolTrainingView ProduceIdolTrainingView Pointer
    // 050 SkillView                                00018654EED0 ModelClassType ProduceIdolSkillView ProduceIdolSkillView ProduceIdolSkillView Pointer
    // 058 SelectFavoriteMarkPopupViewFactory       000186715A50 ModelClassType SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory Pointer
    // 060 PIdolDetailPopupViewFactory              00018670A490 ModelClassType PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory Pointer
    // 068 HowToGetItemsPopupViewFactory            0001866D78E0 ModelClassType HowToGetItemsPopupViewFactory HowToGetItemsPopupViewFactory HowToGetItemsPopupViewFactory Pointer
    // 070 AwakeningExecutionConfirmedPopupViewFactory 00018672CE40 ModelClassType AwakeningExecutionConfirmedPopupViewFactory AwakeningExecutionConfirmedPopupViewFactory AwakeningExecutionConfirmedPopupViewFactory Pointer
    // 078 PiTrainingExecutionConfirmedPopupViewFactory 000186706B40 ModelClassType PITrainingExecutionConfirmedPopupViewFactory PITrainingExecutionConfirmedPopupViewFactory PITrainingExecutionConfirmedPopupViewFactory Pointer
    // 080 CostumeAcquisitionPopupViewFactory       000186628320 ModelClassType CostumeAcquisitionPopupViewFactory CostumeAcquisitionPopupViewFactory CostumeAcquisitionPopupViewFactory Pointer
    // 088 CostumeDetailPopupViewFactory            00018662BEB0 ModelClassType CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory Pointer
    // 090 IdolSkillLvUpExecutionConfirmedPopupViewFactory 0001866C0F20 ModelClassType IdolSkillLvUpExecutionConfirmedPopupViewFactory IdolSkillLvUpExecutionConfirmedPopupViewFactory IdolSkillLvUpExecutionConfirmedPopupViewFactory Pointer
    // 098 IdolSkillLvUpCompletedPopupViewFactory   0001866BFE10 ModelClassType IdolSkillLvUpCompletedPopupViewFactory IdolSkillLvUpCompletedPopupViewFactory IdolSkillLvUpCompletedPopupViewFactory Pointer
    // 0A0 EfficacyDetailListPopupViewFactory       000186722210 ModelClassType EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory Pointer
    public partial class ProduceIdolUpgradingBuilder : DataModel
    {
        public CommonTitleView?                         TitleView                               { get; set; }
        public ProduceIdolUpgradingUICharacterView?     UiCharacterView                         { get; set; }
        public ProduceIdolUpgradingView?                View                                    { get; set; }
        public ProduceIdolStatusView?                   StatusView                              { get; set; }
        public ProduceIdolAwakeningView?                AwakeningView                           { get; set; }
        public ProduceIdolTrainingView?                 TrainingView                            { get; set; }
        public ProduceIdolSkillView?                    SkillView                               { get; set; }
        public SelectFavoriteMarkPopupViewFactory?      SelectFavoriteMarkPopupViewFactory      { get; set; }
        public PIdolDetailPopupViewFactory?             PIdolDetailPopupViewFactory             { get; set; }
        public HowToGetItemsPopupViewFactory?           HowToGetItemsPopupViewFactory           { get; set; }
        public AwakeningExecutionConfirmedPopupViewFactory? AwakeningExecutionConfirmedPopupViewFactory { get; set; }
        public PITrainingExecutionConfirmedPopupViewFactory? PiTrainingExecutionConfirmedPopupViewFactory { get; set; }
        public CostumeAcquisitionPopupViewFactory?      CostumeAcquisitionPopupViewFactory      { get; set; }
        public CostumeDetailPopupViewFactory?           CostumeDetailPopupViewFactory           { get; set; }
        public IdolSkillLvUpExecutionConfirmedPopupViewFactory? IdolSkillLvUpExecutionConfirmedPopupViewFactory { get; set; }
        public IdolSkillLvUpCompletedPopupViewFactory?  IdolSkillLvUpCompletedPopupViewFactory  { get; set; }
        public EfficacyDetailListPopupViewFactory?      EfficacyDetailListPopupViewFactory      { get; set; }

        public static ProduceIdolUpgradingBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolUpgradingBuilder() { Pointer= p0 };

            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 02466B67EEA0 0x20 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.UiCharacterView                           = GetObject<ProduceIdolUpgradingUICharacterView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceIdolUpgradingUICharacterView.FromPointer); // 02466B67EEC0 0x28 UiCharacterView             ( 000186554FB0 ModelClassType ProduceIdolUpgradingUICharacterView ProduceIdolUpgradingUICharacterView ProduceIdolUpgradingUICharacterView Pointer )
            value.View                                      = GetObject<ProduceIdolUpgradingView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceIdolUpgradingView.FromPointer); // 02466B67EEE0 0x30 View                        ( 0001865559F0 ModelClassType ProduceIdolUpgradingView ProduceIdolUpgradingView ProduceIdolUpgradingView Pointer )
            value.StatusView                                = GetObject<ProduceIdolStatusView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceIdolStatusView.FromPointer); // 02466B67EF00 0x38 StatusView                  ( 0001865507F0 ModelClassType ProduceIdolStatusView ProduceIdolStatusView ProduceIdolStatusView Pointer )
            value.AwakeningView                             = GetObject<ProduceIdolAwakeningView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceIdolAwakeningView.FromPointer); // 02466B67EF20 0x40 AwakeningView               ( 0001865471D0 ModelClassType ProduceIdolAwakeningView ProduceIdolAwakeningView ProduceIdolAwakeningView Pointer )
            value.TrainingView                              = GetObject<ProduceIdolTrainingView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceIdolTrainingView.FromPointer); // 02466B67EF40 0x48 TrainingView                ( 0001865519A0 ModelClassType ProduceIdolTrainingView ProduceIdolTrainingView ProduceIdolTrainingView Pointer )
            value.SkillView                                 = GetObject<ProduceIdolSkillView>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceIdolSkillView.FromPointer); // 02466B67EF60 0x50 SkillView                   ( 00018654EED0 ModelClassType ProduceIdolSkillView ProduceIdolSkillView ProduceIdolSkillView Pointer )
            value.SelectFavoriteMarkPopupViewFactory        = GetObject<SelectFavoriteMarkPopupViewFactory>(new IntPtr(p + 0x058), ReversePrism.DataModels.SelectFavoriteMarkPopupViewFactory.FromPointer); // 02466B67EF80 0x58 SelectFavoriteMarkPopupViewFactory ( 000186715A50 ModelClassType SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<PIdolDetailPopupViewFactory>(new IntPtr(p + 0x060), ReversePrism.DataModels.PIdolDetailPopupViewFactory.FromPointer); // 02466B67EFA0 0x60 PIdolDetailPopupViewFactory ( 00018670A490 ModelClassType PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory Pointer )
            value.HowToGetItemsPopupViewFactory             = GetObject<HowToGetItemsPopupViewFactory>(new IntPtr(p + 0x068), ReversePrism.DataModels.HowToGetItemsPopupViewFactory.FromPointer); // 02466B67EFC0 0x68 HowToGetItemsPopupViewFactory ( 0001866D78E0 ModelClassType HowToGetItemsPopupViewFactory HowToGetItemsPopupViewFactory HowToGetItemsPopupViewFactory Pointer )
            value.AwakeningExecutionConfirmedPopupViewFactory = GetObject<AwakeningExecutionConfirmedPopupViewFactory>(new IntPtr(p + 0x070), ReversePrism.DataModels.AwakeningExecutionConfirmedPopupViewFactory.FromPointer); // 02466B67EFE0 0x70 AwakeningExecutionConfirmedPopupViewFactory ( 00018672CE40 ModelClassType AwakeningExecutionConfirmedPopupViewFactory AwakeningExecutionConfirmedPopupViewFactory AwakeningExecutionConfirmedPopupViewFactory Pointer )
            value.PiTrainingExecutionConfirmedPopupViewFactory = GetObject<PITrainingExecutionConfirmedPopupViewFactory>(new IntPtr(p + 0x078), ReversePrism.DataModels.PITrainingExecutionConfirmedPopupViewFactory.FromPointer); // 02466B67F000 0x78 PiTrainingExecutionConfirmedPopupViewFactory ( 000186706B40 ModelClassType PITrainingExecutionConfirmedPopupViewFactory PITrainingExecutionConfirmedPopupViewFactory PITrainingExecutionConfirmedPopupViewFactory Pointer )
            value.CostumeAcquisitionPopupViewFactory        = GetObject<CostumeAcquisitionPopupViewFactory>(new IntPtr(p + 0x080), ReversePrism.DataModels.CostumeAcquisitionPopupViewFactory.FromPointer); // 02466B67F020 0x80 CostumeAcquisitionPopupViewFactory ( 000186628320 ModelClassType CostumeAcquisitionPopupViewFactory CostumeAcquisitionPopupViewFactory CostumeAcquisitionPopupViewFactory Pointer )
            value.CostumeDetailPopupViewFactory             = GetObject<CostumeDetailPopupViewFactory>(new IntPtr(p + 0x088), ReversePrism.DataModels.CostumeDetailPopupViewFactory.FromPointer); // 02466B67F040 0x88 CostumeDetailPopupViewFactory ( 00018662BEB0 ModelClassType CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory Pointer )
            value.IdolSkillLvUpExecutionConfirmedPopupViewFactory = GetObject<IdolSkillLvUpExecutionConfirmedPopupViewFactory>(new IntPtr(p + 0x090), ReversePrism.DataModels.IdolSkillLvUpExecutionConfirmedPopupViewFactory.FromPointer); // 02466B67F060 0x90 IdolSkillLvUpExecutionConfirmedPopupViewFactory ( 0001866C0F20 ModelClassType IdolSkillLvUpExecutionConfirmedPopupViewFactory IdolSkillLvUpExecutionConfirmedPopupViewFactory IdolSkillLvUpExecutionConfirmedPopupViewFactory Pointer )
            value.IdolSkillLvUpCompletedPopupViewFactory    = GetObject<IdolSkillLvUpCompletedPopupViewFactory>(new IntPtr(p + 0x098), ReversePrism.DataModels.IdolSkillLvUpCompletedPopupViewFactory.FromPointer); // 02466B67F080 0x98 IdolSkillLvUpCompletedPopupViewFactory ( 0001866BFE10 ModelClassType IdolSkillLvUpCompletedPopupViewFactory IdolSkillLvUpCompletedPopupViewFactory IdolSkillLvUpCompletedPopupViewFactory Pointer )
            value.EfficacyDetailListPopupViewFactory        = GetObject<EfficacyDetailListPopupViewFactory>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.EfficacyDetailListPopupViewFactory.FromPointer); // 02466B67F0A0 0xA0 EfficacyDetailListPopupViewFactory ( 000186722210 ModelClassType EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory Pointer )

            return value;
        }
    }
}
