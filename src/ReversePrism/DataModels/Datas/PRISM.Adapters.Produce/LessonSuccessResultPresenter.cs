using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Argument                                 ModelClassType LessonSuccessResultArgument LessonSuccessResultArgument LessonSuccessResultArgument Pointer
    // 018 View                                     ModelClassType ILessonSuccessResultView ILessonSuccessResultView ILessonSuccessResultView Pointer
    // 020 AdvPresenter                             ModelClassType InGameResultADVPresenter InGameResultADVPresenter InGameResultADVPresenter Pointer
    // 028 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class LessonSuccessResultPresenter : DataModel
    {
        public LessonSuccessResultArgument?             Argument                                { get; set; }
        public ILessonSuccessResultView?                View                                    { get; set; }
        public InGameResultADVPresenter?                AdvPresenter                            { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static LessonSuccessResultPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LessonSuccessResultPresenter() { Pointer= p0 };

            value.Argument                                  = GetObject<LessonSuccessResultArgument>(new IntPtr(p + 0x010), ReversePrism.DataModels.LessonSuccessResultArgument.FromPointer); // 0x10 Argument                    ( ModelClassType LessonSuccessResultArgument LessonSuccessResultArgument LessonSuccessResultArgument Pointer )
            value.View                                      = GetObject<ILessonSuccessResultView>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILessonSuccessResultView.FromPointer); // 0x18 View                        ( ModelClassType ILessonSuccessResultView ILessonSuccessResultView ILessonSuccessResultView Pointer )
            value.AdvPresenter                              = GetObject<InGameResultADVPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGameResultADVPresenter.FromPointer); // 0x20 AdvPresenter                ( ModelClassType InGameResultADVPresenter InGameResultADVPresenter InGameResultADVPresenter Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
