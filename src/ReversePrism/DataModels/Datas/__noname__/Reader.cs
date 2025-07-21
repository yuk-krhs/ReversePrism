using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BlockData                              ModelEnumType Block Block Block Int32
    // 030 m_CurrentBlock                           IntPtr IL2CPP_TYPE_PTR
    // 038 m_CurrentPtr                             IntPtr IL2CPP_TYPE_PTR
    // 040 m_CurrentBlockEnd                        IntPtr IL2CPP_TYPE_PTR
    // 048 M_RemainingItemCount                     ModelPrimitiveType int int int Int32
    // 04C M_LastBlockSize                          ModelPrimitiveType int int int Int32
    public partial class Reader : DataModel
    {
        public Block                                    M_BlockData                             { get; set; }
        public int                                      M_RemainingItemCount                    { get; set; }
        public int                                      M_LastBlockSize                         { get; set; }

        public static Reader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Reader() { Pointer= p0 };

            value.M_BlockData                               = (Block)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_BlockData                 ( ModelEnumType Block Block Block Int32 )
            value.M_RemainingItemCount                      = GetInt32(new IntPtr(p + 0x048)); // 0x48 M_RemainingItemCount        ( ModelPrimitiveType int int int Int32 )
            value.M_LastBlockSize                           = GetInt32(new IntPtr(p + 0x04C)); // 0x4C M_LastBlockSize             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
