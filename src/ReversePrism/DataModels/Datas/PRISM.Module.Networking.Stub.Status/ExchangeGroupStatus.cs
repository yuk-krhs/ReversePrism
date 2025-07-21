using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeginDate                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 EndDate                                  ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ExchangeGroupStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstExchangeGroupIdFieldNumber            int IL2CPP_TYPE_I4
    // 038 MstExchangeGroupId                       ModelPrimitiveType int int int Int32
    // 000 ExchangeProductListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_exchangeProductList_codec      FieldCodec`1<ExchangeProductStatus> IL2CPP_TYPE_GENERICINST
    // 040 ExchangeProductList                      ModelClassListType RepeatedField`1<ExchangeProductStatus> RepeatedField`1<ExchangeProductStatus> List<ExchangeProductStatus> Pointer
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 048 _BeginDate                               ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 050 _EndDate                                 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 058 SortId                                   ModelPrimitiveType int int int Int32
    public partial class ExchangeGroupStatus : DataModel
    {
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public int                                      MstExchangeGroupId                      { get; set; }
        public List<ExchangeProductStatus>?             ExchangeProductList                     { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public int                                      SortId                                  { get; set; }

        public static ExchangeGroupStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeGroupStatus() { Pointer= p0 };

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0x10 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0x20 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstExchangeGroupId                        = GetInt32(new IntPtr(p + 0x038)); // 0x38 MstExchangeGroupId          ( ModelPrimitiveType int int int Int32 )
            value.ExchangeProductList                       = GetObjectList<ExchangeProductStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExchangeProductStatus.FromPointer); // 0x40 ExchangeProductList         ( ModelClassListType RepeatedField`1<ExchangeProductStatus> RepeatedField`1<ExchangeProductStatus> List<ExchangeProductStatus> Pointer )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 0x48 _BeginDate                  ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x050), ReversePrism.DataModels.Timestamp.FromPointer); // 0x50 _EndDate                    ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x058)); // 0x58 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
