using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PolicyLastUpdateDate                     000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GetVersionReply> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PolicyLastUpdateDateFieldNumber          int IL2CPP_TYPE_I4
    // 028 _PolicyLastUpdateDate                    000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 TermsUrlFieldNumber                      int IL2CPP_TYPE_I4
    // 030 TermsUrl                                 000186671910 ModelPrimitiveType string string string String
    // 000 PolicyUrlFieldNumber                     int IL2CPP_TYPE_I4
    // 038 PolicyUrl                                000186671910 ModelPrimitiveType string string string String
    // 000 FaqUrlFieldNumber                        int IL2CPP_TYPE_I4
    // 040 FaqUrl                                   000186671910 ModelPrimitiveType string string string String
    // 000 GlobalConsentUrlFieldNumber              int IL2CPP_TYPE_I4
    // 048 GlobalConsentUrl                         000186671910 ModelPrimitiveType string string string String
    // 000 VideoPolicyUrlFieldNumber                int IL2CPP_TYPE_I4
    // 050 VideoPolicyUrl                           000186671910 ModelPrimitiveType string string string String
    // 000 DeleteRequestUrlFieldNumber              int IL2CPP_TYPE_I4
    // 058 DeleteRequestUrl                         000186671910 ModelPrimitiveType string string string String
    public partial class GetVersionReply : DataModel
    {
        public DateTime                                 PolicyLastUpdateDate                    { get; set; }
        public Timestamp?                               _PolicyLastUpdateDate                   { get; set; }
        public string                                   TermsUrl                                { get; set; }
        public string                                   PolicyUrl                               { get; set; }
        public string                                   FaqUrl                                  { get; set; }
        public string                                   GlobalConsentUrl                        { get; set; }
        public string                                   VideoPolicyUrl                          { get; set; }
        public string                                   DeleteRequestUrl                        { get; set; }

        public static GetVersionReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetVersionReply() { Pointer= p0 };

            value.PolicyLastUpdateDate                      = GetDateTime(new IntPtr(p + 0x010)); // 0246618ECAC0 0x10 PolicyLastUpdateDate        ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value._PolicyLastUpdateDate                     = GetObject<Timestamp>(new IntPtr(p + 0x028), ReversePrism.DataModels.Timestamp.FromPointer); // 0246618ECB40 0x28 _PolicyLastUpdateDate       ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.TermsUrl                                  = GetString(new IntPtr(p + 0x030)); // 0246618ECB80 0x30 TermsUrl                    ( 000186671910 ModelPrimitiveType string string string String )
            value.PolicyUrl                                 = GetString(new IntPtr(p + 0x038)); // 0246618ECBC0 0x38 PolicyUrl                   ( 000186671910 ModelPrimitiveType string string string String )
            value.FaqUrl                                    = GetString(new IntPtr(p + 0x040)); // 0246618ECC00 0x40 FaqUrl                      ( 000186671910 ModelPrimitiveType string string string String )
            value.GlobalConsentUrl                          = GetString(new IntPtr(p + 0x048)); // 0246618ECC40 0x48 GlobalConsentUrl            ( 000186671910 ModelPrimitiveType string string string String )
            value.VideoPolicyUrl                            = GetString(new IntPtr(p + 0x050)); // 0246618ECC80 0x50 VideoPolicyUrl              ( 000186671910 ModelPrimitiveType string string string String )
            value.DeleteRequestUrl                          = GetString(new IntPtr(p + 0x058)); // 0246618ECCC0 0x58 DeleteRequestUrl            ( 000186671910 ModelPrimitiveType string string string String )
            value.PolicyLastUpdateDate          = ToDateTime(value._PolicyLastUpdateDate);

            return value;
        }
    }
}
