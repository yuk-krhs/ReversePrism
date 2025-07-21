using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SubCategoryId                            ModelPrimitiveType int int int Int32
    // 018 ExtraStories                             ModelClassListType IReadOnlyList`1<IExtraStoryStatus> IReadOnlyList`1<IExtraStoryStatus> List<IExtraStoryStatus> Pointer
    public partial class ExtraStoryLastCategoryModel : DataModel
    {
        public int                                      SubCategoryId                           { get; set; }
        public List<IExtraStoryStatus>?                 ExtraStories                            { get; set; }

        public static ExtraStoryLastCategoryModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStoryLastCategoryModel() { Pointer= p0 };

            value.SubCategoryId                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 SubCategoryId               ( ModelPrimitiveType int int int Int32 )
            value.ExtraStories                              = GetObjectList<IExtraStoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IExtraStoryStatus.FromPointer); // 0x18 ExtraStories                ( ModelClassListType IReadOnlyList`1<IExtraStoryStatus> IReadOnlyList`1<IExtraStoryStatus> List<IExtraStoryStatus> Pointer )

            return value;
        }
    }
}
