using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 SearchResult                             ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer
    // 040 Reference                                ModelClassType HierarchyDataRoot HierarchyDataRoot HierarchyDataRoot Pointer
    // 048 SearchTerm                               ModelPrimitiveType string string string String
    public partial class HierarchyDataRootSearch : DataModel
    {
        public List<Transform>?                         SearchResult                            { get; set; }
        public HierarchyDataRoot?                       Reference                               { get; set; }
        public string                                   SearchTerm                              { get; set; }

        public static HierarchyDataRootSearch? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HierarchyDataRootSearch() { Pointer= p0 };

            value.SearchResult                              = GetObjectList<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0x38 SearchResult                ( ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer )
            value.Reference                                 = GetObject<HierarchyDataRoot>(new IntPtr(p + 0x040), ReversePrism.DataModels.HierarchyDataRoot.FromPointer); // 0x40 Reference                   ( ModelClassType HierarchyDataRoot HierarchyDataRoot HierarchyDataRoot Pointer )
            value.SearchTerm                                = GetString(new IntPtr(p + 0x048)); // 0x48 SearchTerm                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
