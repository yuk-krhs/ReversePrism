using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       0001866C28B0 ModelEnumType bool4 bool4 bool4 Int32
    // 014 C1                                       0001866C28B0 ModelEnumType bool4 bool4 bool4 Int32
    public partial class bool4x2
    {
        public bool4                                    C0                                      { get; set; }
        public bool4                                    C1                                      { get; set; }

        public static bool4x2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new bool4x2();

            value.C0                                        = (bool4)GetInt32(new IntPtr(p + 0x010)); // 0270D7E4ADB8 0x10 C0                          ( 0001866C28B0 ModelEnumType bool4 bool4 bool4 Int32 )
            value.C1                                        = (bool4)GetInt32(new IntPtr(p + 0x014)); // 0270D7E4ADD8 0x14 C1                          ( 0001866C28B0 ModelEnumType bool4 bool4 bool4 Int32 )

            return value;
        }
    }
}
