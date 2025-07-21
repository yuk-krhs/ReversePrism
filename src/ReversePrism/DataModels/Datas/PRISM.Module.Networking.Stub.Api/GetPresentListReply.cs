using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetPresentListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PresentListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_presentList_codec              FieldCodec`1<PresentStatus> IL2CPP_TYPE_GENERICINST
    // 018 PresentList                              ModelClassListType RepeatedField`1<PresentStatus> RepeatedField`1<PresentStatus> List<PresentStatus> Pointer
    // 000 CursorFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Cursor                                   ModelPrimitiveType string string string String
    public partial class GetPresentListReply : DataModel
    {
        public List<PresentStatus>?                     PresentList                             { get; set; }
        public string                                   Cursor                                  { get; set; }

        public static GetPresentListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetPresentListReply() { Pointer= p0 };

            value.PresentList                               = GetObjectList<PresentStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.PresentStatus.FromPointer); // 0x18 PresentList                 ( ModelClassListType RepeatedField`1<PresentStatus> RepeatedField`1<PresentStatus> List<PresentStatus> Pointer )
            value.Cursor                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Cursor                      ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
