using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 mainStoriesCache                         Dictionary`2<int, IMainStoryStatus> IL2CPP_TYPE_GENERICINST
    // 018 idolStoriesCache                         Dictionary`2<int, IIdolStoryStatus> IL2CPP_TYPE_GENERICINST
    // 020 eventStoriesCache                        Dictionary`2<int, IEventStoryStatus> IL2CPP_TYPE_GENERICINST
    // 028 extraStoriesCache                        Dictionary`2<int, IExtraStoryStatus> IL2CPP_TYPE_GENERICINST
    // 030 IsReady                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class StoryCache
    {
        public bool                                     IsReady                                 { get; set; }

        public static StoryCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryCache();

            value.IsReady                                   = GetBool(new IntPtr(p + 0x030)); // 027004A8B2D8 0x30 IsReady                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
