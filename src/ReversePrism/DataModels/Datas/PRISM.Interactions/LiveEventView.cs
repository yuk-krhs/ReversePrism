using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundImage                          0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 CharacterArea                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 EventLogo                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 038 EventLogoEffect                          0001866CCDB0 ModelClassType Image Image Image Pointer
    // 040 DetailView                               000186755080 ModelClassType EventDetailPanelView EventDetailPanelView EventDetailPanelView Pointer
    // 048 EventStoryButton                         0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 050 GashaButton                              0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 058 LiveButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 LiveButtonGrayOut                        0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 068 LbContent                                000186540AD0 ModelClassType LiveBonusContent LiveBonusContent LiveBonusContent Pointer
    // 070 MoviePlayer                              000186658A40 ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer
    // 078 EventBonusView                           00018674F4E0 ModelClassType EventBonusRateView EventBonusRateView EventBonusRateView Pointer
    // 080 HowToPlayPopupOpener                     0001866D8C30 ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 088 LiveEventViewModel                       0001865555B0 ModelClassType LiveEventViewModel LiveEventViewModel LiveEventViewModel Pointer
    // 090 NotificationManageViewModel              0001866B2CF0 ModelClassType NotificationManageViewModel NotificationManageViewModel NotificationManageViewModel Pointer
    // 098 onClickRankingButton                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A0 onClickRewardButton                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A8 onClickMissionButton                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0B0 onClickShopButton                        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0B8 onClickEventBonusRateDetailButton        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0C0 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
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
        public LiveEventViewModel?                      LiveEventViewModel                      { get; set; }
        public NotificationManageViewModel?             NotificationManageViewModel             { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static LiveEventView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventView() { Pointer= p0 };

            value.BackgroundImage                           = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 02466B691D78 0x20 BackgroundImage             ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.CharacterArea                             = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466B691D98 0x28 CharacterArea               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.EventLogo                                 = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 02466B691DB8 0x30 EventLogo                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.EventLogoEffect                           = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 02466B691DD8 0x38 EventLogoEffect             ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.DetailView                                = GetObject<EventDetailPanelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.EventDetailPanelView.FromPointer); // 02466B691DF8 0x40 DetailView                  ( 000186755080 ModelClassType EventDetailPanelView EventDetailPanelView EventDetailPanelView Pointer )
            value.EventStoryButton                          = GetObject<CommonFooterButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 02466B691E18 0x48 EventStoryButton            ( 0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.GashaButton                               = GetObject<CommonFooterButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 02466B691E38 0x50 GashaButton                 ( 0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.LiveButton                                = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 02466B691E58 0x58 LiveButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.LiveButtonGrayOut                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 02466B691E78 0x60 LiveButtonGrayOut           ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.LbContent                                 = GetObject<LiveBonusContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveBonusContent.FromPointer); // 02466B691E98 0x68 LbContent                   ( 000186540AD0 ModelClassType LiveBonusContent LiveBonusContent LiveBonusContent Pointer )
            value.MoviePlayer                               = GetObject<MoviePlayer>(new IntPtr(p + 0x070), ReversePrism.DataModels.MoviePlayer.FromPointer); // 02466B691EB8 0x70 MoviePlayer                 ( 000186658A40 ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer )
            value.EventBonusView                            = GetObject<EventBonusRateView>(new IntPtr(p + 0x078), ReversePrism.DataModels.EventBonusRateView.FromPointer); // 02466B691ED8 0x78 EventBonusView              ( 00018674F4E0 ModelClassType EventBonusRateView EventBonusRateView EventBonusRateView Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x080), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 02466B691EF8 0x80 HowToPlayPopupOpener        ( 0001866D8C30 ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.LiveEventViewModel                        = GetObject<LiveEventViewModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveEventViewModel.FromPointer); // 02466B691F18 0x88 LiveEventViewModel          ( 0001865555B0 ModelClassType LiveEventViewModel LiveEventViewModel LiveEventViewModel Pointer )
            value.NotificationManageViewModel               = GetObject<NotificationManageViewModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.NotificationManageViewModel.FromPointer); // 02466B691F38 0x90 NotificationManageViewModel ( 0001866B2CF0 ModelClassType NotificationManageViewModel NotificationManageViewModel NotificationManageViewModel Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466B691FF8 0xC0 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
