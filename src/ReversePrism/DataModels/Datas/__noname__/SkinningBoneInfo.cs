using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartTransformIndex                      ModelPrimitiveType int int int Int32
    // 014 StartPos                                 ModelEnumType float3 float3 float3 Int32
    // 020 EndTransformIndex                        ModelPrimitiveType int int int Int32
    // 024 EndPos                                   ModelEnumType float3 float3 float3 Int32
    public partial class SkinningBoneInfo : DataModel
    {
        public int                                      StartTransformIndex                     { get; set; }
        public float3                                   StartPos                                { get; set; }
        public int                                      EndTransformIndex                       { get; set; }
        public float3                                   EndPos                                  { get; set; }

        public static SkinningBoneInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkinningBoneInfo() { Pointer= p0 };

            value.StartTransformIndex                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 StartTransformIndex         ( ModelPrimitiveType int int int Int32 )
            value.StartPos                                  = (float3)GetInt32(new IntPtr(p + 0x014)); // 0x14 StartPos                    ( ModelEnumType float3 float3 float3 Int32 )
            value.EndTransformIndex                         = GetInt32(new IntPtr(p + 0x020)); // 0x20 EndTransformIndex           ( ModelPrimitiveType int int int Int32 )
            value.EndPos                                    = (float3)GetInt32(new IntPtr(p + 0x024)); // 0x24 EndPos                      ( ModelEnumType float3 float3 float3 Int32 )

            return value;
        }
    }
}
