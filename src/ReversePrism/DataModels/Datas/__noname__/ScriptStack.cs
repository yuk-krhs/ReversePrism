using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScriptName                               0001866722E0 ModelPrimitiveType string string string String
    // 018 SceneCount                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C ScriptDataCount                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 CameraTime                               000186666050 ModelPrimitiveType float float float Single
    // 028 PositionID                               000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 PositionData                             000185CC1B08 ModelClassListType PositionData[] PositionData[] List<PositionData> Pointer
    public partial class ScriptStack
    {
        public string                                   ScriptName                              { get; set; }
        public int                                      SceneCount                              { get; set; }
        public int                                      ScriptDataCount                         { get; set; }
        public float                                    CameraTime                              { get; set; }
        public List<string>?                            PositionID                              { get; set; }
        public List<PositionData>?                      PositionData                            { get; set; }

        public static ScriptStack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScriptStack();

            value.ScriptName                                = GetString(new IntPtr(p + 0x010)); // 0270D5DF69A0 0x10 ScriptName                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SceneCount                                = GetInt32(new IntPtr(p + 0x018)); // 0270D5DF69C0 0x18 SceneCount                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ScriptDataCount                           = GetInt32(new IntPtr(p + 0x01C)); // 0270D5DF69E0 0x1C ScriptDataCount             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CameraTime                                = GetSingle(new IntPtr(p + 0x020)); // 0270D5DF6A00 0x20 CameraTime                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.PositionID                                = GetStringList(new IntPtr(p + 0x028)); // 0270D5DF6A20 0x28 PositionID                  ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.PositionData                              = GetObjectList<PositionData>(new IntPtr(p + 0x030), ReversePrism.DataModels.PositionData.FromPointer); // 0270D5DF6A40 0x30 PositionData                ( 000185CC1B08 ModelClassListType PositionData[] PositionData[] List<PositionData> Pointer )

            return value;
        }
    }
}
