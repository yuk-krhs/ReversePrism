using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rarity                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 014 NormalRate                               000186666CB0 ModelPrimitiveType float float float Single
    // 018 PromiseRate                              000186666CB0 ModelPrimitiveType float float float Single
    public partial class StepUpRarityRateModel : DataModel
    {
        public int                                      Rarity                                  { get; set; }
        public float                                    NormalRate                              { get; set; }
        public float                                    PromiseRate                             { get; set; }

        public static StepUpRarityRateModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpRarityRateModel() { Pointer= p0 };

            value.Rarity                                    = GetInt32(new IntPtr(p + 0x010)); // 02466545EDC8 0x10 Rarity                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.NormalRate                                = GetSingle(new IntPtr(p + 0x014)); // 02466545EDE8 0x14 NormalRate                  ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.PromiseRate                               = GetSingle(new IntPtr(p + 0x018)); // 02466545EE08 0x18 PromiseRate                 ( 000186666CB0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
