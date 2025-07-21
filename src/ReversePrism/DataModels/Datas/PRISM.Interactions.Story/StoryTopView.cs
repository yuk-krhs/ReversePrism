using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 StoryTopTabGroup                         ModelClassType StoryTopTabGroup StoryTopTabGroup StoryTopTabGroup Pointer
    // 030 MainContentView                          ModelClassType StoryTopMainContentView StoryTopMainContentView StoryTopMainContentView Pointer
    // 038 IdolContentView                          ModelClassType StoryTopIdolContentView StoryTopIdolContentView StoryTopIdolContentView Pointer
    // 040 EventContentView                         ModelClassType StoryTopEventContentView StoryTopEventContentView StoryTopEventContentView Pointer
    // 048 ExtraContentView                         ModelClassType StoryTopExtraContentView StoryTopExtraContentView StoryTopExtraContentView Pointer
    // 050 FavoriteContentView                      ModelClassType StoryTopFavoriteContentView StoryTopFavoriteContentView StoryTopFavoriteContentView Pointer
    // 058 SearchContentView                        ModelClassType StoryTopSearchContentView StoryTopSearchContentView StoryTopSearchContentView Pointer
    // 060 contentViewDic                           Dictionary`2<StoryTopContentType, IStoryTopContentView> IL2CPP_TYPE_GENERICINST
    public partial class StoryTopView : DataModel
    {
        public CommonTitleView?                         TitleView                               { get; set; }
        public StoryTopTabGroup?                        StoryTopTabGroup                        { get; set; }
        public StoryTopMainContentView?                 MainContentView                         { get; set; }
        public StoryTopIdolContentView?                 IdolContentView                         { get; set; }
        public StoryTopEventContentView?                EventContentView                        { get; set; }
        public StoryTopExtraContentView?                ExtraContentView                        { get; set; }
        public StoryTopFavoriteContentView?             FavoriteContentView                     { get; set; }
        public StoryTopSearchContentView?               SearchContentView                       { get; set; }

        public static StoryTopView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopView() { Pointer= p0 };

            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x20 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.StoryTopTabGroup                          = GetObject<StoryTopTabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.StoryTopTabGroup.FromPointer); // 0x28 StoryTopTabGroup            ( ModelClassType StoryTopTabGroup StoryTopTabGroup StoryTopTabGroup Pointer )
            value.MainContentView                           = GetObject<StoryTopMainContentView>(new IntPtr(p + 0x030), ReversePrism.DataModels.StoryTopMainContentView.FromPointer); // 0x30 MainContentView             ( ModelClassType StoryTopMainContentView StoryTopMainContentView StoryTopMainContentView Pointer )
            value.IdolContentView                           = GetObject<StoryTopIdolContentView>(new IntPtr(p + 0x038), ReversePrism.DataModels.StoryTopIdolContentView.FromPointer); // 0x38 IdolContentView             ( ModelClassType StoryTopIdolContentView StoryTopIdolContentView StoryTopIdolContentView Pointer )
            value.EventContentView                          = GetObject<StoryTopEventContentView>(new IntPtr(p + 0x040), ReversePrism.DataModels.StoryTopEventContentView.FromPointer); // 0x40 EventContentView            ( ModelClassType StoryTopEventContentView StoryTopEventContentView StoryTopEventContentView Pointer )
            value.ExtraContentView                          = GetObject<StoryTopExtraContentView>(new IntPtr(p + 0x048), ReversePrism.DataModels.StoryTopExtraContentView.FromPointer); // 0x48 ExtraContentView            ( ModelClassType StoryTopExtraContentView StoryTopExtraContentView StoryTopExtraContentView Pointer )
            value.FavoriteContentView                       = GetObject<StoryTopFavoriteContentView>(new IntPtr(p + 0x050), ReversePrism.DataModels.StoryTopFavoriteContentView.FromPointer); // 0x50 FavoriteContentView         ( ModelClassType StoryTopFavoriteContentView StoryTopFavoriteContentView StoryTopFavoriteContentView Pointer )
            value.SearchContentView                         = GetObject<StoryTopSearchContentView>(new IntPtr(p + 0x058), ReversePrism.DataModels.StoryTopSearchContentView.FromPointer); // 0x58 SearchContentView           ( ModelClassType StoryTopSearchContentView StoryTopSearchContentView StoryTopSearchContentView Pointer )

            return value;
        }
    }
}
