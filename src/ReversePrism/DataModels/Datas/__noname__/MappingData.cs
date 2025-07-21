using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TeamId                                   ModelPrimitiveType int int int Int32
    // 014 CenterTransformIndex                     ModelPrimitiveType int int int Int32
    // 018 MappingCommonChunk                       ModelEnumType DataChunk DataChunk DataChunk Int32
    // 020 ToProxyMatrix                            ModelEnumType float4x4 float4x4 float4x4 Int32
    // 060 ToProxyRotation                          ModelEnumType quaternion quaternion quaternion Int32
    // 070 SameSpace                                ModelPrimitiveType bool bool bool Bool
    // 074 ToMappingMatrix                          ModelEnumType float4x4 float4x4 float4x4 Int32
    // 0B4 ToMappingRotation                        ModelEnumType quaternion quaternion quaternion Int32
    // 0C4 ScaleRatio                               ModelPrimitiveType float float float Single
    public partial class MappingData : DataModel
    {
        public int                                      TeamId                                  { get; set; }
        public int                                      CenterTransformIndex                    { get; set; }
        public DataChunk                                MappingCommonChunk                      { get; set; }
        public float4x4                                 ToProxyMatrix                           { get; set; }
        public quaternion                               ToProxyRotation                         { get; set; }
        public bool                                     SameSpace                               { get; set; }
        public float4x4                                 ToMappingMatrix                         { get; set; }
        public quaternion                               ToMappingRotation                       { get; set; }
        public float                                    ScaleRatio                              { get; set; }

        public static MappingData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MappingData() { Pointer= p0 };

            value.TeamId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 TeamId                      ( ModelPrimitiveType int int int Int32 )
            value.CenterTransformIndex                      = GetInt32(new IntPtr(p + 0x014)); // 0x14 CenterTransformIndex        ( ModelPrimitiveType int int int Int32 )
            value.MappingCommonChunk                        = (DataChunk)GetInt32(new IntPtr(p + 0x018)); // 0x18 MappingCommonChunk          ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.ToProxyMatrix                             = (float4x4)GetInt32(new IntPtr(p + 0x020)); // 0x20 ToProxyMatrix               ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.ToProxyRotation                           = (quaternion)GetInt32(new IntPtr(p + 0x060)); // 0x60 ToProxyRotation             ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.SameSpace                                 = GetBool(new IntPtr(p + 0x070)); // 0x70 SameSpace                   ( ModelPrimitiveType bool bool bool Bool )
            value.ToMappingMatrix                           = (float4x4)GetInt32(new IntPtr(p + 0x074)); // 0x74 ToMappingMatrix             ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.ToMappingRotation                         = (quaternion)GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 ToMappingRotation           ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.ScaleRatio                                = GetSingle(new IntPtr(p + 0x0C4)); // 0xC4 ScaleRatio                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
