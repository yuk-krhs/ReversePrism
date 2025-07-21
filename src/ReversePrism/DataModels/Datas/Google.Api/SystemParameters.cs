using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SystemParameters> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RulesFieldNumber                         int IL2CPP_TYPE_I4
    // 008 _repeated_rules_codec                    FieldCodec`1<SystemParameterRule> IL2CPP_TYPE_GENERICINST
    // 018 Rules                                    ModelClassListType RepeatedField`1<SystemParameterRule> RepeatedField`1<SystemParameterRule> List<SystemParameterRule> Pointer
    public partial class SystemParameters : DataModel
    {
        public List<SystemParameterRule>?               Rules                                   { get; set; }

        public static SystemParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SystemParameters() { Pointer= p0 };

            value.Rules                                     = GetObjectList<SystemParameterRule>(new IntPtr(p + 0x018), ReversePrism.DataModels.SystemParameterRule.FromPointer); // 0x18 Rules                       ( ModelClassListType RepeatedField`1<SystemParameterRule> RepeatedField`1<SystemParameterRule> List<SystemParameterRule> Pointer )

            return value;
        }
    }
}
