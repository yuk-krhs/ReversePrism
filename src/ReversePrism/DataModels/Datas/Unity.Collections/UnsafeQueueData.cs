using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_FirstBlock                             <int> IL2CPP_TYPE_I
    // 018 m_LastBlock                              <int> IL2CPP_TYPE_I
    // 020 M_MaxItems                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 M_CurrentRead                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 m_CurrentWriteBlockTLS                   IntPtr IL2CPP_TYPE_PTR
    public partial class UnsafeQueueData
    {
        public int                                      M_MaxItems                              { get; set; }
        public int                                      M_CurrentRead                           { get; set; }

        public static UnsafeQueueData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeQueueData();

            value.M_MaxItems                                = GetInt32(new IntPtr(p + 0x020)); // 0270D9C60768 0x20 M_MaxItems                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.M_CurrentRead                             = GetInt32(new IntPtr(p + 0x024)); // 0270D9C60788 0x24 M_CurrentRead               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
