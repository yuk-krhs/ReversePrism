using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       0001866C1A60 ModelEnumType bool2 bool2 bool2 Int32
    // 012 C1                                       0001866C1A60 ModelEnumType bool2 bool2 bool2 Int32
    public partial class bool2x2 : DataModel
    {
        public bool2                                    C0                                      { get; set; }
        public bool2                                    C1                                      { get; set; }

        public static bool2x2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new bool2x2() { Pointer= p0 };

            value.C0                                        = (bool2)GetInt32(new IntPtr(p + 0x010)); // 024667EB2070 0x10 C0                          ( 0001866C1A60 ModelEnumType bool2 bool2 bool2 Int32 )
            value.C1                                        = (bool2)GetInt32(new IntPtr(p + 0x012)); // 024667EB2090 0x12 C1                          ( 0001866C1A60 ModelEnumType bool2 bool2 bool2 Int32 )

            return value;
        }
    }
}
