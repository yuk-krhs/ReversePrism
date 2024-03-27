using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Quota> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LimitsFieldNumber                        int IL2CPP_TYPE_I4
    // 008 _repeated_limits_codec                   FieldCodec`1<QuotaLimit> IL2CPP_TYPE_GENERICINST
    // 018 Limits                                   000185CEE568 ModelClassListType RepeatedField`1<QuotaLimit> RepeatedField`1<QuotaLimit> List<QuotaLimit> Pointer
    // 000 MetricRulesFieldNumber                   int IL2CPP_TYPE_I4
    // 010 _repeated_metricRules_codec              FieldCodec`1<MetricRule> IL2CPP_TYPE_GENERICINST
    // 020 MetricRules                              000185CE67B8 ModelClassListType RepeatedField`1<MetricRule> RepeatedField`1<MetricRule> List<MetricRule> Pointer
    public partial class Quota
    {
        public List<QuotaLimit>?                        Limits                                  { get; set; }
        public List<MetricRule>?                        MetricRules                             { get; set; }

        public static Quota? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Quota();

            value.Limits                                    = GetObjectList<QuotaLimit>(new IntPtr(p + 0x018), ReversePrism.DataModels.QuotaLimit.FromPointer); // 0270DA825900 0x18 Limits                      ( 000185CEE568 ModelClassListType RepeatedField`1<QuotaLimit> RepeatedField`1<QuotaLimit> List<QuotaLimit> Pointer )
            value.MetricRules                               = GetObjectList<MetricRule>(new IntPtr(p + 0x020), ReversePrism.DataModels.MetricRule.FromPointer); // 0270DA825960 0x20 MetricRules                 ( 000185CE67B8 ModelClassListType RepeatedField`1<MetricRule> RepeatedField`1<MetricRule> List<MetricRule> Pointer )

            return value;
        }
    }
}
