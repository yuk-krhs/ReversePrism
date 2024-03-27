using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 UiCharacterView                          0001866AA980 ModelClassType IdolBaseDetailUICharacterView IdolBaseDetailUICharacterView IdolBaseDetailUICharacterView Pointer
    // 030 View                                     0001866AB0C0 ModelClassType IdolBaseDetailView IdolBaseDetailView IdolBaseDetailView Pointer
    // 038 ProfileView                              0001866A8260 ModelClassType IdolBaseDetailProfileView IdolBaseDetailProfileView IdolBaseDetailProfileView Pointer
    // 040 StatusView                               0001866A9D20 ModelClassType IdolBaseDetailStatusView IdolBaseDetailStatusView IdolBaseDetailStatusView Pointer
    // 048 GalleryView                              0001866A6EB0 ModelClassType IdolBaseDetailGalleryView IdolBaseDetailGalleryView IdolBaseDetailGalleryView Pointer
    // 050 CasualCostumeView                        0001866A6240 ModelClassType IdolBaseDetailCasualCostumeView IdolBaseDetailCasualCostumeView IdolBaseDetailCasualCostumeView Pointer
    // 058 AlbumPopupViewFactory                    00018669F660 ModelClassType AlbumPopupViewFactory AlbumPopupViewFactory AlbumPopupViewFactory Pointer
    // 060 CostumePopupViewFactory                  00018662ED50 ModelClassType CostumePopupViewFactory CostumePopupViewFactory CostumePopupViewFactory Pointer
    // 068 VoicePopupViewFactory                    000186538BE0 ModelClassType VoicePopupViewFactory VoicePopupViewFactory VoicePopupViewFactory Pointer
    // 070 VoicePlayTabListPopupViewFactory         000186537780 ModelClassType VoicePlayTabListPopupViewFactory VoicePlayTabListPopupViewFactory VoicePlayTabListPopupViewFactory Pointer
    // 078 VoicePlayListPopupViewFactory            000186536120 ModelClassType VoicePlayListPopupViewFactory VoicePlayListPopupViewFactory VoicePlayListPopupViewFactory Pointer
    // 080 MoviePopupViewFactory                    00018665AEF0 ModelClassType MoviePopupViewFactory MoviePopupViewFactory MoviePopupViewFactory Pointer
    // 088 EtceteraPopupViewFactory                 00018674A050 ModelClassType EtceteraPopupViewFactory EtceteraPopupViewFactory EtceteraPopupViewFactory Pointer
    // 090 FullSizeImageOverlayViewFactory          0001865D3620 ModelClassType FullSizeImageOverlayViewFactory FullSizeImageOverlayViewFactory FullSizeImageOverlayViewFactory Pointer
    // 098 RewardListPopupFactory                   0001866A8E70 ModelClassType IdolBaseDetailRewardListPopupFactory IdolBaseDetailRewardListPopupFactory IdolBaseDetailRewardListPopupFactory Pointer
    // 0A0 PIdolDetailPopupViewFactory              00018670A490 ModelClassType PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory Pointer
    // 0A8 CostumeDetailPopupViewFactory            00018662BEB0 ModelClassType CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory Pointer
    // 0B0 SCharaDetailPopupViewFactory             0001866A44F0 ModelClassType SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory Pointer
    public partial class IdolBaseDetailBuilder
    {
        public CommonTitleView?                         TitleView                               { get; set; }
        public IdolBaseDetailUICharacterView?           UiCharacterView                         { get; set; }
        public IdolBaseDetailView?                      View                                    { get; set; }
        public IdolBaseDetailProfileView?               ProfileView                             { get; set; }
        public IdolBaseDetailStatusView?                StatusView                              { get; set; }
        public IdolBaseDetailGalleryView?               GalleryView                             { get; set; }
        public IdolBaseDetailCasualCostumeView?         CasualCostumeView                       { get; set; }
        public AlbumPopupViewFactory?                   AlbumPopupViewFactory                   { get; set; }
        public CostumePopupViewFactory?                 CostumePopupViewFactory                 { get; set; }
        public VoicePopupViewFactory?                   VoicePopupViewFactory                   { get; set; }
        public VoicePlayTabListPopupViewFactory?        VoicePlayTabListPopupViewFactory        { get; set; }
        public VoicePlayListPopupViewFactory?           VoicePlayListPopupViewFactory           { get; set; }
        public MoviePopupViewFactory?                   MoviePopupViewFactory                   { get; set; }
        public EtceteraPopupViewFactory?                EtceteraPopupViewFactory                { get; set; }
        public FullSizeImageOverlayViewFactory?         FullSizeImageOverlayViewFactory         { get; set; }
        public IdolBaseDetailRewardListPopupFactory?    RewardListPopupFactory                  { get; set; }
        public PIdolDetailPopupViewFactory?             PIdolDetailPopupViewFactory             { get; set; }
        public CostumeDetailPopupViewFactory?           CostumeDetailPopupViewFactory           { get; set; }
        public SCharaDetailPopupViewFactory?            SCharaDetailPopupViewFactory            { get; set; }

        public static IdolBaseDetailBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailBuilder();

            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270DB642F50 0x20 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.UiCharacterView                           = GetObject<IdolBaseDetailUICharacterView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolBaseDetailUICharacterView.FromPointer); // 0270DB642F70 0x28 UiCharacterView             ( 0001866AA980 ModelClassType IdolBaseDetailUICharacterView IdolBaseDetailUICharacterView IdolBaseDetailUICharacterView Pointer )
            value.View                                      = GetObject<IdolBaseDetailView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IdolBaseDetailView.FromPointer); // 0270DB642F90 0x30 View                        ( 0001866AB0C0 ModelClassType IdolBaseDetailView IdolBaseDetailView IdolBaseDetailView Pointer )
            value.ProfileView                               = GetObject<IdolBaseDetailProfileView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolBaseDetailProfileView.FromPointer); // 0270DB642FB0 0x38 ProfileView                 ( 0001866A8260 ModelClassType IdolBaseDetailProfileView IdolBaseDetailProfileView IdolBaseDetailProfileView Pointer )
            value.StatusView                                = GetObject<IdolBaseDetailStatusView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolBaseDetailStatusView.FromPointer); // 0270DB642FD0 0x40 StatusView                  ( 0001866A9D20 ModelClassType IdolBaseDetailStatusView IdolBaseDetailStatusView IdolBaseDetailStatusView Pointer )
            value.GalleryView                               = GetObject<IdolBaseDetailGalleryView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolBaseDetailGalleryView.FromPointer); // 0270DB642FF0 0x48 GalleryView                 ( 0001866A6EB0 ModelClassType IdolBaseDetailGalleryView IdolBaseDetailGalleryView IdolBaseDetailGalleryView Pointer )
            value.CasualCostumeView                         = GetObject<IdolBaseDetailCasualCostumeView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IdolBaseDetailCasualCostumeView.FromPointer); // 0270DB643010 0x50 CasualCostumeView           ( 0001866A6240 ModelClassType IdolBaseDetailCasualCostumeView IdolBaseDetailCasualCostumeView IdolBaseDetailCasualCostumeView Pointer )
            value.AlbumPopupViewFactory                     = GetObject<AlbumPopupViewFactory>(new IntPtr(p + 0x058), ReversePrism.DataModels.AlbumPopupViewFactory.FromPointer); // 0270DB643030 0x58 AlbumPopupViewFactory       ( 00018669F660 ModelClassType AlbumPopupViewFactory AlbumPopupViewFactory AlbumPopupViewFactory Pointer )
            value.CostumePopupViewFactory                   = GetObject<CostumePopupViewFactory>(new IntPtr(p + 0x060), ReversePrism.DataModels.CostumePopupViewFactory.FromPointer); // 0270DB643050 0x60 CostumePopupViewFactory     ( 00018662ED50 ModelClassType CostumePopupViewFactory CostumePopupViewFactory CostumePopupViewFactory Pointer )
            value.VoicePopupViewFactory                     = GetObject<VoicePopupViewFactory>(new IntPtr(p + 0x068), ReversePrism.DataModels.VoicePopupViewFactory.FromPointer); // 0270DB643070 0x68 VoicePopupViewFactory       ( 000186538BE0 ModelClassType VoicePopupViewFactory VoicePopupViewFactory VoicePopupViewFactory Pointer )
            value.VoicePlayTabListPopupViewFactory          = GetObject<VoicePlayTabListPopupViewFactory>(new IntPtr(p + 0x070), ReversePrism.DataModels.VoicePlayTabListPopupViewFactory.FromPointer); // 0270DB643090 0x70 VoicePlayTabListPopupViewFactory ( 000186537780 ModelClassType VoicePlayTabListPopupViewFactory VoicePlayTabListPopupViewFactory VoicePlayTabListPopupViewFactory Pointer )
            value.VoicePlayListPopupViewFactory             = GetObject<VoicePlayListPopupViewFactory>(new IntPtr(p + 0x078), ReversePrism.DataModels.VoicePlayListPopupViewFactory.FromPointer); // 0270DB6430B0 0x78 VoicePlayListPopupViewFactory ( 000186536120 ModelClassType VoicePlayListPopupViewFactory VoicePlayListPopupViewFactory VoicePlayListPopupViewFactory Pointer )
            value.MoviePopupViewFactory                     = GetObject<MoviePopupViewFactory>(new IntPtr(p + 0x080), ReversePrism.DataModels.MoviePopupViewFactory.FromPointer); // 0270DB6430D0 0x80 MoviePopupViewFactory       ( 00018665AEF0 ModelClassType MoviePopupViewFactory MoviePopupViewFactory MoviePopupViewFactory Pointer )
            value.EtceteraPopupViewFactory                  = GetObject<EtceteraPopupViewFactory>(new IntPtr(p + 0x088), ReversePrism.DataModels.EtceteraPopupViewFactory.FromPointer); // 0270DB6430F0 0x88 EtceteraPopupViewFactory    ( 00018674A050 ModelClassType EtceteraPopupViewFactory EtceteraPopupViewFactory EtceteraPopupViewFactory Pointer )
            value.FullSizeImageOverlayViewFactory           = GetObject<FullSizeImageOverlayViewFactory>(new IntPtr(p + 0x090), ReversePrism.DataModels.FullSizeImageOverlayViewFactory.FromPointer); // 0270DB643110 0x90 FullSizeImageOverlayViewFactory ( 0001865D3620 ModelClassType FullSizeImageOverlayViewFactory FullSizeImageOverlayViewFactory FullSizeImageOverlayViewFactory Pointer )
            value.RewardListPopupFactory                    = GetObject<IdolBaseDetailRewardListPopupFactory>(new IntPtr(p + 0x098), ReversePrism.DataModels.IdolBaseDetailRewardListPopupFactory.FromPointer); // 0270DB643130 0x98 RewardListPopupFactory      ( 0001866A8E70 ModelClassType IdolBaseDetailRewardListPopupFactory IdolBaseDetailRewardListPopupFactory IdolBaseDetailRewardListPopupFactory Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<PIdolDetailPopupViewFactory>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.PIdolDetailPopupViewFactory.FromPointer); // 0270DB643150 0xA0 PIdolDetailPopupViewFactory ( 00018670A490 ModelClassType PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory Pointer )
            value.CostumeDetailPopupViewFactory             = GetObject<CostumeDetailPopupViewFactory>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.CostumeDetailPopupViewFactory.FromPointer); // 0270DB643170 0xA8 CostumeDetailPopupViewFactory ( 00018662BEB0 ModelClassType CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory Pointer )
            value.SCharaDetailPopupViewFactory              = GetObject<SCharaDetailPopupViewFactory>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.SCharaDetailPopupViewFactory.FromPointer); // 0270DB643190 0xB0 SCharaDetailPopupViewFactory ( 0001866A44F0 ModelClassType SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory Pointer )

            return value;
        }
    }
}
