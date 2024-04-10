using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CheckNGWordReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 HasNgWordListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_hasNgWordList_codec            FieldCodec`1<bool> IL2CPP_TYPE_GENERICINST
    // 018 HasNgWordList                            000185CCFEC8 ModelPrimitiveListType RepeatedField`1<bool> RepeatedField`1<bool> List<bool> Pointer
    public partial class CheckNGWordReply : DataModel
    {
        public List<bool>?                              HasNgWordList                           { get; set; }

        public static CheckNGWordReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CheckNGWordReply() { Pointer= p0 };

            value.HasNgWordList                             = GetBoolList(new IntPtr(p + 0x018)); // 0246620D5A20 0x18 HasNgWordList               ( 000185CCFEC8 ModelPrimitiveListType RepeatedField`1<bool> RepeatedField`1<bool> List<bool> Pointer )

            return value;
        }
    }
}
