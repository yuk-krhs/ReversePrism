using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType VirtualMeshPrimitive VirtualMeshPrimitive VirtualMeshPrimitive Int32
    // 014 Index                                    ModelPrimitiveType int int int Int32
    // 018 Position                                 ModelEnumType float3 float3 float3 Int32
    // 024 Normal                                   ModelEnumType float3 float3 float3 Int32
    // 030 Distance                                 ModelPrimitiveType float float float Single
    public partial class VirtualMeshRaycastHit : DataModel
    {
        public VirtualMeshPrimitive                     Type                                    { get; set; }
        public int                                      Index                                   { get; set; }
        public float3                                   Position                                { get; set; }
        public float3                                   Normal                                  { get; set; }
        public float                                    Distance                                { get; set; }

        public static VirtualMeshRaycastHit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VirtualMeshRaycastHit() { Pointer= p0 };

            value.Type                                      = (VirtualMeshPrimitive)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType VirtualMeshPrimitive VirtualMeshPrimitive VirtualMeshPrimitive Int32 )
            value.Index                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Index                       ( ModelPrimitiveType int int int Int32 )
            value.Position                                  = (float3)GetInt32(new IntPtr(p + 0x018)); // 0x18 Position                    ( ModelEnumType float3 float3 float3 Int32 )
            value.Normal                                    = (float3)GetInt32(new IntPtr(p + 0x024)); // 0x24 Normal                      ( ModelEnumType float3 float3 float3 Int32 )
            value.Distance                                  = GetSingle(new IntPtr(p + 0x030)); // 0x30 Distance                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
