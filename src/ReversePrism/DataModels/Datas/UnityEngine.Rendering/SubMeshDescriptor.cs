using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bounds                                   ModelEnumType Bounds Bounds Bounds Int32
    // 028 Topology                                 ModelEnumType MeshTopology MeshTopology MeshTopology Int32
    // 02C IndexStart                               ModelPrimitiveType int int int Int32
    // 030 IndexCount                               ModelPrimitiveType int int int Int32
    // 034 BaseVertex                               ModelPrimitiveType int int int Int32
    // 038 FirstVertex                              ModelPrimitiveType int int int Int32
    // 03C VertexCount                              ModelPrimitiveType int int int Int32
    public partial class SubMeshDescriptor : DataModel
    {
        public Bounds                                   Bounds                                  { get; set; }
        public MeshTopology                             Topology                                { get; set; }
        public int                                      IndexStart                              { get; set; }
        public int                                      IndexCount                              { get; set; }
        public int                                      BaseVertex                              { get; set; }
        public int                                      FirstVertex                             { get; set; }
        public int                                      VertexCount                             { get; set; }

        public static SubMeshDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubMeshDescriptor() { Pointer= p0 };

            value.Bounds                                    = (Bounds)GetInt32(new IntPtr(p + 0x010)); // 0x10 Bounds                      ( ModelEnumType Bounds Bounds Bounds Int32 )
            value.Topology                                  = (MeshTopology)GetInt32(new IntPtr(p + 0x028)); // 0x28 Topology                    ( ModelEnumType MeshTopology MeshTopology MeshTopology Int32 )
            value.IndexStart                                = GetInt32(new IntPtr(p + 0x02C)); // 0x2C IndexStart                  ( ModelPrimitiveType int int int Int32 )
            value.IndexCount                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 IndexCount                  ( ModelPrimitiveType int int int Int32 )
            value.BaseVertex                                = GetInt32(new IntPtr(p + 0x034)); // 0x34 BaseVertex                  ( ModelPrimitiveType int int int Int32 )
            value.FirstVertex                               = GetInt32(new IntPtr(p + 0x038)); // 0x38 FirstVertex                 ( ModelPrimitiveType int int int Int32 )
            value.VertexCount                               = GetInt32(new IntPtr(p + 0x03C)); // 0x3C VertexCount                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
