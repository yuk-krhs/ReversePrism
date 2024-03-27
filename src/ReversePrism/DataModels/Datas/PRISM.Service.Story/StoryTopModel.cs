using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <MainStories>k__BackingField             IEnumerable`1<IMainStoryStatus> IL2CPP_TYPE_GENERICINST
    // 018 <IdolStories>k__BackingField             IEnumerable`1<IIdolStoryStatus> IL2CPP_TYPE_GENERICINST
    // 020 <EventStories>k__BackingField            IEnumerable`1<IEventStoryStatus> IL2CPP_TYPE_GENERICINST
    // 028 <ExtraStories>k__BackingField            IEnumerable`1<IExtraStoryStatus> IL2CPP_TYPE_GENERICINST
    public partial class StoryTopModel
    {

        public static StoryTopModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopModel();


            return value;
        }
    }
}
