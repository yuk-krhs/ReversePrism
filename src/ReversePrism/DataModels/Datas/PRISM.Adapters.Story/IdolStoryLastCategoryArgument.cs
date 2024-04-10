using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Legacy                                   0001866C6B50 ModelClassType IdolStoryLastCategoryArgumentForLegacy IdolStoryLastCategoryArgumentForLegacy IdolStoryLastCategoryArgumentForLegacy Pointer
    public partial class IdolStoryLastCategoryArgument : DataModel
    {
        public IdolStoryLastCategoryArgumentForLegacy?  Legacy                                  { get; set; }

        public static IdolStoryLastCategoryArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStoryLastCategoryArgument() { Pointer= p0 };

            value.Legacy                                    = GetObject<IdolStoryLastCategoryArgumentForLegacy>(new IntPtr(p + 0x010), ReversePrism.DataModels.IdolStoryLastCategoryArgumentForLegacy.FromPointer); // 0246667FF030 0x10 Legacy                      ( 0001866C6B50 ModelClassType IdolStoryLastCategoryArgumentForLegacy IdolStoryLastCategoryArgumentForLegacy IdolStoryLastCategoryArgumentForLegacy Pointer )

            return value;
        }
    }
}
