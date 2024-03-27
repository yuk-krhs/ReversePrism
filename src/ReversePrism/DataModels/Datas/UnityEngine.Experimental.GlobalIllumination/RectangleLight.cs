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
    // 058 Width                                    000186666050 ModelPrimitiveType float float float Single
    // 05C Height                                   000186666050 ModelPrimitiveType float float float Single
    // 060 Falloff                                  000186552FB0 ModelEnumType FalloffType FalloffType FalloffType Int32
    public partial class RectangleLight
    {
        public int                                      InstanceID                              { get; set; }
        public bool                                     Shadow                                  { get; set; }
        public LightMode                                Mode                                    { get; set; }
        public Vector3                                  Position                                { get; set; }
        public Quaternion                               Orientation                             { get; set; }
        public LinearColor                              Color                                   { get; set; }
        public LinearColor                              IndirectColor                           { get; set; }
        public float                                    Range                                   { get; set; }
        public float                                    Width                                   { get; set; }
        public float                                    Height                                  { get; set; }
        public FalloffType                              Falloff                                 { get; set; }

        public static RectangleLight? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RectangleLight();

            value.InstanceID                                = GetInt32(new IntPtr(p + 0x010)); // 0270068D7D00 0x10 InstanceID                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Shadow                                    = GetBool(new IntPtr(p + 0x014)); // 0270068D7D20 0x14 Shadow                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Mode                                      = (LightMode)GetInt32(new IntPtr(p + 0x015)); // 0270068D7D40 0x15 Mode                        ( 000186526160 ModelEnumType LightMode LightMode LightMode Int32 )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0270068D7D60 0x18 Position                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Orientation                               = (Quaternion)GetInt32(new IntPtr(p + 0x024)); // 0270068D7D80 0x24 Orientation                 ( 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Color                                     = (LinearColor)GetInt32(new IntPtr(p + 0x034)); // 0270068D7DA0 0x34 Color                       ( 000186607DF0 ModelEnumType LinearColor LinearColor LinearColor Int32 )
            value.IndirectColor                             = (LinearColor)GetInt32(new IntPtr(p + 0x044)); // 0270068D7DC0 0x44 IndirectColor               ( 000186607DF0 ModelEnumType LinearColor LinearColor LinearColor Int32 )
            value.Range                                     = GetSingle(new IntPtr(p + 0x054)); // 0270068D7DE0 0x54 Range                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Width                                     = GetSingle(new IntPtr(p + 0x058)); // 0270068D7E00 0x58 Width                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Height                                    = GetSingle(new IntPtr(p + 0x05C)); // 0270068D7E20 0x5C Height                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Falloff                                   = (FalloffType)GetInt32(new IntPtr(p + 0x060)); // 0270068D7E40 0x60 Falloff                     ( 000186552FB0 ModelEnumType FalloffType FalloffType FalloffType Int32 )

            return value;
        }
    }
}
