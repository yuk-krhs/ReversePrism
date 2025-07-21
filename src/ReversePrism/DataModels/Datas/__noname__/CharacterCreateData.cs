using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C RotationY                                ModelPrimitiveType float float float Single
    // 020 AnimName                                 ModelPrimitiveType string string string String
    // 028 LipSyncName                              ModelPrimitiveType string string string String
    // 030 RecordedAnimName                         ModelPrimitiveType string string string String
    public partial class CharacterCreateData : DataModel
    {
        public Vector3                                  Position                                { get; set; }
        public float                                    RotationY                               { get; set; }
        public string                                   AnimName                                { get; set; }
        public string                                   LipSyncName                             { get; set; }
        public string                                   RecordedAnimName                        { get; set; }

        public static CharacterCreateData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterCreateData() { Pointer= p0 };

            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RotationY                                 = GetSingle(new IntPtr(p + 0x01C)); // 0x1C RotationY                   ( ModelPrimitiveType float float float Single )
            value.AnimName                                  = GetString(new IntPtr(p + 0x020)); // 0x20 AnimName                    ( ModelPrimitiveType string string string String )
            value.LipSyncName                               = GetString(new IntPtr(p + 0x028)); // 0x28 LipSyncName                 ( ModelPrimitiveType string string string String )
            value.RecordedAnimName                          = GetString(new IntPtr(p + 0x030)); // 0x30 RecordedAnimName            ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
