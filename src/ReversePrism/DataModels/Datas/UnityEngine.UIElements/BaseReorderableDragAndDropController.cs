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
    public partial class BaseReorderableDragAndDropController
    {
        public BaseVerticalCollectionView?              M_View                                  { get; set; }
        public List<int>?                               M_SortedSelectedIds                     { get; set; }
        public bool                                     EnableReordering                        { get; set; }

        public static BaseReorderableDragAndDropController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseReorderableDragAndDropController();

            value.M_View                                    = GetObject<BaseVerticalCollectionView>(new IntPtr(p + 0x010), ReversePrism.DataModels.BaseVerticalCollectionView.FromPointer); // 027006753998 0x10 M_View                      ( 000186745A50 ModelClassType BaseVerticalCollectionView BaseVerticalCollectionView BaseVerticalCollectionView Pointer )
            value.M_SortedSelectedIds                       = GetInt32List(new IntPtr(p + 0x018)); // 0270067539B8 0x18 M_SortedSelectedIds         ( 000185CED038 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.EnableReordering                          = GetBool(new IntPtr(p + 0x020)); // 0270067539D8 0x20 EnableReordering            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
