using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CategoryId                               ModelPrimitiveType int int int Int32
    // 014 SortId                                   ModelPrimitiveType int int int Int32
    // 018 IsNew                                    ModelPrimitiveType bool bool bool Bool
    // 019 IsUnread                                 ModelPrimitiveType bool bool bool Bool
    public partial class MainStoryFirstCategoryCellData : DataModel
    {
        public int                                      CategoryId                              { get; set; }
        public int                                      SortId                                  { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public bool                                     IsUnread                                { get; set; }

        public static MainStoryFirstCategoryCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainStoryFirstCategoryCellData() { Pointer= p0 };

            value.CategoryId                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 CategoryId                  ( ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x018)); // 0x18 IsNew                       ( ModelPrimitiveType bool bool bool Bool )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x019)); // 0x19 IsUnread                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
