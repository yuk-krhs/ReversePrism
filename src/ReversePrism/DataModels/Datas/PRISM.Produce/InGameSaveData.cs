using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PhaseState                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 RandomSeed                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 FastForwardSpeedType                     000186601990 ModelEnumType FastForwardSpeedType FastForwardSpeedType FastForwardSpeedType Int32
    public partial class InGameSaveData
    {
        public int                                      PhaseState                              { get; set; }
        public int                                      RandomSeed                              { get; set; }
        public FastForwardSpeedType                     FastForwardSpeedType                    { get; set; }

        public static InGameSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameSaveData();

            value.PhaseState                                = GetInt32(new IntPtr(p + 0x010)); // 027003A7D968 0x10 PhaseState                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RandomSeed                                = GetInt32(new IntPtr(p + 0x014)); // 027003A7D988 0x14 RandomSeed                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FastForwardSpeedType                      = (FastForwardSpeedType)GetInt32(new IntPtr(p + 0x018)); // 027003A7D9A8 0x18 FastForwardSpeedType        ( 000186601990 ModelEnumType FastForwardSpeedType FastForwardSpeedType FastForwardSpeedType Int32 )

            return value;
        }
    }
}
