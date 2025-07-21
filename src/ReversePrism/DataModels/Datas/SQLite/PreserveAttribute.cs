using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AllMembers                               ModelPrimitiveType bool bool bool Bool
    // 011 Conditional                              ModelPrimitiveType bool bool bool Bool
    public partial class PreserveAttribute : DataModel
    {
        public bool                                     AllMembers                              { get; set; }
        public bool                                     Conditional                             { get; set; }

        public static PreserveAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PreserveAttribute() { Pointer= p0 };

            value.AllMembers                                = GetBool(new IntPtr(p + 0x010)); // 0x10 AllMembers                  ( ModelPrimitiveType bool bool bool Bool )
            value.Conditional                               = GetBool(new IntPtr(p + 0x011)); // 0x11 Conditional                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
