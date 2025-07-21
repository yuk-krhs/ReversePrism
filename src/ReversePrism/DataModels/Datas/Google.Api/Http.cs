using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Http> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RulesFieldNumber                         int IL2CPP_TYPE_I4
    // 008 _repeated_rules_codec                    FieldCodec`1<HttpRule> IL2CPP_TYPE_GENERICINST
    // 018 Rules                                    ModelClassListType RepeatedField`1<HttpRule> RepeatedField`1<HttpRule> List<HttpRule> Pointer
    // 000 FullyDecodeReservedExpansionFieldNumber  int IL2CPP_TYPE_I4
    // 020 FullyDecodeReservedExpansion             ModelPrimitiveType bool bool bool Bool
    public partial class Http : DataModel
    {
        public List<HttpRule>?                          Rules                                   { get; set; }
        public bool                                     FullyDecodeReservedExpansion            { get; set; }

        public static Http? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Http() { Pointer= p0 };

            value.Rules                                     = GetObjectList<HttpRule>(new IntPtr(p + 0x018), ReversePrism.DataModels.HttpRule.FromPointer); // 0x18 Rules                       ( ModelClassListType RepeatedField`1<HttpRule> RepeatedField`1<HttpRule> List<HttpRule> Pointer )
            value.FullyDecodeReservedExpansion              = GetBool(new IntPtr(p + 0x020)); // 0x20 FullyDecodeReservedExpansion ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
