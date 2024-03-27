using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 F0                                       0001865BDF70 ModelEnumType Long8 Long8 Long8 Int32
    // 050 F1                                       0001865BDF70 ModelEnumType Long8 Long8 Long8 Int32
    // 090 F2                                       0001865BDF70 ModelEnumType Long8 Long8 Long8 Int32
    // 0D0 F3                                       0001865BDF70 ModelEnumType Long8 Long8 Long8 Int32
    // 110 F4                                       0001865BDF70 ModelEnumType Long8 Long8 Long8 Int32
    // 150 F5                                       0001865BDF70 ModelEnumType Long8 Long8 Long8 Int32
    // 190 F6                                       0001865BDF70 ModelEnumType Long8 Long8 Long8 Int32
    // 1D0 F7                                       0001865BDF70 ModelEnumType Long8 Long8 Long8 Int32
    public partial class Long64
    {
        public Long8                                    F0                                      { get; set; }
        public Long8                                    F1                                      { get; set; }
        public Long8                                    F2                                      { get; set; }
        public Long8                                    F3                                      { get; set; }
        public Long8                                    F4                                      { get; set; }
        public Long8                                    F5                                      { get; set; }
        public Long8                                    F6                                      { get; set; }
        public Long8                                    F7                                      { get; set; }

        public static Long64? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Long64();

            value.F0                                        = (Long8)GetInt32(new IntPtr(p + 0x010)); // 0270D9876B58 0x10 F0                          ( 0001865BDF70 ModelEnumType Long8 Long8 Long8 Int32 )
            value.F1                                        = (Long8)GetInt32(new IntPtr(p + 0x050)); // 0270D9876B78 0x50 F1                          ( 0001865BDF70 ModelEnumType Long8 Long8 Long8 Int32 )
            value.F2                                        = (Long8)GetInt32(new IntPtr(p + 0x090)); // 0270D9876B98 0x90 F2                          ( 0001865BDF70 ModelEnumType Long8 Long8 Long8 Int32 )
            value.F3                                        = (Long8)GetInt32(new IntPtr(p + 0x0D0)); // 0270D9876BB8 0xD0 F3                          ( 0001865BDF70 ModelEnumType Long8 Long8 Long8 Int32 )
            value.F4                                        = (Long8)GetInt32(new IntPtr(p + 0x110)); // 0270D9876BD8 0x110 F4                          ( 0001865BDF70 ModelEnumType Long8 Long8 Long8 Int32 )
            value.F5                                        = (Long8)GetInt32(new IntPtr(p + 0x150)); // 0270D9876BF8 0x150 F5                          ( 0001865BDF70 ModelEnumType Long8 Long8 Long8 Int32 )
            value.F6                                        = (Long8)GetInt32(new IntPtr(p + 0x190)); // 0270D9876C18 0x190 F6                          ( 0001865BDF70 ModelEnumType Long8 Long8 Long8 Int32 )
            value.F7                                        = (Long8)GetInt32(new IntPtr(p + 0x1D0)); // 0270D9876C38 0x1D0 F7                          ( 0001865BDF70 ModelEnumType Long8 Long8 Long8 Int32 )

            return value;
        }
    }
}
