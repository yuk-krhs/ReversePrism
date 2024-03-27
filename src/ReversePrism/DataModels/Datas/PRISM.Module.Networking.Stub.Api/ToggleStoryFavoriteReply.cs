using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ToggleStoryFavoriteReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UpdatedStoryFieldNumber                  int IL2CPP_TYPE_I4
    // 018 UpdatedStory                             0001865A4D90 ModelClassType StoryStatus StoryStatus StoryStatus Pointer
    public partial class ToggleStoryFavoriteReply
    {
        public StoryStatus?                             UpdatedStory                            { get; set; }

        public static ToggleStoryFavoriteReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ToggleStoryFavoriteReply();

            value.UpdatedStory                              = GetObject<StoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryStatus.FromPointer); // 0270D2A30F30 0x18 UpdatedStory                ( 0001865A4D90 ModelClassType StoryStatus StoryStatus StoryStatus Pointer )

            return value;
        }
    }
}
