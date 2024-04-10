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
    public partial class ScriptStack : DataModel
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
            var value   = new ScriptStack() { Pointer= p0 };

            value.ScriptName                                = GetString(new IntPtr(p + 0x010)); // 024665E672F8 0x10 ScriptName                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SceneCount                                = GetInt32(new IntPtr(p + 0x018)); // 024665E67318 0x18 SceneCount                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ScriptDataCount                           = GetInt32(new IntPtr(p + 0x01C)); // 024665E67338 0x1C ScriptDataCount             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CameraTime                                = GetSingle(new IntPtr(p + 0x020)); // 024665E67358 0x20 CameraTime                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.PositionID                                = GetStringList(new IntPtr(p + 0x028)); // 024665E67378 0x28 PositionID                  ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.PositionData                              = GetObjectList<PositionData>(new IntPtr(p + 0x030), ReversePrism.DataModels.PositionData.FromPointer); // 024665E67398 0x30 PositionData                ( 000185CC1B08 ModelClassListType PositionData[] PositionData[] List<PositionData> Pointer )

            return value;
        }
    }
}
