using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Values                                 000185D0F0B8 ModelEnumListType List`1<StyleValue> List`1<StyleValue> List<StyleValue> Pointer
    public partial class StyleValueCollection : DataModel
    {
        public List<StyleValue>?                        M_Values                                { get; set; }

        public static StyleValueCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleValueCollection() { Pointer= p0 };

            value.M_Values                                  = GetEnumList<StyleValue>(new IntPtr(p + 0x010)); // 0245A67AEFA0 0x10 M_Values                    ( 000185D0F0B8 ModelEnumListType List`1<StyleValue> List`1<StyleValue> List<StyleValue> Pointer )

            return value;
        }
    }
}
