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
    // 010 FrameRegexWithFileInfo                   ModelPrimitiveType string string string String
    // 018 MonoFilenameUnknownString                ModelPrimitiveType string string string String
    // 020 StringDelimiters                         ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class StackTraceParser : DataModel
    {
        public string                                   FrameRegexWithFileInfo                  { get; set; }
        public string                                   MonoFilenameUnknownString               { get; set; }
        public List<string>?                            StringDelimiters                        { get; set; }

        public static StackTraceParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StackTraceParser() { Pointer= p0 };

            value.FrameRegexWithFileInfo                    = GetString(new IntPtr(p + 0x010)); // 0x10 FrameRegexWithFileInfo      ( ModelPrimitiveType string string string String )
            value.MonoFilenameUnknownString                 = GetString(new IntPtr(p + 0x018)); // 0x18 MonoFilenameUnknownString   ( ModelPrimitiveType string string string String )
            value.StringDelimiters                          = GetStringList(new IntPtr(p + 0x020)); // 0x20 StringDelimiters            ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
