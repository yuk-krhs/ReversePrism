using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScrollPosition                           ModelPrimitiveType float float float Single
    // 014 IsUnreadOnlyToggleOn                     ModelPrimitiveType bool bool bool Bool
    public partial class StoryTopExtraContentArgument : DataModel
    {
        public float                                    ScrollPosition                          { get; set; }
        public bool                                     IsUnreadOnlyToggleOn                    { get; set; }

        public static StoryTopExtraContentArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopExtraContentArgument() { Pointer= p0 };

            value.ScrollPosition                            = GetSingle(new IntPtr(p + 0x010)); // 0x10 ScrollPosition              ( ModelPrimitiveType float float float Single )
            value.IsUnreadOnlyToggleOn                      = GetBool(new IntPtr(p + 0x014)); // 0x14 IsUnreadOnlyToggleOn        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
