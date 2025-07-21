using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartStoryReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StoryFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Story                                    ModelClassType StoryStatus StoryStatus StoryStatus Pointer
    // 000 NextStoryIdFieldNumber                   int IL2CPP_TYPE_I4
    // 020 NextStoryId                              ModelClassType StoryIDStatus StoryIDStatus StoryIDStatus Pointer
    public partial class StartStoryReply : DataModel
    {
        public StoryStatus?                             Story                                   { get; set; }
        public StoryIDStatus?                           NextStoryId                             { get; set; }

        public static StartStoryReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartStoryReply() { Pointer= p0 };

            value.Story                                     = GetObject<StoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryStatus.FromPointer); // 0x18 Story                       ( ModelClassType StoryStatus StoryStatus StoryStatus Pointer )
            value.NextStoryId                               = GetObject<StoryIDStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryIDStatus.FromPointer); // 0x20 NextStoryId                 ( ModelClassType StoryIDStatus StoryIDStatus StoryIDStatus Pointer )

            return value;
        }
    }
}
