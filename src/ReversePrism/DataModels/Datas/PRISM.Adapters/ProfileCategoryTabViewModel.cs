using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CategoryType                             ModelEnumType CategoryType CategoryType CategoryType Int32
    public partial class ProfileCategoryTabViewModel : DataModel
    {
        public CategoryType                             CategoryType                            { get; set; }

        public static ProfileCategoryTabViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileCategoryTabViewModel() { Pointer= p0 };

            value.CategoryType                              = (CategoryType)GetInt32(new IntPtr(p + 0x010)); // 0x10 CategoryType                ( ModelEnumType CategoryType CategoryType CategoryType Int32 )

            return value;
        }
    }
}
