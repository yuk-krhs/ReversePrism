using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<DebugInfo> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StackEntriesFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_stackEntries_codec             FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 018 StackEntries                             000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 DetailFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Detail                                   000186671910 ModelPrimitiveType string string string String
    public partial class DebugInfo : DataModel
    {
        public List<string>?                            StackEntries                            { get; set; }
        public string                                   Detail                                  { get; set; }

        public static DebugInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugInfo() { Pointer= p0 };

            value.StackEntries                              = GetStringList(new IntPtr(p + 0x018)); // 02466A718498 0x18 StackEntries                ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.Detail                                    = GetString(new IntPtr(p + 0x020)); // 02466A7184D8 0x20 Detail                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
