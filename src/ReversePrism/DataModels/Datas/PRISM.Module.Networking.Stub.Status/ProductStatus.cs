using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExpireDate                               000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ProductStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProductTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 028 ProductType                              0001865A5C10 ModelEnumType ProductType ProductType ProductType Int32
    // 000 ProductMstIdFieldNumber                  int IL2CPP_TYPE_I4
    // 02C ProductMstId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ExpireTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 030 ExpireType                               00018673E5E0 ModelEnumType ItemExpireType ItemExpireType ItemExpireType Int32
    // 000 ExpireDateFieldNumber                    int IL2CPP_TYPE_I4
    // 038 _ExpireDate                              000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 NaviTypeFieldNumber                      int IL2CPP_TYPE_I4
    // 040 NaviType                                 0001867404C0 ModelEnumType ItemNaviType ItemNaviType ItemNaviType Int32
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 044 SortId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProductStatus
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
            var value   = new ProductStatus();

            value.ExpireDate                                = GetDateTime(new IntPtr(p + 0x010)); // 0270D0F62E88 0x10 ExpireDate                  ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ProductType                               = (ProductType)GetInt32(new IntPtr(p + 0x028)); // 0270D0F62F08 0x28 ProductType                 ( 0001865A5C10 ModelEnumType ProductType ProductType ProductType Int32 )
            value.ProductMstId                              = GetInt32(new IntPtr(p + 0x02C)); // 0270D0F62F48 0x2C ProductMstId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ExpireType                                = (ItemExpireType)GetInt32(new IntPtr(p + 0x030)); // 0270D0F62F88 0x30 ExpireType                  ( 00018673E5E0 ModelEnumType ItemExpireType ItemExpireType ItemExpireType Int32 )
            value._ExpireDate                               = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D0F62FC8 0x38 _ExpireDate                 ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.NaviType                                  = (ItemNaviType)GetInt32(new IntPtr(p + 0x040)); // 0270D0F63008 0x40 NaviType                    ( 0001867404C0 ModelEnumType ItemNaviType ItemNaviType ItemNaviType Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x044)); // 0270D0F63048 0x44 SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ExpireDate                    = ToDateTime(value._ExpireDate);

            return value;
        }
    }
}
