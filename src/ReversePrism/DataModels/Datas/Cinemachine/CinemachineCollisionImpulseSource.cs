using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 M_LayerMask                              ModelEnumType LayerMask LayerMask LayerMask Int32
    // 040 M_IgnoreTag                              ModelPrimitiveType string string string String
    // 048 M_UseImpactDirection                     ModelPrimitiveType bool bool bool Bool
    // 049 M_ScaleImpactWithMass                    ModelPrimitiveType bool bool bool Bool
    // 04A M_ScaleImpactWithSpeed                   ModelPrimitiveType bool bool bool Bool
    // 050 MRigidBody                               ModelClassType Rigidbody Rigidbody Rigidbody Pointer
    // 058 MRigidBody2D                             ModelClassType Rigidbody2D Rigidbody2D Rigidbody2D Pointer
    public partial class CinemachineCollisionImpulseSource : DataModel
    {
        public LayerMask                                M_LayerMask                             { get; set; }
        public string                                   M_IgnoreTag                             { get; set; }
        public bool                                     M_UseImpactDirection                    { get; set; }
        public bool                                     M_ScaleImpactWithMass                   { get; set; }
        public bool                                     M_ScaleImpactWithSpeed                  { get; set; }
        public Rigidbody?                               MRigidBody                              { get; set; }
        public Rigidbody2D?                             MRigidBody2D                            { get; set; }

        public static CinemachineCollisionImpulseSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineCollisionImpulseSource() { Pointer= p0 };

            value.M_LayerMask                               = (LayerMask)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_LayerMask                 ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.M_IgnoreTag                               = GetString(new IntPtr(p + 0x040)); // 0x40 M_IgnoreTag                 ( ModelPrimitiveType string string string String )
            value.M_UseImpactDirection                      = GetBool(new IntPtr(p + 0x048)); // 0x48 M_UseImpactDirection        ( ModelPrimitiveType bool bool bool Bool )
            value.M_ScaleImpactWithMass                     = GetBool(new IntPtr(p + 0x049)); // 0x49 M_ScaleImpactWithMass       ( ModelPrimitiveType bool bool bool Bool )
            value.M_ScaleImpactWithSpeed                    = GetBool(new IntPtr(p + 0x04A)); // 0x4A M_ScaleImpactWithSpeed      ( ModelPrimitiveType bool bool bool Bool )
            value.MRigidBody                                = GetObject<Rigidbody>(new IntPtr(p + 0x050), ReversePrism.DataModels.Rigidbody.FromPointer); // 0x50 MRigidBody                  ( ModelClassType Rigidbody Rigidbody Rigidbody Pointer )
            value.MRigidBody2D                              = GetObject<Rigidbody2D>(new IntPtr(p + 0x058), ReversePrism.DataModels.Rigidbody2D.FromPointer); // 0x58 MRigidBody2D                ( ModelClassType Rigidbody2D Rigidbody2D Rigidbody2D Pointer )

            return value;
        }
    }
}
