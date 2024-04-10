using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865F65C0 ModelClassType IProduceTopMenuPopupView IProduceTopMenuPopupView IProduceTopMenuPopupView Pointer
    // 018 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 020 CancellationTokenSource                  0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
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

            value.View                                      = GetObject<IProduceTopMenuPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceTopMenuPopupView.FromPointer); // 024666597F98 0x10 View                        ( 0001865F65C0 ModelClassType IProduceTopMenuPopupView IProduceTopMenuPopupView IProduceTopMenuPopupView Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x018), ReversePrism.DataModels.IResourceTag.FromPointer); // 024666597FB8 0x18 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024666597FD8 0x20 CancellationTokenSource     ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024666597FF8 0x28 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
