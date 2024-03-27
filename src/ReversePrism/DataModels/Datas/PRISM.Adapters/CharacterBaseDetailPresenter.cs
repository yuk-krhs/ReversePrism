using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 018 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 Argument                                 000186598110 ModelClassType CharacterBaseDetailArgument CharacterBaseDetailArgument CharacterBaseDetailArgument Pointer
    // 028 TitleView                                0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 030 UiCharacterView                          000186570A90 ModelClassType IIdolBaseDetailUICharacterView IIdolBaseDetailUICharacterView IIdolBaseDetailUICharacterView Pointer
    // 038 View                                     000186570FA0 ModelClassType IIdolBaseDetailView IIdolBaseDetailView IIdolBaseDetailView Pointer
    // 040 ProfileView                              00018656FDF0 ModelClassType IIdolBaseDetailProfileView IIdolBaseDetailProfileView IIdolBaseDetailProfileView Pointer
    // 048 GalleryView                              00018656F8D0 ModelClassType IIdolBaseDetailGalleryView IIdolBaseDetailGalleryView IIdolBaseDetailGalleryView Pointer
    // 050 albumPopupViewFactory                    IPopupViewFactory`1<IAlbumPopupView> IL2CPP_TYPE_GENERICINST
    // 058 costumePopupViewFactory                  IPopupViewFactory`1<ICostumePopupView> IL2CPP_TYPE_GENERICINST
    // 060 voicePopupViewFactory                    IPopupViewFactory`1<IVoicePopupView> IL2CPP_TYPE_GENERICINST
    // 068 voicePlayTabListPopupViewFactory         IPopupViewFactory`1<IVoicePlayTabListPopupView> IL2CPP_TYPE_GENERICINST
    // 070 voicePlayListPopupViewFactory            IPopupViewFactory`1<IVoicePlayListPopupView> IL2CPP_TYPE_GENERICINST
    // 078 moviePopupViewFactory                    IPopupViewFactory`1<IMoviePopupView> IL2CPP_TYPE_GENERICINST
    // 080 etceteraPopupViewFactory                 IPopupViewFactory`1<IEtceteraPopupView> IL2CPP_TYPE_GENERICINST
    // 088 fullSizeImageOverlayViewFactory          IOverlayViewFactory`1<IFullSizeImageOverlayView> IL2CPP_TYPE_GENERICINST
    // 090 costumeDetailPopupViewFactory            IPopupViewFactory`1<ICostumeDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 098 SCharaDetailPopupViewFactory             000186622C10 ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer
    // 0A0 ViewModel                                0001866AB5A0 ModelClassType IdolBaseDetailViewModel IdolBaseDetailViewModel IdolBaseDetailViewModel Pointer
    // 0A8 ProfileViewModel                         0001866A8760 ModelClassType IdolBaseDetailProfileViewModel IdolBaseDetailProfileViewModel IdolBaseDetailProfileViewModel Pointer
    // 0B0 GalleryViewModel                         0001866A73D0 ModelClassType IdolBaseDetailGalleryViewModel IdolBaseDetailGalleryViewModel IdolBaseDetailGalleryViewModel Pointer
    // 0B8 AlbumPopupViewModel                      0001866A02C0 ModelClassType AlbumViewModel AlbumViewModel AlbumViewModel Pointer
    // 0C0 CostumePopupViewModel                    00018662F240 ModelClassType CostumePopupViewModel CostumePopupViewModel CostumePopupViewModel Pointer
    // 0C8 VoicePopupViewModel                      000186539100 ModelClassType VoicePopupViewModel VoicePopupViewModel VoicePopupViewModel Pointer
    // 0D0 VoicePlayTabListPopupViewModel           000186537C90 ModelClassType VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel Pointer
    // 0D8 CasualCostumeVoicePlayListViewModel      000185CE17D8 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
    // 0E0 MoviePopupViewModel                      00018665B410 ModelClassType MoviePopupViewModel MoviePopupViewModel MoviePopupViewModel Pointer
    // 0E8 EtceteraPopupViewModel                   00018674A520 ModelClassType EtceteraPopupViewModel EtceteraPopupViewModel EtceteraPopupViewModel Pointer
    // 0F0 sCharaVoicePlayListViewModel             Dictionary`2<int, List`1<ICategoryElementGridCellViewModel>> IL2CPP_TYPE_GENERICINST
    // 0F8 MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 100 InitializeCts                            0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 108 AdditionalLoadedCueSheets                000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class CharacterBaseDetailPresenter
    {
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CharacterBaseDetailArgument?             Argument                                { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public IIdolBaseDetailUICharacterView?          UiCharacterView                         { get; set; }
        public IIdolBaseDetailView?                     View                                    { get; set; }
        public IIdolBaseDetailProfileView?              ProfileView                             { get; set; }
        public IIdolBaseDetailGalleryView?              GalleryView                             { get; set; }
        public ISCharaDetailPopupViewFactory?           SCharaDetailPopupViewFactory            { get; set; }
        public IdolBaseDetailViewModel?                 ViewModel                               { get; set; }
        public IdolBaseDetailProfileViewModel?          ProfileViewModel                        { get; set; }
        public IdolBaseDetailGalleryViewModel?          GalleryViewModel                        { get; set; }
        public AlbumViewModel?                          AlbumPopupViewModel                     { get; set; }
        public CostumePopupViewModel?                   CostumePopupViewModel                   { get; set; }
        public VoicePopupViewModel?                     VoicePopupViewModel                     { get; set; }
        public VoicePlayTabListPopupViewModel?          VoicePlayTabListPopupViewModel          { get; set; }
        public List<ICategoryElementGridCellViewModel>? CasualCostumeVoicePlayListViewModel     { get; set; }
        public MoviePopupViewModel?                     MoviePopupViewModel                     { get; set; }
        public EtceteraPopupViewModel?                  EtceteraPopupViewModel                  { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public CancellationTokenSource?                 InitializeCts                           { get; set; }
        public List<string>?                            AdditionalLoadedCueSheets               { get; set; }

        public static CharacterBaseDetailPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBaseDetailPresenter();

            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5E6BC10 0x10 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D5E6BC30 0x18 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Argument                                  = GetObject<CharacterBaseDetailArgument>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterBaseDetailArgument.FromPointer); // 0270D5E6BC50 0x20 Argument                    ( 000186598110 ModelClassType CharacterBaseDetailArgument CharacterBaseDetailArgument CharacterBaseDetailArgument Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270D5E6BC70 0x28 TitleView                   ( 0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.UiCharacterView                           = GetObject<IIdolBaseDetailUICharacterView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IIdolBaseDetailUICharacterView.FromPointer); // 0270D5E6BC90 0x30 UiCharacterView             ( 000186570A90 ModelClassType IIdolBaseDetailUICharacterView IIdolBaseDetailUICharacterView IIdolBaseDetailUICharacterView Pointer )
            value.View                                      = GetObject<IIdolBaseDetailView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolBaseDetailView.FromPointer); // 0270D5E6BCB0 0x38 View                        ( 000186570FA0 ModelClassType IIdolBaseDetailView IIdolBaseDetailView IIdolBaseDetailView Pointer )
            value.ProfileView                               = GetObject<IIdolBaseDetailProfileView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IIdolBaseDetailProfileView.FromPointer); // 0270D5E6BCD0 0x40 ProfileView                 ( 00018656FDF0 ModelClassType IIdolBaseDetailProfileView IIdolBaseDetailProfileView IIdolBaseDetailProfileView Pointer )
            value.GalleryView                               = GetObject<IIdolBaseDetailGalleryView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IIdolBaseDetailGalleryView.FromPointer); // 0270D5E6BCF0 0x48 GalleryView                 ( 00018656F8D0 ModelClassType IIdolBaseDetailGalleryView IIdolBaseDetailGalleryView IIdolBaseDetailGalleryView Pointer )
            value.SCharaDetailPopupViewFactory              = GetObject<ISCharaDetailPopupViewFactory>(new IntPtr(p + 0x098), ReversePrism.DataModels.ISCharaDetailPopupViewFactory.FromPointer); // 0270D5E6BE30 0x98 SCharaDetailPopupViewFactory ( 000186622C10 ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer )
            value.ViewModel                                 = GetObject<IdolBaseDetailViewModel>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IdolBaseDetailViewModel.FromPointer); // 0270D5E6BE50 0xA0 ViewModel                   ( 0001866AB5A0 ModelClassType IdolBaseDetailViewModel IdolBaseDetailViewModel IdolBaseDetailViewModel Pointer )
            value.ProfileViewModel                          = GetObject<IdolBaseDetailProfileViewModel>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IdolBaseDetailProfileViewModel.FromPointer); // 0270D5E6BE70 0xA8 ProfileViewModel            ( 0001866A8760 ModelClassType IdolBaseDetailProfileViewModel IdolBaseDetailProfileViewModel IdolBaseDetailProfileViewModel Pointer )
            value.GalleryViewModel                          = GetObject<IdolBaseDetailGalleryViewModel>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IdolBaseDetailGalleryViewModel.FromPointer); // 0270D5E6BE90 0xB0 GalleryViewModel            ( 0001866A73D0 ModelClassType IdolBaseDetailGalleryViewModel IdolBaseDetailGalleryViewModel IdolBaseDetailGalleryViewModel Pointer )
            value.AlbumPopupViewModel                       = GetObject<AlbumViewModel>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.AlbumViewModel.FromPointer); // 0270D5E6BEB0 0xB8 AlbumPopupViewModel         ( 0001866A02C0 ModelClassType AlbumViewModel AlbumViewModel AlbumViewModel Pointer )
            value.CostumePopupViewModel                     = GetObject<CostumePopupViewModel>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.CostumePopupViewModel.FromPointer); // 0270D5E6BED0 0xC0 CostumePopupViewModel       ( 00018662F240 ModelClassType CostumePopupViewModel CostumePopupViewModel CostumePopupViewModel Pointer )
            value.VoicePopupViewModel                       = GetObject<VoicePopupViewModel>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.VoicePopupViewModel.FromPointer); // 0270D5E6BEF0 0xC8 VoicePopupViewModel         ( 000186539100 ModelClassType VoicePopupViewModel VoicePopupViewModel VoicePopupViewModel Pointer )
            value.VoicePlayTabListPopupViewModel            = GetObject<VoicePlayTabListPopupViewModel>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.VoicePlayTabListPopupViewModel.FromPointer); // 0270D5E6BF10 0xD0 VoicePlayTabListPopupViewModel ( 000186537C90 ModelClassType VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel Pointer )
            value.CasualCostumeVoicePlayListViewModel       = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 0270D5E6BF30 0xD8 CasualCostumeVoicePlayListViewModel ( 000185CE17D8 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )
            value.MoviePopupViewModel                       = GetObject<MoviePopupViewModel>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.MoviePopupViewModel.FromPointer); // 0270D5E6BF50 0xE0 MoviePopupViewModel         ( 00018665B410 ModelClassType MoviePopupViewModel MoviePopupViewModel MoviePopupViewModel Pointer )
            value.EtceteraPopupViewModel                    = GetObject<EtceteraPopupViewModel>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.EtceteraPopupViewModel.FromPointer); // 0270D5E6BF70 0xE8 EtceteraPopupViewModel      ( 00018674A520 ModelClassType EtceteraPopupViewModel EtceteraPopupViewModel EtceteraPopupViewModel Pointer )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x0F8)); // 0270D5E6BFB0 0xF8 MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InitializeCts                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x100), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5E6BFD0 0x100 InitializeCts               ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.AdditionalLoadedCueSheets                 = GetStringList(new IntPtr(p + 0x108)); // 0270D5E6BFF0 0x108 AdditionalLoadedCueSheets   ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
