using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultTailSpaceSize                     int IL2CPP_TYPE_I4
    // 000 Native                                   NativeMethods IL2CPP_TYPE_CLASS
    // 008 Logger                                   ILogger IL2CPP_TYPE_CLASS
    // 010 NullInstance                             ModelClassType SliceBufferSafeHandle SliceBufferSafeHandle SliceBufferSafeHandle Pointer
    // 020 tailSpacePtr                             <int> IL2CPP_TYPE_I
    // 028 TailSpaceLen                             ModelPrimitiveType int int int Int32
    // 030 MemoryManagerLazy                        ModelClassType SliceMemoryManager SliceMemoryManager SliceMemoryManager Pointer
    public partial class SliceBufferSafeHandle : DataModel
    {
        public SliceBufferSafeHandle?                   NullInstance                            { get; set; }
        public int                                      TailSpaceLen                            { get; set; }
        public SliceMemoryManager?                      MemoryManagerLazy                       { get; set; }

        public static SliceBufferSafeHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SliceBufferSafeHandle() { Pointer= p0 };

            value.NullInstance                              = GetObject<SliceBufferSafeHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.SliceBufferSafeHandle.FromPointer); // 0x10 NullInstance                ( ModelClassType SliceBufferSafeHandle SliceBufferSafeHandle SliceBufferSafeHandle Pointer )
            value.TailSpaceLen                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 TailSpaceLen                ( ModelPrimitiveType int int int Int32 )
            value.MemoryManagerLazy                         = GetObject<SliceMemoryManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.SliceMemoryManager.FromPointer); // 0x30 MemoryManagerLazy           ( ModelClassType SliceMemoryManager SliceMemoryManager SliceMemoryManager Pointer )

            return value;
        }
    }
}
