using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Objects                                  00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 018 IsKeys                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class OrderedDictionaryKeyValueCollection : DataModel
    {
        public ArrayList?                               Objects                                 { get; set; }
        public bool                                     IsKeys                                  { get; set; }

        public static OrderedDictionaryKeyValueCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OrderedDictionaryKeyValueCollection() { Pointer= p0 };

            value.Objects                                   = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 0245A6007E50 0x10 Objects                     ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.IsKeys                                    = GetBool(new IntPtr(p + 0x018)); // 0245A6007E70 0x18 IsKeys                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
