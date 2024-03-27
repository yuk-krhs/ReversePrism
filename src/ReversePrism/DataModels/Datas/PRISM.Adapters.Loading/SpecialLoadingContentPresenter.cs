using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018664AAA0 ModelClassType ISpecialLoadingContentView ISpecialLoadingContentView ISpecialLoadingContentView Pointer
    // 018 TransitionAnimationType                  0001866ACD70 ModelEnumType TransitionAnimationType TransitionAnimationType TransitionAnimationType Int32
    public partial class SpecialLoadingContentPresenter
    {
        public ISpecialLoadingContentView?              View                                    { get; set; }
        public TransitionAnimationType                  TransitionAnimationType                 { get; set; }

        public static SpecialLoadingContentPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialLoadingContentPresenter();

            value.View                                      = GetObject<ISpecialLoadingContentView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISpecialLoadingContentView.FromPointer); // 027003A5AA08 0x10 View                        ( 00018664AAA0 ModelClassType ISpecialLoadingContentView ISpecialLoadingContentView ISpecialLoadingContentView Pointer )
            value.TransitionAnimationType                   = (TransitionAnimationType)GetInt32(new IntPtr(p + 0x018)); // 027003A5AA28 0x18 TransitionAnimationType     ( 0001866ACD70 ModelEnumType TransitionAnimationType TransitionAnimationType TransitionAnimationType Int32 )

            return value;
        }
    }
}
