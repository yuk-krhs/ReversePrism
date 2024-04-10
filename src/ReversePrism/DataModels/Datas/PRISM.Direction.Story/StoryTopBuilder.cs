using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     0001865AFE60 ModelClassType StoryTopView StoryTopView StoryTopView Pointer
    public partial class StoryTopBuilder : DataModel
    {
        public StoryTopView?                            View                                    { get; set; }

        public static StoryTopBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopBuilder() { Pointer= p0 };

            value.View                                      = GetObject<StoryTopView>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryTopView.FromPointer); // 02466B6D2E98 0x20 View                        ( 0001865AFE60 ModelClassType StoryTopView StoryTopView StoryTopView Pointer )

            return value;
        }
    }
}
