using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Legacy                                   0001865C9AF0 ModelClassType MainStoryLastCategoryArgumentForLegacy MainStoryLastCategoryArgumentForLegacy MainStoryLastCategoryArgumentForLegacy Pointer
    public partial class MainStoryLastCategoryArgument
    {
        public MainStoryLastCategoryArgumentForLegacy?  Legacy                                  { get; set; }

        public static MainStoryLastCategoryArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainStoryLastCategoryArgument();

            value.Legacy                                    = GetObject<MainStoryLastCategoryArgumentForLegacy>(new IntPtr(p + 0x010), ReversePrism.DataModels.MainStoryLastCategoryArgumentForLegacy.FromPointer); // 0270D67BBA98 0x10 Legacy                      ( 0001865C9AF0 ModelClassType MainStoryLastCategoryArgumentForLegacy MainStoryLastCategoryArgumentForLegacy MainStoryLastCategoryArgumentForLegacy Pointer )

            return value;
        }
    }
}
