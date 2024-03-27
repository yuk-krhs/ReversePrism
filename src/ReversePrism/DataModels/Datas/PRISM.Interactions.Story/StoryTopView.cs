using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 StoryTopTabGroup                         0001865AF6D0 ModelClassType StoryTopTabGroup StoryTopTabGroup StoryTopTabGroup Pointer
    // 030 MainContentView                          0001865ACA90 ModelClassType StoryTopMainContentView StoryTopMainContentView StoryTopMainContentView Pointer
    // 038 IdolContentView                          0001865AB6F0 ModelClassType StoryTopIdolContentView StoryTopIdolContentView StoryTopIdolContentView Pointer
    // 040 EventContentView                         0001865A7930 ModelClassType StoryTopEventContentView StoryTopEventContentView StoryTopEventContentView Pointer
    // 048 ExtraContentView                         0001865A87F0 ModelClassType StoryTopExtraContentView StoryTopExtraContentView StoryTopExtraContentView Pointer
    // 050 FavoriteContentView                      0001865AA7E0 ModelClassType StoryTopFavoriteContentView StoryTopFavoriteContentView StoryTopFavoriteContentView Pointer
    // 058 SearchContentView                        0001865AE810 ModelClassType StoryTopSearchContentView StoryTopSearchContentView StoryTopSearchContentView Pointer
    // 060 AdvTransitionerView                      0001865A6340 ModelClassType StoryToAdvTransitionerView StoryToAdvTransitionerView StoryToAdvTransitionerView Pointer
    // 068 contentViewDic                           Dictionary`2<int, GameObject> IL2CPP_TYPE_GENERICINST
    // 070 scrollerDic                              Dictionary`2<int, IStoryScroller> IL2CPP_TYPE_GENERICINST
    public partial class StoryTopView
    {
        public CommonTitleView?                         TitleView                               { get; set; }
        public StoryTopTabGroup?                        StoryTopTabGroup                        { get; set; }
        public StoryTopMainContentView?                 MainContentView                         { get; set; }
        public StoryTopIdolContentView?                 IdolContentView                         { get; set; }
        public StoryTopEventContentView?                EventContentView                        { get; set; }
        public StoryTopExtraContentView?                ExtraContentView                        { get; set; }
        public StoryTopFavoriteContentView?             FavoriteContentView                     { get; set; }
        public StoryTopSearchContentView?               SearchContentView                       { get; set; }
        public StoryToAdvTransitionerView?              AdvTransitionerView                     { get; set; }

        public static StoryTopView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopView();

            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270DB646D68 0x20 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.StoryTopTabGroup                          = GetObject<StoryTopTabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.StoryTopTabGroup.FromPointer); // 0270DB646D88 0x28 StoryTopTabGroup            ( 0001865AF6D0 ModelClassType StoryTopTabGroup StoryTopTabGroup StoryTopTabGroup Pointer )
            value.MainContentView                           = GetObject<StoryTopMainContentView>(new IntPtr(p + 0x030), ReversePrism.DataModels.StoryTopMainContentView.FromPointer); // 0270DB646DA8 0x30 MainContentView             ( 0001865ACA90 ModelClassType StoryTopMainContentView StoryTopMainContentView StoryTopMainContentView Pointer )
            value.IdolContentView                           = GetObject<StoryTopIdolContentView>(new IntPtr(p + 0x038), ReversePrism.DataModels.StoryTopIdolContentView.FromPointer); // 0270DB646DC8 0x38 IdolContentView             ( 0001865AB6F0 ModelClassType StoryTopIdolContentView StoryTopIdolContentView StoryTopIdolContentView Pointer )
            value.EventContentView                          = GetObject<StoryTopEventContentView>(new IntPtr(p + 0x040), ReversePrism.DataModels.StoryTopEventContentView.FromPointer); // 0270DB646DE8 0x40 EventContentView            ( 0001865A7930 ModelClassType StoryTopEventContentView StoryTopEventContentView StoryTopEventContentView Pointer )
            value.ExtraContentView                          = GetObject<StoryTopExtraContentView>(new IntPtr(p + 0x048), ReversePrism.DataModels.StoryTopExtraContentView.FromPointer); // 0270DB646E08 0x48 ExtraContentView            ( 0001865A87F0 ModelClassType StoryTopExtraContentView StoryTopExtraContentView StoryTopExtraContentView Pointer )
            value.FavoriteContentView                       = GetObject<StoryTopFavoriteContentView>(new IntPtr(p + 0x050), ReversePrism.DataModels.StoryTopFavoriteContentView.FromPointer); // 0270DB646E28 0x50 FavoriteContentView         ( 0001865AA7E0 ModelClassType StoryTopFavoriteContentView StoryTopFavoriteContentView StoryTopFavoriteContentView Pointer )
            value.SearchContentView                         = GetObject<StoryTopSearchContentView>(new IntPtr(p + 0x058), ReversePrism.DataModels.StoryTopSearchContentView.FromPointer); // 0270DB646E48 0x58 SearchContentView           ( 0001865AE810 ModelClassType StoryTopSearchContentView StoryTopSearchContentView StoryTopSearchContentView Pointer )
            value.AdvTransitionerView                       = GetObject<StoryToAdvTransitionerView>(new IntPtr(p + 0x060), ReversePrism.DataModels.StoryToAdvTransitionerView.FromPointer); // 0270DB646E68 0x60 AdvTransitionerView         ( 0001865A6340 ModelClassType StoryToAdvTransitionerView StoryToAdvTransitionerView StoryToAdvTransitionerView Pointer )

            return value;
        }
    }
}
