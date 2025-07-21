using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Offset                                   ModelPrimitiveType int int int Int32
    // 018 positionList                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 028 attributeList                            NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 038 AttributeMapWidth                        ModelPrimitiveType int int int Int32
    // 03C ToM                                      ModelEnumType float4x4 float4x4 float4x4 Int32
    // 07C XySize                                   ModelEnumType int2 int2 int2 Int32
    // 084 AttributeReadFlag                        ModelEnumType ExBitFlag8 ExBitFlag8 ExBitFlag8 Int32
    // 088 attributeMapData                         NativeArray`1<Color32> IL2CPP_TYPE_GENERICINST
    // 098 uvs                                      NativeArray`1<float2> IL2CPP_TYPE_GENERICINST
    // 0A8 vertexs                                  NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    public partial class GenerateSelectionJob : DataModel
    {
        public int                                      Offset                                  { get; set; }
        public int                                      AttributeMapWidth                       { get; set; }
        public float4x4                                 ToM                                     { get; set; }
        public int2                                     XySize                                  { get; set; }
        public ExBitFlag8                               AttributeReadFlag                       { get; set; }

        public static GenerateSelectionJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GenerateSelectionJob() { Pointer= p0 };

            value.Offset                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Offset                      ( ModelPrimitiveType int int int Int32 )
            value.AttributeMapWidth                         = GetInt32(new IntPtr(p + 0x038)); // 0x38 AttributeMapWidth           ( ModelPrimitiveType int int int Int32 )
            value.ToM                                       = (float4x4)GetInt32(new IntPtr(p + 0x03C)); // 0x3C ToM                         ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.XySize                                    = (int2)GetInt32(new IntPtr(p + 0x07C)); // 0x7C XySize                      ( ModelEnumType int2 int2 int2 Int32 )
            value.AttributeReadFlag                         = (ExBitFlag8)GetInt32(new IntPtr(p + 0x084)); // 0x84 AttributeReadFlag           ( ModelEnumType ExBitFlag8 ExBitFlag8 ExBitFlag8 Int32 )

            return value;
        }
    }
}
