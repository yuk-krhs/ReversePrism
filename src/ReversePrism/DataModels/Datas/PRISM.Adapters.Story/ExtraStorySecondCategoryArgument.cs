using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Legacy                                   00018653C480 ModelClassType ExtraStorySecondCategoryArgumentForLegacy ExtraStorySecondCategoryArgumentForLegacy ExtraStorySecondCategoryArgumentForLegacy Pointer
    public partial class ExtraStorySecondCategoryArgument
    {
        public ExtraStorySecondCategoryArgumentForLegacy? Legacy                                  { get; set; }

        public static ExtraStorySecondCategoryArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStorySecondCategoryArgument();

            value.Legacy                                    = GetObject<ExtraStorySecondCategoryArgumentForLegacy>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExtraStorySecondCategoryArgumentForLegacy.FromPointer); // 0270D679C318 0x10 Legacy                      ( 00018653C480 ModelClassType ExtraStorySecondCategoryArgumentForLegacy ExtraStorySecondCategoryArgumentForLegacy ExtraStorySecondCategoryArgumentForLegacy Pointer )

            return value;
        }
    }
}
