using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellPos                                  0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 AllStoriesReadText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 StoryScroller                            00018659B950 ModelClassType StoryScroller StoryScroller StoryScroller Pointer
    public partial class StoryLastCategoryScroller : DataModel
    {
        public Transform?                               CellPos                                 { get; set; }
        public UITextMeshProUGUI?                       AllStoriesReadText                      { get; set; }
        public StoryScroller?                           StoryScroller                           { get; set; }

        public static StoryLastCategoryScroller? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryLastCategoryScroller() { Pointer= p0 };

            value.CellPos                                   = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 02466B9CCCA0 0x20 CellPos                     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.AllStoriesReadText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B9CCCC0 0x28 AllStoriesReadText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StoryScroller                             = GetObject<StoryScroller>(new IntPtr(p + 0x030), ReversePrism.DataModels.StoryScroller.FromPointer); // 02466B9CCCE0 0x30 StoryScroller               ( 00018659B950 ModelClassType StoryScroller StoryScroller StoryScroller Pointer )

            return value;
        }
    }
}
