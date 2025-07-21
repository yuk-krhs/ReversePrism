using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SceneReference                           ModelPrimitiveType string string string String
    // 028 Frontispiece                             ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 FrontispieceImage                        ModelClassType UIImage UIImage UIImage Pointer
    // 038 FrontispieceMessage                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 PremiumImage                             ModelClassType UIImage UIImage UIImage Pointer
    // 048 ScreenTapUIView                          ModelClassType OurStreamLiveViewingScreenTapUIView OurStreamLiveViewingScreenTapUIView OurStreamLiveViewingScreenTapUIView Pointer
    // 050 MovieView                                ModelClassType OurStreamLiveViewingMovieView OurStreamLiveViewingMovieView OurStreamLiveViewingMovieView Pointer
    // 058 PreRecordedView                          ModelClassType OurStreamLiveViewingPreRecordedView OurStreamLiveViewingPreRecordedView OurStreamLiveViewingPreRecordedView Pointer
    // 060 CameraControlView                        ModelClassType OurStreamLiveViewingCameraControlView OurStreamLiveViewingCameraControlView OurStreamLiveViewingCameraControlView Pointer
    // 068 ReconnectingScreen                       ModelClassType GameObject GameObject GameObject Pointer
    // 070 ImageIdArray                             ModelPrimitiveListType int[] int[] List<int> Pointer
    // 078 FrontispieceMessages                     ModelPrimitiveListType string[] string[] List<string> Pointer
    // 080 FrontispieceSprites                      ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 088 ReadyToWatch                             ModelPrimitiveType bool bool bool Bool
    // 089 IsLive                                   ModelPrimitiveType bool bool bool Bool
    // 08A IsInitPMode                              ModelPrimitiveType bool bool bool Bool
    // 08B IsPremium                                ModelPrimitiveType bool bool bool Bool
    // 08C LiveViewingType                          ModelEnumType LiveViewingType LiveViewingType LiveViewingType Int32
    // 090 CurrentArchiveView                       ModelClassType IOurStreamLiveViewingArchiveView IOurStreamLiveViewingArchiveView IOurStreamLiveViewingArchiveView Pointer
    // 098 CameraController                         ModelClassType CameraController CameraController CameraController Pointer
    // 0A0 OperatorView                             ModelClassType OperatorView OperatorView OperatorView Pointer
    // 0A8 SoundView                                ModelClassType SoundView SoundView SoundView Pointer
    // 0B0 CameraView                               ModelClassType CameraView CameraView CameraView Pointer
    // 0B8 BgmFadeTime                              ModelPrimitiveType int int int Int32
    // 0BC PremiumImageFadeTime                     ModelPrimitiveType float float float Single
    // 0C0 BgmCurrentTime                           ModelPrimitiveType float float float Single
    // 0C4 IsBgmPlaying                             ModelPrimitiveType bool bool bool Bool
    // 0C5 BeforePaused                             ModelPrimitiveType bool bool bool Bool
    // 0C6 ShowPremiumImage                         ModelPrimitiveType bool bool bool Bool
    // 0C8 MstStreamData                            ModelClassType MstStreamProgram MstStreamProgram MstStreamProgram Pointer
    // 0D0 SceneLoader                              ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer
    // 0D8 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 0E0 UpdateTimeDisposable                     ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class OurStreamLiveViewingView : DataModel
    {
        public string                                   SceneReference                          { get; set; }
        public CanvasGroup?                             Frontispiece                            { get; set; }
        public UIImage?                                 FrontispieceImage                       { get; set; }
        public UITextMeshProUGUI?                       FrontispieceMessage                     { get; set; }
        public UIImage?                                 PremiumImage                            { get; set; }
        public OurStreamLiveViewingScreenTapUIView?     ScreenTapUIView                         { get; set; }
        public OurStreamLiveViewingMovieView?           MovieView                               { get; set; }
        public OurStreamLiveViewingPreRecordedView?     PreRecordedView                         { get; set; }
        public OurStreamLiveViewingCameraControlView?   CameraControlView                       { get; set; }
        public GameObject?                              ReconnectingScreen                      { get; set; }
        public List<int>?                               ImageIdArray                            { get; set; }
        public List<string>?                            FrontispieceMessages                    { get; set; }
        public List<Sprite>?                            FrontispieceSprites                     { get; set; }
        public bool                                     ReadyToWatch                            { get; set; }
        public bool                                     IsLive                                  { get; set; }
        public bool                                     IsInitPMode                             { get; set; }
        public bool                                     IsPremium                               { get; set; }
        public LiveViewingType                          LiveViewingType                         { get; set; }
        public IOurStreamLiveViewingArchiveView?        CurrentArchiveView                      { get; set; }
        public CameraController?                        CameraController                        { get; set; }
        public OperatorView?                            OperatorView                            { get; set; }
        public SoundView?                               SoundView                               { get; set; }
        public CameraView?                              CameraView                              { get; set; }
        public int                                      BgmFadeTime                             { get; set; }
        public float                                    PremiumImageFadeTime                    { get; set; }
        public float                                    BgmCurrentTime                          { get; set; }
        public bool                                     IsBgmPlaying                            { get; set; }
        public bool                                     BeforePaused                            { get; set; }
        public bool                                     ShowPremiumImage                        { get; set; }
        public MstStreamProgram?                        MstStreamData                           { get; set; }
        public SceneLoaderAddressable?                  SceneLoader                             { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public IDisposable?                             UpdateTimeDisposable                    { get; set; }

        public static OurStreamLiveViewingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamLiveViewingView() { Pointer= p0 };

            value.SceneReference                            = GetString(new IntPtr(p + 0x020)); // 0x20 SceneReference              ( ModelPrimitiveType string string string String )
            value.Frontispiece                              = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 Frontispiece                ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FrontispieceImage                         = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0x30 FrontispieceImage           ( ModelClassType UIImage UIImage UIImage Pointer )
            value.FrontispieceMessage                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 FrontispieceMessage         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PremiumImage                              = GetObject<UIImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIImage.FromPointer); // 0x40 PremiumImage                ( ModelClassType UIImage UIImage UIImage Pointer )
            value.ScreenTapUIView                           = GetObject<OurStreamLiveViewingScreenTapUIView>(new IntPtr(p + 0x048), ReversePrism.DataModels.OurStreamLiveViewingScreenTapUIView.FromPointer); // 0x48 ScreenTapUIView             ( ModelClassType OurStreamLiveViewingScreenTapUIView OurStreamLiveViewingScreenTapUIView OurStreamLiveViewingScreenTapUIView Pointer )
            value.MovieView                                 = GetObject<OurStreamLiveViewingMovieView>(new IntPtr(p + 0x050), ReversePrism.DataModels.OurStreamLiveViewingMovieView.FromPointer); // 0x50 MovieView                   ( ModelClassType OurStreamLiveViewingMovieView OurStreamLiveViewingMovieView OurStreamLiveViewingMovieView Pointer )
            value.PreRecordedView                           = GetObject<OurStreamLiveViewingPreRecordedView>(new IntPtr(p + 0x058), ReversePrism.DataModels.OurStreamLiveViewingPreRecordedView.FromPointer); // 0x58 PreRecordedView             ( ModelClassType OurStreamLiveViewingPreRecordedView OurStreamLiveViewingPreRecordedView OurStreamLiveViewingPreRecordedView Pointer )
            value.CameraControlView                         = GetObject<OurStreamLiveViewingCameraControlView>(new IntPtr(p + 0x060), ReversePrism.DataModels.OurStreamLiveViewingCameraControlView.FromPointer); // 0x60 CameraControlView           ( ModelClassType OurStreamLiveViewingCameraControlView OurStreamLiveViewingCameraControlView OurStreamLiveViewingCameraControlView Pointer )
            value.ReconnectingScreen                        = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 ReconnectingScreen          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ImageIdArray                              = GetInt32List(new IntPtr(p + 0x070)); // 0x70 ImageIdArray                ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.FrontispieceMessages                      = GetStringList(new IntPtr(p + 0x078)); // 0x78 FrontispieceMessages        ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.FrontispieceSprites                       = GetObjectList<Sprite>(new IntPtr(p + 0x080), ReversePrism.DataModels.Sprite.FromPointer); // 0x80 FrontispieceSprites         ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.ReadyToWatch                              = GetBool(new IntPtr(p + 0x088)); // 0x88 ReadyToWatch                ( ModelPrimitiveType bool bool bool Bool )
            value.IsLive                                    = GetBool(new IntPtr(p + 0x089)); // 0x89 IsLive                      ( ModelPrimitiveType bool bool bool Bool )
            value.IsInitPMode                               = GetBool(new IntPtr(p + 0x08A)); // 0x8A IsInitPMode                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsPremium                                 = GetBool(new IntPtr(p + 0x08B)); // 0x8B IsPremium                   ( ModelPrimitiveType bool bool bool Bool )
            value.LiveViewingType                           = (LiveViewingType)GetInt32(new IntPtr(p + 0x08C)); // 0x8C LiveViewingType             ( ModelEnumType LiveViewingType LiveViewingType LiveViewingType Int32 )
            value.CurrentArchiveView                        = GetObject<IOurStreamLiveViewingArchiveView>(new IntPtr(p + 0x090), ReversePrism.DataModels.IOurStreamLiveViewingArchiveView.FromPointer); // 0x90 CurrentArchiveView          ( ModelClassType IOurStreamLiveViewingArchiveView IOurStreamLiveViewingArchiveView IOurStreamLiveViewingArchiveView Pointer )
            value.CameraController                          = GetObject<CameraController>(new IntPtr(p + 0x098), ReversePrism.DataModels.CameraController.FromPointer); // 0x98 CameraController            ( ModelClassType CameraController CameraController CameraController Pointer )
            value.OperatorView                              = GetObject<OperatorView>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.OperatorView.FromPointer); // 0xA0 OperatorView                ( ModelClassType OperatorView OperatorView OperatorView Pointer )
            value.SoundView                                 = GetObject<SoundView>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.SoundView.FromPointer); // 0xA8 SoundView                   ( ModelClassType SoundView SoundView SoundView Pointer )
            value.CameraView                                = GetObject<CameraView>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.CameraView.FromPointer); // 0xB0 CameraView                  ( ModelClassType CameraView CameraView CameraView Pointer )
            value.BgmFadeTime                               = GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 BgmFadeTime                 ( ModelPrimitiveType int int int Int32 )
            value.PremiumImageFadeTime                      = GetSingle(new IntPtr(p + 0x0BC)); // 0xBC PremiumImageFadeTime        ( ModelPrimitiveType float float float Single )
            value.BgmCurrentTime                            = GetSingle(new IntPtr(p + 0x0C0)); // 0xC0 BgmCurrentTime              ( ModelPrimitiveType float float float Single )
            value.IsBgmPlaying                              = GetBool(new IntPtr(p + 0x0C4)); // 0xC4 IsBgmPlaying                ( ModelPrimitiveType bool bool bool Bool )
            value.BeforePaused                              = GetBool(new IntPtr(p + 0x0C5)); // 0xC5 BeforePaused                ( ModelPrimitiveType bool bool bool Bool )
            value.ShowPremiumImage                          = GetBool(new IntPtr(p + 0x0C6)); // 0xC6 ShowPremiumImage            ( ModelPrimitiveType bool bool bool Bool )
            value.MstStreamData                             = GetObject<MstStreamProgram>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.MstStreamProgram.FromPointer); // 0xC8 MstStreamData               ( ModelClassType MstStreamProgram MstStreamProgram MstStreamProgram Pointer )
            value.SceneLoader                               = GetObject<SceneLoaderAddressable>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.SceneLoaderAddressable.FromPointer); // 0xD0 SceneLoader                 ( ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0xD8 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.UpdateTimeDisposable                      = GetObject<IDisposable>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.IDisposable.FromPointer); // 0xE0 UpdateTimeDisposable        ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
