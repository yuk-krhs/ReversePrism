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
    // 054 PenumbraWidthRadian                      000186666050 ModelPrimitiveType float float float Single
    // 058 Direction                                0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class DirectionalLight : DataModel
    {
        public int                                      InstanceID                              { get; set; }
        public bool                                     Shadow                                  { get; set; }
        public LightMode                                Mode                                    { get; set; }
        public Vector3                                  Position                                { get; set; }
        public Quaternion                               Orientation                             { get; set; }
        public LinearColor                              Color                                   { get; set; }
        public LinearColor                              IndirectColor                           { get; set; }
        public float                                    PenumbraWidthRadian                     { get; set; }
        public Vector3                                  Direction                               { get; set; }

        public static DirectionalLight? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DirectionalLight() { Pointer= p0 };

            value.InstanceID                                = GetInt32(new IntPtr(p + 0x010)); // 0245A689A000 0x10 InstanceID                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Shadow                                    = GetBool(new IntPtr(p + 0x014)); // 0245A689A020 0x14 Shadow                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Mode                                      = (LightMode)GetInt32(new IntPtr(p + 0x015)); // 0245A689A040 0x15 Mode                        ( 000186526160 ModelEnumType LightMode LightMode LightMode Int32 )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0245A689A060 0x18 Position                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Orientation                               = (Quaternion)GetInt32(new IntPtr(p + 0x024)); // 0245A689A080 0x24 Orientation                 ( 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Color                                     = (LinearColor)GetInt32(new IntPtr(p + 0x034)); // 0245A689A0A0 0x34 Color                       ( 000186607DF0 ModelEnumType LinearColor LinearColor LinearColor Int32 )
            value.IndirectColor                             = (LinearColor)GetInt32(new IntPtr(p + 0x044)); // 0245A689A0C0 0x44 IndirectColor               ( 000186607DF0 ModelEnumType LinearColor LinearColor LinearColor Int32 )
            value.PenumbraWidthRadian                       = GetSingle(new IntPtr(p + 0x054)); // 0245A689A0E0 0x54 PenumbraWidthRadian         ( 000186666050 ModelPrimitiveType float float float Single )
            value.Direction                                 = (Vector3)GetInt32(new IntPtr(p + 0x058)); // 0245A689A100 0x58 Direction                   ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
