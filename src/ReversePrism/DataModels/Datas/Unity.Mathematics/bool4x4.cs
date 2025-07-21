using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       ModelEnumType bool4 bool4 bool4 Int32
    // 014 C1                                       ModelEnumType bool4 bool4 bool4 Int32
    // 018 C2                                       ModelEnumType bool4 bool4 bool4 Int32
    // 01C C3                                       ModelEnumType bool4 bool4 bool4 Int32
    public partial class bool4x4 : DataModel
    {
        public bool4                                    C0                                      { get; set; }
        public bool4                                    C1                                      { get; set; }
        public bool4                                    C2                                      { get; set; }
        public bool4                                    C3                                      { get; set; }

        public static bool4x4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new bool4x4() { Pointer= p0 };

            value.C0                                        = (bool4)GetInt32(new IntPtr(p + 0x010)); // 0x10 C0                          ( ModelEnumType bool4 bool4 bool4 Int32 )
            value.C1                                        = (bool4)GetInt32(new IntPtr(p + 0x014)); // 0x14 C1                          ( ModelEnumType bool4 bool4 bool4 Int32 )
            value.C2                                        = (bool4)GetInt32(new IntPtr(p + 0x018)); // 0x18 C2                          ( ModelEnumType bool4 bool4 bool4 Int32 )
            value.C3                                        = (bool4)GetInt32(new IntPtr(p + 0x01C)); // 0x1C C3                          ( ModelEnumType bool4 bool4 bool4 Int32 )

            return value;
        }
    }
}
