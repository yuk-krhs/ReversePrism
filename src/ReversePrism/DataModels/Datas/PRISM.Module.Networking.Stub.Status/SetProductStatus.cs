using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetProductStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Product                                  0001865A5470 ModelClassType ProductStatus ProductStatus ProductStatus Pointer
    // 000 ProductListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_productList_codec              FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 020 ProductList                              000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    public partial class SetProductStatus
    {
        public ProductStatus?                           Product                                 { get; set; }
        public List<ProductWithAmountStatus>?           ProductList                             { get; set; }

        public static SetProductStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetProductStatus();

            value.Product                                   = GetObject<ProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductStatus.FromPointer); // 0270D0F66BA8 0x18 Product                     ( 0001865A5470 ModelClassType ProductStatus ProductStatus ProductStatus Pointer )
            value.ProductList                               = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D0F66C08 0x20 ProductList                 ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
