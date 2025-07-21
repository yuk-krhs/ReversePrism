using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InstanceID                               ModelPrimitiveType int int int Int32
    // 014 CookieID                                 ModelPrimitiveType int int int Int32
    // 018 CookieScale                              ModelPrimitiveType float float float Single
    // 01C Color                                    ModelEnumType LinearColor LinearColor LinearColor Int32
    // 02C IndirectColor                            ModelEnumType LinearColor LinearColor LinearColor Int32
    // 03C Orientation                              ModelEnumType Quaternion Quaternion Quaternion Int32
    // 04C Position                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 058 Range                                    ModelPrimitiveType float float float Single
    // 05C ConeAngle                                ModelPrimitiveType float float float Single
    // 060 InnerConeAngle                           ModelPrimitiveType float float float Single
    // 064 Shape0                                   ModelPrimitiveType float float float Single
    // 068 Shape1                                   ModelPrimitiveType float float float Single
    // 06C Type                                     ModelEnumType LightType LightType LightType Int32
    // 06D Mode                                     ModelEnumType LightMode LightMode LightMode Int32
    // 06E Shadow                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 06F Falloff                                  ModelEnumType FalloffType FalloffType FalloffType Int32
    public partial class LightDataGI : DataModel
    {
        public int                                      InstanceID                              { get; set; }
        public int                                      CookieID                                { get; set; }
        public float                                    CookieScale                             { get; set; }
        public LinearColor                              Color                                   { get; set; }
        public LinearColor                              IndirectColor                           { get; set; }
        public Quaternion                               Orientation                             { get; set; }
        public Vector3                                  Position                                { get; set; }
        public float                                    Range                                   { get; set; }
        public float                                    ConeAngle                               { get; set; }
        public float                                    InnerConeAngle                          { get; set; }
        public float                                    Shape0                                  { get; set; }
        public float                                    Shape1                                  { get; set; }
        public LightType                                Type                                    { get; set; }
        public LightMode                                Mode                                    { get; set; }
        public sbyte                                    Shadow                                  { get; set; }
        public FalloffType                              Falloff                                 { get; set; }

        public static LightDataGI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightDataGI() { Pointer= p0 };

            value.InstanceID                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 InstanceID                  ( ModelPrimitiveType int int int Int32 )
            value.CookieID                                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 CookieID                    ( ModelPrimitiveType int int int Int32 )
            value.CookieScale                               = GetSingle(new IntPtr(p + 0x018)); // 0x18 CookieScale                 ( ModelPrimitiveType float float float Single )
            value.Color                                     = (LinearColor)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Color                       ( ModelEnumType LinearColor LinearColor LinearColor Int32 )
            value.IndirectColor                             = (LinearColor)GetInt32(new IntPtr(p + 0x02C)); // 0x2C IndirectColor               ( ModelEnumType LinearColor LinearColor LinearColor Int32 )
            value.Orientation                               = (Quaternion)GetInt32(new IntPtr(p + 0x03C)); // 0x3C Orientation                 ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x04C)); // 0x4C Position                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Range                                     = GetSingle(new IntPtr(p + 0x058)); // 0x58 Range                       ( ModelPrimitiveType float float float Single )
            value.ConeAngle                                 = GetSingle(new IntPtr(p + 0x05C)); // 0x5C ConeAngle                   ( ModelPrimitiveType float float float Single )
            value.InnerConeAngle                            = GetSingle(new IntPtr(p + 0x060)); // 0x60 InnerConeAngle              ( ModelPrimitiveType float float float Single )
            value.Shape0                                    = GetSingle(new IntPtr(p + 0x064)); // 0x64 Shape0                      ( ModelPrimitiveType float float float Single )
            value.Shape1                                    = GetSingle(new IntPtr(p + 0x068)); // 0x68 Shape1                      ( ModelPrimitiveType float float float Single )
            value.Type                                      = (LightType)GetInt32(new IntPtr(p + 0x06C)); // 0x6C Type                        ( ModelEnumType LightType LightType LightType Int32 )
            value.Mode                                      = (LightMode)GetInt32(new IntPtr(p + 0x06D)); // 0x6D Mode                        ( ModelEnumType LightMode LightMode LightMode Int32 )
            value.Shadow                                    = GetSByte(new IntPtr(p + 0x06E)); // 0x6E Shadow                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Falloff                                   = (FalloffType)GetInt32(new IntPtr(p + 0x06F)); // 0x6F Falloff                     ( ModelEnumType FalloffType FalloffType FalloffType Int32 )

            return value;
        }
    }
}
