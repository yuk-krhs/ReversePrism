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
    // 038 Counter                                  ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 040 UiFaderEventCaller                       ModelClassType UIFaderEventCaller UIFaderEventCaller UIFaderEventCaller Pointer
    public partial class LoadingView : DataModel
    {
        public IntReactiveProperty?                     Counter                                 { get; set; }
        public UIFaderEventCaller?                      UiFaderEventCaller                      { get; set; }

        public static LoadingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadingView() { Pointer= p0 };

            value.Counter                                   = GetObject<IntReactiveProperty>(new IntPtr(p + 0x038), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x38 Counter                     ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.UiFaderEventCaller                        = GetObject<UIFaderEventCaller>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIFaderEventCaller.FromPointer); // 0x40 UiFaderEventCaller          ( ModelClassType UIFaderEventCaller UIFaderEventCaller UIFaderEventCaller Pointer )

            return value;
        }
    }
}
