using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 SearchResult                             000185D16118 ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer
    // 040 Reference                                0001866B4610 ModelClassType HierarchyDataRoot HierarchyDataRoot HierarchyDataRoot Pointer
    // 048 SearchTerm                               000186671910 ModelPrimitiveType string string string String
    public partial class HierarchyDataRootSearch
    {
        public List<Transform>?                         SearchResult                            { get; set; }
        public HierarchyDataRoot?                       Reference                               { get; set; }
        public string                                   SearchTerm                              { get; set; }

        public static HierarchyDataRootSearch? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HierarchyDataRootSearch();

            value.SearchResult                              = GetObjectList<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0270DB1B8878 0x38 SearchResult                ( 000185D16118 ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer )
            value.Reference                                 = GetObject<HierarchyDataRoot>(new IntPtr(p + 0x040), ReversePrism.DataModels.HierarchyDataRoot.FromPointer); // 0270DB1B8898 0x40 Reference                   ( 0001866B4610 ModelClassType HierarchyDataRoot HierarchyDataRoot HierarchyDataRoot Pointer )
            value.SearchTerm                                = GetString(new IntPtr(p + 0x048)); // 0270DB1B88B8 0x48 SearchTerm                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
