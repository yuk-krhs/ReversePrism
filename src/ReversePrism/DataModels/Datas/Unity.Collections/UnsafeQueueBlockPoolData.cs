using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_FirstBlock                             <int> IL2CPP_TYPE_I
    // 018 M_NumBlocks                              0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C M_MaxBlocks                              0001865F2F90 ModelPrimitiveType int int int Int32
    // 000 m_BlockSize                              int IL2CPP_TYPE_I4
    // 020 M_AllocLock                              0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class UnsafeQueueBlockPoolData
    {
        public int                                      M_NumBlocks                             { get; set; }
        public int                                      M_MaxBlocks                             { get; set; }
        public int                                      M_AllocLock                             { get; set; }

        public static UnsafeQueueBlockPoolData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeQueueBlockPoolData();

            value.M_NumBlocks                               = GetInt32(new IntPtr(p + 0x018)); // 0270D9C603D0 0x18 M_NumBlocks                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_MaxBlocks                               = GetInt32(new IntPtr(p + 0x01C)); // 0270D9C603F0 0x1C M_MaxBlocks                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_AllocLock                               = GetInt32(new IntPtr(p + 0x020)); // 0270D9C60430 0x20 M_AllocLock                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
