using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    000186740750 ModelClassType ICostumeChangeModel ICostumeChangeModel ICostumeChangeModel Pointer
    // 018 costumeDetailPopupViewFactory            IPopupViewFactory`1<ICostumeDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 020 View                                     000186740E40 ModelClassType ICostumeChangeView ICostumeChangeView ICostumeChangeView Pointer
    // 028 Disposables                              0001865F3410 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class CostumeChangePresenter
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
            var value   = new CostumeChangePresenter();

            value.Model                                     = GetObject<ICostumeChangeModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICostumeChangeModel.FromPointer); // 0270D62287B8 0x10 Model                       ( 000186740750 ModelClassType ICostumeChangeModel ICostumeChangeModel ICostumeChangeModel Pointer )
            value.View                                      = GetObject<ICostumeChangeView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ICostumeChangeView.FromPointer); // 0270D62287F8 0x20 View                        ( 000186740E40 ModelClassType ICostumeChangeView ICostumeChangeView ICostumeChangeView Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D6228818 0x28 Disposables                 ( 0001865F3410 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D6228838 0x30 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
