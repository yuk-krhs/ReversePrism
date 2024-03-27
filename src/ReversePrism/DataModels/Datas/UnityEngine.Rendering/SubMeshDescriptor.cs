using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bounds                                   0001865993A0 ModelEnumType Bounds Bounds Bounds Int32
    // 028 Topology                                 000186604640 ModelEnumType MeshTopology MeshTopology MeshTopology Int32
    // 02C IndexStart                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 IndexCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 BaseVertex                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 FirstVertex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C VertexCount                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SubMeshDescriptor
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
            var value   = new SubMeshDescriptor();

            value.Bounds                                    = (Bounds)GetInt32(new IntPtr(p + 0x010)); // 0270068C93E8 0x10 Bounds                      ( 0001865993A0 ModelEnumType Bounds Bounds Bounds Int32 )
            value.Topology                                  = (MeshTopology)GetInt32(new IntPtr(p + 0x028)); // 0270068C9408 0x28 Topology                    ( 000186604640 ModelEnumType MeshTopology MeshTopology MeshTopology Int32 )
            value.IndexStart                                = GetInt32(new IntPtr(p + 0x02C)); // 0270068C9428 0x2C IndexStart                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IndexCount                                = GetInt32(new IntPtr(p + 0x030)); // 0270068C9448 0x30 IndexCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BaseVertex                                = GetInt32(new IntPtr(p + 0x034)); // 0270068C9468 0x34 BaseVertex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FirstVertex                               = GetInt32(new IntPtr(p + 0x038)); // 0270068C9488 0x38 FirstVertex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VertexCount                               = GetInt32(new IntPtr(p + 0x03C)); // 0270068C94A8 0x3C VertexCount                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
