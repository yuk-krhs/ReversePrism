using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetStoryListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MainStoryListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_mainStoryList_codec            FieldCodec`1<MainStoryStatus> IL2CPP_TYPE_GENERICINST
    // 018 MainStoryList                            ModelClassListType RepeatedField`1<MainStoryStatus> RepeatedField`1<MainStoryStatus> List<MainStoryStatus> Pointer
    // 000 IdolStoryListFieldNumber                 int IL2CPP_TYPE_I4
    // 010 _repeated_idolStoryList_codec            FieldCodec`1<IdolStoryStatus> IL2CPP_TYPE_GENERICINST
    // 020 IdolStoryList                            ModelClassListType RepeatedField`1<IdolStoryStatus> RepeatedField`1<IdolStoryStatus> List<IdolStoryStatus> Pointer
    // 000 EventStoryListFieldNumber                int IL2CPP_TYPE_I4
    // 018 _repeated_eventStoryList_codec           FieldCodec`1<EventStoryStatus> IL2CPP_TYPE_GENERICINST
    // 028 EventStoryList                           ModelClassListType RepeatedField`1<EventStoryStatus> RepeatedField`1<EventStoryStatus> List<EventStoryStatus> Pointer
    // 000 ExtraStoryListFieldNumber                int IL2CPP_TYPE_I4
    // 020 _repeated_extraStoryList_codec           FieldCodec`1<ExtraStoryStatus> IL2CPP_TYPE_GENERICINST
    // 030 ExtraStoryList                           ModelClassListType RepeatedField`1<ExtraStoryStatus> RepeatedField`1<ExtraStoryStatus> List<ExtraStoryStatus> Pointer
    public partial class GetStoryListReply : DataModel
    {
        public List<MainStoryStatus>?                   MainStoryList                           { get; set; }
        public List<IdolStoryStatus>?                   IdolStoryList                           { get; set; }
        public List<EventStoryStatus>?                  EventStoryList                          { get; set; }
        public List<ExtraStoryStatus>?                  ExtraStoryList                          { get; set; }

        public static GetStoryListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetStoryListReply() { Pointer= p0 };

            value.MainStoryList                             = GetObjectList<MainStoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.MainStoryStatus.FromPointer); // 0x18 MainStoryList               ( ModelClassListType RepeatedField`1<MainStoryStatus> RepeatedField`1<MainStoryStatus> List<MainStoryStatus> Pointer )
            value.IdolStoryList                             = GetObjectList<IdolStoryStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolStoryStatus.FromPointer); // 0x20 IdolStoryList               ( ModelClassListType RepeatedField`1<IdolStoryStatus> RepeatedField`1<IdolStoryStatus> List<IdolStoryStatus> Pointer )
            value.EventStoryList                            = GetObjectList<EventStoryStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.EventStoryStatus.FromPointer); // 0x28 EventStoryList              ( ModelClassListType RepeatedField`1<EventStoryStatus> RepeatedField`1<EventStoryStatus> List<EventStoryStatus> Pointer )
            value.ExtraStoryList                            = GetObjectList<ExtraStoryStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ExtraStoryStatus.FromPointer); // 0x30 ExtraStoryList              ( ModelClassListType RepeatedField`1<ExtraStoryStatus> RepeatedField`1<ExtraStoryStatus> List<ExtraStoryStatus> Pointer )

            return value;
        }
    }
}
