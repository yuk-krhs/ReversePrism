using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    ModelClassType LiveCostumeChangeModel LiveCostumeChangeModel LiveCostumeChangeModel Pointer
    // 018 Argument                                 ModelClassType LiveCostumeChangeArgument LiveCostumeChangeArgument LiveCostumeChangeArgument Pointer
    // 020 View                                     ModelClassType ILiveCostumeChangeView ILiveCostumeChangeView ILiveCostumeChangeView Pointer
    // 028 Ct                                       ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class LiveCostumeChangePresenter : DataModel
    {
        public LiveCostumeChangeModel?                  Model                                   { get; set; }
        public LiveCostumeChangeArgument?               Argument                                { get; set; }
        public ILiveCostumeChangeView?                  View                                    { get; set; }
        public CancellationTokenSource?                 Ct                                      { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static LiveCostumeChangePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumeChangePresenter() { Pointer= p0 };

            value.Model                                     = GetObject<LiveCostumeChangeModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.LiveCostumeChangeModel.FromPointer); // 0x10 Model                       ( ModelClassType LiveCostumeChangeModel LiveCostumeChangeModel LiveCostumeChangeModel Pointer )
            value.Argument                                  = GetObject<LiveCostumeChangeArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.LiveCostumeChangeArgument.FromPointer); // 0x18 Argument                    ( ModelClassType LiveCostumeChangeArgument LiveCostumeChangeArgument LiveCostumeChangeArgument Pointer )
            value.View                                      = GetObject<ILiveCostumeChangeView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ILiveCostumeChangeView.FromPointer); // 0x20 View                        ( ModelClassType ILiveCostumeChangeView ILiveCostumeChangeView ILiveCostumeChangeView Pointer )
            value.Ct                                        = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 Ct                          ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
