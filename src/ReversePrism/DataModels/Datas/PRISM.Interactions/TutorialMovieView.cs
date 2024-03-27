using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Player                                   000186658A40 ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer
    // 028 SkipButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 TapSkipObject                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 OnFinishSequence                         0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    // 040 ResourceTag                              000186672320 ModelClassType ResourceTag ResourceTag ResourceTag Pointer
    // 048 SkipToken                                0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 050 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class TutorialMovieView
    {
        public MoviePlayer?                             Player                                  { get; set; }
        public UIButton?                                SkipButton                              { get; set; }
        public GameObject?                              TapSkipObject                           { get; set; }
        public ITutorialSequence?                       OnFinishSequence                        { get; set; }
        public ResourceTag?                             ResourceTag                             { get; set; }
        public CancellationTokenSource?                 SkipToken                               { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static TutorialMovieView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialMovieView();

            value.Player                                    = GetObject<MoviePlayer>(new IntPtr(p + 0x020), ReversePrism.DataModels.MoviePlayer.FromPointer); // 0270DB61F980 0x20 Player                      ( 000186658A40 ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer )
            value.SkipButton                                = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB61F9A0 0x28 SkipButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TapSkipObject                             = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB61F9C0 0x30 TapSkipObject               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OnFinishSequence                          = GetObject<ITutorialSequence>(new IntPtr(p + 0x038), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0270DB61F9E0 0x38 OnFinishSequence            ( 0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )
            value.ResourceTag                               = GetObject<ResourceTag>(new IntPtr(p + 0x040), ReversePrism.DataModels.ResourceTag.FromPointer); // 0270DB61FA00 0x40 ResourceTag                 ( 000186672320 ModelClassType ResourceTag ResourceTag ResourceTag Pointer )
            value.SkipToken                                 = GetObject<CancellationTokenSource>(new IntPtr(p + 0x048), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270DB61FA20 0x48 SkipToken                   ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DB61FA40 0x50 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
