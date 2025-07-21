using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SubCategoryId                            ModelPrimitiveType int int int Int32
    // 014 ScrollPosition                           ModelPrimitiveType float float float Single
    // 018 AdvTransitionerModel                     ModelClassType StoryToAdvTransitionerModel StoryToAdvTransitionerModel StoryToAdvTransitionerModel Pointer
    public partial class ExtraStoryLastCategoryArgument : DataModel
    {
        public int                                      SubCategoryId                           { get; set; }
        public float                                    ScrollPosition                          { get; set; }
        public StoryToAdvTransitionerModel?             AdvTransitionerModel                    { get; set; }

        public static ExtraStoryLastCategoryArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStoryLastCategoryArgument() { Pointer= p0 };

            value.SubCategoryId                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 SubCategoryId               ( ModelPrimitiveType int int int Int32 )
            value.ScrollPosition                            = GetSingle(new IntPtr(p + 0x014)); // 0x14 ScrollPosition              ( ModelPrimitiveType float float float Single )
            value.AdvTransitionerModel                      = GetObject<StoryToAdvTransitionerModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryToAdvTransitionerModel.FromPointer); // 0x18 AdvTransitionerModel        ( ModelClassType StoryToAdvTransitionerModel StoryToAdvTransitionerModel StoryToAdvTransitionerModel Pointer )

            return value;
        }
    }
}
