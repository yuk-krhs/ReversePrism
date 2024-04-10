using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewModel                                000186774A10 ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer
    // 018 View                                     000186645700 ModelClassType IShopView IShopView IShopView Pointer
    // 020 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ShopPresenter : DataModel
    {
        public ShopViewModel?                           ViewModel                               { get; set; }
        public IShopView?                               View                                    { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static ShopPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPresenter() { Pointer= p0 };

            value.ViewModel                                 = GetObject<ShopViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ShopViewModel.FromPointer); // 024666777408 0x10 ViewModel                   ( 000186774A10 ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer )
            value.View                                      = GetObject<IShopView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IShopView.FromPointer); // 024666777428 0x18 View                        ( 000186645700 ModelClassType IShopView IShopView IShopView Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024666777448 0x20 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024666777468 0x28 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
