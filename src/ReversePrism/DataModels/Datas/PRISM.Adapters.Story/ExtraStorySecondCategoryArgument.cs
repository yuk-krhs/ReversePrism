using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CategoryId                               ModelPrimitiveType int int int Int32
    // 014 ScrollPosition                           ModelPrimitiveType float float float Single
    // 018 IsUnreadToggleOn                         ModelPrimitiveType bool bool bool Bool
    public partial class ExtraStorySecondCategoryArgument : DataModel
    {
        public int                                      CategoryId                              { get; set; }
        public float                                    ScrollPosition                          { get; set; }
        public bool                                     IsUnreadToggleOn                        { get; set; }

        public static ExtraStorySecondCategoryArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStorySecondCategoryArgument() { Pointer= p0 };

            value.CategoryId                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 CategoryId                  ( ModelPrimitiveType int int int Int32 )
            value.ScrollPosition                            = GetSingle(new IntPtr(p + 0x014)); // 0x14 ScrollPosition              ( ModelPrimitiveType float float float Single )
            value.IsUnreadToggleOn                          = GetBool(new IntPtr(p + 0x018)); // 0x18 IsUnreadToggleOn            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
