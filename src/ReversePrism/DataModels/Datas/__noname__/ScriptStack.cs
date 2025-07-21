using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScriptName                               ModelPrimitiveType string string string String
    // 018 SceneCount                               ModelPrimitiveType int int int Int32
    // 01C ScriptDataCount                          ModelPrimitiveType int int int Int32
    // 020 CameraTime                               ModelPrimitiveType float float float Single
    // 028 PositionID                               ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 PositionData                             ModelClassListType PositionData[] PositionData[] List<PositionData> Pointer
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

            value.ScriptName                                = GetString(new IntPtr(p + 0x010)); // 0x10 ScriptName                  ( ModelPrimitiveType string string string String )
            value.SceneCount                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 SceneCount                  ( ModelPrimitiveType int int int Int32 )
            value.ScriptDataCount                           = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ScriptDataCount             ( ModelPrimitiveType int int int Int32 )
            value.CameraTime                                = GetSingle(new IntPtr(p + 0x020)); // 0x20 CameraTime                  ( ModelPrimitiveType float float float Single )
            value.PositionID                                = GetStringList(new IntPtr(p + 0x028)); // 0x28 PositionID                  ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.PositionData                              = GetObjectList<PositionData>(new IntPtr(p + 0x030), ReversePrism.DataModels.PositionData.FromPointer); // 0x30 PositionData                ( ModelClassListType PositionData[] PositionData[] List<PositionData> Pointer )

            return value;
        }
    }
}
