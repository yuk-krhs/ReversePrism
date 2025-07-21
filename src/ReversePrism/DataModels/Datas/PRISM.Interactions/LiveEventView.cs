using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundImage                          ModelClassType Image Image Image Pointer
    // 028 CharacterArea                            ModelClassType Transform Transform Transform Pointer
    // 030 EventLogo                                ModelClassType Image Image Image Pointer
    // 038 EventLogoEffect                          ModelClassType Image Image Image Pointer
    // 040 DetailView                               ModelClassType EventDetailPanelView EventDetailPanelView EventDetailPanelView Pointer
    // 048 EventStoryButton                         ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 050 GashaButton                              ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 058 LiveButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 060 LiveButtonGrayOut                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 068 LbContent                                ModelClassType LiveBonusContent LiveBonusContent LiveBonusContent Pointer
    // 070 MoviePlayer                              ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer
    // 078 EventBonusView                           ModelClassType EventBonusRateView EventBonusRateView EventBonusRateView Pointer
    // 080 HowToPlayPopupOpener                     ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 088 AlbumButton                              ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 090 MedalExchangeButton                      ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 098 LiveEventBreakTimeView                   ModelClassType EventBreakTimeView EventBreakTimeView EventBreakTimeView Pointer
    // 0A0 ResultButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 0A8 RandomCharacterAreas                     ModelClassListType Image[] Image[] List<Image> Pointer
    // 0B0 LiveEventViewModel                       ModelClassType LiveEventViewModel LiveEventViewModel LiveEventViewModel Pointer
    // 0B8 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class LiveEventView : DataModel
    {
        public Image?                                   BackgroundImage                         { get; set; }
        public Transform?                               CharacterArea                           { get; set; }
        public Image?                                   EventLogo                               { get; set; }
        public Image?                                   EventLogoEffect                         { get; set; }
        public EventDetailPanelView?                    DetailView                              { get; set; }
        public CommonFooterButton?                      EventStoryButton                        { get; set; }
        public CommonFooterButton?                      GashaButton                             { get; set; }
        public UIButton?                                LiveButton                              { get; set; }
        public UIGrayOutController?                     LiveButtonGrayOut                       { get; set; }
        public LiveBonusContent?                        LbContent                               { get; set; }
        public MoviePlayer?                             MoviePlayer                             { get; set; }
        public EventBonusRateView?                      EventBonusView                          { get; set; }
        public HowToPlayPopupOpener?                    HowToPlayPopupOpener                    { get; set; }
        public CommonFooterButton?                      AlbumButton                             { get; set; }
        public CommonFooterButton?                      MedalExchangeButton                     { get; set; }
        public EventBreakTimeView?                      LiveEventBreakTimeView                  { get; set; }
        public UIButton?                                ResultButton                            { get; set; }
        public List<Image>?                             RandomCharacterAreas                    { get; set; }
        public LiveEventViewModel?                      LiveEventViewModel                      { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static LiveEventView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventView() { Pointer= p0 };

            value.BackgroundImage                           = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 BackgroundImage             ( ModelClassType Image Image Image Pointer )
            value.CharacterArea                             = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 CharacterArea               ( ModelClassType Transform Transform Transform Pointer )
            value.EventLogo                                 = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0x30 EventLogo                   ( ModelClassType Image Image Image Pointer )
            value.EventLogoEffect                           = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 0x38 EventLogoEffect             ( ModelClassType Image Image Image Pointer )
            value.DetailView                                = GetObject<EventDetailPanelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.EventDetailPanelView.FromPointer); // 0x40 DetailView                  ( ModelClassType EventDetailPanelView EventDetailPanelView EventDetailPanelView Pointer )
            value.EventStoryButton                          = GetObject<CommonFooterButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0x48 EventStoryButton            ( ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.GashaButton                               = GetObject<CommonFooterButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0x50 GashaButton                 ( ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.LiveButton                                = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 LiveButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.LiveButtonGrayOut                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x60 LiveButtonGrayOut           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.LbContent                                 = GetObject<LiveBonusContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveBonusContent.FromPointer); // 0x68 LbContent                   ( ModelClassType LiveBonusContent LiveBonusContent LiveBonusContent Pointer )
            value.MoviePlayer                               = GetObject<MoviePlayer>(new IntPtr(p + 0x070), ReversePrism.DataModels.MoviePlayer.FromPointer); // 0x70 MoviePlayer                 ( ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer )
            value.EventBonusView                            = GetObject<EventBonusRateView>(new IntPtr(p + 0x078), ReversePrism.DataModels.EventBonusRateView.FromPointer); // 0x78 EventBonusView              ( ModelClassType EventBonusRateView EventBonusRateView EventBonusRateView Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x080), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0x80 HowToPlayPopupOpener        ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.AlbumButton                               = GetObject<CommonFooterButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0x88 AlbumButton                 ( ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.MedalExchangeButton                       = GetObject<CommonFooterButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0x90 MedalExchangeButton         ( ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.LiveEventBreakTimeView                    = GetObject<EventBreakTimeView>(new IntPtr(p + 0x098), ReversePrism.DataModels.EventBreakTimeView.FromPointer); // 0x98 LiveEventBreakTimeView      ( ModelClassType EventBreakTimeView EventBreakTimeView EventBreakTimeView Pointer )
            value.ResultButton                              = GetObject<UIButton>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UIButton.FromPointer); // 0xA0 ResultButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.RandomCharacterAreas                      = GetObjectList<Image>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Image.FromPointer); // 0xA8 RandomCharacterAreas        ( ModelClassListType Image[] Image[] List<Image> Pointer )
            value.LiveEventViewModel                        = GetObject<LiveEventViewModel>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.LiveEventViewModel.FromPointer); // 0xB0 LiveEventViewModel          ( ModelClassType LiveEventViewModel LiveEventViewModel LiveEventViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0xB8 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
