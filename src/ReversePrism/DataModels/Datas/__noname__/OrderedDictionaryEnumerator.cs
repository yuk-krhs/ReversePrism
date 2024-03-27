using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectReturnType                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 ArrayEnumerator                          00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer
    public partial class OrderedDictionaryEnumerator
    {
        public int                                      ObjectReturnType                        { get; set; }
        public IEnumerator?                             ArrayEnumerator                         { get; set; }

        public static OrderedDictionaryEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OrderedDictionaryEnumerator();

            value.ObjectReturnType                          = GetInt32(new IntPtr(p + 0x010)); // 0270D7B6AB08 0x10 ObjectReturnType            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ArrayEnumerator                           = GetObject<IEnumerator>(new IntPtr(p + 0x018), ReversePrism.DataModels.IEnumerator.FromPointer); // 0270D7B6AB28 0x18 ArrayEnumerator             ( 00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer )

            return value;
        }
    }
}
