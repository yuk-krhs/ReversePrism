using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FlagAndTeamId                            ModelPrimitiveType uint uint uint UInt32
    // 014 SortIndex                                ModelPrimitiveType int int int Int32
    // 018 ParticleIndices                          ModelEnumType int3 int3 int3 Int32
    // 024 NextPos                                  ModelEnumType float3x3 float3x3 float3x3 Int32
    // 048 OldPos                                   ModelEnumType float3x3 float3x3 float3x3 Int32
    // 06C InvMass                                  ModelEnumType float3 float3 float3 Int32
    // 078 Thickness                                ModelPrimitiveType float float float Single
    public partial class Primitive : DataModel
    {
        public uint                                     FlagAndTeamId                           { get; set; }
        public int                                      SortIndex                               { get; set; }
        public int3                                     ParticleIndices                         { get; set; }
        public float3x3                                 NextPos                                 { get; set; }
        public float3x3                                 OldPos                                  { get; set; }
        public float3                                   InvMass                                 { get; set; }
        public float                                    Thickness                               { get; set; }

        public static Primitive? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Primitive() { Pointer= p0 };

            value.FlagAndTeamId                             = GetUInt32(new IntPtr(p + 0x010)); // 0x10 FlagAndTeamId               ( ModelPrimitiveType uint uint uint UInt32 )
            value.SortIndex                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 SortIndex                   ( ModelPrimitiveType int int int Int32 )
            value.ParticleIndices                           = (int3)GetInt32(new IntPtr(p + 0x018)); // 0x18 ParticleIndices             ( ModelEnumType int3 int3 int3 Int32 )
            value.NextPos                                   = (float3x3)GetInt32(new IntPtr(p + 0x024)); // 0x24 NextPos                     ( ModelEnumType float3x3 float3x3 float3x3 Int32 )
            value.OldPos                                    = (float3x3)GetInt32(new IntPtr(p + 0x048)); // 0x48 OldPos                      ( ModelEnumType float3x3 float3x3 float3x3 Int32 )
            value.InvMass                                   = (float3)GetInt32(new IntPtr(p + 0x06C)); // 0x6C InvMass                     ( ModelEnumType float3 float3 float3 Int32 )
            value.Thickness                                 = GetSingle(new IntPtr(p + 0x078)); // 0x78 Thickness                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
