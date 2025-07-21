using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BgImage                                  ModelClassType UIImage UIImage UIImage Pointer
    // 028 EventPeriodText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 EventPointObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 038 EventPointText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ViewTitle                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 048 CellList                                 ModelClassType StoryLastCategoryCellListView StoryLastCategoryCellListView StoryLastCategoryCellListView Pointer
    public partial class EventStoryLastCategoryView : DataModel
    {
        public UIImage?                                 BgImage                                 { get; set; }
        public UITextMeshProUGUI?                       EventPeriodText                         { get; set; }
        public GameObject?                              EventPointObject                        { get; set; }
        public UITextMeshProUGUI?                       EventPointText                          { get; set; }
        public CommonTitleView?                         ViewTitle                               { get; set; }
        public StoryLastCategoryCellListView?           CellList                                { get; set; }

        public static EventStoryLastCategoryView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventStoryLastCategoryView() { Pointer= p0 };

            value.BgImage                                   = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 BgImage                     ( ModelClassType UIImage UIImage UIImage Pointer )
            value.EventPeriodText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 EventPeriodText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventPointObject                          = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 EventPointObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EventPointText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 EventPointText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViewTitle                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x040), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x40 ViewTitle                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.CellList                                  = GetObject<StoryLastCategoryCellListView>(new IntPtr(p + 0x048), ReversePrism.DataModels.StoryLastCategoryCellListView.FromPointer); // 0x48 CellList                    ( ModelClassType StoryLastCategoryCellListView StoryLastCategoryCellListView StoryLastCategoryCellListView Pointer )

            return value;
        }
    }
}
