using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rarity                                   ModelPrimitiveType int int int Int32
    // 014 RateListCount                            ModelPrimitiveType int int int Int32
    // 018 IsTop                                    ModelPrimitiveType bool bool bool Bool
    public partial class GashaRatesRateHeaderCellViewModel : DataModel
    {
        public int                                      Rarity                                  { get; set; }
        public int                                      RateListCount                           { get; set; }
        public bool                                     IsTop                                   { get; set; }

        public static GashaRatesRateHeaderCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRatesRateHeaderCellViewModel() { Pointer= p0 };

            value.Rarity                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Rarity                      ( ModelPrimitiveType int int int Int32 )
            value.RateListCount                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 RateListCount               ( ModelPrimitiveType int int int Int32 )
            value.IsTop                                     = GetBool(new IntPtr(p + 0x018)); // 0x18 IsTop                       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
