using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MvNameFormat                             string IL2CPP_TYPE_STRING
    // 050 SceneLoader                              ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer
    // 058 MvSequencer                              ModelClassType MvSequencer MvSequencer MvSequencer Pointer
    // 060 ImageTask                                ModelEnumType UniTask UniTask UniTask Int32
    // 070 Cs                                       ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 078 CsNameList                               ModelPrimitiveListType string[] string[] List<string> Pointer
    // 080 EpisodeId                                ModelPrimitiveType int int int Int32
    // 084 LastGameMode                             ModelEnumType GameMode GameMode GameMode Int32
    // 088 BackgroundSuppressDisposable             ModelClassType IDisposable IDisposable IDisposable Pointer
    // 090 IsExitSequence                           ModelPrimitiveType bool bool bool Bool
    // 098 MvSequencerScene                         ModelPrimitiveType string string string String
    // 0A0 Image                                    ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 0A8 SkipButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 0B0 ImageSwappingMillisec                    ModelPrimitiveType int int int Int32
    // 0B8 TutorialSequence                         ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    // 0C0 Prm                                      ModelClassType Parameter Parameter Parameter Pointer
    public partial class ViewProduceMv : DataModel
    {
        public SceneLoaderAddressable?                  SceneLoader                             { get; set; }
        public MvSequencer?                             MvSequencer                             { get; set; }
        public UniTask                                  ImageTask                               { get; set; }
        public CancellationTokenSource?                 Cs                                      { get; set; }
        public List<string>?                            CsNameList                              { get; set; }
        public int                                      EpisodeId                               { get; set; }
        public GameMode                                 LastGameMode                            { get; set; }
        public IDisposable?                             BackgroundSuppressDisposable            { get; set; }
        public bool                                     IsExitSequence                          { get; set; }
        public string                                   MvSequencerScene                        { get; set; }
        public UIRawImage?                              Image                                   { get; set; }
        public UIButton?                                SkipButton                              { get; set; }
        public int                                      ImageSwappingMillisec                   { get; set; }
        public ITutorialSequence?                       TutorialSequence                        { get; set; }
        public Parameter?                               Prm                                     { get; set; }

        public static ViewProduceMv? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewProduceMv() { Pointer= p0 };

            value.SceneLoader                               = GetObject<SceneLoaderAddressable>(new IntPtr(p + 0x050), ReversePrism.DataModels.SceneLoaderAddressable.FromPointer); // 0x50 SceneLoader                 ( ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer )
            value.MvSequencer                               = GetObject<MvSequencer>(new IntPtr(p + 0x058), ReversePrism.DataModels.MvSequencer.FromPointer); // 0x58 MvSequencer                 ( ModelClassType MvSequencer MvSequencer MvSequencer Pointer )
            value.ImageTask                                 = (UniTask)GetInt32(new IntPtr(p + 0x060)); // 0x60 ImageTask                   ( ModelEnumType UniTask UniTask UniTask Int32 )
            value.Cs                                        = GetObject<CancellationTokenSource>(new IntPtr(p + 0x070), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x70 Cs                          ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.CsNameList                                = GetStringList(new IntPtr(p + 0x078)); // 0x78 CsNameList                  ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.EpisodeId                                 = GetInt32(new IntPtr(p + 0x080)); // 0x80 EpisodeId                   ( ModelPrimitiveType int int int Int32 )
            value.LastGameMode                              = (GameMode)GetInt32(new IntPtr(p + 0x084)); // 0x84 LastGameMode                ( ModelEnumType GameMode GameMode GameMode Int32 )
            value.BackgroundSuppressDisposable              = GetObject<IDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.IDisposable.FromPointer); // 0x88 BackgroundSuppressDisposable ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.IsExitSequence                            = GetBool(new IntPtr(p + 0x090)); // 0x90 IsExitSequence              ( ModelPrimitiveType bool bool bool Bool )
            value.MvSequencerScene                          = GetString(new IntPtr(p + 0x098)); // 0x98 MvSequencerScene            ( ModelPrimitiveType string string string String )
            value.Image                                     = GetObject<UIRawImage>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UIRawImage.FromPointer); // 0xA0 Image                       ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.SkipButton                                = GetObject<UIButton>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UIButton.FromPointer); // 0xA8 SkipButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ImageSwappingMillisec                     = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 ImageSwappingMillisec       ( ModelPrimitiveType int int int Int32 )
            value.TutorialSequence                          = GetObject<ITutorialSequence>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0xB8 TutorialSequence            ( ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )
            value.Prm                                       = GetObject<Parameter>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Parameter.FromPointer); // 0xC0 Prm                         ( ModelClassType Parameter Parameter Parameter Pointer )

            return value;
        }
    }
}
