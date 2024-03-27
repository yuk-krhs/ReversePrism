using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018659F780 ModelClassType ILoadingView ILoadingView ILoadingView Pointer
    // 018 CommonLoadingContentPresenter            0001865E6B70 ModelClassType CommonLoadingContentPresenter CommonLoadingContentPresenter CommonLoadingContentPresenter Pointer
    // 020 SimpleFadeLoadingContentPresenter        00018650AED0 ModelClassType SimpleFadeLoadingContentPresenter SimpleFadeLoadingContentPresenter SimpleFadeLoadingContentPresenter Pointer
    // 028 SpecialLoadingContentPresenter           0001865409C0 ModelClassType SpecialLoadingContentPresenter SpecialLoadingContentPresenter SpecialLoadingContentPresenter Pointer
    // 030 CurrentLoadingViewType                   0001865A0B10 ModelEnumType LoadingViewType LoadingViewType LoadingViewType Int32
    // 034 ExistingCounter                          0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LoadingPresenter
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
            var value   = new LoadingPresenter();

            value.View                                      = GetObject<ILoadingView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILoadingView.FromPointer); // 027003A595A8 0x10 View                        ( 00018659F780 ModelClassType ILoadingView ILoadingView ILoadingView Pointer )
            value.CommonLoadingContentPresenter             = GetObject<CommonLoadingContentPresenter>(new IntPtr(p + 0x018), ReversePrism.DataModels.CommonLoadingContentPresenter.FromPointer); // 027003A595C8 0x18 CommonLoadingContentPresenter ( 0001865E6B70 ModelClassType CommonLoadingContentPresenter CommonLoadingContentPresenter CommonLoadingContentPresenter Pointer )
            value.SimpleFadeLoadingContentPresenter         = GetObject<SimpleFadeLoadingContentPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.SimpleFadeLoadingContentPresenter.FromPointer); // 027003A595E8 0x20 SimpleFadeLoadingContentPresenter ( 00018650AED0 ModelClassType SimpleFadeLoadingContentPresenter SimpleFadeLoadingContentPresenter SimpleFadeLoadingContentPresenter Pointer )
            value.SpecialLoadingContentPresenter            = GetObject<SpecialLoadingContentPresenter>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpecialLoadingContentPresenter.FromPointer); // 027003A59608 0x28 SpecialLoadingContentPresenter ( 0001865409C0 ModelClassType SpecialLoadingContentPresenter SpecialLoadingContentPresenter SpecialLoadingContentPresenter Pointer )
            value.CurrentLoadingViewType                    = (LoadingViewType)GetInt32(new IntPtr(p + 0x030)); // 027003A59628 0x30 CurrentLoadingViewType      ( 0001865A0B10 ModelEnumType LoadingViewType LoadingViewType LoadingViewType Int32 )
            value.ExistingCounter                           = GetInt32(new IntPtr(p + 0x034)); // 027003A59648 0x34 ExistingCounter             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
