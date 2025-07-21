using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SubCategoryId                            ModelPrimitiveType int int int Int32
    // 014 SortId                                   ModelPrimitiveType int int int Int32
    // 018 IsNew                                    ModelPrimitiveType bool bool bool Bool
    // 019 IsUnread                                 ModelPrimitiveType bool bool bool Bool
    // 01C JumpType                                 ModelEnumType ExtraStorySubCategoryJumpType ExtraStorySubCategoryJumpType ExtraStorySubCategoryJumpType Int32
    public partial class ExtraStorySecondCategoryCellData : DataModel
    {
        public int                                      SubCategoryId                           { get; set; }
        public int                                      SortId                                  { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public bool                                     IsUnread                                { get; set; }
        public ExtraStorySubCategoryJumpType            JumpType                                { get; set; }

        public static ExtraStorySecondCategoryCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStorySecondCategoryCellData() { Pointer= p0 };

            value.SubCategoryId                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 SubCategoryId               ( ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x018)); // 0x18 IsNew                       ( ModelPrimitiveType bool bool bool Bool )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x019)); // 0x19 IsUnread                    ( ModelPrimitiveType bool bool bool Bool )
            value.JumpType                                  = (ExtraStorySubCategoryJumpType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C JumpType                    ( ModelEnumType ExtraStorySubCategoryJumpType ExtraStorySubCategoryJumpType ExtraStorySubCategoryJumpType Int32 )

            return value;
        }
    }
}
