using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_PackedValues                           uint[] IL2CPP_TYPE_SZARRAY
    // 010 MinLocalIdx                              0001866AD970 ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 01C MaxLocalIdx                              0001866AD970 ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 028 FirstChunkIndex                          0001865F2F90 ModelPrimitiveType int int int Int32
    // 02C MinSubdiv                                0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class IndexMetaData
    {
        public Vector3Int                               MinLocalIdx                             { get; set; }
        public Vector3Int                               MaxLocalIdx                             { get; set; }
        public int                                      FirstChunkIndex                         { get; set; }
        public int                                      MinSubdiv                               { get; set; }

        public static IndexMetaData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IndexMetaData();

            value.MinLocalIdx                               = (Vector3Int)GetInt32(new IntPtr(p + 0x010)); // 0270D91E5320 0x10 MinLocalIdx                 ( 0001866AD970 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.MaxLocalIdx                               = (Vector3Int)GetInt32(new IntPtr(p + 0x01C)); // 0270D91E5340 0x1C MaxLocalIdx                 ( 0001866AD970 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.FirstChunkIndex                           = GetInt32(new IntPtr(p + 0x028)); // 0270D91E5360 0x28 FirstChunkIndex             ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.MinSubdiv                                 = GetInt32(new IntPtr(p + 0x02C)); // 0270D91E5380 0x2C MinSubdiv                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
