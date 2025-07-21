using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Particle                               ModelEnumType Particle Particle Particle Int32
    // 094 M_PositionSet                            ModelPrimitiveType bool bool bool Bool
    // 095 M_VelocitySet                            ModelPrimitiveType bool bool bool Bool
    // 096 M_AxisOfRotationSet                      ModelPrimitiveType bool bool bool Bool
    // 097 M_RotationSet                            ModelPrimitiveType bool bool bool Bool
    // 098 M_AngularVelocitySet                     ModelPrimitiveType bool bool bool Bool
    // 099 M_StartSizeSet                           ModelPrimitiveType bool bool bool Bool
    // 09A M_StartColorSet                          ModelPrimitiveType bool bool bool Bool
    // 09B M_RandomSeedSet                          ModelPrimitiveType bool bool bool Bool
    // 09C M_StartLifetimeSet                       ModelPrimitiveType bool bool bool Bool
    // 09D M_MeshIndexSet                           ModelPrimitiveType bool bool bool Bool
    // 09E M_ApplyShapeToPosition                   ModelPrimitiveType bool bool bool Bool
    public partial class EmitParams : DataModel
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
            var value   = new EmitParams() { Pointer= p0 };

            value.M_Particle                                = (Particle)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Particle                  ( ModelEnumType Particle Particle Particle Int32 )
            value.M_PositionSet                             = GetBool(new IntPtr(p + 0x094)); // 0x94 M_PositionSet               ( ModelPrimitiveType bool bool bool Bool )
            value.M_VelocitySet                             = GetBool(new IntPtr(p + 0x095)); // 0x95 M_VelocitySet               ( ModelPrimitiveType bool bool bool Bool )
            value.M_AxisOfRotationSet                       = GetBool(new IntPtr(p + 0x096)); // 0x96 M_AxisOfRotationSet         ( ModelPrimitiveType bool bool bool Bool )
            value.M_RotationSet                             = GetBool(new IntPtr(p + 0x097)); // 0x97 M_RotationSet               ( ModelPrimitiveType bool bool bool Bool )
            value.M_AngularVelocitySet                      = GetBool(new IntPtr(p + 0x098)); // 0x98 M_AngularVelocitySet        ( ModelPrimitiveType bool bool bool Bool )
            value.M_StartSizeSet                            = GetBool(new IntPtr(p + 0x099)); // 0x99 M_StartSizeSet              ( ModelPrimitiveType bool bool bool Bool )
            value.M_StartColorSet                           = GetBool(new IntPtr(p + 0x09A)); // 0x9A M_StartColorSet             ( ModelPrimitiveType bool bool bool Bool )
            value.M_RandomSeedSet                           = GetBool(new IntPtr(p + 0x09B)); // 0x9B M_RandomSeedSet             ( ModelPrimitiveType bool bool bool Bool )
            value.M_StartLifetimeSet                        = GetBool(new IntPtr(p + 0x09C)); // 0x9C M_StartLifetimeSet          ( ModelPrimitiveType bool bool bool Bool )
            value.M_MeshIndexSet                            = GetBool(new IntPtr(p + 0x09D)); // 0x9D M_MeshIndexSet              ( ModelPrimitiveType bool bool bool Bool )
            value.M_ApplyShapeToPosition                    = GetBool(new IntPtr(p + 0x09E)); // 0x9E M_ApplyShapeToPosition      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
