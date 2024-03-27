using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CategoryId                               0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ExtraStories                             000185CF6BC8 ModelClassListType IReadOnlyList`1<IExtraStoryStatus> IReadOnlyList`1<IExtraStoryStatus> List<IExtraStoryStatus> Pointer
    public partial class ExtraStorySecondCategoryModel
    {
        public int                                      CategoryId                              { get; set; }
        public List<IExtraStoryStatus>?                 ExtraStories                            { get; set; }

        public static ExtraStorySecondCategoryModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStorySecondCategoryModel();

            value.CategoryId                                = GetInt32(new IntPtr(p + 0x010)); // 0270D679EC38 0x10 CategoryId                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ExtraStories                              = GetObjectList<IExtraStoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IExtraStoryStatus.FromPointer); // 0270D679EC58 0x18 ExtraStories                ( 000185CF6BC8 ModelClassListType IReadOnlyList`1<IExtraStoryStatus> IReadOnlyList`1<IExtraStoryStatus> List<IExtraStoryStatus> Pointer )

            return value;
        }
    }
}
