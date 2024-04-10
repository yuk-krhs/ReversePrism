using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    0001865483B0 ModelClassType LiveCostumeChangeModel LiveCostumeChangeModel LiveCostumeChangeModel Pointer
    // 018 Argument                                 000186546F40 ModelClassType LiveCostumeChangeArgument LiveCostumeChangeArgument LiveCostumeChangeArgument Pointer
    // 020 View                                     000186594710 ModelClassType ILiveCostumeChangeView ILiveCostumeChangeView ILiveCostumeChangeView Pointer
    // 028 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 030 Ct                                       0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class LiveCostumeChangePresenter : DataModel
    {
        public LiveCostumeChangeModel?                  Model                                   { get; set; }
        public LiveCostumeChangeArgument?               Argument                                { get; set; }
        public ILiveCostumeChangeView?                  View                                    { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public CancellationTokenSource?                 Ct                                      { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static LiveCostumeChangePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumeChangePresenter() { Pointer= p0 };

            value.Model                                     = GetObject<LiveCostumeChangeModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.LiveCostumeChangeModel.FromPointer); // 02466643CAB8 0x10 Model                       ( 0001865483B0 ModelClassType LiveCostumeChangeModel LiveCostumeChangeModel LiveCostumeChangeModel Pointer )
            value.Argument                                  = GetObject<LiveCostumeChangeArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.LiveCostumeChangeArgument.FromPointer); // 02466643CAD8 0x18 Argument                    ( 000186546F40 ModelClassType LiveCostumeChangeArgument LiveCostumeChangeArgument LiveCostumeChangeArgument Pointer )
            value.View                                      = GetObject<ILiveCostumeChangeView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ILiveCostumeChangeView.FromPointer); // 02466643CAF8 0x20 View                        ( 000186594710 ModelClassType ILiveCostumeChangeView ILiveCostumeChangeView ILiveCostumeChangeView Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x028), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466643CB18 0x28 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.Ct                                        = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 02466643CB38 0x30 Ct                          ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 02466643CB58 0x38 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
