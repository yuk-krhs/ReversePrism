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
    // 018 Product                                  0001866AD720 ModelClassType HavingProductStatus HavingProductStatus HavingProductStatus Pointer
    // 000 MaximumProduceIdolFieldNumber            int IL2CPP_TYPE_I4
    // 020 MaximumProduceIdol                       0001865E57D0 ModelClassType MaximumProduceIdolStatus MaximumProduceIdolStatus MaximumProduceIdolStatus Pointer
    // 000 MaximumSupportCharacterFieldNumber       int IL2CPP_TYPE_I4
    // 028 MaximumSupportCharacter                  0001865E5EA0 ModelClassType MaximumSupportCharacterStatus MaximumSupportCharacterStatus MaximumSupportCharacterStatus Pointer
    // 000 SetProductFieldNumber                    int IL2CPP_TYPE_I4
    // 030 SetProduct                               000186746DA0 ModelClassType SetProductStatus SetProductStatus SetProductStatus Pointer
    public partial class ProductDetailStatus
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
            var value   = new ProductDetailStatus();

            value.Product                                   = GetObject<HavingProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.HavingProductStatus.FromPointer); // 0270D1A34B58 0x18 Product                     ( 0001866AD720 ModelClassType HavingProductStatus HavingProductStatus HavingProductStatus Pointer )
            value.MaximumProduceIdol                        = GetObject<MaximumProduceIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.MaximumProduceIdolStatus.FromPointer); // 0270D1A34B98 0x20 MaximumProduceIdol          ( 0001865E57D0 ModelClassType MaximumProduceIdolStatus MaximumProduceIdolStatus MaximumProduceIdolStatus Pointer )
            value.MaximumSupportCharacter                   = GetObject<MaximumSupportCharacterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.MaximumSupportCharacterStatus.FromPointer); // 0270D1A34BD8 0x28 MaximumSupportCharacter     ( 0001865E5EA0 ModelClassType MaximumSupportCharacterStatus MaximumSupportCharacterStatus MaximumSupportCharacterStatus Pointer )
            value.SetProduct                                = GetObject<SetProductStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.SetProductStatus.FromPointer); // 0270D1A34C18 0x30 SetProduct                  ( 000186746DA0 ModelClassType SetProductStatus SetProductStatus SetProductStatus Pointer )

            return value;
        }
    }
}
