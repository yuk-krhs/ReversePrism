using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Ptrs                                   IntPtr IL2CPP_TYPE_PTR
    // 018 M_Length                                 ModelPrimitiveType int int int Int32
    public partial class MeshDataArray : DataModel
    {
        public int                                      M_Length                                { get; set; }

        public static MeshDataArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshDataArray() { Pointer= p0 };

            value.M_Length                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Length                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
