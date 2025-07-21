using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType MainStoryLastCategoryView MainStoryLastCategoryView MainStoryLastCategoryView Pointer
    public partial class MainStoryLastCategoryBuilder : DataModel
    {
        public MainStoryLastCategoryView?               View                                    { get; set; }

        public static MainStoryLastCategoryBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainStoryLastCategoryBuilder() { Pointer= p0 };

            value.View                                      = GetObject<MainStoryLastCategoryView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MainStoryLastCategoryView.FromPointer); // 0x20 View                        ( ModelClassType MainStoryLastCategoryView MainStoryLastCategoryView MainStoryLastCategoryView Pointer )

            return value;
        }
    }
}
