using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CheckNGWordArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TextListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_textList_codec                 FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 018 TextList                                 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class CheckNGWordArgs : DataModel
    {
        public List<string>?                            TextList                                { get; set; }

        public static CheckNGWordArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CheckNGWordArgs() { Pointer= p0 };

            value.TextList                                  = GetStringList(new IntPtr(p + 0x018)); // 0246620D5058 0x18 TextList                    ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
