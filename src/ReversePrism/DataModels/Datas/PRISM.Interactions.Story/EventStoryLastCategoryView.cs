using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BgImage                                  0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 EventPeriodText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 EventPointObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 EventPointText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ViewTitle                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 048 CellList                                 000186769FF0 ModelClassType EventStoryLastCategoryCellList EventStoryLastCategoryCellList EventStoryLastCategoryCellList Pointer
    // 050 AdvTransitionerView                      0001865A6340 ModelClassType StoryToAdvTransitionerView StoryToAdvTransitionerView StoryToAdvTransitionerView Pointer
    public partial class EventStoryLastCategoryView
    {
        public UIImage?                                 BgImage                                 { get; set; }
        public UITextMeshProUGUI?                       EventPeriodText                         { get; set; }
        public GameObject?                              EventPointObject                        { get; set; }
        public UITextMeshProUGUI?                       EventPointText                          { get; set; }
        public CommonTitleView?                         ViewTitle                               { get; set; }
        public EventStoryLastCategoryCellList?          CellList                                { get; set; }
        public StoryToAdvTransitionerView?              AdvTransitionerView                     { get; set; }

        public static EventStoryLastCategoryView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventStoryLastCategoryView();

            value.BgImage                                   = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB646A28 0x20 BgImage                     ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.EventPeriodText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB646A48 0x28 EventPeriodText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventPointObject                          = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB646A68 0x30 EventPointObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EventPointText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB646A88 0x38 EventPointText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViewTitle                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x040), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270DB646AA8 0x40 ViewTitle                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.CellList                                  = GetObject<EventStoryLastCategoryCellList>(new IntPtr(p + 0x048), ReversePrism.DataModels.EventStoryLastCategoryCellList.FromPointer); // 0270DB646AC8 0x48 CellList                    ( 000186769FF0 ModelClassType EventStoryLastCategoryCellList EventStoryLastCategoryCellList EventStoryLastCategoryCellList Pointer )
            value.AdvTransitionerView                       = GetObject<StoryToAdvTransitionerView>(new IntPtr(p + 0x050), ReversePrism.DataModels.StoryToAdvTransitionerView.FromPointer); // 0270DB646AE8 0x50 AdvTransitionerView         ( 0001865A6340 ModelClassType StoryToAdvTransitionerView StoryToAdvTransitionerView StoryToAdvTransitionerView Pointer )

            return value;
        }
    }
}
