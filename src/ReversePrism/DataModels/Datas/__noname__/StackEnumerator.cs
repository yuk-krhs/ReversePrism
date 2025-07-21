using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Stack                                    ModelClassType Stack Stack Stack Pointer
    // 018 Index                                    ModelPrimitiveType int int int Int32
    // 01C Version                                  ModelPrimitiveType int int int Int32
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

            value.Stack                                     = GetObject<Stack>(new IntPtr(p + 0x010), ReversePrism.DataModels.Stack.FromPointer); // 0x10 Stack                       ( ModelClassType Stack Stack Stack Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Index                       ( ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Version                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
