using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 threadLocalInstance                      ThreadLocal`1<DefaultSerializationContext> IL2CPP_TYPE_GENERICINST
    // 010 IsComplete                               ModelPrimitiveType bool bool bool Bool
    // 018 SliceBuffer                              ModelClassType SliceBufferSafeHandle SliceBufferSafeHandle SliceBufferSafeHandle Pointer
    public partial class DefaultSerializationContext : DataModel
    {
        public bool                                     IsComplete                              { get; set; }
        public SliceBufferSafeHandle?                   SliceBuffer                             { get; set; }

        public static DefaultSerializationContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultSerializationContext() { Pointer= p0 };

            value.IsComplete                                = GetBool(new IntPtr(p + 0x010)); // 0x10 IsComplete                  ( ModelPrimitiveType bool bool bool Bool )
            value.SliceBuffer                               = GetObject<SliceBufferSafeHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.SliceBufferSafeHandle.FromPointer); // 0x18 SliceBuffer                 ( ModelClassType SliceBufferSafeHandle SliceBufferSafeHandle SliceBufferSafeHandle Pointer )

            return value;
        }
    }
}
