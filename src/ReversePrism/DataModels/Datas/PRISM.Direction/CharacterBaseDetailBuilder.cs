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
    // 040 GalleryView                              0001866A6EB0 ModelClassType IdolBaseDetailGalleryView IdolBaseDetailGalleryView IdolBaseDetailGalleryView Pointer
    // 048 AlbumPopupViewFactory                    00018669F660 ModelClassType AlbumPopupViewFactory AlbumPopupViewFactory AlbumPopupViewFactory Pointer
    // 050 CostumePopupViewFactory                  00018662ED50 ModelClassType CostumePopupViewFactory CostumePopupViewFactory CostumePopupViewFactory Pointer
    // 058 VoicePopupViewFactory                    000186538BE0 ModelClassType VoicePopupViewFactory VoicePopupViewFactory VoicePopupViewFactory Pointer
    // 060 VoicePlayTabListPopupViewFactory         000186537780 ModelClassType VoicePlayTabListPopupViewFactory VoicePlayTabListPopupViewFactory VoicePlayTabListPopupViewFactory Pointer
    // 068 VoicePlayListPopupViewFactory            000186536120 ModelClassType VoicePlayListPopupViewFactory VoicePlayListPopupViewFactory VoicePlayListPopupViewFactory Pointer
    // 070 MoviePopupViewFactory                    00018665AEF0 ModelClassType MoviePopupViewFactory MoviePopupViewFactory MoviePopupViewFactory Pointer
    // 078 EtceteraPopupViewFactory                 00018674A050 ModelClassType EtceteraPopupViewFactory EtceteraPopupViewFactory EtceteraPopupViewFactory Pointer
    // 080 FullSizeImageOverlayViewFactory          0001865D3620 ModelClassType FullSizeImageOverlayViewFactory FullSizeImageOverlayViewFactory FullSizeImageOverlayViewFactory Pointer
    // 088 CostumeDetailPopupViewFactory            00018662BEB0 ModelClassType CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory Pointer
    // 090 SCharaDetailPopupViewFactory             0001866A44F0 ModelClassType SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory Pointer
    public partial class CharacterBaseDetailBuilder
    {
        public CommonTitleView?                         TitleView                               { get; set; }
        public IdolBaseDetailUICharacterView?           UiCharacterView                         { get; set; }
        public IdolBaseDetailView?                      View                                    { get; set; }
        public IdolBaseDetailProfileView?               ProfileView                             { get; set; }
        public IdolBaseDetailGalleryView?               GalleryView                             { get; set; }
        public AlbumPopupViewFactory?                   AlbumPopupViewFactory                   { get; set; }
        public CostumePopupViewFactory?                 CostumePopupViewFactory                 { get; set; }
        public VoicePopupViewFactory?                   VoicePopupViewFactory                   { get; set; }
        public VoicePlayTabListPopupViewFactory?        VoicePlayTabListPopupViewFactory        { get; set; }
        public VoicePlayListPopupViewFactory?           VoicePlayListPopupViewFactory           { get; set; }
        public MoviePopupViewFactory?                   MoviePopupViewFactory                   { get; set; }
        public EtceteraPopupViewFactory?                EtceteraPopupViewFactory                { get; set; }
        public FullSizeImageOverlayViewFactory?         FullSizeImageOverlayViewFactory         { get; set; }
        public CostumeDetailPopupViewFactory?           CostumeDetailPopupViewFactory           { get; set; }
        public SCharaDetailPopupViewFactory?            SCharaDetailPopupViewFactory            { get; set; }

        public static CharacterBaseDetailBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBaseDetailBuilder();

            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270DB625E38 0x20 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.UiCharacterView                           = GetObject<IdolBaseDetailUICharacterView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolBaseDetailUICharacterView.FromPointer); // 0270DB625E58 0x28 UiCharacterView             ( 0001866AA980 ModelClassType IdolBaseDetailUICharacterView IdolBaseDetailUICharacterView IdolBaseDetailUICharacterView Pointer )
            value.View                                      = GetObject<IdolBaseDetailView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IdolBaseDetailView.FromPointer); // 0270DB625E78 0x30 View                        ( 0001866AB0C0 ModelClassType IdolBaseDetailView IdolBaseDetailView IdolBaseDetailView Pointer )
            value.ProfileView                               = GetObject<IdolBaseDetailProfileView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolBaseDetailProfileView.FromPointer); // 0270DB625E98 0x38 ProfileView                 ( 0001866A8260 ModelClassType IdolBaseDetailProfileView IdolBaseDetailProfileView IdolBaseDetailProfileView Pointer )
            value.GalleryView                               = GetObject<IdolBaseDetailGalleryView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolBaseDetailGalleryView.FromPointer); // 0270DB625EB8 0x40 GalleryView                 ( 0001866A6EB0 ModelClassType IdolBaseDetailGalleryView IdolBaseDetailGalleryView IdolBaseDetailGalleryView Pointer )
            value.AlbumPopupViewFactory                     = GetObject<AlbumPopupViewFactory>(new IntPtr(p + 0x048), ReversePrism.DataModels.AlbumPopupViewFactory.FromPointer); // 0270DB625ED8 0x48 AlbumPopupViewFactory       ( 00018669F660 ModelClassType AlbumPopupViewFactory AlbumPopupViewFactory AlbumPopupViewFactory Pointer )
            value.CostumePopupViewFactory                   = GetObject<CostumePopupViewFactory>(new IntPtr(p + 0x050), ReversePrism.DataModels.CostumePopupViewFactory.FromPointer); // 0270DB625EF8 0x50 CostumePopupViewFactory     ( 00018662ED50 ModelClassType CostumePopupViewFactory CostumePopupViewFactory CostumePopupViewFactory Pointer )
            value.VoicePopupViewFactory                     = GetObject<VoicePopupViewFactory>(new IntPtr(p + 0x058), ReversePrism.DataModels.VoicePopupViewFactory.FromPointer); // 0270DB625F18 0x58 VoicePopupViewFactory       ( 000186538BE0 ModelClassType VoicePopupViewFactory VoicePopupViewFactory VoicePopupViewFactory Pointer )
            value.VoicePlayTabListPopupViewFactory          = GetObject<VoicePlayTabListPopupViewFactory>(new IntPtr(p + 0x060), ReversePrism.DataModels.VoicePlayTabListPopupViewFactory.FromPointer); // 0270DB625F38 0x60 VoicePlayTabListPopupViewFactory ( 000186537780 ModelClassType VoicePlayTabListPopupViewFactory VoicePlayTabListPopupViewFactory VoicePlayTabListPopupViewFactory Pointer )
            value.VoicePlayListPopupViewFactory             = GetObject<VoicePlayListPopupViewFactory>(new IntPtr(p + 0x068), ReversePrism.DataModels.VoicePlayListPopupViewFactory.FromPointer); // 0270DB625F58 0x68 VoicePlayListPopupViewFactory ( 000186536120 ModelClassType VoicePlayListPopupViewFactory VoicePlayListPopupViewFactory VoicePlayListPopupViewFactory Pointer )
            value.MoviePopupViewFactory                     = GetObject<MoviePopupViewFactory>(new IntPtr(p + 0x070), ReversePrism.DataModels.MoviePopupViewFactory.FromPointer); // 0270DB625F78 0x70 MoviePopupViewFactory       ( 00018665AEF0 ModelClassType MoviePopupViewFactory MoviePopupViewFactory MoviePopupViewFactory Pointer )
            value.EtceteraPopupViewFactory                  = GetObject<EtceteraPopupViewFactory>(new IntPtr(p + 0x078), ReversePrism.DataModels.EtceteraPopupViewFactory.FromPointer); // 0270DB625F98 0x78 EtceteraPopupViewFactory    ( 00018674A050 ModelClassType EtceteraPopupViewFactory EtceteraPopupViewFactory EtceteraPopupViewFactory Pointer )
            value.FullSizeImageOverlayViewFactory           = GetObject<FullSizeImageOverlayViewFactory>(new IntPtr(p + 0x080), ReversePrism.DataModels.FullSizeImageOverlayViewFactory.FromPointer); // 0270DB625FB8 0x80 FullSizeImageOverlayViewFactory ( 0001865D3620 ModelClassType FullSizeImageOverlayViewFactory FullSizeImageOverlayViewFactory FullSizeImageOverlayViewFactory Pointer )
            value.CostumeDetailPopupViewFactory             = GetObject<CostumeDetailPopupViewFactory>(new IntPtr(p + 0x088), ReversePrism.DataModels.CostumeDetailPopupViewFactory.FromPointer); // 0270DB625FD8 0x88 CostumeDetailPopupViewFactory ( 00018662BEB0 ModelClassType CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory Pointer )
            value.SCharaDetailPopupViewFactory              = GetObject<SCharaDetailPopupViewFactory>(new IntPtr(p + 0x090), ReversePrism.DataModels.SCharaDetailPopupViewFactory.FromPointer); // 0270DB625FF8 0x90 SCharaDetailPopupViewFactory ( 0001866A44F0 ModelClassType SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory Pointer )

            return value;
        }
    }
}
