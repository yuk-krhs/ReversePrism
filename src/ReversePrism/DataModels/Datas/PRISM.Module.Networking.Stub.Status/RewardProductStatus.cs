using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Product                                  0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 ConvertProductFieldNumber                int IL2CPP_TYPE_I4
    // 020 ConvertProduct                           0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 IsNewFieldNumber                         int IL2CPP_TYPE_I4
    // 028 IsNew                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class RewardProductStatus : DataModel
    {
        public ProductWithAmountStatus?                 Product                                 { get; set; }
        public ProductWithAmountStatus?                 ConvertProduct                          { get; set; }
        public bool                                     IsNew                                   { get; set; }

        public static RewardProductStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RewardProductStatus() { Pointer= p0 };

            value.Product                                   = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 024660F2A6F0 0x18 Product                     ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.ConvertProduct                            = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 024660F2A730 0x20 ConvertProduct              ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x028)); // 024660F2A770 0x28 IsNew                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
