using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TabIndex                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 ScrollPositionHolder                     0001865B2D20 ModelClassType StoryViewScrollPositionHolder StoryViewScrollPositionHolder StoryViewScrollPositionHolder Pointer
    // 020 MainContentArgument                      0001865AC330 ModelClassType StoryTopMainContentArgument StoryTopMainContentArgument StoryTopMainContentArgument Pointer
    // 028 IdolContentArgument                      0001865AACE0 ModelClassType StoryTopIdolContentArgument StoryTopIdolContentArgument StoryTopIdolContentArgument Pointer
    // 030 EventContentArgument                     0001865A7220 ModelClassType StoryTopEventContentArgument StoryTopEventContentArgument StoryTopEventContentArgument Pointer
    // 038 ExtraContentArgument                     0001865A80A0 ModelClassType StoryTopExtraContentArgument StoryTopExtraContentArgument StoryTopExtraContentArgument Pointer
    // 040 FavoriteContentArgument                  0001865A9430 ModelClassType StoryTopFavoriteContentArgument StoryTopFavoriteContentArgument StoryTopFavoriteContentArgument Pointer
    // 048 SearchContentArgument                    0001865AED10 ModelClassType StoryTopStorySearchContentArgument StoryTopStorySearchContentArgument StoryTopStorySearchContentArgument Pointer
    public partial class StoryTopLegacyParameter
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
            var value   = new StoryTopLegacyParameter();

            value.TabIndex                                  = GetInt32(new IntPtr(p + 0x010)); // 0270D5E40218 0x10 TabIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScrollPositionHolder                      = GetObject<StoryViewScrollPositionHolder>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryViewScrollPositionHolder.FromPointer); // 0270D5E40238 0x18 ScrollPositionHolder        ( 0001865B2D20 ModelClassType StoryViewScrollPositionHolder StoryViewScrollPositionHolder StoryViewScrollPositionHolder Pointer )
            value.MainContentArgument                       = GetObject<StoryTopMainContentArgument>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryTopMainContentArgument.FromPointer); // 0270D5E40258 0x20 MainContentArgument         ( 0001865AC330 ModelClassType StoryTopMainContentArgument StoryTopMainContentArgument StoryTopMainContentArgument Pointer )
            value.IdolContentArgument                       = GetObject<StoryTopIdolContentArgument>(new IntPtr(p + 0x028), ReversePrism.DataModels.StoryTopIdolContentArgument.FromPointer); // 0270D5E40278 0x28 IdolContentArgument         ( 0001865AACE0 ModelClassType StoryTopIdolContentArgument StoryTopIdolContentArgument StoryTopIdolContentArgument Pointer )
            value.EventContentArgument                      = GetObject<StoryTopEventContentArgument>(new IntPtr(p + 0x030), ReversePrism.DataModels.StoryTopEventContentArgument.FromPointer); // 0270D5E40298 0x30 EventContentArgument        ( 0001865A7220 ModelClassType StoryTopEventContentArgument StoryTopEventContentArgument StoryTopEventContentArgument Pointer )
            value.ExtraContentArgument                      = GetObject<StoryTopExtraContentArgument>(new IntPtr(p + 0x038), ReversePrism.DataModels.StoryTopExtraContentArgument.FromPointer); // 0270D5E402B8 0x38 ExtraContentArgument        ( 0001865A80A0 ModelClassType StoryTopExtraContentArgument StoryTopExtraContentArgument StoryTopExtraContentArgument Pointer )
            value.FavoriteContentArgument                   = GetObject<StoryTopFavoriteContentArgument>(new IntPtr(p + 0x040), ReversePrism.DataModels.StoryTopFavoriteContentArgument.FromPointer); // 0270D5E402D8 0x40 FavoriteContentArgument     ( 0001865A9430 ModelClassType StoryTopFavoriteContentArgument StoryTopFavoriteContentArgument StoryTopFavoriteContentArgument Pointer )
            value.SearchContentArgument                     = GetObject<StoryTopStorySearchContentArgument>(new IntPtr(p + 0x048), ReversePrism.DataModels.StoryTopStorySearchContentArgument.FromPointer); // 0270D5E402F8 0x48 SearchContentArgument       ( 0001865AED10 ModelClassType StoryTopStorySearchContentArgument StoryTopStorySearchContentArgument StoryTopStorySearchContentArgument Pointer )

            return value;
        }
    }
}
