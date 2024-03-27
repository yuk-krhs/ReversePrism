using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsUnreadOnlyToggleActive                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class StoryTopEventContentArgument
    {
        public bool                                     IsUnreadOnlyToggleActive                { get; set; }

        public static StoryTopEventContentArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopEventContentArgument();

            value.IsUnreadOnlyToggleActive                  = GetBool(new IntPtr(p + 0x010)); // 0270D5E3FC90 0x10 IsUnreadOnlyToggleActive    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
