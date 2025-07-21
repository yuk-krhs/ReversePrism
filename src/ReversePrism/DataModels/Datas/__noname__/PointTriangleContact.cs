using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FlagAndTeamId0                           ModelPrimitiveType uint uint uint UInt32
    // 014 FlagAndTeamId1                           ModelPrimitiveType uint uint uint UInt32
    // 018 Thickness                                ModelEnumType half half half Int32
    // 01A Sign                                     ModelEnumType half half half Int32
    // 01C PointParticleIndex                       ModelPrimitiveType int int int Int32
    // 020 TriangleParticleIndex                    ModelEnumType int3 int3 int3 Int32
    // 02C PointInvMass                             ModelEnumType half half half Int32
    // 02E TriangleInvMass                          ModelEnumType half3 half3 half3 Int32
    public partial class PointTriangleContact : DataModel
    {
        public uint                                     FlagAndTeamId0                          { get; set; }
        public uint                                     FlagAndTeamId1                          { get; set; }
        public half                                     Thickness                               { get; set; }
        public half                                     Sign                                    { get; set; }
        public int                                      PointParticleIndex                      { get; set; }
        public int3                                     TriangleParticleIndex                   { get; set; }
        public half                                     PointInvMass                            { get; set; }
        public half3                                    TriangleInvMass                         { get; set; }

        public static PointTriangleContact? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointTriangleContact() { Pointer= p0 };

            value.FlagAndTeamId0                            = GetUInt32(new IntPtr(p + 0x010)); // 0x10 FlagAndTeamId0              ( ModelPrimitiveType uint uint uint UInt32 )
            value.FlagAndTeamId1                            = GetUInt32(new IntPtr(p + 0x014)); // 0x14 FlagAndTeamId1              ( ModelPrimitiveType uint uint uint UInt32 )
            value.Thickness                                 = (half)GetInt32(new IntPtr(p + 0x018)); // 0x18 Thickness                   ( ModelEnumType half half half Int32 )
            value.Sign                                      = (half)GetInt32(new IntPtr(p + 0x01A)); // 0x1A Sign                        ( ModelEnumType half half half Int32 )
            value.PointParticleIndex                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C PointParticleIndex          ( ModelPrimitiveType int int int Int32 )
            value.TriangleParticleIndex                     = (int3)GetInt32(new IntPtr(p + 0x020)); // 0x20 TriangleParticleIndex       ( ModelEnumType int3 int3 int3 Int32 )
            value.PointInvMass                              = (half)GetInt32(new IntPtr(p + 0x02C)); // 0x2C PointInvMass                ( ModelEnumType half half half Int32 )
            value.TriangleInvMass                           = (half3)GetInt32(new IntPtr(p + 0x02E)); // 0x2E TriangleInvMass             ( ModelEnumType half3 half3 half3 Int32 )

            return value;
        }
    }
}
