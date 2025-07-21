using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScrollPosition                           ModelPrimitiveType float float float Single
    // 014 HasSearched                              ModelPrimitiveType bool bool bool Bool
    // 015 HasVisited                               ModelPrimitiveType bool bool bool Bool
    // 018 AdvTransitionerModel                     ModelClassType StoryToAdvTransitionerModel StoryToAdvTransitionerModel StoryToAdvTransitionerModel Pointer
    public partial class StoryTopFavoriteContentArgument : DataModel
    {
        public float                                    ScrollPosition                          { get; set; }
        public bool                                     HasSearched                             { get; set; }
        public bool                                     HasVisited                              { get; set; }
        public StoryToAdvTransitionerModel?             AdvTransitionerModel                    { get; set; }

        public static StoryTopFavoriteContentArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopFavoriteContentArgument() { Pointer= p0 };

            value.ScrollPosition                            = GetSingle(new IntPtr(p + 0x010)); // 0x10 ScrollPosition              ( ModelPrimitiveType float float float Single )
            value.HasSearched                               = GetBool(new IntPtr(p + 0x014)); // 0x14 HasSearched                 ( ModelPrimitiveType bool bool bool Bool )
            value.HasVisited                                = GetBool(new IntPtr(p + 0x015)); // 0x15 HasVisited                  ( ModelPrimitiveType bool bool bool Bool )
            value.AdvTransitionerModel                      = GetObject<StoryToAdvTransitionerModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryToAdvTransitionerModel.FromPointer); // 0x18 AdvTransitionerModel        ( ModelClassType StoryToAdvTransitionerModel StoryToAdvTransitionerModel StoryToAdvTransitionerModel Pointer )

            return value;
        }
    }
}
