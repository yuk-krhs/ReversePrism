using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaRarityRateStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaProductRarityFieldNumber            int IL2CPP_TYPE_I4
    // 018 GashaProductRarity                       ModelPrimitiveType int int int Int32
    // 000 RateFieldNumber                          int IL2CPP_TYPE_I4
    // 01C Rate                                     ModelPrimitiveType float float float Single
    public partial class GashaRarityRateStatus : DataModel
    {
        public int                                      GashaProductRarity                      { get; set; }
        public float                                    Rate                                    { get; set; }

        public static GashaRarityRateStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRarityRateStatus() { Pointer= p0 };

            value.GashaProductRarity                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 GashaProductRarity          ( ModelPrimitiveType int int int Int32 )
            value.Rate                                      = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Rate                        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
