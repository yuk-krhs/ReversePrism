using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 EmptyViewText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 AllCellDataList                          ModelClassListType IReadOnlyList`1<MainStoryFirstCategoryCellData> IReadOnlyList`1<MainStoryFirstCategoryCellData> List<MainStoryFirstCategoryCellData> Pointer
    public partial class MainStoryFirstCategoryCellList : DataModel
    {
        public UITextMeshProUGUI?                       EmptyViewText                           { get; set; }
        public List<MainStoryFirstCategoryCellData>?    AllCellDataList                         { get; set; }

        public static MainStoryFirstCategoryCellList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainStoryFirstCategoryCellList() { Pointer= p0 };

            value.EmptyViewText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 EmptyViewText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AllCellDataList                           = GetObjectList<MainStoryFirstCategoryCellData>(new IntPtr(p + 0x060), ReversePrism.DataModels.MainStoryFirstCategoryCellData.FromPointer); // 0x60 AllCellDataList             ( ModelClassListType IReadOnlyList`1<MainStoryFirstCategoryCellData> IReadOnlyList`1<MainStoryFirstCategoryCellData> List<MainStoryFirstCategoryCellData> Pointer )

            return value;
        }
    }
}
