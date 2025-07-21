using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CategoryId                               ModelPrimitiveType int int int Int32
    // 018 ExtraStories                             ModelClassListType IReadOnlyList`1<IExtraStoryStatus> IReadOnlyList`1<IExtraStoryStatus> List<IExtraStoryStatus> Pointer
    public partial class ExtraStorySecondCategoryModel : DataModel
    {
        public int                                      CategoryId                              { get; set; }
        public List<IExtraStoryStatus>?                 ExtraStories                            { get; set; }

        public static ExtraStorySecondCategoryModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStorySecondCategoryModel() { Pointer= p0 };

            value.CategoryId                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 CategoryId                  ( ModelPrimitiveType int int int Int32 )
            value.ExtraStories                              = GetObjectList<IExtraStoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IExtraStoryStatus.FromPointer); // 0x18 ExtraStories                ( ModelClassListType IReadOnlyList`1<IExtraStoryStatus> IReadOnlyList`1<IExtraStoryStatus> List<IExtraStoryStatus> Pointer )

            return value;
        }
    }
}
