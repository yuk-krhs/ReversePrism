using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InstanceID                               ModelPrimitiveType int int int Int32
    // 014 Shadow                                   ModelPrimitiveType bool bool bool Bool
    // 015 Mode                                     ModelEnumType LightMode LightMode LightMode Int32
    // 018 Position                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 Orientation                              ModelEnumType Quaternion Quaternion Quaternion Int32
    // 034 Color                                    ModelEnumType LinearColor LinearColor LinearColor Int32
    // 044 IndirectColor                            ModelEnumType LinearColor LinearColor LinearColor Int32
    // 054 Range                                    ModelPrimitiveType float float float Single
    // 058 SphereRadius                             ModelPrimitiveType float float float Single
    // 05C ConeAngle                                ModelPrimitiveType float float float Single
    // 060 InnerConeAngle                           ModelPrimitiveType float float float Single
    // 064 Falloff                                  ModelEnumType FalloffType FalloffType FalloffType Int32
    // 065 AngularFalloff                           ModelEnumType AngularFalloffType AngularFalloffType AngularFalloffType Int32
    public partial class SpotLight : DataModel
    {
        public int                                      InstanceID                              { get; set; }
        public bool                                     Shadow                                  { get; set; }
        public LightMode                                Mode                                    { get; set; }
        public Vector3                                  Position                                { get; set; }
        public Quaternion                               Orientation                             { get; set; }
        public LinearColor                              Color                                   { get; set; }
        public LinearColor                              IndirectColor                           { get; set; }
        public float                                    Range                                   { get; set; }
        public float                                    SphereRadius                            { get; set; }
        public float                                    ConeAngle                               { get; set; }
        public float                                    InnerConeAngle                          { get; set; }
        public FalloffType                              Falloff                                 { get; set; }
        public AngularFalloffType                       AngularFalloff                          { get; set; }

        public static SpotLight? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpotLight() { Pointer= p0 };

            value.InstanceID                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 InstanceID                  ( ModelPrimitiveType int int int Int32 )
            value.Shadow                                    = GetBool(new IntPtr(p + 0x014)); // 0x14 Shadow                      ( ModelPrimitiveType bool bool bool Bool )
            value.Mode                                      = (LightMode)GetInt32(new IntPtr(p + 0x015)); // 0x15 Mode                        ( ModelEnumType LightMode LightMode LightMode Int32 )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0x18 Position                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Orientation                               = (Quaternion)GetInt32(new IntPtr(p + 0x024)); // 0x24 Orientation                 ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Color                                     = (LinearColor)GetInt32(new IntPtr(p + 0x034)); // 0x34 Color                       ( ModelEnumType LinearColor LinearColor LinearColor Int32 )
            value.IndirectColor                             = (LinearColor)GetInt32(new IntPtr(p + 0x044)); // 0x44 IndirectColor               ( ModelEnumType LinearColor LinearColor LinearColor Int32 )
            value.Range                                     = GetSingle(new IntPtr(p + 0x054)); // 0x54 Range                       ( ModelPrimitiveType float float float Single )
            value.SphereRadius                              = GetSingle(new IntPtr(p + 0x058)); // 0x58 SphereRadius                ( ModelPrimitiveType float float float Single )
            value.ConeAngle                                 = GetSingle(new IntPtr(p + 0x05C)); // 0x5C ConeAngle                   ( ModelPrimitiveType float float float Single )
            value.InnerConeAngle                            = GetSingle(new IntPtr(p + 0x060)); // 0x60 InnerConeAngle              ( ModelPrimitiveType float float float Single )
            value.Falloff                                   = (FalloffType)GetInt32(new IntPtr(p + 0x064)); // 0x64 Falloff                     ( ModelEnumType FalloffType FalloffType FalloffType Int32 )
            value.AngularFalloff                            = (AngularFalloffType)GetInt32(new IntPtr(p + 0x065)); // 0x65 AngularFalloff              ( ModelEnumType AngularFalloffType AngularFalloffType AngularFalloffType Int32 )

            return value;
        }
    }
}
