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
    // 014 C2                                       0001866C1A60 ModelEnumType bool2 bool2 bool2 Int32
    // 016 C3                                       0001866C1A60 ModelEnumType bool2 bool2 bool2 Int32
    public partial class bool2x4
    {
        public bool2                                    C0                                      { get; set; }
        public bool2                                    C1                                      { get; set; }
        public bool2                                    C2                                      { get; set; }
        public bool2                                    C3                                      { get; set; }

        public static bool2x4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new bool2x4();

            value.C0                                        = (bool2)GetInt32(new IntPtr(p + 0x010)); // 0270D7E4A230 0x10 C0                          ( 0001866C1A60 ModelEnumType bool2 bool2 bool2 Int32 )
            value.C1                                        = (bool2)GetInt32(new IntPtr(p + 0x012)); // 0270D7E4A250 0x12 C1                          ( 0001866C1A60 ModelEnumType bool2 bool2 bool2 Int32 )
            value.C2                                        = (bool2)GetInt32(new IntPtr(p + 0x014)); // 0270D7E4A270 0x14 C2                          ( 0001866C1A60 ModelEnumType bool2 bool2 bool2 Int32 )
            value.C3                                        = (bool2)GetInt32(new IntPtr(p + 0x016)); // 0270D7E4A290 0x16 C3                          ( 0001866C1A60 ModelEnumType bool2 bool2 bool2 Int32 )

            return value;
        }
    }
}
