using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InstanceID                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 CookieID                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 CookieScale                              000186666050 ModelPrimitiveType float float float Single
    // 01C Color                                    000186607DF0 ModelEnumType LinearColor LinearColor LinearColor Int32
    // 02C IndirectColor                            000186607DF0 ModelEnumType LinearColor LinearColor LinearColor Int32
    // 03C Orientation                              00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 04C Position                                 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 058 Range                                    000186666050 ModelPrimitiveType float float float Single
    // 05C ConeAngle                                000186666050 ModelPrimitiveType float float float Single
    // 060 InnerConeAngle                           000186666050 ModelPrimitiveType float float float Single
    // 064 Shape0                                   000186666050 ModelPrimitiveType float float float Single
    // 068 Shape1                                   000186666050 ModelPrimitiveType float float float Single
    // 06C Type                                     000186528410 ModelEnumType LightType LightType LightType Int32
    // 06D Mode                                     000186526160 ModelEnumType LightMode LightMode LightMode Int32
    // 06E Shadow                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 06F Falloff                                  000186552FB0 ModelEnumType FalloffType FalloffType FalloffType Int32
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

            value.InstanceID                                = GetInt32(new IntPtr(p + 0x010)); // 0245A23891F8 0x10 InstanceID                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CookieID                                  = GetInt32(new IntPtr(p + 0x014)); // 0245A2389218 0x14 CookieID                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CookieScale                               = GetSingle(new IntPtr(p + 0x018)); // 0245A2389238 0x18 CookieScale                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.Color                                     = (LinearColor)GetInt32(new IntPtr(p + 0x01C)); // 0245A2389258 0x1C Color                       ( 000186607DF0 ModelEnumType LinearColor LinearColor LinearColor Int32 )
            value.IndirectColor                             = (LinearColor)GetInt32(new IntPtr(p + 0x02C)); // 0245A2389278 0x2C IndirectColor               ( 000186607DF0 ModelEnumType LinearColor LinearColor LinearColor Int32 )
            value.Orientation                               = (Quaternion)GetInt32(new IntPtr(p + 0x03C)); // 0245A2389298 0x3C Orientation                 ( 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x04C)); // 0245A23892B8 0x4C Position                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Range                                     = GetSingle(new IntPtr(p + 0x058)); // 0245A23892D8 0x58 Range                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.ConeAngle                                 = GetSingle(new IntPtr(p + 0x05C)); // 0245A23892F8 0x5C ConeAngle                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.InnerConeAngle                            = GetSingle(new IntPtr(p + 0x060)); // 0245A2389318 0x60 InnerConeAngle              ( 000186666050 ModelPrimitiveType float float float Single )
            value.Shape0                                    = GetSingle(new IntPtr(p + 0x064)); // 0245A2389338 0x64 Shape0                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Shape1                                    = GetSingle(new IntPtr(p + 0x068)); // 0245A2389358 0x68 Shape1                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Type                                      = (LightType)GetInt32(new IntPtr(p + 0x06C)); // 0245A2389378 0x6C Type                        ( 000186528410 ModelEnumType LightType LightType LightType Int32 )
            value.Mode                                      = (LightMode)GetInt32(new IntPtr(p + 0x06D)); // 0245A2389398 0x6D Mode                        ( 000186526160 ModelEnumType LightMode LightMode LightMode Int32 )
            value.Shadow                                    = GetSByte(new IntPtr(p + 0x06E)); // 0245A23893B8 0x6E Shadow                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Falloff                                   = (FalloffType)GetInt32(new IntPtr(p + 0x06F)); // 0245A23893D8 0x6F Falloff                     ( 000186552FB0 ModelEnumType FalloffType FalloffType FalloffType Int32 )

            return value;
        }
    }
}
