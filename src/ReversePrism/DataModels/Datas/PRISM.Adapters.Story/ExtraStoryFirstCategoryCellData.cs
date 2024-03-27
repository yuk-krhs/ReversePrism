using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CategoryId                               0001865F4260 ModelPrimitiveType int int int Int32
    // 014 IsNew                                    0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 015 IsUnread                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class ExtraStoryFirstCategoryCellData
    {
        public int                                      CategoryId                              { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public bool                                     IsUnread                                { get; set; }

        public static ExtraStoryFirstCategoryCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStoryFirstCategoryCellData();

            value.CategoryId                                = GetInt32(new IntPtr(p + 0x010)); // 0270D67E3EB8 0x10 CategoryId                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x014)); // 0270D67E3ED8 0x14 IsNew                       ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x015)); // 0270D67E3EF8 0x15 IsUnread                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
