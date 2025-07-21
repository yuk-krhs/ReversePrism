using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    ModelClassType ICostumeChangeModel ICostumeChangeModel ICostumeChangeModel Pointer
    // 018 View                                     ModelClassType ICostumeChangeView ICostumeChangeView ICostumeChangeView Pointer
    // 020 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class CostumeChangePresenter : DataModel
    {
        public ICostumeChangeModel?                     Model                                   { get; set; }
        public ICostumeChangeView?                      View                                    { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static CostumeChangePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeChangePresenter() { Pointer= p0 };

            value.Model                                     = GetObject<ICostumeChangeModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICostumeChangeModel.FromPointer); // 0x10 Model                       ( ModelClassType ICostumeChangeModel ICostumeChangeModel ICostumeChangeModel Pointer )
            value.View                                      = GetObject<ICostumeChangeView>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICostumeChangeView.FromPointer); // 0x18 View                        ( ModelClassType ICostumeChangeView ICostumeChangeView ICostumeChangeView Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
