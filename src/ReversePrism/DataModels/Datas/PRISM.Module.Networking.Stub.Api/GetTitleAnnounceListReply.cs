using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetTitleAnnounceListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 AnnounceListFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_announceList_codec             FieldCodec`1<AnnounceStatus> IL2CPP_TYPE_GENERICINST
    // 018 AnnounceList                             000185CCE1F8 ModelClassListType RepeatedField`1<AnnounceStatus> RepeatedField`1<AnnounceStatus> List<AnnounceStatus> Pointer
    // 000 CursorFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Cursor                                   000186671910 ModelPrimitiveType string string string String
    public partial class GetTitleAnnounceListReply
    {
        public List<AnnounceStatus>?                    AnnounceList                            { get; set; }
        public string                                   Cursor                                  { get; set; }

        public static GetTitleAnnounceListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetTitleAnnounceListReply();

            value.AnnounceList                              = GetObjectList<AnnounceStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnnounceStatus.FromPointer); // 0270D2B613D0 0x18 AnnounceList                ( 000185CCE1F8 ModelClassListType RepeatedField`1<AnnounceStatus> RepeatedField`1<AnnounceStatus> List<AnnounceStatus> Pointer )
            value.Cursor                                    = GetString(new IntPtr(p + 0x020)); // 0270D2B61410 0x20 Cursor                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
