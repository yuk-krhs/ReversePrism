using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_View                                   000186745A50 ModelClassType BaseVerticalCollectionView BaseVerticalCollectionView BaseVerticalCollectionView Pointer
    // 018 M_SortedSelectedIds                      000185CED038 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 020 EnableReordering                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class BaseReorderableDragAndDropController : DataModel
    {
        public BaseVerticalCollectionView?              M_View                                  { get; set; }
        public List<int>?                               M_SortedSelectedIds                     { get; set; }
        public bool                                     EnableReordering                        { get; set; }

        public static BaseReorderableDragAndDropController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseReorderableDragAndDropController() { Pointer= p0 };

            value.M_View                                    = GetObject<BaseVerticalCollectionView>(new IntPtr(p + 0x010), ReversePrism.DataModels.BaseVerticalCollectionView.FromPointer); // 0245A6715900 0x10 M_View                      ( 000186745A50 ModelClassType BaseVerticalCollectionView BaseVerticalCollectionView BaseVerticalCollectionView Pointer )
            value.M_SortedSelectedIds                       = GetInt32List(new IntPtr(p + 0x018)); // 0245A6715920 0x18 M_SortedSelectedIds         ( 000185CED038 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.EnableReordering                          = GetBool(new IntPtr(p + 0x020)); // 0245A6715940 0x20 EnableReordering            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
