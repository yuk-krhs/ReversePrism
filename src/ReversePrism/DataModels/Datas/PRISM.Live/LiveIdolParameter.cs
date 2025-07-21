using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vocal                                    ModelPrimitiveType int int int Int32
    // 014 Dance                                    ModelPrimitiveType int int int Int32
    // 018 Visual                                   ModelPrimitiveType int int int Int32
    // 01C Mental                                   ModelPrimitiveType int int int Int32
    // 020 BaseTotal                                ModelPrimitiveType int int int Int32
    // 024 UnitBonus                                ModelPrimitiveType int int int Int32
    // 028 Total                                    ModelPrimitiveType int int int Int32
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

            value.Vocal                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Vocal                       ( ModelPrimitiveType int int int Int32 )
            value.Dance                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Dance                       ( ModelPrimitiveType int int int Int32 )
            value.Visual                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Visual                      ( ModelPrimitiveType int int int Int32 )
            value.Mental                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Mental                      ( ModelPrimitiveType int int int Int32 )
            value.BaseTotal                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 BaseTotal                   ( ModelPrimitiveType int int int Int32 )
            value.UnitBonus                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 UnitBonus                   ( ModelPrimitiveType int int int Int32 )
            value.Total                                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 Total                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
