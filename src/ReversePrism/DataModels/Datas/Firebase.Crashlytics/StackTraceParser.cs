using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 FrameArgsRegex                           string IL2CPP_TYPE_STRING
    // 008 FrameRegexWithoutFileInfo                string IL2CPP_TYPE_STRING
    // 010 FrameRegexWithFileInfo                   0001866738F0 ModelPrimitiveType string string string String
    // 018 MonoFilenameUnknownString                0001866738F0 ModelPrimitiveType string string string String
    // 020 StringDelimiters                         000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class StackTraceParser
    {
        public string                                   FrameRegexWithFileInfo                  { get; set; }
        public string                                   MonoFilenameUnknownString               { get; set; }
        public List<string>?                            StringDelimiters                        { get; set; }

        public static StackTraceParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StackTraceParser();

            value.FrameRegexWithFileInfo                    = GetString(new IntPtr(p + 0x010)); // 0270DBC61758 0x10 FrameRegexWithFileInfo      ( 0001866738F0 ModelPrimitiveType string string string String )
            value.MonoFilenameUnknownString                 = GetString(new IntPtr(p + 0x018)); // 0270DBC61778 0x18 MonoFilenameUnknownString   ( 0001866738F0 ModelPrimitiveType string string string String )
            value.StringDelimiters                          = GetStringList(new IntPtr(p + 0x020)); // 0270DBC61798 0x20 StringDelimiters            ( 000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
