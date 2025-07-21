using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaProductRateStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaProductRarityFieldNumber            int IL2CPP_TYPE_I4
    // 018 GashaProductRarity                       ModelPrimitiveType int int int Int32
    // 000 GashaProductTypeFieldNumber              int IL2CPP_TYPE_I4
    // 01C GashaProductType                         ModelPrimitiveType int int int Int32
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Product                                  ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 RateFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Rate                                     ModelPrimitiveType float float float Single
    public partial class GashaProductRateStatus : DataModel
    {
        public int                                      GashaProductRarity                      { get; set; }
        public int                                      GashaProductType                        { get; set; }
        public ProductWithAmountStatus?                 Product                                 { get; set; }
        public float                                    Rate                                    { get; set; }

        public static GashaProductRateStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaProductRateStatus() { Pointer= p0 };

            value.GashaProductRarity                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 GashaProductRarity          ( ModelPrimitiveType int int int Int32 )
            value.GashaProductType                          = GetInt32(new IntPtr(p + 0x01C)); // 0x1C GashaProductType            ( ModelPrimitiveType int int int Int32 )
            value.Product                                   = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x20 Product                     ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.Rate                                      = GetSingle(new IntPtr(p + 0x028)); // 0x28 Rate                        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
