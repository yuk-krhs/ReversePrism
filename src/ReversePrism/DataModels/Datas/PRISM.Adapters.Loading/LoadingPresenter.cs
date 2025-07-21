using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType ILoadingView ILoadingView ILoadingView Pointer
    // 018 CommonLoadingContentPresenter            ModelClassType CommonLoadingContentPresenter CommonLoadingContentPresenter CommonLoadingContentPresenter Pointer
    // 020 SimpleFadeLoadingContentPresenter        ModelClassType SimpleFadeLoadingContentPresenter SimpleFadeLoadingContentPresenter SimpleFadeLoadingContentPresenter Pointer
    // 028 SpecialLoadingContentPresenter           ModelClassType SpecialLoadingContentPresenter SpecialLoadingContentPresenter SpecialLoadingContentPresenter Pointer
    // 030 CurrentLoadingViewType                   ModelEnumType LoadingViewType LoadingViewType LoadingViewType Int32
    // 034 ExistingCounter                          ModelPrimitiveType int int int Int32
    public partial class LoadingPresenter : DataModel
    {
        public ILoadingView?                            View                                    { get; set; }
        public CommonLoadingContentPresenter?           CommonLoadingContentPresenter           { get; set; }
        public SimpleFadeLoadingContentPresenter?       SimpleFadeLoadingContentPresenter       { get; set; }
        public SpecialLoadingContentPresenter?          SpecialLoadingContentPresenter          { get; set; }
        public LoadingViewType                          CurrentLoadingViewType                  { get; set; }
        public int                                      ExistingCounter                         { get; set; }

        public static LoadingPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadingPresenter() { Pointer= p0 };

            value.View                                      = GetObject<ILoadingView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILoadingView.FromPointer); // 0x10 View                        ( ModelClassType ILoadingView ILoadingView ILoadingView Pointer )
            value.CommonLoadingContentPresenter             = GetObject<CommonLoadingContentPresenter>(new IntPtr(p + 0x018), ReversePrism.DataModels.CommonLoadingContentPresenter.FromPointer); // 0x18 CommonLoadingContentPresenter ( ModelClassType CommonLoadingContentPresenter CommonLoadingContentPresenter CommonLoadingContentPresenter Pointer )
            value.SimpleFadeLoadingContentPresenter         = GetObject<SimpleFadeLoadingContentPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.SimpleFadeLoadingContentPresenter.FromPointer); // 0x20 SimpleFadeLoadingContentPresenter ( ModelClassType SimpleFadeLoadingContentPresenter SimpleFadeLoadingContentPresenter SimpleFadeLoadingContentPresenter Pointer )
            value.SpecialLoadingContentPresenter            = GetObject<SpecialLoadingContentPresenter>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpecialLoadingContentPresenter.FromPointer); // 0x28 SpecialLoadingContentPresenter ( ModelClassType SpecialLoadingContentPresenter SpecialLoadingContentPresenter SpecialLoadingContentPresenter Pointer )
            value.CurrentLoadingViewType                    = (LoadingViewType)GetInt32(new IntPtr(p + 0x030)); // 0x30 CurrentLoadingViewType      ( ModelEnumType LoadingViewType LoadingViewType LoadingViewType Int32 )
            value.ExistingCounter                           = GetInt32(new IntPtr(p + 0x034)); // 0x34 ExistingCounter             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
