using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ContextRule> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectorFieldNumber                      int IL2CPP_TYPE_I4
    // 018 Selector                                 ModelPrimitiveType string string string String
    // 000 RequestedFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_requested_codec                FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 020 Requested                                ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 ProvidedFieldNumber                      int IL2CPP_TYPE_I4
    // 010 _repeated_provided_codec                 FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 028 Provided                                 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 AllowedRequestExtensionsFieldNumber      int IL2CPP_TYPE_I4
    // 018 _repeated_allowedRequestExtensions_codec FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 030 AllowedRequestExtensions                 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 AllowedResponseExtensionsFieldNumber     int IL2CPP_TYPE_I4
    // 020 _repeated_allowedResponseExtensions_codec FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 038 AllowedResponseExtensions                ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class ContextRule : DataModel
    {
        public string                                   Selector                                { get; set; }
        public List<string>?                            Requested                               { get; set; }
        public List<string>?                            Provided                                { get; set; }
        public List<string>?                            AllowedRequestExtensions                { get; set; }
        public List<string>?                            AllowedResponseExtensions               { get; set; }

        public static ContextRule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContextRule() { Pointer= p0 };

            value.Selector                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Selector                    ( ModelPrimitiveType string string string String )
            value.Requested                                 = GetStringList(new IntPtr(p + 0x020)); // 0x20 Requested                   ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.Provided                                  = GetStringList(new IntPtr(p + 0x028)); // 0x28 Provided                    ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.AllowedRequestExtensions                  = GetStringList(new IntPtr(p + 0x030)); // 0x30 AllowedRequestExtensions    ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.AllowedResponseExtensions                 = GetStringList(new IntPtr(p + 0x038)); // 0x38 AllowedResponseExtensions   ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
