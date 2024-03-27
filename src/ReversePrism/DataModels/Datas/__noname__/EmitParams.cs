using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Particle                               000186707460 ModelEnumType Particle Particle Particle Int32
    // 094 M_PositionSet                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 095 M_VelocitySet                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 096 M_AxisOfRotationSet                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 097 M_RotationSet                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 098 M_AngularVelocitySet                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 099 M_StartSizeSet                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 09A M_StartColorSet                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 09B M_RandomSeedSet                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 09C M_StartLifetimeSet                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 09D M_MeshIndexSet                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 09E M_ApplyShapeToPosition                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class EmitParams
    {
        public Particle                                 M_Particle                              { get; set; }
        public bool                                     M_PositionSet                           { get; set; }
        public bool                                     M_VelocitySet                           { get; set; }
        public bool                                     M_AxisOfRotationSet                     { get; set; }
        public bool                                     M_RotationSet                           { get; set; }
        public bool                                     M_AngularVelocitySet                    { get; set; }
        public bool                                     M_StartSizeSet                          { get; set; }
        public bool                                     M_StartColorSet                         { get; set; }
        public bool                                     M_RandomSeedSet                         { get; set; }
        public bool                                     M_StartLifetimeSet                      { get; set; }
        public bool                                     M_MeshIndexSet                          { get; set; }
        public bool                                     M_ApplyShapeToPosition                  { get; set; }

        public static EmitParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EmitParams();

            value.M_Particle                                = (Particle)GetInt32(new IntPtr(p + 0x010)); // 02700696D3D0 0x10 M_Particle                  ( 000186707460 ModelEnumType Particle Particle Particle Int32 )
            value.M_PositionSet                             = GetBool(new IntPtr(p + 0x094)); // 02700696D3F0 0x94 M_PositionSet               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_VelocitySet                             = GetBool(new IntPtr(p + 0x095)); // 02700696D410 0x95 M_VelocitySet               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_AxisOfRotationSet                       = GetBool(new IntPtr(p + 0x096)); // 02700696D430 0x96 M_AxisOfRotationSet         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_RotationSet                             = GetBool(new IntPtr(p + 0x097)); // 02700696D450 0x97 M_RotationSet               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_AngularVelocitySet                      = GetBool(new IntPtr(p + 0x098)); // 02700696D470 0x98 M_AngularVelocitySet        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_StartSizeSet                            = GetBool(new IntPtr(p + 0x099)); // 02700696D490 0x99 M_StartSizeSet              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_StartColorSet                           = GetBool(new IntPtr(p + 0x09A)); // 02700696D4B0 0x9A M_StartColorSet             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_RandomSeedSet                           = GetBool(new IntPtr(p + 0x09B)); // 02700696D4D0 0x9B M_RandomSeedSet             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_StartLifetimeSet                        = GetBool(new IntPtr(p + 0x09C)); // 02700696D4F0 0x9C M_StartLifetimeSet          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_MeshIndexSet                            = GetBool(new IntPtr(p + 0x09D)); // 02700696D510 0x9D M_MeshIndexSet              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ApplyShapeToPosition                    = GetBool(new IntPtr(p + 0x09E)); // 02700696D530 0x9E M_ApplyShapeToPosition      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
