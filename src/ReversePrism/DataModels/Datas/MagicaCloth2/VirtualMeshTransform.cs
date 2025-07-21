using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelEnumType FixedString32Bytes FixedString32Bytes FixedString32Bytes Int32
    // 030 Index                                    ModelPrimitiveType int int int Int32
    // 034 LocalToWorldMatrix                       ModelEnumType float4x4 float4x4 float4x4 Int32
    // 074 WorldToLocalMatrix                       ModelEnumType float4x4 float4x4 float4x4 Int32
    // 0B4 ParentIndex                              ModelPrimitiveType int int int Int32
    public partial class VirtualMeshTransform : DataModel
    {
        public FixedString32Bytes                       Name                                    { get; set; }
        public int                                      Index                                   { get; set; }
        public float4x4                                 LocalToWorldMatrix                      { get; set; }
        public float4x4                                 WorldToLocalMatrix                      { get; set; }
        public int                                      ParentIndex                             { get; set; }

        public static VirtualMeshTransform? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VirtualMeshTransform() { Pointer= p0 };

            value.Name                                      = (FixedString32Bytes)GetInt32(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelEnumType FixedString32Bytes FixedString32Bytes FixedString32Bytes Int32 )
            value.Index                                     = GetInt32(new IntPtr(p + 0x030)); // 0x30 Index                       ( ModelPrimitiveType int int int Int32 )
            value.LocalToWorldMatrix                        = (float4x4)GetInt32(new IntPtr(p + 0x034)); // 0x34 LocalToWorldMatrix          ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.WorldToLocalMatrix                        = (float4x4)GetInt32(new IntPtr(p + 0x074)); // 0x74 WorldToLocalMatrix          ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.ParentIndex                               = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 ParentIndex                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
