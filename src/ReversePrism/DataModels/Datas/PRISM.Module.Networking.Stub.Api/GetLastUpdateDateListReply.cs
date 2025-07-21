using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetLastUpdateDateListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LastUpdateDateListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_lastUpdateDateList_codec       FieldCodec`1<LastUpdateDateStatus> IL2CPP_TYPE_GENERICINST
    // 018 LastUpdateDateList                       ModelClassListType RepeatedField`1<LastUpdateDateStatus> RepeatedField`1<LastUpdateDateStatus> List<LastUpdateDateStatus> Pointer
    // 000 UnreadListFieldNumber                    int IL2CPP_TYPE_I4
    // 010 _repeated_unreadList_codec               FieldCodec`1<UnreadStatus> IL2CPP_TYPE_GENERICINST
    // 020 UnreadList                               ModelClassListType RepeatedField`1<UnreadStatus> RepeatedField`1<UnreadStatus> List<UnreadStatus> Pointer
    public partial class GetLastUpdateDateListReply : DataModel
    {
        public List<LastUpdateDateStatus>?              LastUpdateDateList                      { get; set; }
        public List<UnreadStatus>?                      UnreadList                              { get; set; }

        public static GetLastUpdateDateListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetLastUpdateDateListReply() { Pointer= p0 };

            value.LastUpdateDateList                        = GetObjectList<LastUpdateDateStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LastUpdateDateStatus.FromPointer); // 0x18 LastUpdateDateList          ( ModelClassListType RepeatedField`1<LastUpdateDateStatus> RepeatedField`1<LastUpdateDateStatus> List<LastUpdateDateStatus> Pointer )
            value.UnreadList                                = GetObjectList<UnreadStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnreadStatus.FromPointer); // 0x20 UnreadList                  ( ModelClassListType RepeatedField`1<UnreadStatus> RepeatedField`1<UnreadStatus> List<UnreadStatus> Pointer )

            return value;
        }
    }
}
