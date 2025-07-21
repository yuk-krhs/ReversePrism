using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rarity                                   ModelPrimitiveType int int int Int32
    // 014 NormalRate                               ModelPrimitiveType float float float Single
    // 018 PromiseRate                              ModelPrimitiveType float float float Single
    public partial class GashaRatesRarityRateModel : DataModel
    {
        public int                                      Rarity                                  { get; set; }
        public float                                    NormalRate                              { get; set; }
        public float                                    PromiseRate                             { get; set; }

        public static GashaRatesRarityRateModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRatesRarityRateModel() { Pointer= p0 };

            value.Rarity                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Rarity                      ( ModelPrimitiveType int int int Int32 )
            value.NormalRate                                = GetSingle(new IntPtr(p + 0x014)); // 0x14 NormalRate                  ( ModelPrimitiveType float float float Single )
            value.PromiseRate                               = GetSingle(new IntPtr(p + 0x018)); // 0x18 PromiseRate                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
