using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HasSearched                              ModelPrimitiveType bool bool bool Bool
    // 011 HasVisited                               ModelPrimitiveType bool bool bool Bool
    // 018 AdvTransitionerModel                     ModelClassType StoryToAdvTransitionerModel StoryToAdvTransitionerModel StoryToAdvTransitionerModel Pointer
    public partial class StoryTopStorySearchContentArgument : DataModel
    {
        public bool                                     HasSearched                             { get; set; }
        public bool                                     HasVisited                              { get; set; }
        public StoryToAdvTransitionerModel?             AdvTransitionerModel                    { get; set; }

        public static StoryTopStorySearchContentArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopStorySearchContentArgument() { Pointer= p0 };

            value.HasSearched                               = GetBool(new IntPtr(p + 0x010)); // 0x10 HasSearched                 ( ModelPrimitiveType bool bool bool Bool )
            value.HasVisited                                = GetBool(new IntPtr(p + 0x011)); // 0x11 HasVisited                  ( ModelPrimitiveType bool bool bool Bool )
            value.AdvTransitionerModel                      = GetObject<StoryToAdvTransitionerModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryToAdvTransitionerModel.FromPointer); // 0x18 AdvTransitionerModel        ( ModelClassType StoryToAdvTransitionerModel StoryToAdvTransitionerModel StoryToAdvTransitionerModel Pointer )

            return value;
        }
    }
}
