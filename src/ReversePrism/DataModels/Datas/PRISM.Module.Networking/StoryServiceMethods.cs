using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetStoryList                             Method`2<IGetStoryListArgs, IGetStoryListReply> IL2CPP_TYPE_GENERICINST
    // 018 StartStory                               Method`2<IStartStoryArgs, IStartStoryReply> IL2CPP_TYPE_GENERICINST
    // 030 FinishStory                              Method`2<IFinishStoryArgs, IFinishStoryReply> IL2CPP_TYPE_GENERICINST
    // 048 TouchStoryList                           Method`2<ITouchStoryListArgs, ITouchStoryListReply> IL2CPP_TYPE_GENERICINST
    // 060 ToggleStoryFavorite                      Method`2<IToggleStoryFavoriteArgs, IToggleStoryFavoriteReply> IL2CPP_TYPE_GENERICINST
    // 078 GetEventInfoForEventStory                Method`2<IGetEventInfoForEventStoryArgs, IGetEventInfoForEventStoryReply> IL2CPP_TYPE_GENERICINST
    public partial class StoryServiceMethods : DataModel
    {

        public static StoryServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
