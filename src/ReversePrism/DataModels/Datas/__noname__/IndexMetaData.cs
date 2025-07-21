using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_PackedValues                           uint[] IL2CPP_TYPE_SZARRAY
    // 010 MinLocalIdx                              ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 01C MaxLocalIdx                              ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 028 FirstChunkIndex                          ModelPrimitiveType int int int Int32
    // 02C MinSubdiv                                ModelPrimitiveType int int int Int32
    public partial class IndexMetaData : DataModel
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
            var value   = new IndexMetaData() { Pointer= p0 };

            value.MinLocalIdx                               = (Vector3Int)GetInt32(new IntPtr(p + 0x010)); // 0x10 MinLocalIdx                 ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.MaxLocalIdx                               = (Vector3Int)GetInt32(new IntPtr(p + 0x01C)); // 0x1C MaxLocalIdx                 ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.FirstChunkIndex                           = GetInt32(new IntPtr(p + 0x028)); // 0x28 FirstChunkIndex             ( ModelPrimitiveType int int int Int32 )
            value.MinSubdiv                                 = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MinSubdiv                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
