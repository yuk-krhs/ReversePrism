using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Usage> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RequirementsFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_requirements_codec             FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 018 Requirements                             000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 RulesFieldNumber                         int IL2CPP_TYPE_I4
    // 010 _repeated_rules_codec                    FieldCodec`1<UsageRule> IL2CPP_TYPE_GENERICINST
    // 020 Rules                                    000185CF6718 ModelClassListType RepeatedField`1<UsageRule> RepeatedField`1<UsageRule> List<UsageRule> Pointer
    // 000 ProducerNotificationChannelFieldNumber   int IL2CPP_TYPE_I4
    // 028 ProducerNotificationChannel              000186671910 ModelPrimitiveType string string string String
    public partial class Usage
    {
        public List<string>?                            Requirements                            { get; set; }
        public List<UsageRule>?                         Rules                                   { get; set; }
        public string                                   ProducerNotificationChannel             { get; set; }

        public static Usage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Usage();

            value.Requirements                              = GetStringList(new IntPtr(p + 0x018)); // 0270DA867EE0 0x18 Requirements                ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.Rules                                     = GetObjectList<UsageRule>(new IntPtr(p + 0x020), ReversePrism.DataModels.UsageRule.FromPointer); // 0270DA867F40 0x20 Rules                       ( 000185CF6718 ModelClassListType RepeatedField`1<UsageRule> RepeatedField`1<UsageRule> List<UsageRule> Pointer )
            value.ProducerNotificationChannel               = GetString(new IntPtr(p + 0x028)); // 0270DA867F80 0x28 ProducerNotificationChannel ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
