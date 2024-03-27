using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 commonLoadingContentBuilder              SerializableInterface`1<ICommonLoadingContentBuilder> IL2CPP_TYPE_GENERICINST
    // 028 simpleFadeLoadingContentBuilder          SerializableInterface`1<ISimpleFadeLoadingContentBuilder> IL2CPP_TYPE_GENERICINST
    // 030 specialAnimationLoadingContentBuilder    SerializableInterface`1<ISpecialLoadingContentBuilder> IL2CPP_TYPE_GENERICINST
    // 038 Counter                                  000186714310 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 040 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 048 UiFaderEventCaller                       0001866E7890 ModelClassType UIFaderEventCaller UIFaderEventCaller UIFaderEventCaller Pointer
    public partial class LoadingView
    {
        public IntReactiveProperty?                     Counter                                 { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public UIFaderEventCaller?                      UiFaderEventCaller                      { get; set; }

        public static LoadingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadingView();

            value.Counter                                   = GetObject<IntReactiveProperty>(new IntPtr(p + 0x038), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 027001E9C3E0 0x38 Counter                     ( 000186714310 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x040), ReversePrism.DataModels.IResourceTag.FromPointer); // 027001E9C400 0x40 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.UiFaderEventCaller                        = GetObject<UIFaderEventCaller>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIFaderEventCaller.FromPointer); // 027001E9C420 0x48 UiFaderEventCaller          ( 0001866E7890 ModelClassType UIFaderEventCaller UIFaderEventCaller UIFaderEventCaller Pointer )

            return value;
        }
    }
}
