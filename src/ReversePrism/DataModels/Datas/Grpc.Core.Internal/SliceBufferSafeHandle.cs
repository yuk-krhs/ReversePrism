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
    // 010 NullInstance                             00018651B840 ModelClassType SliceBufferSafeHandle SliceBufferSafeHandle SliceBufferSafeHandle Pointer
    // 020 tailSpacePtr                             <int> IL2CPP_TYPE_I
    // 028 TailSpaceLen                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 MemoryManagerLazy                        00018651BD60 ModelClassType SliceMemoryManager SliceMemoryManager SliceMemoryManager Pointer
    public partial class SliceBufferSafeHandle
    {
        public SliceBufferSafeHandle?                   NullInstance                            { get; set; }
        public int                                      TailSpaceLen                            { get; set; }
        public SliceMemoryManager?                      MemoryManagerLazy                       { get; set; }

        public static SliceBufferSafeHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SliceBufferSafeHandle();

            value.NullInstance                              = GetObject<SliceBufferSafeHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.SliceBufferSafeHandle.FromPointer); // 0270D3040AE8 0x10 NullInstance                ( 00018651B840 ModelClassType SliceBufferSafeHandle SliceBufferSafeHandle SliceBufferSafeHandle Pointer )
            value.TailSpaceLen                              = GetInt32(new IntPtr(p + 0x028)); // 0270D3040B28 0x28 TailSpaceLen                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MemoryManagerLazy                         = GetObject<SliceMemoryManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.SliceMemoryManager.FromPointer); // 0270D3040B48 0x30 MemoryManagerLazy           ( 00018651BD60 ModelClassType SliceMemoryManager SliceMemoryManager SliceMemoryManager Pointer )

            return value;
        }
    }
}
