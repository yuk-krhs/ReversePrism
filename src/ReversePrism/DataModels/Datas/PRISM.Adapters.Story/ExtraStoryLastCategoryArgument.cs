using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Legacy                                   0001865398C0 ModelClassType ExtraStoryLastCategoryArgumentForLegacy ExtraStoryLastCategoryArgumentForLegacy ExtraStoryLastCategoryArgumentForLegacy Pointer
    public partial class ExtraStoryLastCategoryArgument
    {
        public ExtraStoryLastCategoryArgumentForLegacy? Legacy                                  { get; set; }

        public static ExtraStoryLastCategoryArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStoryLastCategoryArgument();

            value.Legacy                                    = GetObject<ExtraStoryLastCategoryArgumentForLegacy>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExtraStoryLastCategoryArgumentForLegacy.FromPointer); // 0270D6799038 0x10 Legacy                      ( 0001865398C0 ModelClassType ExtraStoryLastCategoryArgumentForLegacy ExtraStoryLastCategoryArgumentForLegacy ExtraStoryLastCategoryArgumentForLegacy Pointer )

            return value;
        }
    }
}
