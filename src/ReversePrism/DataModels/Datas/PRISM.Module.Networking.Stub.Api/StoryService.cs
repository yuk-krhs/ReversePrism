using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetStoryListArgs        Marshaller`1<GetStoryListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetStoryListReply       Marshaller`1<GetStoryListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_StartStoryArgs          Marshaller`1<StartStoryArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_StartStoryReply         Marshaller`1<StartStoryReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_FinishStoryArgs         Marshaller`1<FinishStoryArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_FinishStoryReply        Marshaller`1<FinishStoryReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_TouchStoryListArgs      Marshaller`1<TouchStoryListArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_TouchStoryListReply     Marshaller`1<TouchStoryListReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_ToggleStoryFavoriteArgs Marshaller`1<ToggleStoryFavoriteArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_ToggleStoryFavoriteReply Marshaller`1<ToggleStoryFavoriteReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_GetEventInfoForEventStoryArgs Marshaller`1<GetEventInfoForEventStoryArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_GetEventInfoForEventStoryReply Marshaller`1<GetEventInfoForEventStoryReply> IL2CPP_TYPE_GENERICINST
    // 068 __Method_GetStoryList                    Method`2<GetStoryListArgs, GetStoryListReply> IL2CPP_TYPE_GENERICINST
    // 070 __Method_StartStory                      Method`2<StartStoryArgs, StartStoryReply> IL2CPP_TYPE_GENERICINST
    // 078 __Method_FinishStory                     Method`2<FinishStoryArgs, FinishStoryReply> IL2CPP_TYPE_GENERICINST
    // 080 __Method_TouchStoryList                  Method`2<TouchStoryListArgs, TouchStoryListReply> IL2CPP_TYPE_GENERICINST
    // 088 __Method_ToggleStoryFavorite             Method`2<ToggleStoryFavoriteArgs, ToggleStoryFavoriteReply> IL2CPP_TYPE_GENERICINST
    // 090 __Method_GetEventInfoForEventStory       Method`2<GetEventInfoForEventStoryArgs, GetEventInfoForEventStoryReply> IL2CPP_TYPE_GENERICINST
    public partial class StoryService : DataModel
    {

        public static StoryService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryService() { Pointer= p0 };


            return value;
        }
    }
}
