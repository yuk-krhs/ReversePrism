using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SubCategoryId                            0001865F4260 ModelPrimitiveType int int int Int32
    // 014 IsNew                                    0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 015 IsUnread                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 018 ExtraStoryType                           0001865F40A0 ModelEnumType ExtraStoryType ExtraStoryType ExtraStoryType Int32
    public partial class ExtraStorySecondCategoryCellData : DataModel
    {
        public int                                      SubCategoryId                           { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public bool                                     IsUnread                                { get; set; }
        public ExtraStoryType                           ExtraStoryType                          { get; set; }

        public static ExtraStorySecondCategoryCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStorySecondCategoryCellData() { Pointer= p0 };

            value.SubCategoryId                             = GetInt32(new IntPtr(p + 0x010)); // 0246667FCA68 0x10 SubCategoryId               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x014)); // 0246667FCA88 0x14 IsNew                       ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x015)); // 0246667FCAA8 0x15 IsUnread                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ExtraStoryType                            = (ExtraStoryType)GetInt32(new IntPtr(p + 0x018)); // 0246667FCAC8 0x18 ExtraStoryType              ( 0001865F40A0 ModelEnumType ExtraStoryType ExtraStoryType ExtraStoryType Int32 )

            return value;
        }
    }
}
