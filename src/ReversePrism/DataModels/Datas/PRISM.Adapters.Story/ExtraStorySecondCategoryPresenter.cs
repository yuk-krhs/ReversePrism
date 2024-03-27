using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186773510 ModelClassType IExtraStorySecondCategoryView IExtraStorySecondCategoryView IExtraStorySecondCategoryView Pointer
    // 018 Argument                                 00018653BF40 ModelClassType ExtraStorySecondCategoryArgument ExtraStorySecondCategoryArgument ExtraStorySecondCategoryArgument Pointer
    // 020 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 Model                                    00018653E140 ModelClassType ExtraStorySecondCategoryModel ExtraStorySecondCategoryModel ExtraStorySecondCategoryModel Pointer
    public partial class ExtraStorySecondCategoryPresenter
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
            var value   = new ExtraStorySecondCategoryPresenter();

            value.View                                      = GetObject<IExtraStorySecondCategoryView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IExtraStorySecondCategoryView.FromPointer); // 0270D679DEA0 0x10 View                        ( 000186773510 ModelClassType IExtraStorySecondCategoryView IExtraStorySecondCategoryView IExtraStorySecondCategoryView Pointer )
            value.Argument                                  = GetObject<ExtraStorySecondCategoryArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExtraStorySecondCategoryArgument.FromPointer); // 0270D679DEC0 0x18 Argument                    ( 00018653BF40 ModelClassType ExtraStorySecondCategoryArgument ExtraStorySecondCategoryArgument ExtraStorySecondCategoryArgument Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D679DEE0 0x20 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D679DF00 0x28 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Model                                     = GetObject<ExtraStorySecondCategoryModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ExtraStorySecondCategoryModel.FromPointer); // 0270D679DF20 0x30 Model                       ( 00018653E140 ModelClassType ExtraStorySecondCategoryModel ExtraStorySecondCategoryModel ExtraStorySecondCategoryModel Pointer )

            return value;
        }
    }
}
