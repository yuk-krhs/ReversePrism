using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TabIndex                                 ModelPrimitiveType int int int Int32
    // 018 MainContentArgument                      ModelClassType StoryTopMainContentArgument StoryTopMainContentArgument StoryTopMainContentArgument Pointer
    // 020 IdolContentArgument                      ModelClassType StoryTopIdolContentArgument StoryTopIdolContentArgument StoryTopIdolContentArgument Pointer
    // 028 EventContentArgument                     ModelClassType StoryTopEventContentArgument StoryTopEventContentArgument StoryTopEventContentArgument Pointer
    // 030 ExtraContentArgument                     ModelClassType StoryTopExtraContentArgument StoryTopExtraContentArgument StoryTopExtraContentArgument Pointer
    // 038 FavoriteContentArgument                  ModelClassType StoryTopFavoriteContentArgument StoryTopFavoriteContentArgument StoryTopFavoriteContentArgument Pointer
    // 040 SearchContentArgument                    ModelClassType StoryTopSearchContentArgument StoryTopSearchContentArgument StoryTopSearchContentArgument Pointer
    public partial class StoryTopArgument : DataModel
    {
        public int                                      TabIndex                                { get; set; }
        public StoryTopMainContentArgument?             MainContentArgument                     { get; set; }
        public StoryTopIdolContentArgument?             IdolContentArgument                     { get; set; }
        public StoryTopEventContentArgument?            EventContentArgument                    { get; set; }
        public StoryTopExtraContentArgument?            ExtraContentArgument                    { get; set; }
        public StoryTopFavoriteContentArgument?         FavoriteContentArgument                 { get; set; }
        public StoryTopSearchContentArgument?           SearchContentArgument                   { get; set; }

        public static StoryTopArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopArgument() { Pointer= p0 };

            value.TabIndex                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 TabIndex                    ( ModelPrimitiveType int int int Int32 )
            value.MainContentArgument                       = GetObject<StoryTopMainContentArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryTopMainContentArgument.FromPointer); // 0x18 MainContentArgument         ( ModelClassType StoryTopMainContentArgument StoryTopMainContentArgument StoryTopMainContentArgument Pointer )
            value.IdolContentArgument                       = GetObject<StoryTopIdolContentArgument>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoryTopIdolContentArgument.FromPointer); // 0x20 IdolContentArgument         ( ModelClassType StoryTopIdolContentArgument StoryTopIdolContentArgument StoryTopIdolContentArgument Pointer )
            value.EventContentArgument                      = GetObject<StoryTopEventContentArgument>(new IntPtr(p + 0x028), ReversePrism.DataModels.StoryTopEventContentArgument.FromPointer); // 0x28 EventContentArgument        ( ModelClassType StoryTopEventContentArgument StoryTopEventContentArgument StoryTopEventContentArgument Pointer )
            value.ExtraContentArgument                      = GetObject<StoryTopExtraContentArgument>(new IntPtr(p + 0x030), ReversePrism.DataModels.StoryTopExtraContentArgument.FromPointer); // 0x30 ExtraContentArgument        ( ModelClassType StoryTopExtraContentArgument StoryTopExtraContentArgument StoryTopExtraContentArgument Pointer )
            value.FavoriteContentArgument                   = GetObject<StoryTopFavoriteContentArgument>(new IntPtr(p + 0x038), ReversePrism.DataModels.StoryTopFavoriteContentArgument.FromPointer); // 0x38 FavoriteContentArgument     ( ModelClassType StoryTopFavoriteContentArgument StoryTopFavoriteContentArgument StoryTopFavoriteContentArgument Pointer )
            value.SearchContentArgument                     = GetObject<StoryTopSearchContentArgument>(new IntPtr(p + 0x040), ReversePrism.DataModels.StoryTopSearchContentArgument.FromPointer); // 0x40 SearchContentArgument       ( ModelClassType StoryTopSearchContentArgument StoryTopSearchContentArgument StoryTopSearchContentArgument Pointer )

            return value;
        }
    }
}
