using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IExtraStorySecondCategoryView IExtraStorySecondCategoryView IExtraStorySecondCategoryView Pointer
    // 018 Argument                                 ModelClassType ExtraStorySecondCategoryArgument ExtraStorySecondCategoryArgument ExtraStorySecondCategoryArgument Pointer
    // 020 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 Model                                    ModelClassType ExtraStorySecondCategoryModel ExtraStorySecondCategoryModel ExtraStorySecondCategoryModel Pointer
    public partial class ExtraStorySecondCategoryPresenter : DataModel
    {
        public IExtraStorySecondCategoryView?           View                                    { get; set; }
        public ExtraStorySecondCategoryArgument?        Argument                                { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ExtraStorySecondCategoryModel?           Model                                   { get; set; }

        public static ExtraStorySecondCategoryPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStorySecondCategoryPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IExtraStorySecondCategoryView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IExtraStorySecondCategoryView.FromPointer); // 0x10 View                        ( ModelClassType IExtraStorySecondCategoryView IExtraStorySecondCategoryView IExtraStorySecondCategoryView Pointer )
            value.Argument                                  = GetObject<ExtraStorySecondCategoryArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExtraStorySecondCategoryArgument.FromPointer); // 0x18 Argument                    ( ModelClassType ExtraStorySecondCategoryArgument ExtraStorySecondCategoryArgument ExtraStorySecondCategoryArgument Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x20 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x28 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Model                                     = GetObject<ExtraStorySecondCategoryModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ExtraStorySecondCategoryModel.FromPointer); // 0x30 Model                       ( ModelClassType ExtraStorySecondCategoryModel ExtraStorySecondCategoryModel ExtraStorySecondCategoryModel Pointer )

            return value;
        }
    }
}
