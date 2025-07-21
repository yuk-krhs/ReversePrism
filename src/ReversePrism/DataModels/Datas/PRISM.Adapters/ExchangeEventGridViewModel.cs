using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventName                                ModelPrimitiveType string string string String
    // 018 EventId                                  ModelPrimitiveType int int int Int32
    // 020 TokenProduct                             ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 028 PlayableStartTime                        ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 PlayableEndTime                          ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 048 ExchangeStartTime                        ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 058 ExchangeEndTime                          ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 068 ShowTabType                              ModelEnumType ExchangeTabType ExchangeTabType ExchangeTabType Int32
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

            value.EventName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 EventName                   ( ModelPrimitiveType string string string String )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 EventId                     ( ModelPrimitiveType int int int Int32 )
            value.TokenProduct                              = GetObject<IProductStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProductStatus.FromPointer); // 0x20 TokenProduct                ( ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.PlayableStartTime                         = GetDateTime(new IntPtr(p + 0x028)); // 0x28 PlayableStartTime           ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.PlayableEndTime                           = GetDateTime(new IntPtr(p + 0x038)); // 0x38 PlayableEndTime             ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ExchangeStartTime                         = GetDateTime(new IntPtr(p + 0x048)); // 0x48 ExchangeStartTime           ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ExchangeEndTime                           = GetDateTime(new IntPtr(p + 0x058)); // 0x58 ExchangeEndTime             ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ShowTabType                               = (ExchangeTabType)GetInt32(new IntPtr(p + 0x068)); // 0x68 ShowTabType                 ( ModelEnumType ExchangeTabType ExchangeTabType ExchangeTabType Int32 )

            return value;
        }
    }
}
