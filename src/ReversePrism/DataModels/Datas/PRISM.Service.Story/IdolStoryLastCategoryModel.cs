using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdolId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 018 IdolStories                              000185CFE358 ModelClassListType IReadOnlyList`1<IIdolStoryStatus> IReadOnlyList`1<IIdolStoryStatus> List<IIdolStoryStatus> Pointer
    public partial class IdolStoryLastCategoryModel
    {
        public int                                      IdolId                                  { get; set; }
        public List<IIdolStoryStatus>?                  IdolStories                             { get; set; }

        public static IdolStoryLastCategoryModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStoryLastCategoryModel();

            value.IdolId                                    = GetInt32(new IntPtr(p + 0x010)); // 0270D67BA6F0 0x10 IdolId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IdolStories                               = GetObjectList<IIdolStoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IIdolStoryStatus.FromPointer); // 0270D67BA710 0x18 IdolStories                 ( 000185CFE358 ModelClassListType IReadOnlyList`1<IIdolStoryStatus> IReadOnlyList`1<IIdolStoryStatus> List<IIdolStoryStatus> Pointer )

            return value;
        }
    }
}
