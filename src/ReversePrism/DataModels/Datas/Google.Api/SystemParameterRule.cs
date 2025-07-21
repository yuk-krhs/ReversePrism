using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SystemParameterRule> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectorFieldNumber                      int IL2CPP_TYPE_I4
    // 018 Selector                                 ModelPrimitiveType string string string String
    // 000 ParametersFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_parameters_codec               FieldCodec`1<SystemParameter> IL2CPP_TYPE_GENERICINST
    // 020 Parameters                               ModelClassListType RepeatedField`1<SystemParameter> RepeatedField`1<SystemParameter> List<SystemParameter> Pointer
    public partial class SystemParameterRule : DataModel
    {
        public string                                   Selector                                { get; set; }
        public List<SystemParameter>?                   Parameters                              { get; set; }

        public static SystemParameterRule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SystemParameterRule() { Pointer= p0 };

            value.Selector                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Selector                    ( ModelPrimitiveType string string string String )
            value.Parameters                                = GetObjectList<SystemParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.SystemParameter.FromPointer); // 0x20 Parameters                  ( ModelClassListType RepeatedField`1<SystemParameter> RepeatedField`1<SystemParameter> List<SystemParameter> Pointer )

            return value;
        }
    }
}
