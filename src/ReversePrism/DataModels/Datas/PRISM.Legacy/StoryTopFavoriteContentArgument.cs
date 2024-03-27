using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HasSearched                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 HasVisited                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 AdvTransitionerModel                     0001865A5750 ModelClassType StoryToAdvTransitionerModel StoryToAdvTransitionerModel StoryToAdvTransitionerModel Pointer
    public partial class StoryTopFavoriteContentArgument
    {
        public bool                                     HasSearched                             { get; set; }
        public bool                                     HasVisited                              { get; set; }
        public StoryToAdvTransitionerModel?             AdvTransitionerModel                    { get; set; }

        public static StoryTopFavoriteContentArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopFavoriteContentArgument();

            value.HasSearched                               = GetBool(new IntPtr(p + 0x010)); // 0270D5E3C3A8 0x10 HasSearched                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasVisited                                = GetBool(new IntPtr(p + 0x011)); // 0270D5E3C3C8 0x11 HasVisited                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AdvTransitionerModel                      = GetObject<StoryToAdvTransitionerModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryToAdvTransitionerModel.FromPointer); // 0270D5E3C3E8 0x18 AdvTransitionerModel        ( 0001865A5750 ModelClassType StoryToAdvTransitionerModel StoryToAdvTransitionerModel StoryToAdvTransitionerModel Pointer )

            return value;
        }
    }
}
