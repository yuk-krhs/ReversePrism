using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MegaBytes                                double IL2CPP_TYPE_R8
    // 000 LevelTable                               ValueTuple`2<double, int>[] IL2CPP_TYPE_SZARRAY
    // 000 RecommendedDefaultLevel                  int IL2CPP_TYPE_I4
    // 010 Stability                                ModelEnumType StabilityState StabilityState StabilityState Int32
    // 014 DefaultLevel                             ModelPrimitiveType int int int Int32
    // 018 CurrentLevel                             ModelPrimitiveType int int int Int32
    // 020 LastBitPerSec                            ModelPrimitiveType double double double Double
    public partial class AdaptiveConcurrencyController : DataModel
    {
        public StabilityState                           Stability                               { get; set; }
        public int                                      DefaultLevel                            { get; set; }
        public int                                      CurrentLevel                            { get; set; }
        public double                                   LastBitPerSec                           { get; set; }

        public static AdaptiveConcurrencyController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveConcurrencyController() { Pointer= p0 };

            value.Stability                                 = (StabilityState)GetInt32(new IntPtr(p + 0x010)); // 0x10 Stability                   ( ModelEnumType StabilityState StabilityState StabilityState Int32 )
            value.DefaultLevel                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 DefaultLevel                ( ModelPrimitiveType int int int Int32 )
            value.CurrentLevel                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 CurrentLevel                ( ModelPrimitiveType int int int Int32 )
            value.LastBitPerSec                             = GetDouble(new IntPtr(p + 0x020)); // 0x20 LastBitPerSec               ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
