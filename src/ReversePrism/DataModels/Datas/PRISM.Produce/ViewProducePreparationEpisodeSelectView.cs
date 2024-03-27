using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitBackgroundView                       00018656B8E0 ModelClassType ProducePreparationEpisodeSelectUnitBackgroundView ProducePreparationEpisodeSelectUnitBackgroundView ProducePreparationEpisodeSelectUnitBackgroundView Pointer
    // 028 UnitListView                             00018656D090 ModelClassType ProducePreparationEpisodeSelectUnitListView ProducePreparationEpisodeSelectUnitListView ProducePreparationEpisodeSelectUnitListView Pointer
    // 030 EpisodeListView                          00018656AC20 ModelClassType ProducePreparationEpisodeSelectListView ProducePreparationEpisodeSelectListView ProducePreparationEpisodeSelectListView Pointer
    // 038 DetailView                               00018656A2F0 ModelClassType ProducePreparationEpisodeSelectDetailView ProducePreparationEpisodeSelectDetailView ProducePreparationEpisodeSelectDetailView Pointer
    // 040 bannerBuilder                            SerializableInterface`1<IProducePreparationEpisodeSelectBannerBuilder> IL2CPP_TYPE_GENERICINST
    // 048 ConfirmHowToPlayButton                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 FeaturesButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 TutorialButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 HowToPlayManualKey                       000186671910 ModelPrimitiveType string string string String
    // 068 FesDataPossessionLimitCheckerCaller      000186777310 ModelClassType IFesDataPossessionLimitCheckerCaller IFesDataPossessionLimitCheckerCaller IFesDataPossessionLimitCheckerCaller Pointer
    // 070 FesDataPossessionLimitPopupCaller        000186777820 ModelClassType IFesDataPossessionLimitPopupCaller IFesDataPossessionLimitPopupCaller IFesDataPossessionLimitPopupCaller Pointer
    // 078 HowToPlayProduceManualData               0001866DA470 ModelClassType HowToPlayProduceManualData HowToPlayProduceManualData HowToPlayProduceManualData Pointer
    public partial class ViewProducePreparationEpisodeSelectView
    {
        public ProducePreparationEpisodeSelectUnitBackgroundView? UnitBackgroundView                      { get; set; }
        public ProducePreparationEpisodeSelectUnitListView? UnitListView                            { get; set; }
        public ProducePreparationEpisodeSelectListView? EpisodeListView                         { get; set; }
        public ProducePreparationEpisodeSelectDetailView? DetailView                              { get; set; }
        public UIButton?                                ConfirmHowToPlayButton                  { get; set; }
        public UIButton?                                FeaturesButton                          { get; set; }
        public UIButton?                                TutorialButton                          { get; set; }
        public string                                   HowToPlayManualKey                      { get; set; }
        public IFesDataPossessionLimitCheckerCaller?    FesDataPossessionLimitCheckerCaller     { get; set; }
        public IFesDataPossessionLimitPopupCaller?      FesDataPossessionLimitPopupCaller       { get; set; }
        public HowToPlayProduceManualData?              HowToPlayProduceManualData              { get; set; }

        public static ViewProducePreparationEpisodeSelectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewProducePreparationEpisodeSelectView();

            value.UnitBackgroundView                        = GetObject<ProducePreparationEpisodeSelectUnitBackgroundView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProducePreparationEpisodeSelectUnitBackgroundView.FromPointer); // 0270D59FB2A8 0x20 UnitBackgroundView          ( 00018656B8E0 ModelClassType ProducePreparationEpisodeSelectUnitBackgroundView ProducePreparationEpisodeSelectUnitBackgroundView ProducePreparationEpisodeSelectUnitBackgroundView Pointer )
            value.UnitListView                              = GetObject<ProducePreparationEpisodeSelectUnitListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProducePreparationEpisodeSelectUnitListView.FromPointer); // 0270D59FB2C8 0x28 UnitListView                ( 00018656D090 ModelClassType ProducePreparationEpisodeSelectUnitListView ProducePreparationEpisodeSelectUnitListView ProducePreparationEpisodeSelectUnitListView Pointer )
            value.EpisodeListView                           = GetObject<ProducePreparationEpisodeSelectListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProducePreparationEpisodeSelectListView.FromPointer); // 0270D59FB2E8 0x30 EpisodeListView             ( 00018656AC20 ModelClassType ProducePreparationEpisodeSelectListView ProducePreparationEpisodeSelectListView ProducePreparationEpisodeSelectListView Pointer )
            value.DetailView                                = GetObject<ProducePreparationEpisodeSelectDetailView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProducePreparationEpisodeSelectDetailView.FromPointer); // 0270D59FB308 0x38 DetailView                  ( 00018656A2F0 ModelClassType ProducePreparationEpisodeSelectDetailView ProducePreparationEpisodeSelectDetailView ProducePreparationEpisodeSelectDetailView Pointer )
            value.ConfirmHowToPlayButton                    = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0270D59FB348 0x48 ConfirmHowToPlayButton      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.FeaturesButton                            = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0270D59FB368 0x50 FeaturesButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TutorialButton                            = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0270D59FB388 0x58 TutorialButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.HowToPlayManualKey                        = GetString(new IntPtr(p + 0x060)); // 0270D59FB3A8 0x60 HowToPlayManualKey          ( 000186671910 ModelPrimitiveType string string string String )
            value.FesDataPossessionLimitCheckerCaller       = GetObject<IFesDataPossessionLimitCheckerCaller>(new IntPtr(p + 0x068), ReversePrism.DataModels.IFesDataPossessionLimitCheckerCaller.FromPointer); // 0270D59FB3C8 0x68 FesDataPossessionLimitCheckerCaller ( 000186777310 ModelClassType IFesDataPossessionLimitCheckerCaller IFesDataPossessionLimitCheckerCaller IFesDataPossessionLimitCheckerCaller Pointer )
            value.FesDataPossessionLimitPopupCaller         = GetObject<IFesDataPossessionLimitPopupCaller>(new IntPtr(p + 0x070), ReversePrism.DataModels.IFesDataPossessionLimitPopupCaller.FromPointer); // 0270D59FB3E8 0x70 FesDataPossessionLimitPopupCaller ( 000186777820 ModelClassType IFesDataPossessionLimitPopupCaller IFesDataPossessionLimitPopupCaller IFesDataPossessionLimitPopupCaller Pointer )
            value.HowToPlayProduceManualData                = GetObject<HowToPlayProduceManualData>(new IntPtr(p + 0x078), ReversePrism.DataModels.HowToPlayProduceManualData.FromPointer); // 0270D59FB408 0x78 HowToPlayProduceManualData  ( 0001866DA470 ModelClassType HowToPlayProduceManualData HowToPlayProduceManualData HowToPlayProduceManualData Pointer )

            return value;
        }
    }
}
