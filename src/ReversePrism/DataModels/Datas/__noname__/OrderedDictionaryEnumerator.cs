using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectReturnType                         ModelPrimitiveType int int int Int32
    // 018 ArrayEnumerator                          ModelClassType IEnumerator IEnumerator IEnumerator Pointer
    public partial class OrderedDictionaryEnumerator : DataModel
    {
        public int                                      ObjectReturnType                        { get; set; }
        public IEnumerator?                             ArrayEnumerator                         { get; set; }

        public static OrderedDictionaryEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OrderedDictionaryEnumerator() { Pointer= p0 };

            value.ObjectReturnType                          = GetInt32(new IntPtr(p + 0x010)); // 0x10 ObjectReturnType            ( ModelPrimitiveType int int int Int32 )
            value.ArrayEnumerator                           = GetObject<IEnumerator>(new IntPtr(p + 0x018), ReversePrism.DataModels.IEnumerator.FromPointer); // 0x18 ArrayEnumerator             ( ModelClassType IEnumerator IEnumerator IEnumerator Pointer )

            return value;
        }
    }
}
