using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType ICommonLoadingContentView ICommonLoadingContentView ICommonLoadingContentView Pointer
    // 018 NeedsShowTips                            ModelPrimitiveType bool bool bool Bool
    // 020 LoadTask                                 ModelEnumType UniTask UniTask UniTask Int32
    public partial class CommonLoadingContentPresenter : DataModel
    {
        public ICommonLoadingContentView?               View                                    { get; set; }
        public bool                                     NeedsShowTips                           { get; set; }
        public UniTask                                  LoadTask                                { get; set; }

        public static CommonLoadingContentPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonLoadingContentPresenter() { Pointer= p0 };

            value.View                                      = GetObject<ICommonLoadingContentView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICommonLoadingContentView.FromPointer); // 0x10 View                        ( ModelClassType ICommonLoadingContentView ICommonLoadingContentView ICommonLoadingContentView Pointer )
            value.NeedsShowTips                             = GetBool(new IntPtr(p + 0x018)); // 0x18 NeedsShowTips               ( ModelPrimitiveType bool bool bool Bool )
            value.LoadTask                                  = (UniTask)GetInt32(new IntPtr(p + 0x020)); // 0x20 LoadTask                    ( ModelEnumType UniTask UniTask UniTask Int32 )

            return value;
        }
    }
}
