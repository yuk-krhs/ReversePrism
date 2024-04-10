using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Context> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RulesFieldNumber                         int IL2CPP_TYPE_I4
    // 008 _repeated_rules_codec                    FieldCodec`1<ContextRule> IL2CPP_TYPE_GENERICINST
    // 018 Rules                                    000185CD24C8 ModelClassListType RepeatedField`1<ContextRule> RepeatedField`1<ContextRule> List<ContextRule> Pointer
    public partial class Context : DataModel
    {
        public List<ContextRule>?                       Rules                                   { get; set; }

        public static Context? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Context() { Pointer= p0 };

            value.Rules                                     = GetObjectList<ContextRule>(new IntPtr(p + 0x018), ReversePrism.DataModels.ContextRule.FromPointer); // 02466A7EAE78 0x18 Rules                       ( 000185CD24C8 ModelClassListType RepeatedField`1<ContextRule> RepeatedField`1<ContextRule> List<ContextRule> Pointer )

            return value;
        }
    }
}
