using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Legacy                                   0001865ABE80 ModelClassType StoryTopLegacyParameter StoryTopLegacyParameter StoryTopLegacyParameter Pointer
    public partial class StoryTopArgument
    {
        public StoryTopLegacyParameter?                 Legacy                                  { get; set; }

        public static StoryTopArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopArgument();

            value.Legacy                                    = GetObject<StoryTopLegacyParameter>(new IntPtr(p + 0x010), ReversePrism.DataModels.StoryTopLegacyParameter.FromPointer); // 0270D6812EB0 0x10 Legacy                      ( 0001865ABE80 ModelClassType StoryTopLegacyParameter StoryTopLegacyParameter StoryTopLegacyParameter Pointer )

            return value;
        }
    }
}
