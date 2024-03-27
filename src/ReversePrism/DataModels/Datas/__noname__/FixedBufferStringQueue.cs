using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_ReadCursor                             IntPtr IL2CPP_TYPE_PTR
    // 018 m_WriteCursor                            IntPtr IL2CPP_TYPE_PTR
    // 020 m_BufferEnd                              IntPtr IL2CPP_TYPE_PTR
    // 028 m_BufferStart                            IntPtr IL2CPP_TYPE_PTR
    // 030 M_BufferLength                           0001865F4260 ModelPrimitiveType int int int Int32
    // 034 Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class FixedBufferStringQueue
    {
        public int                                      M_BufferLength                          { get; set; }
        public int                                      Count                                   { get; set; }

        public static FixedBufferStringQueue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedBufferStringQueue();

            value.M_BufferLength                            = GetInt32(new IntPtr(p + 0x030)); // 0270D90FD978 0x30 M_BufferLength              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x034)); // 0270D90FD998 0x34 Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
