using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vocal                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 014 Dance                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Visual                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 01C Mental                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 020 BaseTotal                                0001865F4260 ModelPrimitiveType int int int Int32
    // 024 UnitBonus                                0001865F4260 ModelPrimitiveType int int int Int32
    // 028 Total                                    0001865F4260 ModelPrimitiveType int int int Int32
    public partial class LiveIdolParameter : DataModel
    {
        public int                                      Vocal                                   { get; set; }
        public int                                      Dance                                   { get; set; }
        public int                                      Visual                                  { get; set; }
        public int                                      Mental                                  { get; set; }
        public int                                      BaseTotal                               { get; set; }
        public int                                      UnitBonus                               { get; set; }
        public int                                      Total                                   { get; set; }

        public static LiveIdolParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveIdolParameter() { Pointer= p0 };

            value.Vocal                                     = GetInt32(new IntPtr(p + 0x010)); // 024664D28ED0 0x10 Vocal                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Dance                                     = GetInt32(new IntPtr(p + 0x014)); // 024664D28EF0 0x14 Dance                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Visual                                    = GetInt32(new IntPtr(p + 0x018)); // 024664D28F10 0x18 Visual                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Mental                                    = GetInt32(new IntPtr(p + 0x01C)); // 024664D28F30 0x1C Mental                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.BaseTotal                                 = GetInt32(new IntPtr(p + 0x020)); // 024664D28F50 0x20 BaseTotal                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UnitBonus                                 = GetInt32(new IntPtr(p + 0x024)); // 024664D28F70 0x24 UnitBonus                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Total                                     = GetInt32(new IntPtr(p + 0x028)); // 024664D28F90 0x28 Total                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
