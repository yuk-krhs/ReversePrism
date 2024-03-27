using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PropertiesList                           000185D0E0E8 ModelEnumListType List`1<StylePropertyName> List`1<StylePropertyName> List<StylePropertyName> Pointer
    public partial class StylePropertyNameCollection
    {
        public List<StylePropertyName>?                 PropertiesList                          { get; set; }

        public static StylePropertyNameCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StylePropertyNameCollection();

            value.PropertiesList                            = GetEnumList<StylePropertyName>(new IntPtr(p + 0x010)); // 0270067D3070 0x10 PropertiesList              ( 000185D0E0E8 ModelEnumListType List`1<StylePropertyName> List`1<StylePropertyName> List<StylePropertyName> Pointer )

            return value;
        }
    }
}
