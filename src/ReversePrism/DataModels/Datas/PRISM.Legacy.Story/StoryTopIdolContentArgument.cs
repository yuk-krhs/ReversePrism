using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsUnreadOnlyToggleActive                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class StoryTopIdolContentArgument : DataModel
    {
        public bool                                     IsUnreadOnlyToggleActive                { get; set; }

        public static StoryTopIdolContentArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopIdolContentArgument() { Pointer= p0 };

            value.IsUnreadOnlyToggleActive                  = GetBool(new IntPtr(p + 0x010)); // 024665EB07B8 0x10 IsUnreadOnlyToggleActive    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
