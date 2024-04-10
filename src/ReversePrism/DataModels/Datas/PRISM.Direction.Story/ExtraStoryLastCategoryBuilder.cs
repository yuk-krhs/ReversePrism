using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     00018653BA00 ModelClassType ExtraStoryLastCategoryView ExtraStoryLastCategoryView ExtraStoryLastCategoryView Pointer
    public partial class ExtraStoryLastCategoryBuilder : DataModel
    {
        public ExtraStoryLastCategoryView?              View                                    { get; set; }

        public static ExtraStoryLastCategoryBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStoryLastCategoryBuilder() { Pointer= p0 };

            value.View                                      = GetObject<ExtraStoryLastCategoryView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExtraStoryLastCategoryView.FromPointer); // 02466B6D2CB8 0x20 View                        ( 00018653BA00 ModelClassType ExtraStoryLastCategoryView ExtraStoryLastCategoryView ExtraStoryLastCategoryView Pointer )

            return value;
        }
    }
}
