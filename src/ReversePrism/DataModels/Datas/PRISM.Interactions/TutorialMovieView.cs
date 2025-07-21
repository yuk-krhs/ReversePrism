using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Player                                   ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer
    // 028 SkipButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 030 TapSkipObject                            ModelClassType GameObject GameObject GameObject Pointer
    // 038 OnFinishSequence                         ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    // 040 SkipToken                                ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 048 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class TutorialMovieView : DataModel
    {
        public MoviePlayer?                             Player                                  { get; set; }
        public UIButton?                                SkipButton                              { get; set; }
        public GameObject?                              TapSkipObject                           { get; set; }
        public ITutorialSequence?                       OnFinishSequence                        { get; set; }
        public CancellationTokenSource?                 SkipToken                               { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static TutorialMovieView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialMovieView() { Pointer= p0 };

            value.Player                                    = GetObject<MoviePlayer>(new IntPtr(p + 0x020), ReversePrism.DataModels.MoviePlayer.FromPointer); // 0x20 Player                      ( ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer )
            value.SkipButton                                = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 SkipButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TapSkipObject                             = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 TapSkipObject               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OnFinishSequence                          = GetObject<ITutorialSequence>(new IntPtr(p + 0x038), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0x38 OnFinishSequence            ( ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )
            value.SkipToken                                 = GetObject<CancellationTokenSource>(new IntPtr(p + 0x040), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x40 SkipToken                   ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0x48 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
