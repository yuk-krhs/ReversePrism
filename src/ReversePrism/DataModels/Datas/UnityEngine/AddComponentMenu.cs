using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_AddComponentMenu                       ModelPrimitiveType string string string String
    // 018 M_Ordering                               ModelPrimitiveType int int int Int32
    public partial class AddComponentMenu : DataModel
    {
        public string                                   M_AddComponentMenu                      { get; set; }
        public int                                      M_Ordering                              { get; set; }

        public static AddComponentMenu? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AddComponentMenu() { Pointer= p0 };

            value.M_AddComponentMenu                        = GetString(new IntPtr(p + 0x010)); // 0x10 M_AddComponentMenu          ( ModelPrimitiveType string string string String )
            value.M_Ordering                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Ordering                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
