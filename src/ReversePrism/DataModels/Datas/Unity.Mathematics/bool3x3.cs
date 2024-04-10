using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       0001866C21A0 ModelEnumType bool3 bool3 bool3 Int32
    // 013 C1                                       0001866C21A0 ModelEnumType bool3 bool3 bool3 Int32
    // 016 C2                                       0001866C21A0 ModelEnumType bool3 bool3 bool3 Int32
    public partial class bool3x3 : DataModel
    {
        public bool3                                    C0                                      { get; set; }
        public bool3                                    C1                                      { get; set; }
        public bool3                                    C2                                      { get; set; }

        public static bool3x3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new bool3x3() { Pointer= p0 };

            value.C0                                        = (bool3)GetInt32(new IntPtr(p + 0x010)); // 024667EB5940 0x10 C0                          ( 0001866C21A0 ModelEnumType bool3 bool3 bool3 Int32 )
            value.C1                                        = (bool3)GetInt32(new IntPtr(p + 0x013)); // 024667EB5960 0x13 C1                          ( 0001866C21A0 ModelEnumType bool3 bool3 bool3 Int32 )
            value.C2                                        = (bool3)GetInt32(new IntPtr(p + 0x016)); // 024667EB5980 0x16 C2                          ( 0001866C21A0 ModelEnumType bool3 bool3 bool3 Int32 )

            return value;
        }
    }
}
