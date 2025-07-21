using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitBackgroundView                       ModelClassType ProducePreparationEpisodeSelectUnitBackgroundView ProducePreparationEpisodeSelectUnitBackgroundView ProducePreparationEpisodeSelectUnitBackgroundView Pointer
    // 028 UnitListView                             ModelClassType ProducePreparationEpisodeSelectUnitListView ProducePreparationEpisodeSelectUnitListView ProducePreparationEpisodeSelectUnitListView Pointer
    // 030 EpisodeListView                          ModelClassType ProducePreparationEpisodeSelectListView ProducePreparationEpisodeSelectListView ProducePreparationEpisodeSelectListView Pointer
    // 038 DetailView                               ModelClassType ProducePreparationEpisodeSelectDetailView ProducePreparationEpisodeSelectDetailView ProducePreparationEpisodeSelectDetailView Pointer
    // 040 ConfirmHowToPlayButton                   ModelClassType UIButton UIButton UIButton Pointer
    // 048 FeaturesButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 050 TutorialButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 058 HowToPlayManualKey                       ModelPrimitiveType string string string String
    // 060 FesDataPossessionLimitCheckerCaller      ModelClassType IFesDataPossessionLimitCheckerCaller IFesDataPossessionLimitCheckerCaller IFesDataPossessionLimitCheckerCaller Pointer
    // 068 FesDataPossessionLimitPopupCaller        ModelClassType IFesDataPossessionLimitPopupCaller IFesDataPossessionLimitPopupCaller IFesDataPossessionLimitPopupCaller Pointer
    // 070 HowToPlayProduceManualData               ModelClassType HowToPlayProduceManualData HowToPlayProduceManualData HowToPlayProduceManualData Pointer
    public partial class ViewProducePreparationEpisodeSelectView : DataModel
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
            var value   = new ViewProducePreparationEpisodeSelectView() { Pointer= p0 };

            value.UnitBackgroundView                        = GetObject<ProducePreparationEpisodeSelectUnitBackgroundView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProducePreparationEpisodeSelectUnitBackgroundView.FromPointer); // 0x20 UnitBackgroundView          ( ModelClassType ProducePreparationEpisodeSelectUnitBackgroundView ProducePreparationEpisodeSelectUnitBackgroundView ProducePreparationEpisodeSelectUnitBackgroundView Pointer )
            value.UnitListView                              = GetObject<ProducePreparationEpisodeSelectUnitListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProducePreparationEpisodeSelectUnitListView.FromPointer); // 0x28 UnitListView                ( ModelClassType ProducePreparationEpisodeSelectUnitListView ProducePreparationEpisodeSelectUnitListView ProducePreparationEpisodeSelectUnitListView Pointer )
            value.EpisodeListView                           = GetObject<ProducePreparationEpisodeSelectListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProducePreparationEpisodeSelectListView.FromPointer); // 0x30 EpisodeListView             ( ModelClassType ProducePreparationEpisodeSelectListView ProducePreparationEpisodeSelectListView ProducePreparationEpisodeSelectListView Pointer )
            value.DetailView                                = GetObject<ProducePreparationEpisodeSelectDetailView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProducePreparationEpisodeSelectDetailView.FromPointer); // 0x38 DetailView                  ( ModelClassType ProducePreparationEpisodeSelectDetailView ProducePreparationEpisodeSelectDetailView ProducePreparationEpisodeSelectDetailView Pointer )
            value.ConfirmHowToPlayButton                    = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 ConfirmHowToPlayButton      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.FeaturesButton                            = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 FeaturesButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TutorialButton                            = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 TutorialButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.HowToPlayManualKey                        = GetString(new IntPtr(p + 0x058)); // 0x58 HowToPlayManualKey          ( ModelPrimitiveType string string string String )
            value.FesDataPossessionLimitCheckerCaller       = GetObject<IFesDataPossessionLimitCheckerCaller>(new IntPtr(p + 0x060), ReversePrism.DataModels.IFesDataPossessionLimitCheckerCaller.FromPointer); // 0x60 FesDataPossessionLimitCheckerCaller ( ModelClassType IFesDataPossessionLimitCheckerCaller IFesDataPossessionLimitCheckerCaller IFesDataPossessionLimitCheckerCaller Pointer )
            value.FesDataPossessionLimitPopupCaller         = GetObject<IFesDataPossessionLimitPopupCaller>(new IntPtr(p + 0x068), ReversePrism.DataModels.IFesDataPossessionLimitPopupCaller.FromPointer); // 0x68 FesDataPossessionLimitPopupCaller ( ModelClassType IFesDataPossessionLimitPopupCaller IFesDataPossessionLimitPopupCaller IFesDataPossessionLimitPopupCaller Pointer )
            value.HowToPlayProduceManualData                = GetObject<HowToPlayProduceManualData>(new IntPtr(p + 0x070), ReversePrism.DataModels.HowToPlayProduceManualData.FromPointer); // 0x70 HowToPlayProduceManualData  ( ModelClassType HowToPlayProduceManualData HowToPlayProduceManualData HowToPlayProduceManualData Pointer )

            return value;
        }
    }
}
