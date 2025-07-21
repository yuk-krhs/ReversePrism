using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewModel                                ModelClassType ProduceResultFUnitDetailPopupViewModel ProduceResultFUnitDetailPopupViewModel ProduceResultFUnitDetailPopupViewModel Pointer
    // 018 LogModel                                 ModelClassType LogIndexViewModel LogIndexViewModel LogIndexViewModel Pointer
    // 020 View                                     ModelClassType IProduceResultFUnitDetailPopupView IProduceResultFUnitDetailPopupView IProduceResultFUnitDetailPopupView Pointer
    // 028 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 IsDoneTransfer                           ModelPrimitiveType bool bool bool Bool
    // 039 IsClose                                  ModelPrimitiveType bool bool bool Bool
    public partial class ProduceResultFUnitDetailPopupPresenter : DataModel
    {
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

            value.ViewModel                                 = GetObject<ProduceResultFUnitDetailPopupViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceResultFUnitDetailPopupViewModel.FromPointer); // 0x10 ViewModel                   ( ModelClassType ProduceResultFUnitDetailPopupViewModel ProduceResultFUnitDetailPopupViewModel ProduceResultFUnitDetailPopupViewModel Pointer )
            value.LogModel                                  = GetObject<LogIndexViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.LogIndexViewModel.FromPointer); // 0x18 LogModel                    ( ModelClassType LogIndexViewModel LogIndexViewModel LogIndexViewModel Pointer )
            value.View                                      = GetObject<IProduceResultFUnitDetailPopupView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceResultFUnitDetailPopupView.FromPointer); // 0x20 View                        ( ModelClassType IProduceResultFUnitDetailPopupView IProduceResultFUnitDetailPopupView IProduceResultFUnitDetailPopupView Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsDoneTransfer                            = GetBool(new IntPtr(p + 0x038)); // 0x38 IsDoneTransfer              ( ModelPrimitiveType bool bool bool Bool )
            value.IsClose                                   = GetBool(new IntPtr(p + 0x039)); // 0x39 IsClose                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
