using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 vertices                                 <int> IL2CPP_TYPE_I
    // 018 indices                                  <int> IL2CPP_TYPE_I
    // 020 VertexCount                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 IndexCount                               0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class MeshWriteDataInterface
    {
        public int                                      VertexCount                             { get; set; }
        public int                                      IndexCount                              { get; set; }

        public static MeshWriteDataInterface? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshWriteDataInterface();

            value.VertexCount                               = GetInt32(new IntPtr(p + 0x020)); // 0270067DE4D8 0x20 VertexCount                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IndexCount                                = GetInt32(new IntPtr(p + 0x024)); // 0270067DE4F8 0x24 IndexCount                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
