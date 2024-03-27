using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CachedStoryService                       000186716FD0 ModelClassType ICachedStoryService ICachedStoryService ICachedStoryService Pointer
    public partial class StoryService
    {
        public ICachedStoryService?                     CachedStoryService                      { get; set; }

        public static StoryService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryService();

            value.CachedStoryService                        = GetObject<ICachedStoryService>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICachedStoryService.FromPointer); // 0270D58E1498 0x10 CachedStoryService          ( 000186716FD0 ModelClassType ICachedStoryService ICachedStoryService ICachedStoryService Pointer )

            return value;
        }
    }
}
