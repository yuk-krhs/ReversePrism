using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ReturnFromCasualCostumeTabIndex          int IL2CPP_TYPE_I4
    // 010 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 018 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 Argument                                 ModelClassType IdolBaseDetailArgument IdolBaseDetailArgument IdolBaseDetailArgument Pointer
    // 028 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 030 UiCharacterView                          ModelClassType IIdolBaseDetailUICharacterView IIdolBaseDetailUICharacterView IIdolBaseDetailUICharacterView Pointer
    // 038 View                                     ModelClassType IIdolBaseDetailView IIdolBaseDetailView IIdolBaseDetailView Pointer
    // 040 ProfileView                              ModelClassType IIdolBaseDetailProfileView IIdolBaseDetailProfileView IIdolBaseDetailProfileView Pointer
    // 048 StatusView                               ModelClassType IIdolBaseDetailStatusView IIdolBaseDetailStatusView IIdolBaseDetailStatusView Pointer
    // 050 GalleryView                              ModelClassType IIdolBaseDetailGalleryView IIdolBaseDetailGalleryView IIdolBaseDetailGalleryView Pointer
    // 058 CasualCostumeView                        ModelClassType IIdolBaseDetailCasualCostumeView IIdolBaseDetailCasualCostumeView IIdolBaseDetailCasualCostumeView Pointer
    // 060 ViewModel                                ModelClassType IdolBaseDetailViewModel IdolBaseDetailViewModel IdolBaseDetailViewModel Pointer
    // 068 ProfileViewModel                         ModelClassType IdolBaseDetailProfileViewModel IdolBaseDetailProfileViewModel IdolBaseDetailProfileViewModel Pointer
    // 070 StatusViewModel                          ModelClassType IdolBaseDetailStatusViewModel IdolBaseDetailStatusViewModel IdolBaseDetailStatusViewModel Pointer
    // 078 GalleryViewModel                         ModelClassType IdolBaseDetailGalleryViewModel IdolBaseDetailGalleryViewModel IdolBaseDetailGalleryViewModel Pointer
    // 080 CasualCostumeViewModel                   ModelClassType IdolBaseDetailCasualCostumeViewModel IdolBaseDetailCasualCostumeViewModel IdolBaseDetailCasualCostumeViewModel Pointer
    // 088 dataPackage                              SavableJsonObject`1<IdolBaseDetailPermanentData> IL2CPP_TYPE_GENERICINST
    // 090 AlbumPopupViewModel                      ModelClassType AlbumViewModel AlbumViewModel AlbumViewModel Pointer
    // 098 CostumePopupViewModel                    ModelClassType CostumePopupViewModel CostumePopupViewModel CostumePopupViewModel Pointer
    // 0A0 VoicePopupViewModel                      ModelClassType VoicePopupViewModel VoicePopupViewModel VoicePopupViewModel Pointer
    // 0A8 VoicePlayTabListPopupViewModel           ModelClassType VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel Pointer
    // 0B0 CasualCostumeVoicePlayListViewModel      ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
    // 0B8 pIdolVoicePlayListViewModel              Dictionary`2<int, List`1<ICategoryElementGridCellViewModel>> IL2CPP_TYPE_GENERICINST
    // 0C0 sCharaVoicePlayListViewModel             Dictionary`2<int, List`1<ICategoryElementGridCellViewModel>> IL2CPP_TYPE_GENERICINST
    // 0C8 MoviePopupViewModel                      ModelClassType MoviePopupViewModel MoviePopupViewModel MoviePopupViewModel Pointer
    // 0D0 EtceteraPopupViewModel                   ModelClassType EtceteraPopupViewModel EtceteraPopupViewModel EtceteraPopupViewModel Pointer
    // 0D8 IdolBase                                 ModelClassType IIdolBaseStatus IIdolBaseStatus IIdolBaseStatus Pointer
    // 0E0 InitializeCts                            ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 0E8 AdditionalLoadedCueSheets                ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0F0 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
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
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static IdolBaseDetailPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailPresenter() { Pointer= p0 };

            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x10 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x18 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Argument                                  = GetObject<IdolBaseDetailArgument>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolBaseDetailArgument.FromPointer); // 0x20 Argument                    ( ModelClassType IdolBaseDetailArgument IdolBaseDetailArgument IdolBaseDetailArgument Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x28 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.UiCharacterView                           = GetObject<IIdolBaseDetailUICharacterView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IIdolBaseDetailUICharacterView.FromPointer); // 0x30 UiCharacterView             ( ModelClassType IIdolBaseDetailUICharacterView IIdolBaseDetailUICharacterView IIdolBaseDetailUICharacterView Pointer )
            value.View                                      = GetObject<IIdolBaseDetailView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolBaseDetailView.FromPointer); // 0x38 View                        ( ModelClassType IIdolBaseDetailView IIdolBaseDetailView IIdolBaseDetailView Pointer )
            value.ProfileView                               = GetObject<IIdolBaseDetailProfileView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IIdolBaseDetailProfileView.FromPointer); // 0x40 ProfileView                 ( ModelClassType IIdolBaseDetailProfileView IIdolBaseDetailProfileView IIdolBaseDetailProfileView Pointer )
            value.StatusView                                = GetObject<IIdolBaseDetailStatusView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IIdolBaseDetailStatusView.FromPointer); // 0x48 StatusView                  ( ModelClassType IIdolBaseDetailStatusView IIdolBaseDetailStatusView IIdolBaseDetailStatusView Pointer )
            value.GalleryView                               = GetObject<IIdolBaseDetailGalleryView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IIdolBaseDetailGalleryView.FromPointer); // 0x50 GalleryView                 ( ModelClassType IIdolBaseDetailGalleryView IIdolBaseDetailGalleryView IIdolBaseDetailGalleryView Pointer )
            value.CasualCostumeView                         = GetObject<IIdolBaseDetailCasualCostumeView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IIdolBaseDetailCasualCostumeView.FromPointer); // 0x58 CasualCostumeView           ( ModelClassType IIdolBaseDetailCasualCostumeView IIdolBaseDetailCasualCostumeView IIdolBaseDetailCasualCostumeView Pointer )
            value.ViewModel                                 = GetObject<IdolBaseDetailViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.IdolBaseDetailViewModel.FromPointer); // 0x60 ViewModel                   ( ModelClassType IdolBaseDetailViewModel IdolBaseDetailViewModel IdolBaseDetailViewModel Pointer )
            value.ProfileViewModel                          = GetObject<IdolBaseDetailProfileViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.IdolBaseDetailProfileViewModel.FromPointer); // 0x68 ProfileViewModel            ( ModelClassType IdolBaseDetailProfileViewModel IdolBaseDetailProfileViewModel IdolBaseDetailProfileViewModel Pointer )
            value.StatusViewModel                           = GetObject<IdolBaseDetailStatusViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.IdolBaseDetailStatusViewModel.FromPointer); // 0x70 StatusViewModel             ( ModelClassType IdolBaseDetailStatusViewModel IdolBaseDetailStatusViewModel IdolBaseDetailStatusViewModel Pointer )
            value.GalleryViewModel                          = GetObject<IdolBaseDetailGalleryViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.IdolBaseDetailGalleryViewModel.FromPointer); // 0x78 GalleryViewModel            ( ModelClassType IdolBaseDetailGalleryViewModel IdolBaseDetailGalleryViewModel IdolBaseDetailGalleryViewModel Pointer )
            value.CasualCostumeViewModel                    = GetObject<IdolBaseDetailCasualCostumeViewModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.IdolBaseDetailCasualCostumeViewModel.FromPointer); // 0x80 CasualCostumeViewModel      ( ModelClassType IdolBaseDetailCasualCostumeViewModel IdolBaseDetailCasualCostumeViewModel IdolBaseDetailCasualCostumeViewModel Pointer )
            value.AlbumPopupViewModel                       = GetObject<AlbumViewModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.AlbumViewModel.FromPointer); // 0x90 AlbumPopupViewModel         ( ModelClassType AlbumViewModel AlbumViewModel AlbumViewModel Pointer )
            value.CostumePopupViewModel                     = GetObject<CostumePopupViewModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.CostumePopupViewModel.FromPointer); // 0x98 CostumePopupViewModel       ( ModelClassType CostumePopupViewModel CostumePopupViewModel CostumePopupViewModel Pointer )
            value.VoicePopupViewModel                       = GetObject<VoicePopupViewModel>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.VoicePopupViewModel.FromPointer); // 0xA0 VoicePopupViewModel         ( ModelClassType VoicePopupViewModel VoicePopupViewModel VoicePopupViewModel Pointer )
            value.VoicePlayTabListPopupViewModel            = GetObject<VoicePlayTabListPopupViewModel>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.VoicePlayTabListPopupViewModel.FromPointer); // 0xA8 VoicePlayTabListPopupViewModel ( ModelClassType VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel Pointer )
            value.CasualCostumeVoicePlayListViewModel       = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 0xB0 CasualCostumeVoicePlayListViewModel ( ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )
            value.MoviePopupViewModel                       = GetObject<MoviePopupViewModel>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.MoviePopupViewModel.FromPointer); // 0xC8 MoviePopupViewModel         ( ModelClassType MoviePopupViewModel MoviePopupViewModel MoviePopupViewModel Pointer )
            value.EtceteraPopupViewModel                    = GetObject<EtceteraPopupViewModel>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.EtceteraPopupViewModel.FromPointer); // 0xD0 EtceteraPopupViewModel      ( ModelClassType EtceteraPopupViewModel EtceteraPopupViewModel EtceteraPopupViewModel Pointer )
            value.IdolBase                                  = GetObject<IIdolBaseStatus>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IIdolBaseStatus.FromPointer); // 0xD8 IdolBase                    ( ModelClassType IIdolBaseStatus IIdolBaseStatus IIdolBaseStatus Pointer )
            value.InitializeCts                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0xE0 InitializeCts               ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.AdditionalLoadedCueSheets                 = GetStringList(new IntPtr(p + 0x0E8)); // 0xE8 AdditionalLoadedCueSheets   ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0xF0 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
