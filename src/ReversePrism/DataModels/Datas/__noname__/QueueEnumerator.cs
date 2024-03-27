using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Q                                        0001865FFF70 ModelClassType Queue Queue Queue Pointer
    // 018 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 _currentElement                          <object> IL2CPP_TYPE_OBJECT
    public partial class QueueEnumerator
    {
        public Queue?                                   Q                                       { get; set; }
        public int                                      Index                                   { get; set; }
        public int                                      Version                                 { get; set; }

        public static QueueEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueueEnumerator();

            value.Q                                         = GetObject<Queue>(new IntPtr(p + 0x010), ReversePrism.DataModels.Queue.FromPointer); // 0270D6D3FA50 0x10 Q                           ( 0001865FFF70 ModelClassType Queue Queue Queue Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D6D3FA70 0x18 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x01C)); // 0270D6D3FA90 0x1C Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
