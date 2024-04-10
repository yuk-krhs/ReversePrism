using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventName                                000186672F10 ModelPrimitiveType string string string String
    // 018 EventId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 020 TokenProduct                             0001865F9930 ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 028 PlayableStartTime                        000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 PlayableEndTime                          000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 048 ExchangeStartTime                        000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 058 ExchangeEndTime                          000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 068 ShowTabType                              0001866410A0 ModelEnumType ExchangeTabType ExchangeTabType ExchangeTabType Int32
    public partial class ExchangeEventGridViewModel : DataModel
    {
        public string                                   EventName                               { get; set; }
        public int                                      EventId                                 { get; set; }
        public IProductStatus?                          TokenProduct                            { get; set; }
        public DateTime                                 PlayableStartTime                       { get; set; }
        public DateTime                                 PlayableEndTime                         { get; set; }
        public DateTime                                 ExchangeStartTime                       { get; set; }
        public DateTime                                 ExchangeEndTime                         { get; set; }
        public ExchangeTabType                          ShowTabType                             { get; set; }

        public static ExchangeEventGridViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeEventGridViewModel() { Pointer= p0 };

            value.EventName                                 = GetString(new IntPtr(p + 0x010)); // 024666339A80 0x10 EventName                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x018)); // 024666339AA0 0x18 EventId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.TokenProduct                              = GetObject<IProductStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProductStatus.FromPointer); // 024666339AC0 0x20 TokenProduct                ( 0001865F9930 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.PlayableStartTime                         = GetDateTime(new IntPtr(p + 0x028)); // 024666339AE0 0x28 PlayableStartTime           ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.PlayableEndTime                           = GetDateTime(new IntPtr(p + 0x038)); // 024666339B00 0x38 PlayableEndTime             ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ExchangeStartTime                         = GetDateTime(new IntPtr(p + 0x048)); // 024666339B20 0x48 ExchangeStartTime           ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ExchangeEndTime                           = GetDateTime(new IntPtr(p + 0x058)); // 024666339B40 0x58 ExchangeEndTime             ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ShowTabType                               = (ExchangeTabType)GetInt32(new IntPtr(p + 0x068)); // 024666339B60 0x68 ShowTabType                 ( 0001866410A0 ModelEnumType ExchangeTabType ExchangeTabType ExchangeTabType Int32 )

            return value;
        }
    }
}
