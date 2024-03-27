using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Ptr                                    <int> IL2CPP_TYPE_I
    // 018 M_Version                                0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class AsyncGPUReadbackRequest
    {
        public int                                      M_Version                               { get; set; }

        public static AsyncGPUReadbackRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncGPUReadbackRequest();

            value.M_Version                                 = GetInt32(new IntPtr(p + 0x018)); // 0270024458B8 0x18 M_Version                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
