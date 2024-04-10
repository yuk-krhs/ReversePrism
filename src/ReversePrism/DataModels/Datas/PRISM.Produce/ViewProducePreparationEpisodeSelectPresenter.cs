using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 View                                     000186520FE0 ModelClassType ViewProducePreparationEpisodeSelectView ViewProducePreparationEpisodeSelectView ViewProducePreparationEpisodeSelectView Pointer
    // 088 DifficultyReleasedConfigRef              000186671E00 ModelPrimitiveType string string string String
    // 090 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 098 Model                                    00018651FD70 ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer
    // 0A0 BannerPresenter                          000186568C90 ModelClassType ProducePreparationEpisodeSelectBannerPresenter ProducePreparationEpisodeSelectBannerPresenter ProducePreparationEpisodeSelectBannerPresenter Pointer
    // 0A8 IsInitilizing                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B0 TutorialInfoSequence                     0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    // 0B8 EndTutorialCaller                        000186730E10 ModelClassType EndTutorialConfirmPopupViewCaller EndTutorialConfirmPopupViewCaller EndTutorialConfirmPopupViewCaller Pointer
    public partial class ViewProducePreparationEpisodeSelectPresenter : DataModel
    {
        public ViewProducePreparationEpisodeSelectView? View                                    { get; set; }
        public string                                   DifficultyReleasedConfigRef             { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public ViewProducePreparationEpisodeSelectModel? Model                                   { get; set; }
        public ProducePreparationEpisodeSelectBannerPresenter? BannerPresenter                         { get; set; }
        public bool                                     IsInitilizing                           { get; set; }
        public ITutorialSequence?                       TutorialInfoSequence                    { get; set; }
        public EndTutorialConfirmPopupViewCaller?       EndTutorialCaller                       { get; set; }

        public static ViewProducePreparationEpisodeSelectPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewProducePreparationEpisodeSelectPresenter() { Pointer= p0 };

            value.View                                      = GetObject<ViewProducePreparationEpisodeSelectView>(new IntPtr(p + 0x080), ReversePrism.DataModels.ViewProducePreparationEpisodeSelectView.FromPointer); // 024665A58858 0x80 View                        ( 000186520FE0 ModelClassType ViewProducePreparationEpisodeSelectView ViewProducePreparationEpisodeSelectView ViewProducePreparationEpisodeSelectView Pointer )
            value.DifficultyReleasedConfigRef               = GetString(new IntPtr(p + 0x088)); // 024665A58878 0x88 DifficultyReleasedConfigRef ( 000186671E00 ModelPrimitiveType string string string String )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x090)); // 024665A58898 0x90 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Model                                     = GetObject<ViewProducePreparationEpisodeSelectModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.ViewProducePreparationEpisodeSelectModel.FromPointer); // 024665A588B8 0x98 Model                       ( 00018651FD70 ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer )
            value.BannerPresenter                           = GetObject<ProducePreparationEpisodeSelectBannerPresenter>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ProducePreparationEpisodeSelectBannerPresenter.FromPointer); // 024665A588D8 0xA0 BannerPresenter             ( 000186568C90 ModelClassType ProducePreparationEpisodeSelectBannerPresenter ProducePreparationEpisodeSelectBannerPresenter ProducePreparationEpisodeSelectBannerPresenter Pointer )
            value.IsInitilizing                             = GetBool(new IntPtr(p + 0x0A8)); // 024665A588F8 0xA8 IsInitilizing               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TutorialInfoSequence                      = GetObject<ITutorialSequence>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 024665A58918 0xB0 TutorialInfoSequence        ( 0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )
            value.EndTutorialCaller                         = GetObject<EndTutorialConfirmPopupViewCaller>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.EndTutorialConfirmPopupViewCaller.FromPointer); // 024665A58938 0xB8 EndTutorialCaller           ( 000186730E10 ModelClassType EndTutorialConfirmPopupViewCaller EndTutorialConfirmPopupViewCaller EndTutorialConfirmPopupViewCaller Pointer )

            return value;
        }
    }
}
