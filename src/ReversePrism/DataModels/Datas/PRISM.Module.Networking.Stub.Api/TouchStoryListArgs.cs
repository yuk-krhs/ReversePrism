using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<TouchStoryListArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StoryIdListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_storyIdList_codec              FieldCodec`1<StoryIDStatus> IL2CPP_TYPE_GENERICINST
    // 018 StoryIdList                              000185CF2FE8 ModelClassListType RepeatedField`1<StoryIDStatus> RepeatedField`1<StoryIDStatus> List<StoryIDStatus> Pointer
    public partial class TouchStoryListArgs : DataModel
    {
        public List<StoryIDStatus>?                     StoryIdList                             { get; set; }

        public static TouchStoryListArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TouchStoryListArgs() { Pointer= p0 };

            value.StoryIdList                               = GetObjectList<StoryIDStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryIDStatus.FromPointer); // 0246629B81D0 0x18 StoryIdList                 ( 000185CF2FE8 ModelClassListType RepeatedField`1<StoryIDStatus> RepeatedField`1<StoryIDStatus> List<StoryIDStatus> Pointer )

            return value;
        }
    }
}
