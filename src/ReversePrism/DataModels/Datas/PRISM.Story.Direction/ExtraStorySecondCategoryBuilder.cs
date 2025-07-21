using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType ExtraStorySecondCategoryView ExtraStorySecondCategoryView ExtraStorySecondCategoryView Pointer
    public partial class ExtraStorySecondCategoryBuilder : DataModel
    {
        public ExtraStorySecondCategoryView?            View                                    { get; set; }

        public static ExtraStorySecondCategoryBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStorySecondCategoryBuilder() { Pointer= p0 };

            value.View                                      = GetObject<ExtraStorySecondCategoryView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExtraStorySecondCategoryView.FromPointer); // 0x20 View                        ( ModelClassType ExtraStorySecondCategoryView ExtraStorySecondCategoryView ExtraStorySecondCategoryView Pointer )

            return value;
        }
    }
}
