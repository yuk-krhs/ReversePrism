using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 018 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 Argument                                 ModelClassType CharacterBaseDetailArgument CharacterBaseDetailArgument CharacterBaseDetailArgument Pointer
    // 028 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 030 UiCharacterView                          ModelClassType IIdolBaseDetailUICharacterView IIdolBaseDetailUICharacterView IIdolBaseDetailUICharacterView Pointer
    // 038 View                                     ModelClassType IIdolBaseDetailView IIdolBaseDetailView IIdolBaseDetailView Pointer
    // 040 ProfileView                              ModelClassType IIdolBaseDetailProfileView IIdolBaseDetailProfileView IIdolBaseDetailProfileView Pointer
    // 048 GalleryView                              ModelClassType IIdolBaseDetailGalleryView IIdolBaseDetailGalleryView IIdolBaseDetailGalleryView Pointer
    // 050 ViewModel                                ModelClassType IdolBaseDetailViewModel IdolBaseDetailViewModel IdolBaseDetailViewModel Pointer
    // 058 ProfileViewModel                         ModelClassType IdolBaseDetailProfileViewModel IdolBaseDetailProfileViewModel IdolBaseDetailProfileViewModel Pointer
    // 060 GalleryViewModel                         ModelClassType IdolBaseDetailGalleryViewModel IdolBaseDetailGalleryViewModel IdolBaseDetailGalleryViewModel Pointer
    // 068 AlbumPopupViewModel                      ModelClassType AlbumViewModel AlbumViewModel AlbumViewModel Pointer
    // 070 CostumePopupViewModel                    ModelClassType CostumePopupViewModel CostumePopupViewModel CostumePopupViewModel Pointer
    // 078 VoicePopupViewModel                      ModelClassType VoicePopupViewModel VoicePopupViewModel VoicePopupViewModel Pointer
    // 080 VoicePlayTabListPopupViewModel           ModelClassType VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel Pointer
    // 088 CasualCostumeVoicePlayListViewModel      ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
    // 090 MoviePopupViewModel                      ModelClassType MoviePopupViewModel MoviePopupViewModel MoviePopupViewModel Pointer
    // 098 EtceteraPopupViewModel                   ModelClassType EtceteraPopupViewModel EtceteraPopupViewModel EtceteraPopupViewModel Pointer
    // 0A0 sCharaVoicePlayListViewModel             Dictionary`2<int, List`1<ICategoryElementGridCellViewModel>> IL2CPP_TYPE_GENERICINST
    // 0A8 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 0B0 InitializeCts                            ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 0B8 AdditionalLoadedCueSheets                ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0C0 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class CharacterBaseDetailPresenter : DataModel
    {
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CharacterBaseDetailArgument?             Argument                                { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public IIdolBaseDetailUICharacterView?          UiCharacterView                         { get; set; }
        public IIdolBaseDetailView?                     View                                    { get; set; }
        public IIdolBaseDetailProfileView?              ProfileView                             { get; set; }
        public IIdolBaseDetailGalleryView?              GalleryView                             { get; set; }
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
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static CharacterBaseDetailPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBaseDetailPresenter() { Pointer= p0 };

            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x10 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x18 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Argument                                  = GetObject<CharacterBaseDetailArgument>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterBaseDetailArgument.FromPointer); // 0x20 Argument                    ( ModelClassType CharacterBaseDetailArgument CharacterBaseDetailArgument CharacterBaseDetailArgument Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x28 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.UiCharacterView                           = GetObject<IIdolBaseDetailUICharacterView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IIdolBaseDetailUICharacterView.FromPointer); // 0x30 UiCharacterView             ( ModelClassType IIdolBaseDetailUICharacterView IIdolBaseDetailUICharacterView IIdolBaseDetailUICharacterView Pointer )
            value.View                                      = GetObject<IIdolBaseDetailView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolBaseDetailView.FromPointer); // 0x38 View                        ( ModelClassType IIdolBaseDetailView IIdolBaseDetailView IIdolBaseDetailView Pointer )
            value.ProfileView                               = GetObject<IIdolBaseDetailProfileView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IIdolBaseDetailProfileView.FromPointer); // 0x40 ProfileView                 ( ModelClassType IIdolBaseDetailProfileView IIdolBaseDetailProfileView IIdolBaseDetailProfileView Pointer )
            value.GalleryView                               = GetObject<IIdolBaseDetailGalleryView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IIdolBaseDetailGalleryView.FromPointer); // 0x48 GalleryView                 ( ModelClassType IIdolBaseDetailGalleryView IIdolBaseDetailGalleryView IIdolBaseDetailGalleryView Pointer )
            value.ViewModel                                 = GetObject<IdolBaseDetailViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.IdolBaseDetailViewModel.FromPointer); // 0x50 ViewModel                   ( ModelClassType IdolBaseDetailViewModel IdolBaseDetailViewModel IdolBaseDetailViewModel Pointer )
            value.ProfileViewModel                          = GetObject<IdolBaseDetailProfileViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.IdolBaseDetailProfileViewModel.FromPointer); // 0x58 ProfileViewModel            ( ModelClassType IdolBaseDetailProfileViewModel IdolBaseDetailProfileViewModel IdolBaseDetailProfileViewModel Pointer )
            value.GalleryViewModel                          = GetObject<IdolBaseDetailGalleryViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.IdolBaseDetailGalleryViewModel.FromPointer); // 0x60 GalleryViewModel            ( ModelClassType IdolBaseDetailGalleryViewModel IdolBaseDetailGalleryViewModel IdolBaseDetailGalleryViewModel Pointer )
            value.AlbumPopupViewModel                       = GetObject<AlbumViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.AlbumViewModel.FromPointer); // 0x68 AlbumPopupViewModel         ( ModelClassType AlbumViewModel AlbumViewModel AlbumViewModel Pointer )
            value.CostumePopupViewModel                     = GetObject<CostumePopupViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.CostumePopupViewModel.FromPointer); // 0x70 CostumePopupViewModel       ( ModelClassType CostumePopupViewModel CostumePopupViewModel CostumePopupViewModel Pointer )
            value.VoicePopupViewModel                       = GetObject<VoicePopupViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.VoicePopupViewModel.FromPointer); // 0x78 VoicePopupViewModel         ( ModelClassType VoicePopupViewModel VoicePopupViewModel VoicePopupViewModel Pointer )
            value.VoicePlayTabListPopupViewModel            = GetObject<VoicePlayTabListPopupViewModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.VoicePlayTabListPopupViewModel.FromPointer); // 0x80 VoicePlayTabListPopupViewModel ( ModelClassType VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel VoicePlayTabListPopupViewModel Pointer )
            value.CasualCostumeVoicePlayListViewModel       = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 0x88 CasualCostumeVoicePlayListViewModel ( ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )
            value.MoviePopupViewModel                       = GetObject<MoviePopupViewModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.MoviePopupViewModel.FromPointer); // 0x90 MoviePopupViewModel         ( ModelClassType MoviePopupViewModel MoviePopupViewModel MoviePopupViewModel Pointer )
            value.EtceteraPopupViewModel                    = GetObject<EtceteraPopupViewModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.EtceteraPopupViewModel.FromPointer); // 0x98 EtceteraPopupViewModel      ( ModelClassType EtceteraPopupViewModel EtceteraPopupViewModel EtceteraPopupViewModel Pointer )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.InitializeCts                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0xB0 InitializeCts               ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.AdditionalLoadedCueSheets                 = GetStringList(new IntPtr(p + 0x0B8)); // 0xB8 AdditionalLoadedCueSheets   ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0xC0 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
