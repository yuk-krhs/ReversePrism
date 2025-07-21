using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Q                                        ModelClassType Queue Queue Queue Pointer
    // 018 Index                                    ModelPrimitiveType int int int Int32
    // 01C Version                                  ModelPrimitiveType int int int Int32
    // 020 _currentElement                          <object> IL2CPP_TYPE_OBJECT
    public partial class QueueEnumerator : DataModel
    {
        public Queue?                                   Q                                       { get; set; }
        public int                                      Index                                   { get; set; }
        public int                                      Version                                 { get; set; }

        public static QueueEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueueEnumerator() { Pointer= p0 };

            value.Q                                         = GetObject<Queue>(new IntPtr(p + 0x010), ReversePrism.DataModels.Queue.FromPointer); // 0x10 Q                           ( ModelClassType Queue Queue Queue Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Index                       ( ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Version                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
