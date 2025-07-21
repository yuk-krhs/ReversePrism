using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PhaseState                               ModelPrimitiveType int int int Int32
    // 014 RandomSeed                               ModelPrimitiveType int int int Int32
    // 018 FastForwardSpeedType                     ModelEnumType FastForwardSpeedType FastForwardSpeedType FastForwardSpeedType Int32
    public partial class InGameSaveData : DataModel
    {
        public int                                      PhaseState                              { get; set; }
        public int                                      RandomSeed                              { get; set; }
        public FastForwardSpeedType                     FastForwardSpeedType                    { get; set; }

        public static InGameSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameSaveData() { Pointer= p0 };

            value.PhaseState                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 PhaseState                  ( ModelPrimitiveType int int int Int32 )
            value.RandomSeed                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 RandomSeed                  ( ModelPrimitiveType int int int Int32 )
            value.FastForwardSpeedType                      = (FastForwardSpeedType)GetInt32(new IntPtr(p + 0x018)); // 0x18 FastForwardSpeedType        ( ModelEnumType FastForwardSpeedType FastForwardSpeedType FastForwardSpeedType Int32 )

            return value;
        }
    }
}
