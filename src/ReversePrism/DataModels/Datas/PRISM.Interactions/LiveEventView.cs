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
    public partial class LiveEventView
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
            var value   = new LiveEventView();

            value.BackgroundImage                           = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0270DB615380 0x20 BackgroundImage             ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.CharacterArea                             = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DB6153A0 0x28 CharacterArea               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.EventLogo                                 = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0270DB6153C0 0x30 EventLogo                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.EventLogoEffect                           = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 0270DB6153E0 0x38 EventLogoEffect             ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.DetailView                                = GetObject<EventDetailPanelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.EventDetailPanelView.FromPointer); // 0270DB615400 0x40 DetailView                  ( 000186755080 ModelClassType EventDetailPanelView EventDetailPanelView EventDetailPanelView Pointer )
            value.EventStoryButton                          = GetObject<CommonFooterButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0270DB615420 0x48 EventStoryButton            ( 0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.GashaButton                               = GetObject<CommonFooterButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0270DB615440 0x50 GashaButton                 ( 0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.LiveButton                                = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB615460 0x58 LiveButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.LiveButtonGrayOut                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270DB615480 0x60 LiveButtonGrayOut           ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.LbContent                                 = GetObject<LiveBonusContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveBonusContent.FromPointer); // 0270DB6154A0 0x68 LbContent                   ( 000186540AD0 ModelClassType LiveBonusContent LiveBonusContent LiveBonusContent Pointer )
            value.MoviePlayer                               = GetObject<MoviePlayer>(new IntPtr(p + 0x070), ReversePrism.DataModels.MoviePlayer.FromPointer); // 0270DB6154C0 0x70 MoviePlayer                 ( 000186658A40 ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer )
            value.EventBonusView                            = GetObject<EventBonusRateView>(new IntPtr(p + 0x078), ReversePrism.DataModels.EventBonusRateView.FromPointer); // 0270DB6154E0 0x78 EventBonusView              ( 00018674F4E0 ModelClassType EventBonusRateView EventBonusRateView EventBonusRateView Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x080), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0270DB615500 0x80 HowToPlayPopupOpener        ( 0001866D8C30 ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.LiveEventViewModel                        = GetObject<LiveEventViewModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveEventViewModel.FromPointer); // 0270DB615520 0x88 LiveEventViewModel          ( 0001865555B0 ModelClassType LiveEventViewModel LiveEventViewModel LiveEventViewModel Pointer )
            value.NotificationManageViewModel               = GetObject<NotificationManageViewModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.NotificationManageViewModel.FromPointer); // 0270DB615540 0x90 NotificationManageViewModel ( 0001866B2CF0 ModelClassType NotificationManageViewModel NotificationManageViewModel NotificationManageViewModel Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB615600 0xC0 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
