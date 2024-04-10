using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReceivePresentArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IdListFieldNumber                        int IL2CPP_TYPE_I4
    // 008 _repeated_idList_codec                   FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 018 IdList                                   000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class ReceivePresentArgs : DataModel
    {
        public List<string>?                            IdList                                  { get; set; }

        public static ReceivePresentArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceivePresentArgs() { Pointer= p0 };

            value.IdList                                    = GetStringList(new IntPtr(p + 0x018)); // 0246623F97B8 0x18 IdList                      ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
