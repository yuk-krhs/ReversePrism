using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsNewReactiveProperty                    0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 CategoryType                             0001866CE160 ModelEnumType CategoryType CategoryType CategoryType Int32
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

            value.IsNewReactiveProperty                     = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0246663A1D08 0x10 IsNewReactiveProperty       ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.CategoryType                              = (CategoryType)GetInt32(new IntPtr(p + 0x018)); // 0246663A1D28 0x18 CategoryType                ( 0001866CE160 ModelEnumType CategoryType CategoryType CategoryType Int32 )

            return value;
        }
    }
}
