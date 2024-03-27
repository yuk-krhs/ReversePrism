using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MvNameFormat                             string IL2CPP_TYPE_STRING
    // 058 SceneLoader                              0001866CC6B0 ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer
    // 060 MvSequencer                              000186679240 ModelClassType MvSequencer MvSequencer MvSequencer Pointer
    // 068 ImageTask                                00018669FD00 ModelEnumType UniTask UniTask UniTask Int32
    // 078 Cs                                       0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 080 CsNameList                               000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 088 EpisodeId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 08C LastGameMode                             0001865EA840 ModelEnumType GameMode GameMode GameMode Int32
    // 090 BackgroundSuppressDisposable             0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 098 IsExitSequence                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A0 MvSequencerScene                         000186671910 ModelPrimitiveType string string string String
    // 0A8 Image                                    0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 0B0 SkipButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0B8 ImageSwappingMillisec                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0C0 TutorialSequence                         0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    // 0C8 Prm                                      0001866ED5B0 ModelClassType Parameter Parameter Parameter Pointer
    public partial class ViewProduceMv
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
            var value   = new ViewProduceMv();

            value.SceneLoader                               = GetObject<SceneLoaderAddressable>(new IntPtr(p + 0x058), ReversePrism.DataModels.SceneLoaderAddressable.FromPointer); // 0270D5BED8B0 0x58 SceneLoader                 ( 0001866CC6B0 ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer )
            value.MvSequencer                               = GetObject<MvSequencer>(new IntPtr(p + 0x060), ReversePrism.DataModels.MvSequencer.FromPointer); // 0270D5BED8D0 0x60 MvSequencer                 ( 000186679240 ModelClassType MvSequencer MvSequencer MvSequencer Pointer )
            value.ImageTask                                 = (UniTask)GetInt32(new IntPtr(p + 0x068)); // 0270D5BED8F0 0x68 ImageTask                   ( 00018669FD00 ModelEnumType UniTask UniTask UniTask Int32 )
            value.Cs                                        = GetObject<CancellationTokenSource>(new IntPtr(p + 0x078), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5BED910 0x78 Cs                          ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.CsNameList                                = GetStringList(new IntPtr(p + 0x080)); // 0270D5BED930 0x80 CsNameList                  ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.EpisodeId                                 = GetInt32(new IntPtr(p + 0x088)); // 0270D5BED950 0x88 EpisodeId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LastGameMode                              = (GameMode)GetInt32(new IntPtr(p + 0x08C)); // 0270D5BED970 0x8C LastGameMode                ( 0001865EA840 ModelEnumType GameMode GameMode GameMode Int32 )
            value.BackgroundSuppressDisposable              = GetObject<IDisposable>(new IntPtr(p + 0x090), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D5BED990 0x90 BackgroundSuppressDisposable ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.IsExitSequence                            = GetBool(new IntPtr(p + 0x098)); // 0270D5BED9B0 0x98 IsExitSequence              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MvSequencerScene                          = GetString(new IntPtr(p + 0x0A0)); // 0270D5BED9D0 0xA0 MvSequencerScene            ( 000186671910 ModelPrimitiveType string string string String )
            value.Image                                     = GetObject<UIRawImage>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D5BED9F0 0xA8 Image                       ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.SkipButton                                = GetObject<UIButton>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5BEDA10 0xB0 SkipButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ImageSwappingMillisec                     = GetInt32(new IntPtr(p + 0x0B8)); // 0270D5BEDA30 0xB8 ImageSwappingMillisec       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TutorialSequence                          = GetObject<ITutorialSequence>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0270D5BEDA50 0xC0 TutorialSequence            ( 0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )
            value.Prm                                       = GetObject<Parameter>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Parameter.FromPointer); // 0270D5BEDA70 0xC8 Prm                         ( 0001866ED5B0 ModelClassType Parameter Parameter Parameter Pointer )

            return value;
        }
    }
}
