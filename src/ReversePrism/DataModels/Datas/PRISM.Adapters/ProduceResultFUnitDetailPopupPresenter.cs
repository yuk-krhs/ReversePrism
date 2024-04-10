using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FUnitDetailPopupViewFactory              0001865F1840 ModelClassType IProduceResultFUnitDetailPopupViewFactory IProduceResultFUnitDetailPopupViewFactory IProduceResultFUnitDetailPopupViewFactory Pointer
    // 018 ViewModel                                000186574BB0 ModelClassType ProduceResultFUnitDetailPopupViewModel ProduceResultFUnitDetailPopupViewModel ProduceResultFUnitDetailPopupViewModel Pointer
    // 020 LogModel                                 0001865AD430 ModelClassType LogIndexViewModel LogIndexViewModel LogIndexViewModel Pointer
    // 028 View                                     0001865F1400 ModelClassType IProduceResultFUnitDetailPopupView IProduceResultFUnitDetailPopupView IProduceResultFUnitDetailPopupView Pointer
    // 030 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 040 IsDoneTransfer                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 IsClose                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceResultFUnitDetailPopupPresenter : DataModel
    {
        public IProduceResultFUnitDetailPopupViewFactory? FUnitDetailPopupViewFactory             { get; set; }
        public ProduceResultFUnitDetailPopupViewModel?  ViewModel                               { get; set; }
        public LogIndexViewModel?                       LogModel                                { get; set; }
        public IProduceResultFUnitDetailPopupView?      View                                    { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public bool                                     IsDoneTransfer                          { get; set; }
        public bool                                     IsClose                                 { get; set; }

        public static ProduceResultFUnitDetailPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultFUnitDetailPopupPresenter() { Pointer= p0 };

            value.FUnitDetailPopupViewFactory               = GetObject<IProduceResultFUnitDetailPopupViewFactory>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceResultFUnitDetailPopupViewFactory.FromPointer); // 024665FA9218 0x10 FUnitDetailPopupViewFactory ( 0001865F1840 ModelClassType IProduceResultFUnitDetailPopupViewFactory IProduceResultFUnitDetailPopupViewFactory IProduceResultFUnitDetailPopupViewFactory Pointer )
            value.ViewModel                                 = GetObject<ProduceResultFUnitDetailPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceResultFUnitDetailPopupViewModel.FromPointer); // 024665FA9238 0x18 ViewModel                   ( 000186574BB0 ModelClassType ProduceResultFUnitDetailPopupViewModel ProduceResultFUnitDetailPopupViewModel ProduceResultFUnitDetailPopupViewModel Pointer )
            value.LogModel                                  = GetObject<LogIndexViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.LogIndexViewModel.FromPointer); // 024665FA9258 0x20 LogModel                    ( 0001865AD430 ModelClassType LogIndexViewModel LogIndexViewModel LogIndexViewModel Pointer )
            value.View                                      = GetObject<IProduceResultFUnitDetailPopupView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IProduceResultFUnitDetailPopupView.FromPointer); // 024665FA9278 0x28 View                        ( 0001865F1400 ModelClassType IProduceResultFUnitDetailPopupView IProduceResultFUnitDetailPopupView IProduceResultFUnitDetailPopupView Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024665FA9298 0x30 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024665FA92B8 0x38 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsDoneTransfer                            = GetBool(new IntPtr(p + 0x040)); // 024665FA92D8 0x40 IsDoneTransfer              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsClose                                   = GetBool(new IntPtr(p + 0x041)); // 024665FA92F8 0x41 IsClose                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
