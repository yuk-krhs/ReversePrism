using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<TouchStoryListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UpdatedStoryListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_updatedStoryList_codec         FieldCodec`1<StoryStatus> IL2CPP_TYPE_GENERICINST
    // 018 UpdatedStoryList                         ModelClassListType RepeatedField`1<StoryStatus> RepeatedField`1<StoryStatus> List<StoryStatus> Pointer
    public partial class TouchStoryListReply : DataModel
    {
        public List<StoryStatus>?                       UpdatedStoryList                        { get; set; }

        public static TouchStoryListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TouchStoryListReply() { Pointer= p0 };

            value.UpdatedStoryList                          = GetObjectList<StoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryStatus.FromPointer); // 0x18 UpdatedStoryList            ( ModelClassListType RepeatedField`1<StoryStatus> RepeatedField`1<StoryStatus> List<StoryStatus> Pointer )

            return value;
        }
    }
}
