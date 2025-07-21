using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Product                                  ModelClassType ProductStatus ProductStatus ProductStatus Pointer
    // 000 AmountFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Amount                                   ModelPrimitiveType int int int Int32
    public partial class ProductWithAmountStatus : DataModel
    {
        public ProductStatus?                           Product                                 { get; set; }
        public int                                      Amount                                  { get; set; }

        public static ProductWithAmountStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductWithAmountStatus() { Pointer= p0 };

            value.Product                                   = GetObject<ProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductStatus.FromPointer); // 0x18 Product                     ( ModelClassType ProductStatus ProductStatus ProductStatus Pointer )
            value.Amount                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 Amount                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
