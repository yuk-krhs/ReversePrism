using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kLog2MaxMemoryBlockSize                  int IL2CPP_TYPE_I4
    // 000 kMaxMemoryBlockSize                      long IL2CPP_TYPE_I8
    // 000 kMinMemoryBlockSize                      long IL2CPP_TYPE_I8
    // 000 kMaxNumBlocks                            int IL2CPP_TYPE_I4
    // 000 kBlockBusyRewindMask                     int IL2CPP_TYPE_I4
    // 000 kBlockBusyAllocateMask                   int IL2CPP_TYPE_I4
    // 010 M_spinner                                00018654D4B0 ModelEnumType Spinner Spinner Spinner Int32
    // 014 M_handle                                 0001866991F0 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32
    // 018 m_block                                  UnmanagedArray`1<MemoryBlock> IL2CPP_TYPE_GENERICINST
    // 028 M_last                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C M_used                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 M_enableBlockFree                        00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 031 M_reachMaxBlockSize                      00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class RewindableAllocator
    {
        public Spinner                                  M_spinner                               { get; set; }
        public AllocatorHandle                          M_handle                                { get; set; }
        public int                                      M_last                                  { get; set; }
        public int                                      M_used                                  { get; set; }
        public sbyte                                    M_enableBlockFree                       { get; set; }
        public sbyte                                    M_reachMaxBlockSize                     { get; set; }

        public static RewindableAllocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RewindableAllocator();

            value.M_spinner                                 = (Spinner)GetInt32(new IntPtr(p + 0x010)); // 027003562B88 0x10 M_spinner                   ( 00018654D4B0 ModelEnumType Spinner Spinner Spinner Int32 )
            value.M_handle                                  = (AllocatorHandle)GetInt32(new IntPtr(p + 0x014)); // 027003562BA8 0x14 M_handle                    ( 0001866991F0 ModelEnumType AllocatorHandle AllocatorHandle AllocatorHandle Int32 )
            value.M_last                                    = GetInt32(new IntPtr(p + 0x028)); // 027003562BE8 0x28 M_last                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_used                                    = GetInt32(new IntPtr(p + 0x02C)); // 027003562C08 0x2C M_used                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_enableBlockFree                         = GetSByte(new IntPtr(p + 0x030)); // 027003562C28 0x30 M_enableBlockFree           ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_reachMaxBlockSize                       = GetSByte(new IntPtr(p + 0x031)); // 027003562C48 0x31 M_reachMaxBlockSize         ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
