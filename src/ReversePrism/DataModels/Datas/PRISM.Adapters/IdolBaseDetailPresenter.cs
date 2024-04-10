using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ReturnFromCasualCostumeTabIndex          int IL2CPP_TYPE_I4
    // 010 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 018 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 Argument                                 0001866A5B30 ModelClassType IdolBaseDetailArgument IdolBaseDetailArgument IdolBaseDetailArgument Pointer
    // 028 TitleView                                0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 030 UiCharacterView                          000186570A90 ModelClassType IIdolBaseDetailUICharacterView IIdolBaseDetailUICharacterView IIdolBaseDetailUICharacterView Pointer
    // 038 View                                     000186570FA0 ModelClassType IIdolBaseDetailView IIdolBaseDetailView IIdolBaseDetailView Pointer
    // 040 ProfileView                              00018656FDF0 ModelClassType IIdolBaseDetailProfileView IIdolBaseDetailProfileView IIdolBaseDetailProfileView Pointer
    // 048 StatusView                               000186570590 ModelClassType IIdolBaseDetailStatusView IIdolBaseDetailStatusView IIdolBaseDetailStatusView Pointer
    // 050 GalleryView                              00018656F8D0 ModelClassType IIdolBaseDetailGalleryView IIdolBaseDetailGalleryView IIdolBaseDetailGalleryView Pointer
    // 058 CasualCostumeView                        00018656F140 ModelClassType IIdolBaseDetailCasualCostumeView IIdolBaseDetailCasualCostumeView IIdolBaseDetailCasualCostumeView Pointer
    // 060 albumPopupViewFactory                    IPopupViewFactory`1<IAlbumPopupView> IL2CPP_TYPE_GENERICINST
    // 068 costumePopupViewFactory                  IPopupViewFactory`1<ICostumePopupView> IL2CPP_TYPE_GENERICINST
    // 070 voicePopupViewFactory                    IPopupViewFactory`1<IVoicePopupView> IL2CPP_TYPE_GENERICINST
    // 078 voicePlayTabListPopupViewFactory         IPopupViewFactory`1<IVoicePlayTabListPopupView> IL2CPP_TYPE_GENERICINST
    // 080 voicePlayListPopupViewFactory            IPopupViewFactory`1<IVoicePlayListPopupView> IL2CPP_TYPE_GENERICINST
    // 088 moviePopupViewFactory                    IPopupViewFactory`1<IMoviePopupView> IL2CPP_TYPE_GENERICINST
    // 090 etceteraPopupViewFactory                 IPopupViewFactory`1<IEtceteraPopupView> IL2CPP_TYPE_GENERICINST
    // 098 fullSizeImageOverlayViewFactory          IOverlayViewFactory`1<IFullSizeImageOverlayView> IL2CPP_TYPE_GENERICINST
    // 0A0 rewardListPopupViewFactory               IPopupViewFactory`1<IIdolBaseDetailRewardListPopupView> IL2CPP_TYPE_GENERICINST
    // 0A8 PIdolDetailPopupViewFactory              0001865D0010 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer
    // 0B0 costumeDetailPopupViewFactory            IPopupViewFactory`1<ICostumeDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 0B8 SCharaDetailPopupViewFactory             000186622C10 ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer
    // 0C0 ViewModel                                0001866AB5A0 ModelClassType IdolBaseDetailViewModel IdolBaseDetailViewModel IdolBaseDetailViewModel Pointer
    // 0C8 ProfileViewModel                         0001866A8760 ModelClassType IdolBaseDetailProfileViewModel IdolBaseDetailProfileViewModel IdolBaseDetailProfileViewModel Pointer
    // 0D0 StatusViewModel                          0001866AA4C0 ModelClassType IdolBaseDetailStatusViewModel IdolBaseDetailStatusViewModel IdolBaseDetailStatusViewModel Pointer
    // 0D8 GalleryViewModel                         0001866A73D0 ModelClassType IdolBaseDetailGalleryViewModel IdolBaseDetailGalleryViewModel IdolBaseDetailGalleryViewModel Pointer
    // 0E0 CasualCostumeViewModel                   0001866A6740 ModelClassType IdolBaseDetailCasualCostumeViewModel IdolBaseDetailCasualCostumeViewModel IdolBaseDetailCasualCostumeViewModel Pointer
    // 0E8 dataPackage                              SavableJsonObject`1<IdolBaseDetailPermanentData> IL2CPP_TYPE_GENERICINST
    // 0F0 AlbumPopupViewModel                      0001866A02C0 ModelClassType AlbumViewModel AlbumViewModel AlbumViewModel Pointer
    // 0F8 CostumePopupViewModel                    00018662F240 ModelClassType CostumePopupViewModel CostumePopupViewModel CostumePopupViewModel Pointer
    // 100 VoicePopupViewModel                      000186539100 ModelClassType VoicePopupViewModel VoicePopupViewModel VoicePopupViewModel Pointer
    // 108 VoicePlayTabListPopupViewModel           000186537C90 ModelClassType VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel Pointer
    // 110 CasualCostumeVoicePlayListViewModel      000185CE17D8 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
    // 118 pIdolVoicePlayListViewModel              Dictionary`2<int, List`1<ICategoryElementGridCellViewModel>> IL2CPP_TYPE_GENERICINST
    // 120 sCharaVoicePlayListViewModel             Dictionary`2<int, List`1<ICategoryElementGridCellViewModel>> IL2CPP_TYPE_GENERICINST
    // 128 MoviePopupViewModel                      00018665B410 ModelClassType MoviePopupViewModel MoviePopupViewModel MoviePopupViewModel Pointer
    // 130 EtceteraPopupViewModel                   00018674A520 ModelClassType EtceteraPopupViewModel EtceteraPopupViewModel EtceteraPopupViewModel Pointer
    // 138 IdolBase                                 000186572300 ModelClassType IIdolBaseStatus IIdolBaseStatus IIdolBaseStatus Pointer
    // 140 InitializeCts                            0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 148 AdditionalLoadedCueSheets                000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class IdolBaseDetailPresenter : DataModel
    {
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public IdolBaseDetailArgument?                  Argument                                { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public IIdolBaseDetailUICharacterView?          UiCharacterView                         { get; set; }
        public IIdolBaseDetailView?                     View                                    { get; set; }
        public IIdolBaseDetailProfileView?              ProfileView                             { get; set; }
        public IIdolBaseDetailStatusView?               StatusView                              { get; set; }
        public IIdolBaseDetailGalleryView?              GalleryView                             { get; set; }
        public IIdolBaseDetailCasualCostumeView?        CasualCostumeView                       { get; set; }
        public IPIdolDetailPopupViewFactory?            PIdolDetailPopupViewFactory             { get; set; }
        public ISCharaDetailPopupViewFactory?           SCharaDetailPopupViewFactory            { get; set; }
        public IdolBaseDetailViewModel?                 ViewModel                               { get; set; }
        public IdolBaseDetailProfileViewModel?          ProfileViewModel                        { get; set; }
        public IdolBaseDetailStatusViewModel?           StatusViewModel                         { get; set; }
        public IdolBaseDetailGalleryViewModel?          GalleryViewModel                        { get; set; }
        public IdolBaseDetailCasualCostumeViewModel?    CasualCostumeViewModel                  { get; set; }
        public AlbumViewModel?                          AlbumPopupViewModel                     { get; set; }
        public CostumePopupViewModel?                   CostumePopupViewModel                   { get; set; }
        public VoicePopupViewModel?                     VoicePopupViewModel                     { get; set; }
        public VoicePlayTabListPopupViewModel?          VoicePlayTabListPopupViewModel          { get; set; }
        public List<ICategoryElementGridCellViewModel>? CasualCostumeVoicePlayListViewModel     { get; set; }
        public MoviePopupViewModel?                     MoviePopupViewModel                     { get; set; }
        public EtceteraPopupViewModel?                  EtceteraPopupViewModel                  { get; set; }
        public IIdolBaseStatus?                         IdolBase                                { get; set; }
        public CancellationTokenSource?                 InitializeCts                           { get; set; }
        public List<string>?                            AdditionalLoadedCueSheets               { get; set; }

        public static IdolBaseDetailPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailPresenter() { Pointer= p0 };

            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024665F18060 0x10 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024665F18080 0x18 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Argument                                  = GetObject<IdolBaseDetailArgument>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolBaseDetailArgument.FromPointer); // 024665F180A0 0x20 Argument                    ( 0001866A5B30 ModelClassType IdolBaseDetailArgument IdolBaseDetailArgument IdolBaseDetailArgument Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 024665F180C0 0x28 TitleView                   ( 0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.UiCharacterView                           = GetObject<IIdolBaseDetailUICharacterView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IIdolBaseDetailUICharacterView.FromPointer); // 024665F180E0 0x30 UiCharacterView             ( 000186570A90 ModelClassType IIdolBaseDetailUICharacterView IIdolBaseDetailUICharacterView IIdolBaseDetailUICharacterView Pointer )
            value.View                                      = GetObject<IIdolBaseDetailView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolBaseDetailView.FromPointer); // 024665F18100 0x38 View                        ( 000186570FA0 ModelClassType IIdolBaseDetailView IIdolBaseDetailView IIdolBaseDetailView Pointer )
            value.ProfileView                               = GetObject<IIdolBaseDetailProfileView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IIdolBaseDetailProfileView.FromPointer); // 024665F18120 0x40 ProfileView                 ( 00018656FDF0 ModelClassType IIdolBaseDetailProfileView IIdolBaseDetailProfileView IIdolBaseDetailProfileView Pointer )
            value.StatusView                                = GetObject<IIdolBaseDetailStatusView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IIdolBaseDetailStatusView.FromPointer); // 024665F18140 0x48 StatusView                  ( 000186570590 ModelClassType IIdolBaseDetailStatusView IIdolBaseDetailStatusView IIdolBaseDetailStatusView Pointer )
            value.GalleryView                               = GetObject<IIdolBaseDetailGalleryView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IIdolBaseDetailGalleryView.FromPointer); // 024665F18160 0x50 GalleryView                 ( 00018656F8D0 ModelClassType IIdolBaseDetailGalleryView IIdolBaseDetailGalleryView IIdolBaseDetailGalleryView Pointer )
            value.CasualCostumeView                         = GetObject<IIdolBaseDetailCasualCostumeView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IIdolBaseDetailCasualCostumeView.FromPointer); // 024665F18180 0x58 CasualCostumeView           ( 00018656F140 ModelClassType IIdolBaseDetailCasualCostumeView IIdolBaseDetailCasualCostumeView IIdolBaseDetailCasualCostumeView Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<IPIdolDetailPopupViewFactory>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IPIdolDetailPopupViewFactory.FromPointer); // 024665F182C0 0xA8 PIdolDetailPopupViewFactory ( 0001865D0010 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer )
            value.SCharaDetailPopupViewFactory              = GetObject<ISCharaDetailPopupViewFactory>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ISCharaDetailPopupViewFactory.FromPointer); // 024665F18300 0xB8 SCharaDetailPopupViewFactory ( 000186622C10 ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer )
            value.ViewModel                                 = GetObject<IdolBaseDetailViewModel>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IdolBaseDetailViewModel.FromPointer); // 024665F18320 0xC0 ViewModel                   ( 0001866AB5A0 ModelClassType IdolBaseDetailViewModel IdolBaseDetailViewModel IdolBaseDetailViewModel Pointer )
            value.ProfileViewModel                          = GetObject<IdolBaseDetailProfileViewModel>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IdolBaseDetailProfileViewModel.FromPointer); // 024665F18340 0xC8 ProfileViewModel            ( 0001866A8760 ModelClassType IdolBaseDetailProfileViewModel IdolBaseDetailProfileViewModel IdolBaseDetailProfileViewModel Pointer )
            value.StatusViewModel                           = GetObject<IdolBaseDetailStatusViewModel>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IdolBaseDetailStatusViewModel.FromPointer); // 024665F18360 0xD0 StatusViewModel             ( 0001866AA4C0 ModelClassType IdolBaseDetailStatusViewModel IdolBaseDetailStatusViewModel IdolBaseDetailStatusViewModel Pointer )
            value.GalleryViewModel                          = GetObject<IdolBaseDetailGalleryViewModel>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IdolBaseDetailGalleryViewModel.FromPointer); // 024665F18380 0xD8 GalleryViewModel            ( 0001866A73D0 ModelClassType IdolBaseDetailGalleryViewModel IdolBaseDetailGalleryViewModel IdolBaseDetailGalleryViewModel Pointer )
            value.CasualCostumeViewModel                    = GetObject<IdolBaseDetailCasualCostumeViewModel>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.IdolBaseDetailCasualCostumeViewModel.FromPointer); // 024665F183A0 0xE0 CasualCostumeViewModel      ( 0001866A6740 ModelClassType IdolBaseDetailCasualCostumeViewModel IdolBaseDetailCasualCostumeViewModel IdolBaseDetailCasualCostumeViewModel Pointer )
            value.AlbumPopupViewModel                       = GetObject<AlbumViewModel>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.AlbumViewModel.FromPointer); // 024665F183E0 0xF0 AlbumPopupViewModel         ( 0001866A02C0 ModelClassType AlbumViewModel AlbumViewModel AlbumViewModel Pointer )
            value.CostumePopupViewModel                     = GetObject<CostumePopupViewModel>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.CostumePopupViewModel.FromPointer); // 024665F18400 0xF8 CostumePopupViewModel       ( 00018662F240 ModelClassType CostumePopupViewModel CostumePopupViewModel CostumePopupViewModel Pointer )
            value.VoicePopupViewModel                       = GetObject<VoicePopupViewModel>(new IntPtr(p + 0x100), ReversePrism.DataModels.VoicePopupViewModel.FromPointer); // 024665F18420 0x100 VoicePopupViewModel         ( 000186539100 ModelClassType VoicePopupViewModel VoicePopupViewModel VoicePopupViewModel Pointer )
            value.VoicePlayTabListPopupViewModel            = GetObject<VoicePlayTabListPopupViewModel>(new IntPtr(p + 0x108), ReversePrism.DataModels.VoicePlayTabListPopupViewModel.FromPointer); // 024665F18440 0x108 VoicePlayTabListPopupViewModel ( 000186537C90 ModelClassType VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel Pointer )
            value.CasualCostumeVoicePlayListViewModel       = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x110), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 024665F18460 0x110 CasualCostumeVoicePlayListViewModel ( 000185CE17D8 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )
            value.MoviePopupViewModel                       = GetObject<MoviePopupViewModel>(new IntPtr(p + 0x128), ReversePrism.DataModels.MoviePopupViewModel.FromPointer); // 024665F184C0 0x128 MoviePopupViewModel         ( 00018665B410 ModelClassType MoviePopupViewModel MoviePopupViewModel MoviePopupViewModel Pointer )
            value.EtceteraPopupViewModel                    = GetObject<EtceteraPopupViewModel>(new IntPtr(p + 0x130), ReversePrism.DataModels.EtceteraPopupViewModel.FromPointer); // 024665F184E0 0x130 EtceteraPopupViewModel      ( 00018674A520 ModelClassType EtceteraPopupViewModel EtceteraPopupViewModel EtceteraPopupViewModel Pointer )
            value.IdolBase                                  = GetObject<IIdolBaseStatus>(new IntPtr(p + 0x138), ReversePrism.DataModels.IIdolBaseStatus.FromPointer); // 024665F18500 0x138 IdolBase                    ( 000186572300 ModelClassType IIdolBaseStatus IIdolBaseStatus IIdolBaseStatus Pointer )
            value.InitializeCts                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x140), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024665F18520 0x140 InitializeCts               ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.AdditionalLoadedCueSheets                 = GetStringList(new IntPtr(p + 0x148)); // 024665F18540 0x148 AdditionalLoadedCueSheets   ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
