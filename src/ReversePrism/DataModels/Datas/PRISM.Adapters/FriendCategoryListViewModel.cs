using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsNewReactiveProperty                    ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 CategoryType                             ModelEnumType CategoryType CategoryType CategoryType Int32
    public partial class FriendCategoryListViewModel : DataModel
    {
        public BoolReactiveProperty?                    IsNewReactiveProperty                   { get; set; }
        public CategoryType                             CategoryType                            { get; set; }

        public static FriendCategoryListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendCategoryListViewModel() { Pointer= p0 };

            value.IsNewReactiveProperty                     = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x10 IsNewReactiveProperty       ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.CategoryType                              = (CategoryType)GetInt32(new IntPtr(p + 0x018)); // 0x18 CategoryType                ( ModelEnumType CategoryType CategoryType CategoryType Int32 )

            return value;
        }
    }
}
