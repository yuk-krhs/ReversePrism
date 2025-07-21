using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TabIndex                                 ModelPrimitiveType int int int Int32
    // 018 ScrollPositionHolder                     ModelClassType StoryViewScrollPositionHolder StoryViewScrollPositionHolder StoryViewScrollPositionHolder Pointer
    // 020 MainContentArgument                      ModelClassType StoryTopMainContentArgument StoryTopMainContentArgument StoryTopMainContentArgument Pointer
    // 028 IdolContentArgument                      ModelClassType StoryTopIdolContentArgument StoryTopIdolContentArgument StoryTopIdolContentArgument Pointer
    // 030 EventContentArgument                     ModelClassType StoryTopEventContentArgument StoryTopEventContentArgument StoryTopEventContentArgument Pointer
    // 038 ExtraContentArgument                     ModelClassType StoryTopExtraContentArgument StoryTopExtraContentArgument StoryTopExtraContentArgument Pointer
    // 040 FavoriteContentArgument                  ModelClassType StoryTopFavoriteContentArgument StoryTopFavoriteContentArgument StoryTopFavoriteContentArgument Pointer
    // 048 SearchContentArgument                    ModelClassType StoryTopStorySearchContentArgument StoryTopStorySearchContentArgument StoryTopStorySearchContentArgument Pointer
    public partial class StoryTopLegacyParameter : DataModel
    {
        public int                                      TabIndex                                { get; set; }
        public StoryViewScrollPositionHolder?           ScrollPositionHolder                    { get; set; }
        public StoryTopMainContentArgument?             MainContentArgument                     { get; set; }
        public StoryTopIdolContentArgument?             IdolContentArgument                     { get; set; }
        public StoryTopEventContentArgument?            EventContentArgument                    { get; set; }
        public StoryTopExtraContentArgument?            ExtraContentArgument                    { get; set; }
        public StoryTopFavoriteContentArgument?         FavoriteContentArgument                 { get; set; }
        public StoryTopStorySearchContentArgument?      SearchContentArgument                   { get; set; }

        public static StoryTopLegacyParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopLegacyParameter() { Pointer= p0 };

            value.TabIndex                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 TabIndex                    ( ModelPrimitiveType int int int Int32 )
            value.ScrollPositionHolder                      = GetObject<StoryViewScrollPositionHolder>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryViewScrollPositionHolder.FromPointer); // 0x18 ScrollPositionHolder        ( ModelClassType StoryViewScrollPositionHolder StoryViewScrollPositionHolder StoryViewScrollPositionHolder Pointer )
            value.MainContentArgument                       = GetObject<StoryTopMainContentArgument>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryTopMainContentArgument.FromPointer); // 0x20 MainContentArgument         ( ModelClassType StoryTopMainContentArgument StoryTopMainContentArgument StoryTopMainContentArgument Pointer )
            value.IdolContentArgument                       = GetObject<StoryTopIdolContentArgument>(new IntPtr(p + 0x028), ReversePrism.DataModels.StoryTopIdolContentArgument.FromPointer); // 0x28 IdolContentArgument         ( ModelClassType StoryTopIdolContentArgument StoryTopIdolContentArgument StoryTopIdolContentArgument Pointer )
            value.EventContentArgument                      = GetObject<StoryTopEventContentArgument>(new IntPtr(p + 0x030), ReversePrism.DataModels.StoryTopEventContentArgument.FromPointer); // 0x30 EventContentArgument        ( ModelClassType StoryTopEventContentArgument StoryTopEventContentArgument StoryTopEventContentArgument Pointer )
            value.ExtraContentArgument                      = GetObject<StoryTopExtraContentArgument>(new IntPtr(p + 0x038), ReversePrism.DataModels.StoryTopExtraContentArgument.FromPointer); // 0x38 ExtraContentArgument        ( ModelClassType StoryTopExtraContentArgument StoryTopExtraContentArgument StoryTopExtraContentArgument Pointer )
            value.FavoriteContentArgument                   = GetObject<StoryTopFavoriteContentArgument>(new IntPtr(p + 0x040), ReversePrism.DataModels.StoryTopFavoriteContentArgument.FromPointer); // 0x40 FavoriteContentArgument     ( ModelClassType StoryTopFavoriteContentArgument StoryTopFavoriteContentArgument StoryTopFavoriteContentArgument Pointer )
            value.SearchContentArgument                     = GetObject<StoryTopStorySearchContentArgument>(new IntPtr(p + 0x048), ReversePrism.DataModels.StoryTopStorySearchContentArgument.FromPointer); // 0x48 SearchContentArgument       ( ModelClassType StoryTopStorySearchContentArgument StoryTopStorySearchContentArgument StoryTopStorySearchContentArgument Pointer )

            return value;
        }
    }
}
