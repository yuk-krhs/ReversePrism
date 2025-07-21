using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType ITitleView ITitleView ITitleView Pointer
    // 018 ViewModel                                ModelClassType TitleViewModel TitleViewModel TitleViewModel Pointer
    // 020 CancellationTokenSource                  ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 Sequences                                ModelClassListType ITitleSequence[] ITitleSequence[] List<ITitleSequence> Pointer
    public partial class TitlePresenter : DataModel
    {
        public ITitleView?                              View                                    { get; set; }
        public TitleViewModel?                          ViewModel                               { get; set; }
        public CancellationTokenSource?                 CancellationTokenSource                 { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public List<ITitleSequence>?                    Sequences                               { get; set; }

        public static TitlePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitlePresenter() { Pointer= p0 };

            value.View                                      = GetObject<ITitleView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITitleView.FromPointer); // 0x10 View                        ( ModelClassType ITitleView ITitleView ITitleView Pointer )
            value.ViewModel                                 = GetObject<TitleViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.TitleViewModel.FromPointer); // 0x18 ViewModel                   ( ModelClassType TitleViewModel TitleViewModel TitleViewModel Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x20 CancellationTokenSource     ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x28 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Sequences                                 = GetObjectList<ITitleSequence>(new IntPtr(p + 0x030), ReversePrism.DataModels.ITitleSequence.FromPointer); // 0x30 Sequences                   ( ModelClassListType ITitleSequence[] ITitleSequence[] List<ITitleSequence> Pointer )

            return value;
        }
    }
}
