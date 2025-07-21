using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Values                                 ModelEnumListType List`1<StylePropertyValue> List`1<StylePropertyValue> List<StylePropertyValue> Pointer
    public partial class StylePropertyValueMatcher : DataModel
    {
        public List<StylePropertyValue>?                M_Values                                { get; set; }

        public static StylePropertyValueMatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StylePropertyValueMatcher() { Pointer= p0 };

            value.M_Values                                  = GetEnumList<StylePropertyValue>(new IntPtr(p + 0x020)); // 0x20 M_Values                    ( ModelEnumListType List`1<StylePropertyValue> List`1<StylePropertyValue> List<StylePropertyValue> Pointer )

            return value;
        }
    }
}
