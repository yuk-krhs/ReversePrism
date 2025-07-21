using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProductDetailStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Product                                  ModelClassType HavingProductStatus HavingProductStatus HavingProductStatus Pointer
    // 000 MaximumProduceIdolFieldNumber            int IL2CPP_TYPE_I4
    // 020 MaximumProduceIdol                       ModelClassType MaximumProduceIdolStatus MaximumProduceIdolStatus MaximumProduceIdolStatus Pointer
    // 000 MaximumSupportCharacterFieldNumber       int IL2CPP_TYPE_I4
    // 028 MaximumSupportCharacter                  ModelClassType MaximumSupportCharacterStatus MaximumSupportCharacterStatus MaximumSupportCharacterStatus Pointer
    // 000 SetProductFieldNumber                    int IL2CPP_TYPE_I4
    // 030 SetProduct                               ModelClassType SetProductStatus SetProductStatus SetProductStatus Pointer
    public partial class ProductDetailStatus : DataModel
    {
        public HavingProductStatus?                     Product                                 { get; set; }
        public MaximumProduceIdolStatus?                MaximumProduceIdol                      { get; set; }
        public MaximumSupportCharacterStatus?           MaximumSupportCharacter                 { get; set; }
        public SetProductStatus?                        SetProduct                              { get; set; }

        public static ProductDetailStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductDetailStatus() { Pointer= p0 };

            value.Product                                   = GetObject<HavingProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.HavingProductStatus.FromPointer); // 0x18 Product                     ( ModelClassType HavingProductStatus HavingProductStatus HavingProductStatus Pointer )
            value.MaximumProduceIdol                        = GetObject<MaximumProduceIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.MaximumProduceIdolStatus.FromPointer); // 0x20 MaximumProduceIdol          ( ModelClassType MaximumProduceIdolStatus MaximumProduceIdolStatus MaximumProduceIdolStatus Pointer )
            value.MaximumSupportCharacter                   = GetObject<MaximumSupportCharacterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.MaximumSupportCharacterStatus.FromPointer); // 0x28 MaximumSupportCharacter     ( ModelClassType MaximumSupportCharacterStatus MaximumSupportCharacterStatus MaximumSupportCharacterStatus Pointer )
            value.SetProduct                                = GetObject<SetProductStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.SetProductStatus.FromPointer); // 0x30 SetProduct                  ( ModelClassType SetProductStatus SetProductStatus SetProductStatus Pointer )

            return value;
        }
    }
}
