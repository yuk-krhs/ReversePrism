using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsUnreadOnlyToggleActive                 ModelPrimitiveType bool bool bool Bool
    public partial class StoryTopExtraContentArgument : DataModel
    {
        public bool                                     IsUnreadOnlyToggleActive                { get; set; }

        public static StoryTopExtraContentArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopExtraContentArgument() { Pointer= p0 };

            value.IsUnreadOnlyToggleActive                  = GetBool(new IntPtr(p + 0x010)); // 0x10 IsUnreadOnlyToggleActive    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
