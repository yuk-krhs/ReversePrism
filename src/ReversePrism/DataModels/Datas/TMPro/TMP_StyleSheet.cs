using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_StyleList                              000185D12F78 ModelClassListType List`1<TMP_Style> List`1<TMP_Style> List<TMP_Style> Pointer
    // 020 m_StyleLookupDictionary                  Dictionary`2<int, TMP_Style> IL2CPP_TYPE_GENERICINST
    public partial class TMP_StyleSheet
    {
        public List<TMP_Style>?                         M_StyleList                             { get; set; }

        public static TMP_StyleSheet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_StyleSheet();

            value.M_StyleList                               = GetObjectList<TMP_Style>(new IntPtr(p + 0x018), ReversePrism.DataModels.TMP_Style.FromPointer); // 0270D0F81178 0x18 M_StyleList                 ( 000185D12F78 ModelClassListType List`1<TMP_Style> List`1<TMP_Style> List<TMP_Style> Pointer )

            return value;
        }
    }
}
