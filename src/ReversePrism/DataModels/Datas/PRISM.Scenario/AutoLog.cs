using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 textDic                                  Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 018 CurrentScene                             ModelPrimitiveType int int int Int32
    // 01C CurrentScript                            ModelPrimitiveType int int int Int32
    // 020 SpeakerTable                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 ChoicesTable                             ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class AutoLog : DataModel
    {
        public int                                      CurrentScene                            { get; set; }
        public int                                      CurrentScript                           { get; set; }
        public List<string>?                            SpeakerTable                            { get; set; }
        public List<string>?                            ChoicesTable                            { get; set; }

        public static AutoLog? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoLog() { Pointer= p0 };

            value.CurrentScene                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 CurrentScene                ( ModelPrimitiveType int int int Int32 )
            value.CurrentScript                             = GetInt32(new IntPtr(p + 0x01C)); // 0x1C CurrentScript               ( ModelPrimitiveType int int int Int32 )
            value.SpeakerTable                              = GetStringList(new IntPtr(p + 0x020)); // 0x20 SpeakerTable                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ChoicesTable                              = GetStringList(new IntPtr(p + 0x028)); // 0x28 ChoicesTable                ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
