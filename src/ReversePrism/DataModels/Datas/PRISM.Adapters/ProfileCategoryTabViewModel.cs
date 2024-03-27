using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CategoryType                             00018666B2E0 ModelEnumType CategoryType CategoryType CategoryType Int32
    public partial class ProfileCategoryTabViewModel
    {
        public CategoryType                             CategoryType                            { get; set; }

        public static ProfileCategoryTabViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileCategoryTabViewModel();

            value.CategoryType                              = (CategoryType)GetInt32(new IntPtr(p + 0x010)); // 0270D66B87D8 0x10 CategoryType                ( 00018666B2E0 ModelEnumType CategoryType CategoryType CategoryType Int32 )

            return value;
        }
    }
}
