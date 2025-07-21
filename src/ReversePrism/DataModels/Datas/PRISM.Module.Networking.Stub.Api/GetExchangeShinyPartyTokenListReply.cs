using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EndDate                                  ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GetExchangeShinyPartyTokenListReply> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ShinyPartyTokenProductListFieldNumber    int IL2CPP_TYPE_I4
    // 008 _repeated_shinyPartyTokenProductList_codec FieldCodec`1<ShinyPartyTokenProductStatus> IL2CPP_TYPE_GENERICINST
    // 028 ShinyPartyTokenProductList               ModelClassListType RepeatedField`1<ShinyPartyTokenProductStatus> RepeatedField`1<ShinyPartyTokenProductStatus> List<ShinyPartyTokenProductStatus> Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 030 _EndDate                                 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class GetExchangeShinyPartyTokenListReply : DataModel
    {
        public DateTime                                 EndDate                                 { get; set; }
        public List<ShinyPartyTokenProductStatus>?      ShinyPartyTokenProductList              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }

        public static GetExchangeShinyPartyTokenListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetExchangeShinyPartyTokenListReply() { Pointer= p0 };

            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x010)); // 0x10 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ShinyPartyTokenProductList                = GetObjectList<ShinyPartyTokenProductStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ShinyPartyTokenProductStatus.FromPointer); // 0x28 ShinyPartyTokenProductList  ( ModelClassListType RepeatedField`1<ShinyPartyTokenProductStatus> RepeatedField`1<ShinyPartyTokenProductStatus> List<ShinyPartyTokenProductStatus> Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 0x30 _EndDate                    ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
