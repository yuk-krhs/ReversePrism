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
    // 01A S                                        ModelEnumType half half half Int32
    // 01C T                                        ModelEnumType half half half Int32
    // 01E N                                        ModelEnumType half3 half3 half3 Int32
    // 024 EdgeInvMass0                             ModelEnumType half2 half2 half2 Int32
    // 028 EdgeInvMass1                             ModelEnumType half2 half2 half2 Int32
    // 02C EdgeParticleIndex0                       ModelEnumType int2 int2 int2 Int32
    // 034 EdgeParticleIndex1                       ModelEnumType int2 int2 int2 Int32
    public partial class EdgeEdgeContact : DataModel
    {
        public uint                                     FlagAndTeamId0                          { get; set; }
        public uint                                     FlagAndTeamId1                          { get; set; }
        public half                                     Thickness                               { get; set; }
        public half                                     S                                       { get; set; }
        public half                                     T                                       { get; set; }
        public half3                                    N                                       { get; set; }
        public half2                                    EdgeInvMass0                            { get; set; }
        public half2                                    EdgeInvMass1                            { get; set; }
        public int2                                     EdgeParticleIndex0                      { get; set; }
        public int2                                     EdgeParticleIndex1                      { get; set; }

        public static EdgeEdgeContact? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EdgeEdgeContact() { Pointer= p0 };

            value.FlagAndTeamId0                            = GetUInt32(new IntPtr(p + 0x010)); // 0x10 FlagAndTeamId0              ( ModelPrimitiveType uint uint uint UInt32 )
            value.FlagAndTeamId1                            = GetUInt32(new IntPtr(p + 0x014)); // 0x14 FlagAndTeamId1              ( ModelPrimitiveType uint uint uint UInt32 )
            value.Thickness                                 = (half)GetInt32(new IntPtr(p + 0x018)); // 0x18 Thickness                   ( ModelEnumType half half half Int32 )
            value.S                                         = (half)GetInt32(new IntPtr(p + 0x01A)); // 0x1A S                           ( ModelEnumType half half half Int32 )
            value.T                                         = (half)GetInt32(new IntPtr(p + 0x01C)); // 0x1C T                           ( ModelEnumType half half half Int32 )
            value.N                                         = (half3)GetInt32(new IntPtr(p + 0x01E)); // 0x1E N                           ( ModelEnumType half3 half3 half3 Int32 )
            value.EdgeInvMass0                              = (half2)GetInt32(new IntPtr(p + 0x024)); // 0x24 EdgeInvMass0                ( ModelEnumType half2 half2 half2 Int32 )
            value.EdgeInvMass1                              = (half2)GetInt32(new IntPtr(p + 0x028)); // 0x28 EdgeInvMass1                ( ModelEnumType half2 half2 half2 Int32 )
            value.EdgeParticleIndex0                        = (int2)GetInt32(new IntPtr(p + 0x02C)); // 0x2C EdgeParticleIndex0          ( ModelEnumType int2 int2 int2 Int32 )
            value.EdgeParticleIndex1                        = (int2)GetInt32(new IntPtr(p + 0x034)); // 0x34 EdgeParticleIndex1          ( ModelEnumType int2 int2 int2 Int32 )

            return value;
        }
    }
}
