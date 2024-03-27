using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Argument                                 00018653ED20 ModelClassType SpecialLessonResultArgument SpecialLessonResultArgument SpecialLessonResultArgument Pointer
    // 018 View                                     00018664A360 ModelClassType ISpecialLessonResultView ISpecialLessonResultView ISpecialLessonResultView Pointer
    // 020 AdvPresenter                             0001866D7B40 ModelClassType InGameResultADVPresenter InGameResultADVPresenter InGameResultADVPresenter Pointer
    // 028 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class SpecialLessonResultPresenter
    {
        public SpecialLessonResultArgument?             Argument                                { get; set; }
        public ISpecialLessonResultView?                View                                    { get; set; }
        public InGameResultADVPresenter?                AdvPresenter                            { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static SpecialLessonResultPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialLessonResultPresenter();

            value.Argument                                  = GetObject<SpecialLessonResultArgument>(new IntPtr(p + 0x010), ReversePrism.DataModels.SpecialLessonResultArgument.FromPointer); // 0270D683CB70 0x10 Argument                    ( 00018653ED20 ModelClassType SpecialLessonResultArgument SpecialLessonResultArgument SpecialLessonResultArgument Pointer )
            value.View                                      = GetObject<ISpecialLessonResultView>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISpecialLessonResultView.FromPointer); // 0270D683CB90 0x18 View                        ( 00018664A360 ModelClassType ISpecialLessonResultView ISpecialLessonResultView ISpecialLessonResultView Pointer )
            value.AdvPresenter                              = GetObject<InGameResultADVPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGameResultADVPresenter.FromPointer); // 0270D683CBB0 0x20 AdvPresenter                ( 0001866D7B40 ModelClassType InGameResultADVPresenter InGameResultADVPresenter InGameResultADVPresenter Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D683CBD0 0x28 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D683CBF0 0x30 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
