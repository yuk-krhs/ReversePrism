using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OldVertexCount                           ModelPrimitiveType int int int Int32
    // 018 joinIndices                              NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 028 vertexRemapIndices                       NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class Organize_RemapVertexJob : DataModel
    {
        public int                                      OldVertexCount                          { get; set; }

        public static Organize_RemapVertexJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Organize_RemapVertexJob() { Pointer= p0 };

            value.OldVertexCount                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 OldVertexCount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
