using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExchangeBeginDate                        000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 ExchangeEndDate                          000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 EventBeginDate                           000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 040 EventEndDate                             000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ShinyPartyTokenStatus> IL2CPP_TYPE_GENERICINST
    // 050 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProductWithAmountFieldNumber             int IL2CPP_TYPE_I4
    // 058 ProductWithAmount                        0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 ExchangeBeginDateFieldNumber             int IL2CPP_TYPE_I4
    // 060 _ExchangeBeginDate                       000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ExchangeEndDateFieldNumber               int IL2CPP_TYPE_I4
    // 068 _ExchangeEndDate                         000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EventBeginDateFieldNumber                int IL2CPP_TYPE_I4
    // 070 _EventBeginDate                          000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EventEndDateFieldNumber                  int IL2CPP_TYPE_I4
    // 078 _EventEndDate                            000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EventNameFieldNumber                     int IL2CPP_TYPE_I4
    // 080 EventName                                000186671910 ModelPrimitiveType string string string String
    public partial class ShinyPartyTokenStatus
    {
        public DateTime                                 ExchangeBeginDate                       { get; set; }
        public DateTime                                 ExchangeEndDate                         { get; set; }
        public DateTime                                 EventBeginDate                          { get; set; }
        public DateTime                                 EventEndDate                            { get; set; }
        public ProductWithAmountStatus?                 ProductWithAmount                       { get; set; }
        public Timestamp?                               _ExchangeBeginDate                      { get; set; }
        public Timestamp?                               _ExchangeEndDate                        { get; set; }
        public Timestamp?                               _EventBeginDate                         { get; set; }
        public Timestamp?                               _EventEndDate                           { get; set; }
        public string                                   EventName                               { get; set; }

        public static ShinyPartyTokenStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShinyPartyTokenStatus();

            value.ExchangeBeginDate                         = GetDateTime(new IntPtr(p + 0x010)); // 0270D1235318 0x10 ExchangeBeginDate           ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ExchangeEndDate                           = GetDateTime(new IntPtr(p + 0x020)); // 0270D1235338 0x20 ExchangeEndDate             ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EventBeginDate                            = GetDateTime(new IntPtr(p + 0x030)); // 0270D1235358 0x30 EventBeginDate              ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EventEndDate                              = GetDateTime(new IntPtr(p + 0x040)); // 0270D1235378 0x40 EventEndDate                ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ProductWithAmount                         = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D12353F8 0x58 ProductWithAmount           ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value._ExchangeBeginDate                        = GetObject<Timestamp>(new IntPtr(p + 0x060), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D1235438 0x60 _ExchangeBeginDate          ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._ExchangeEndDate                          = GetObject<Timestamp>(new IntPtr(p + 0x068), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D1235478 0x68 _ExchangeEndDate            ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EventBeginDate                           = GetObject<Timestamp>(new IntPtr(p + 0x070), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D12354B8 0x70 _EventBeginDate             ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EventEndDate                             = GetObject<Timestamp>(new IntPtr(p + 0x078), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D12354F8 0x78 _EventEndDate               ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.EventName                                 = GetString(new IntPtr(p + 0x080)); // 0270D1235538 0x80 EventName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.ExchangeBeginDate             = ToDateTime(value._ExchangeBeginDate);
            value.ExchangeEndDate               = ToDateTime(value._ExchangeEndDate);
            value.EventBeginDate                = ToDateTime(value._EventBeginDate);
            value.EventEndDate                  = ToDateTime(value._EventEndDate);

            return value;
        }
    }
}
