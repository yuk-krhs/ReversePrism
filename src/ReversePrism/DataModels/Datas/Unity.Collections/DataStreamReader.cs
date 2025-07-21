using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_BufferPtr                              IntPtr IL2CPP_TYPE_PTR
    // 018 M_Context                                ModelEnumType Context Context Context Int32
    // 030 M_Length                                 ModelPrimitiveType int int int Int32
    public partial class DataStreamReader : DataModel
    {
        public Context                                  M_Context                               { get; set; }
        public int                                      M_Length                                { get; set; }

        public static DataStreamReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataStreamReader() { Pointer= p0 };

            value.M_Context                                 = (Context)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Context                   ( ModelEnumType Context Context Context Int32 )
            value.M_Length                                  = GetInt32(new IntPtr(p + 0x030)); // 0x30 M_Length                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
