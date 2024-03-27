using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_AddComponentMenu                       000186671910 ModelPrimitiveType string string string String
    // 018 M_Ordering                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AddComponentMenu
    {
        public string                                   M_AddComponentMenu                      { get; set; }
        public int                                      M_Ordering                              { get; set; }

        public static AddComponentMenu? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AddComponentMenu();

            value.M_AddComponentMenu                        = GetString(new IntPtr(p + 0x010)); // 0270024F00C8 0x10 M_AddComponentMenu          ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Ordering                                = GetInt32(new IntPtr(p + 0x018)); // 0270024F00E8 0x18 M_Ordering                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
