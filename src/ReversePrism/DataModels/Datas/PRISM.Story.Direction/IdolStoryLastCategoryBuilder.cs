using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     0001866C8B60 ModelClassType IdolStoryLastCategoryView IdolStoryLastCategoryView IdolStoryLastCategoryView Pointer
    public partial class IdolStoryLastCategoryBuilder
    {
        public IdolStoryLastCategoryView?               View                                    { get; set; }

        public static IdolStoryLastCategoryBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStoryLastCategoryBuilder();

            value.View                                      = GetObject<IdolStoryLastCategoryView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolStoryLastCategoryView.FromPointer); // 0270DB61FCA0 0x20 View                        ( 0001866C8B60 ModelClassType IdolStoryLastCategoryView IdolStoryLastCategoryView IdolStoryLastCategoryView Pointer )

            return value;
        }
    }
}
