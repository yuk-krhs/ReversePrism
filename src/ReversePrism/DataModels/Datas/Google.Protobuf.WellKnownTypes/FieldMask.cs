using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FieldMask> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PathsFieldNumber                         int IL2CPP_TYPE_I4
    // 008 _repeated_paths_codec                    FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 018 Paths                                    ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 FIELD_PATH_SEPARATOR                     char IL2CPP_TYPE_CHAR
    // 000 FIELD_SEPARATOR_REGEX                    char IL2CPP_TYPE_CHAR
    public partial class FieldMask : DataModel
    {
        public List<string>?                            Paths                                   { get; set; }

        public static FieldMask? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldMask() { Pointer= p0 };

            value.Paths                                     = GetStringList(new IntPtr(p + 0x018)); // 0x18 Paths                       ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
