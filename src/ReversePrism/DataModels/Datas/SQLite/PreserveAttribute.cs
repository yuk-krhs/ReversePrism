using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AllMembers                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 011 Conditional                              000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class PreserveAttribute
    {
        public bool                                     AllMembers                              { get; set; }
        public bool                                     Conditional                             { get; set; }

        public static PreserveAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PreserveAttribute();

            value.AllMembers                                = GetBool(new IntPtr(p + 0x010)); // 0270DB2C5240 0x10 AllMembers                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Conditional                               = GetBool(new IntPtr(p + 0x011)); // 0270DB2C5260 0x11 Conditional                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
