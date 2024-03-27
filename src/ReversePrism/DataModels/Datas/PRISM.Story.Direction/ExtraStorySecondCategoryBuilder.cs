using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     00018653EBB0 ModelClassType ExtraStorySecondCategoryView ExtraStorySecondCategoryView ExtraStorySecondCategoryView Pointer
    public partial class ExtraStorySecondCategoryBuilder
    {
        public ExtraStorySecondCategoryView?            View                                    { get; set; }

        public static ExtraStorySecondCategoryBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStorySecondCategoryBuilder();

            value.View                                      = GetObject<ExtraStorySecondCategoryView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExtraStorySecondCategoryView.FromPointer); // 0270DB61FBC0 0x20 View                        ( 00018653EBB0 ModelClassType ExtraStorySecondCategoryView ExtraStorySecondCategoryView ExtraStorySecondCategoryView Pointer )

            return value;
        }
    }
}
