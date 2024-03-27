using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Backend> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RulesFieldNumber                         int IL2CPP_TYPE_I4
    // 008 _repeated_rules_codec                    FieldCodec`1<BackendRule> IL2CPP_TYPE_GENERICINST
    // 018 Rules                                    000185CCF718 ModelClassListType RepeatedField`1<BackendRule> RepeatedField`1<BackendRule> List<BackendRule> Pointer
    public partial class Backend
    {
        public List<BackendRule>?                       Rules                                   { get; set; }

        public static Backend? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Backend();

            value.Rules                                     = GetObjectList<BackendRule>(new IntPtr(p + 0x018), ReversePrism.DataModels.BackendRule.FromPointer); // 0270DA757C68 0x18 Rules                       ( 000185CCF718 ModelClassListType RepeatedField`1<BackendRule> RepeatedField`1<BackendRule> List<BackendRule> Pointer )

            return value;
        }
    }
}
