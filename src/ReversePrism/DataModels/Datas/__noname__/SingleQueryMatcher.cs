using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Match                                    ModelClassType VisualElement VisualElement VisualElement Pointer
    public partial class SingleQueryMatcher : DataModel
    {
        public VisualElement?                           Match                                   { get; set; }

        public static SingleQueryMatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SingleQueryMatcher() { Pointer= p0 };

            value.Match                                     = GetObject<VisualElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.VisualElement.FromPointer); // 0x18 Match                       ( ModelClassType VisualElement VisualElement VisualElement Pointer )

            return value;
        }
    }
}
