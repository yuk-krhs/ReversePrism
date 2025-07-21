using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rarity                                   ModelPrimitiveType int int int Int32
    // 014 Cost                                     ModelPrimitiveType int int int Int32
    // 018 MaxHp                                    ModelPrimitiveType int int int Int32
    // 01C Vocal                                    ModelPrimitiveType int int int Int32
    // 020 Dance                                    ModelPrimitiveType int int int Int32
    // 024 Visual                                   ModelPrimitiveType int int int Int32
    // 028 Mental                                   ModelPrimitiveType int int int Int32
    public partial class IdolStatusData : DataModel
    {
        public int                                      Rarity                                  { get; set; }
        public int                                      Cost                                    { get; set; }
        public int                                      MaxHp                                   { get; set; }
        public int                                      Vocal                                   { get; set; }
        public int                                      Dance                                   { get; set; }
        public int                                      Visual                                  { get; set; }
        public int                                      Mental                                  { get; set; }

        public static IdolStatusData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStatusData() { Pointer= p0 };

            value.Rarity                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Rarity                      ( ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x014)); // 0x14 Cost                        ( ModelPrimitiveType int int int Int32 )
            value.MaxHp                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 MaxHp                       ( ModelPrimitiveType int int int Int32 )
            value.Vocal                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Vocal                       ( ModelPrimitiveType int int int Int32 )
            value.Dance                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Dance                       ( ModelPrimitiveType int int int Int32 )
            value.Visual                                    = GetInt32(new IntPtr(p + 0x024)); // 0x24 Visual                      ( ModelPrimitiveType int int int Int32 )
            value.Mental                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 Mental                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
