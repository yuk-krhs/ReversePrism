using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     0001865CBA50 ModelClassType MainStoryLastCategoryView MainStoryLastCategoryView MainStoryLastCategoryView Pointer
    public partial class MainStoryLastCategoryBuilder
    {
        public MainStoryLastCategoryView?               View                                    { get; set; }

        public static MainStoryLastCategoryBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainStoryLastCategoryBuilder();

            value.View                                      = GetObject<MainStoryLastCategoryView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MainStoryLastCategoryView.FromPointer); // 0270DB646C58 0x20 View                        ( 0001865CBA50 ModelClassType MainStoryLastCategoryView MainStoryLastCategoryView MainStoryLastCategoryView Pointer )

            return value;
        }
    }
}
