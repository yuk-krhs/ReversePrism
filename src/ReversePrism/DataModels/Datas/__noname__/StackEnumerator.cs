using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Stack                                    00018655EBF0 ModelClassType Stack Stack Stack Pointer
    // 018 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 _currentElement                          <object> IL2CPP_TYPE_OBJECT
    public partial class StackEnumerator : DataModel
    {
        public Stack?                                   Stack                                   { get; set; }
        public int                                      Index                                   { get; set; }
        public int                                      Version                                 { get; set; }

        public static StackEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StackEnumerator() { Pointer= p0 };

            value.Stack                                     = GetObject<Stack>(new IntPtr(p + 0x010), ReversePrism.DataModels.Stack.FromPointer); // 024666DD32B8 0x10 Stack                       ( 00018655EBF0 ModelClassType Stack Stack Stack Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 024666DD32D8 0x18 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x01C)); // 024666DD32F8 0x1C Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
