using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SceneReference                           000186671910 ModelPrimitiveType string string string String
    // 028 CameraController                         000186536460 ModelClassType CameraController CameraController CameraController Pointer
    // 030 Render3DManager                          00018664E7E0 ModelClassType Render3DManager Render3DManager Render3DManager Pointer
    // 038 Frontispiece                             000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 FrontispieceImage                        0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 048 FrontispieceMessage                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ScreenTapUIView                          0001866F7200 ModelClassType OurStreamLiveViewingScreenTapUIView OurStreamLiveViewingScreenTapUIView OurStreamLiveViewingScreenTapUIView Pointer
    // 058 MovieView                                0001866F6300 ModelClassType OurStreamLiveViewingMovieView OurStreamLiveViewingMovieView OurStreamLiveViewingMovieView Pointer
    // 060 PreRecordedView                          0001866F6820 ModelClassType OurStreamLiveViewingPreRecordedView OurStreamLiveViewingPreRecordedView OurStreamLiveViewingPreRecordedView Pointer
    // 068 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 070 FrontispieceMessages                     000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 078 ReadyToWatch                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 079 IsLive                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07A IsPMode                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07C LiveViewingType                          000186597C50 ModelEnumType LiveViewingType LiveViewingType LiveViewingType Int32
    // 080 CurrentArchiveView                       0001865CB1D0 ModelClassType IOurStreamLiveViewingArchiveView IOurStreamLiveViewingArchiveView IOurStreamLiveViewingArchiveView Pointer
    // 088 OperatorView                             0001866E5340 ModelClassType OperatorView OperatorView OperatorView Pointer
    // 090 SoundView                                000186538FC0 ModelClassType SoundView SoundView SoundView Pointer
    // 098 CameraView                               0001865394C0 ModelClassType CameraView CameraView CameraView Pointer
    // 0A0 BgmFadeTime                              0001865F4260 ModelPrimitiveType int int int Int32
    // 0A4 BgmCurrentTime                           0001866656B0 ModelPrimitiveType float float float Single
    // 0A8 IsBgmPlaying                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B0 SceneLoader                              0001866CC6B0 ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer
    // 0B8 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 0C0 ResourceLoader                           00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 0C8 UpdateTimeDisposable                     0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class OurStreamLiveViewingView
    {
        public string                                   SceneReference                          { get; set; }
        public CameraController?                        CameraController                        { get; set; }
        public Render3DManager?                         Render3DManager                         { get; set; }
        public CanvasGroup?                             Frontispiece                            { get; set; }
        public UIImage?                                 FrontispieceImage                       { get; set; }
        public UITextMeshProUGUI?                       FrontispieceMessage                     { get; set; }
        public OurStreamLiveViewingScreenTapUIView?     ScreenTapUIView                         { get; set; }
        public OurStreamLiveViewingMovieView?           MovieView                               { get; set; }
        public OurStreamLiveViewingPreRecordedView?     PreRecordedView                         { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public List<string>?                            FrontispieceMessages                    { get; set; }
        public bool                                     ReadyToWatch                            { get; set; }
        public bool                                     IsLive                                  { get; set; }
        public bool                                     IsPMode                                 { get; set; }
        public LiveViewingType                          LiveViewingType                         { get; set; }
        public IOurStreamLiveViewingArchiveView?        CurrentArchiveView                      { get; set; }
        public OperatorView?                            OperatorView                            { get; set; }
        public SoundView?                               SoundView                               { get; set; }
        public CameraView?                              CameraView                              { get; set; }
        public int                                      BgmFadeTime                             { get; set; }
        public float                                    BgmCurrentTime                          { get; set; }
        public bool                                     IsBgmPlaying                            { get; set; }
        public SceneLoaderAddressable?                  SceneLoader                             { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public ResourceLoader?                          ResourceLoader                          { get; set; }
        public IDisposable?                             UpdateTimeDisposable                    { get; set; }

        public static OurStreamLiveViewingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamLiveViewingView();

            value.SceneReference                            = GetString(new IntPtr(p + 0x020)); // 0270DB14EBE0 0x20 SceneReference              ( 000186671910 ModelPrimitiveType string string string String )
            value.CameraController                          = GetObject<CameraController>(new IntPtr(p + 0x028), ReversePrism.DataModels.CameraController.FromPointer); // 0270DB14EC00 0x28 CameraController            ( 000186536460 ModelClassType CameraController CameraController CameraController Pointer )
            value.Render3DManager                           = GetObject<Render3DManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.Render3DManager.FromPointer); // 0270DB14EC20 0x30 Render3DManager             ( 00018664E7E0 ModelClassType Render3DManager Render3DManager Render3DManager Pointer )
            value.Frontispiece                              = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DB14EC40 0x38 Frontispiece                ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FrontispieceImage                         = GetObject<UIImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB14EC60 0x40 FrontispieceImage           ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.FrontispieceMessage                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB14EC80 0x48 FrontispieceMessage         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScreenTapUIView                           = GetObject<OurStreamLiveViewingScreenTapUIView>(new IntPtr(p + 0x050), ReversePrism.DataModels.OurStreamLiveViewingScreenTapUIView.FromPointer); // 0270DB14ECA0 0x50 ScreenTapUIView             ( 0001866F7200 ModelClassType OurStreamLiveViewingScreenTapUIView OurStreamLiveViewingScreenTapUIView OurStreamLiveViewingScreenTapUIView Pointer )
            value.MovieView                                 = GetObject<OurStreamLiveViewingMovieView>(new IntPtr(p + 0x058), ReversePrism.DataModels.OurStreamLiveViewingMovieView.FromPointer); // 0270DB14ECC0 0x58 MovieView                   ( 0001866F6300 ModelClassType OurStreamLiveViewingMovieView OurStreamLiveViewingMovieView OurStreamLiveViewingMovieView Pointer )
            value.PreRecordedView                           = GetObject<OurStreamLiveViewingPreRecordedView>(new IntPtr(p + 0x060), ReversePrism.DataModels.OurStreamLiveViewingPreRecordedView.FromPointer); // 0270DB14ECE0 0x60 PreRecordedView             ( 0001866F6820 ModelClassType OurStreamLiveViewingPreRecordedView OurStreamLiveViewingPreRecordedView OurStreamLiveViewingPreRecordedView Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x068), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB14ED00 0x68 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.FrontispieceMessages                      = GetStringList(new IntPtr(p + 0x070)); // 0270DB14ED20 0x70 FrontispieceMessages        ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ReadyToWatch                              = GetBool(new IntPtr(p + 0x078)); // 0270DB14ED40 0x78 ReadyToWatch                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsLive                                    = GetBool(new IntPtr(p + 0x079)); // 0270DB14ED60 0x79 IsLive                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPMode                                   = GetBool(new IntPtr(p + 0x07A)); // 0270DB14ED80 0x7A IsPMode                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LiveViewingType                           = (LiveViewingType)GetInt32(new IntPtr(p + 0x07C)); // 0270DB14EDA0 0x7C LiveViewingType             ( 000186597C50 ModelEnumType LiveViewingType LiveViewingType LiveViewingType Int32 )
            value.CurrentArchiveView                        = GetObject<IOurStreamLiveViewingArchiveView>(new IntPtr(p + 0x080), ReversePrism.DataModels.IOurStreamLiveViewingArchiveView.FromPointer); // 0270DB14EDC0 0x80 CurrentArchiveView          ( 0001865CB1D0 ModelClassType IOurStreamLiveViewingArchiveView IOurStreamLiveViewingArchiveView IOurStreamLiveViewingArchiveView Pointer )
            value.OperatorView                              = GetObject<OperatorView>(new IntPtr(p + 0x088), ReversePrism.DataModels.OperatorView.FromPointer); // 0270DB14EDE0 0x88 OperatorView                ( 0001866E5340 ModelClassType OperatorView OperatorView OperatorView Pointer )
            value.SoundView                                 = GetObject<SoundView>(new IntPtr(p + 0x090), ReversePrism.DataModels.SoundView.FromPointer); // 0270DB14EE00 0x90 SoundView                   ( 000186538FC0 ModelClassType SoundView SoundView SoundView Pointer )
            value.CameraView                                = GetObject<CameraView>(new IntPtr(p + 0x098), ReversePrism.DataModels.CameraView.FromPointer); // 0270DB14EE20 0x98 CameraView                  ( 0001865394C0 ModelClassType CameraView CameraView CameraView Pointer )
            value.BgmFadeTime                               = GetInt32(new IntPtr(p + 0x0A0)); // 0270DB14EE40 0xA0 BgmFadeTime                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.BgmCurrentTime                            = GetSingle(new IntPtr(p + 0x0A4)); // 0270DB14EE60 0xA4 BgmCurrentTime              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsBgmPlaying                              = GetBool(new IntPtr(p + 0x0A8)); // 0270DB14EE80 0xA8 IsBgmPlaying                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SceneLoader                               = GetObject<SceneLoaderAddressable>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.SceneLoaderAddressable.FromPointer); // 0270DB14EEA0 0xB0 SceneLoader                 ( 0001866CC6B0 ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270DB14EEC0 0xB8 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.ResourceLoader                            = GetObject<ResourceLoader>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ResourceLoader.FromPointer); // 0270DB14EEE0 0xC0 ResourceLoader              ( 00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.UpdateTimeDisposable                      = GetObject<IDisposable>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DB14EF00 0xC8 UpdateTimeDisposable        ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
