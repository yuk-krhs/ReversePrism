using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExpireDate                               ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ProductStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProductTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 028 ProductType                              ModelEnumType ProductType ProductType ProductType Int32
    // 000 ProductMstIdFieldNumber                  int IL2CPP_TYPE_I4
    // 02C ProductMstId                             ModelPrimitiveType int int int Int32
    // 000 ExpireTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 030 ExpireType                               ModelEnumType ItemExpireType ItemExpireType ItemExpireType Int32
    // 000 ExpireDateFieldNumber                    int IL2CPP_TYPE_I4
    // 038 _ExpireDate                              ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 NaviTypeFieldNumber                      int IL2CPP_TYPE_I4
    // 040 NaviType                                 ModelEnumType ItemNaviType ItemNaviType ItemNaviType Int32
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 044 SortId                                   ModelPrimitiveType int int int Int32
    public partial class ProductStatus : DataModel
    {
        public DateTime                                 ExpireDate                              { get; set; }
        public ProductType                              ProductType                             { get; set; }
        public int                                      ProductMstId                            { get; set; }
        public ItemExpireType                           ExpireType                              { get; set; }
        public Timestamp?                               _ExpireDate                             { get; set; }
        public ItemNaviType                             NaviType                                { get; set; }
        public int                                      SortId                                  { get; set; }

        public static ProductStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductStatus() { Pointer= p0 };

            value.ExpireDate                                = GetDateTime(new IntPtr(p + 0x010)); // 0x10 ExpireDate                  ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ProductType                               = (ProductType)GetInt32(new IntPtr(p + 0x028)); // 0x28 ProductType                 ( ModelEnumType ProductType ProductType ProductType Int32 )
            value.ProductMstId                              = GetInt32(new IntPtr(p + 0x02C)); // 0x2C ProductMstId                ( ModelPrimitiveType int int int Int32 )
            value.ExpireType                                = (ItemExpireType)GetInt32(new IntPtr(p + 0x030)); // 0x30 ExpireType                  ( ModelEnumType ItemExpireType ItemExpireType ItemExpireType Int32 )
            value._ExpireDate                               = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 0x38 _ExpireDate                 ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.NaviType                                  = (ItemNaviType)GetInt32(new IntPtr(p + 0x040)); // 0x40 NaviType                    ( ModelEnumType ItemNaviType ItemNaviType ItemNaviType Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x044)); // 0x44 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.ExpireDate                    = ToDateTime(value._ExpireDate);

            return value;
        }
    }
}
