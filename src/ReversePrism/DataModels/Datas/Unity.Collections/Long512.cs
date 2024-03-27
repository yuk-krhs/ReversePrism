using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 F0                                       0001865BDA50 ModelEnumType Long64 Long64 Long64 Int32
    // 210 F1                                       0001865BDA50 ModelEnumType Long64 Long64 Long64 Int32
    // 410 F2                                       0001865BDA50 ModelEnumType Long64 Long64 Long64 Int32
    // 610 F3                                       0001865BDA50 ModelEnumType Long64 Long64 Long64 Int32
    // 810 F4                                       0001865BDA50 ModelEnumType Long64 Long64 Long64 Int32
    // A10 F5                                       0001865BDA50 ModelEnumType Long64 Long64 Long64 Int32
    // C10 F6                                       0001865BDA50 ModelEnumType Long64 Long64 Long64 Int32
    // E10 F7                                       0001865BDA50 ModelEnumType Long64 Long64 Long64 Int32
    public partial class Long512
    {
        public Long64                                   F0                                      { get; set; }
        public Long64                                   F1                                      { get; set; }
        public Long64                                   F2                                      { get; set; }
        public Long64                                   F3                                      { get; set; }
        public Long64                                   F4                                      { get; set; }
        public Long64                                   F5                                      { get; set; }
        public Long64                                   F6                                      { get; set; }
        public Long64                                   F7                                      { get; set; }

        public static Long512? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Long512();

            value.F0                                        = (Long64)GetInt32(new IntPtr(p + 0x010)); // 0270D9876A58 0x10 F0                          ( 0001865BDA50 ModelEnumType Long64 Long64 Long64 Int32 )
            value.F1                                        = (Long64)GetInt32(new IntPtr(p + 0x210)); // 0270D9876A78 0x210 F1                          ( 0001865BDA50 ModelEnumType Long64 Long64 Long64 Int32 )
            value.F2                                        = (Long64)GetInt32(new IntPtr(p + 0x410)); // 0270D9876A98 0x410 F2                          ( 0001865BDA50 ModelEnumType Long64 Long64 Long64 Int32 )
            value.F3                                        = (Long64)GetInt32(new IntPtr(p + 0x610)); // 0270D9876AB8 0x610 F3                          ( 0001865BDA50 ModelEnumType Long64 Long64 Long64 Int32 )
            value.F4                                        = (Long64)GetInt32(new IntPtr(p + 0x810)); // 0270D9876AD8 0x810 F4                          ( 0001865BDA50 ModelEnumType Long64 Long64 Long64 Int32 )
            value.F5                                        = (Long64)GetInt32(new IntPtr(p + 0xA10)); // 0270D9876AF8 0xA10 F5                          ( 0001865BDA50 ModelEnumType Long64 Long64 Long64 Int32 )
            value.F6                                        = (Long64)GetInt32(new IntPtr(p + 0xC10)); // 0270D9876B18 0xC10 F6                          ( 0001865BDA50 ModelEnumType Long64 Long64 Long64 Int32 )
            value.F7                                        = (Long64)GetInt32(new IntPtr(p + 0xE10)); // 0270D9876B38 0xE10 F7                          ( 0001865BDA50 ModelEnumType Long64 Long64 Long64 Int32 )

            return value;
        }
    }
}
