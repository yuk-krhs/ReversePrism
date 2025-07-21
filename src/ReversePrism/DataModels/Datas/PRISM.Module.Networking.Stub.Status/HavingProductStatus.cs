using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<HavingProductStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Product                                  ModelClassType ProductStatus ProductStatus ProductStatus Pointer
    // 000 AmountFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Amount                                   ModelPrimitiveType long long long Int64
    // 000 ExpireDateListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_expireDateList_codec           FieldCodec`1<ExpireDateStatus> IL2CPP_TYPE_GENERICINST
    // 028 ExpireDateList                           ModelClassListType RepeatedField`1<ExpireDateStatus> RepeatedField`1<ExpireDateStatus> List<ExpireDateStatus> Pointer
    public partial class HavingProductStatus : DataModel
    {
        public ProductStatus?                           Product                                 { get; set; }
        public long                                     Amount                                  { get; set; }
        public List<ExpireDateStatus>?                  ExpireDateList                          { get; set; }

        public static HavingProductStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HavingProductStatus() { Pointer= p0 };

            value.Product                                   = GetObject<ProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductStatus.FromPointer); // 0x18 Product                     ( ModelClassType ProductStatus ProductStatus ProductStatus Pointer )
            value.Amount                                    = GetInt64(new IntPtr(p + 0x020)); // 0x20 Amount                      ( ModelPrimitiveType long long long Int64 )
            value.ExpireDateList                            = GetObjectList<ExpireDateStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExpireDateStatus.FromPointer); // 0x28 ExpireDateList              ( ModelClassListType RepeatedField`1<ExpireDateStatus> RepeatedField`1<ExpireDateStatus> List<ExpireDateStatus> Pointer )

            return value;
        }
    }
}
