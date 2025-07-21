using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Timestamp                                ModelPrimitiveType float float float Single
    // 018 StageName                                ModelPrimitiveType string string string String
    // 020 StageSwitchCondition                     ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 StagePosition                            ModelEnumType Vector3 Vector3 Vector3 Int32
    // 034 StageRotation                            ModelEnumType Quaternion Quaternion Quaternion Int32
    public partial class ReceivedData : DataModel
    {
        public float                                    Timestamp                               { get; set; }
        public string                                   StageName                               { get; set; }
        public List<string>?                            StageSwitchCondition                    { get; set; }
        public Vector3                                  StagePosition                           { get; set; }
        public Quaternion                               StageRotation                           { get; set; }

        public static ReceivedData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceivedData() { Pointer= p0 };

            value.Timestamp                                 = GetSingle(new IntPtr(p + 0x010)); // 0x10 Timestamp                   ( ModelPrimitiveType float float float Single )
            value.StageName                                 = GetString(new IntPtr(p + 0x018)); // 0x18 StageName                   ( ModelPrimitiveType string string string String )
            value.StageSwitchCondition                      = GetStringList(new IntPtr(p + 0x020)); // 0x20 StageSwitchCondition        ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.StagePosition                             = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0x28 StagePosition               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.StageRotation                             = (Quaternion)GetInt32(new IntPtr(p + 0x034)); // 0x34 StageRotation               ( ModelEnumType Quaternion Quaternion Quaternion Int32 )

            return value;
        }
    }
}
