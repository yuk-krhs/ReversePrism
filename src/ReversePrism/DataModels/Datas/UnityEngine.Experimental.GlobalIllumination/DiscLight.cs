using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InstanceID                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Shadow                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 015 Mode                                     000186526160 ModelEnumType LightMode LightMode LightMode Int32
    // 018 Position                                 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 Orientation                              00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 034 Color                                    000186607DF0 ModelEnumType LinearColor LinearColor LinearColor Int32
    // 044 IndirectColor                            000186607DF0 ModelEnumType LinearColor LinearColor LinearColor Int32
    // 054 Range                                    000186666050 ModelPrimitiveType float float float Single
    // 058 Radius                                   000186666050 ModelPrimitiveType float float float Single
    // 05C Falloff                                  000186552FB0 ModelEnumType FalloffType FalloffType FalloffType Int32
    public partial class DiscLight
    {
        public int                                      InstanceID                              { get; set; }
        public bool                                     Shadow                                  { get; set; }
        public LightMode                                Mode                                    { get; set; }
        public Vector3                                  Position                                { get; set; }
        public Quaternion                               Orientation                             { get; set; }
        public LinearColor                              Color                                   { get; set; }
        public LinearColor                              IndirectColor                           { get; set; }
        public float                                    Range                                   { get; set; }
        public float                                    Radius                                  { get; set; }
        public FalloffType                              Falloff                                 { get; set; }

        public static DiscLight? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiscLight();

            value.InstanceID                                = GetInt32(new IntPtr(p + 0x010)); // 0270068D7E60 0x10 InstanceID                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Shadow                                    = GetBool(new IntPtr(p + 0x014)); // 0270068D7E80 0x14 Shadow                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Mode                                      = (LightMode)GetInt32(new IntPtr(p + 0x015)); // 0270068D7EA0 0x15 Mode                        ( 000186526160 ModelEnumType LightMode LightMode LightMode Int32 )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0270068D7EC0 0x18 Position                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Orientation                               = (Quaternion)GetInt32(new IntPtr(p + 0x024)); // 0270068D7EE0 0x24 Orientation                 ( 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Color                                     = (LinearColor)GetInt32(new IntPtr(p + 0x034)); // 0270068D7F00 0x34 Color                       ( 000186607DF0 ModelEnumType LinearColor LinearColor LinearColor Int32 )
            value.IndirectColor                             = (LinearColor)GetInt32(new IntPtr(p + 0x044)); // 0270068D7F20 0x44 IndirectColor               ( 000186607DF0 ModelEnumType LinearColor LinearColor LinearColor Int32 )
            value.Range                                     = GetSingle(new IntPtr(p + 0x054)); // 0270068D7F40 0x54 Range                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Radius                                    = GetSingle(new IntPtr(p + 0x058)); // 0270068D7F60 0x58 Radius                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Falloff                                   = (FalloffType)GetInt32(new IntPtr(p + 0x05C)); // 0270068D7F80 0x5C Falloff                     ( 000186552FB0 ModelEnumType FalloffType FalloffType FalloffType Int32 )

            return value;
        }
    }
}
