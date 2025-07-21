using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IProduceTopMenuPopupView IProduceTopMenuPopupView IProduceTopMenuPopupView Pointer
    // 018 ResourceTag                              ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 020 CancellationTokenSource                  ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ProduceTopMenuPopupPresenter : DataModel
    {
        public IProduceTopMenuPopupView?                View                                    { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public CancellationTokenSource?                 CancellationTokenSource                 { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static ProduceTopMenuPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTopMenuPopupPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IProduceTopMenuPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceTopMenuPopupView.FromPointer); // 0x10 View                        ( ModelClassType IProduceTopMenuPopupView IProduceTopMenuPopupView IProduceTopMenuPopupView Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x018), ReversePrism.DataModels.IResourceTag.FromPointer); // 0x18 ResourceTag                 ( ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x20 CancellationTokenSource     ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x28 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
