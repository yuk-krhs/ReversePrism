using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MainStoryFirstCategoryId                 ModelPrimitiveType int int int Int32
    // 018 MainStories                              ModelClassListType IReadOnlyList`1<IMainStoryStatus> IReadOnlyList`1<IMainStoryStatus> List<IMainStoryStatus> Pointer
    public partial class MainStoryLastCategoryModel : DataModel
    {
        public int                                      MainStoryFirstCategoryId                { get; set; }
        public List<IMainStoryStatus>?                  MainStories                             { get; set; }

        public static MainStoryLastCategoryModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainStoryLastCategoryModel() { Pointer= p0 };

            value.MainStoryFirstCategoryId                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 MainStoryFirstCategoryId    ( ModelPrimitiveType int int int Int32 )
            value.MainStories                               = GetObjectList<IMainStoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMainStoryStatus.FromPointer); // 0x18 MainStories                 ( ModelClassListType IReadOnlyList`1<IMainStoryStatus> IReadOnlyList`1<IMainStoryStatus> List<IMainStoryStatus> Pointer )

            return value;
        }
    }
}
