using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_StyleList                              000185D13A78 ModelClassListType List`1<TextStyle> List`1<TextStyle> List<TextStyle> Pointer
    // 020 m_StyleLookupDictionary                  Dictionary`2<int, TextStyle> IL2CPP_TYPE_GENERICINST
    public partial class TextStyleSheet : DataModel
    {
        public List<TextStyle>?                         M_StyleList                             { get; set; }

        public static TextStyleSheet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextStyleSheet() { Pointer= p0 };

            value.M_StyleList                               = GetObjectList<TextStyle>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextStyle.FromPointer); // 0245A68BEEC0 0x18 M_StyleList                 ( 000185D13A78 ModelClassListType List`1<TextStyle> List`1<TextStyle> List<TextStyle> Pointer )

            return value;
        }
    }
}
