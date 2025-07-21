using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ServiceDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 008 NameDefaultValue                         string IL2CPP_TYPE_STRING
    // 018 Name                                     ModelPrimitiveType string string string String
    // 000 MethodFieldNumber                        int IL2CPP_TYPE_I4
    // 010 _repeated_method_codec                   FieldCodec`1<MethodDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 020 Method                                   ModelClassListType RepeatedField`1<MethodDescriptorProto> RepeatedField`1<MethodDescriptorProto> List<MethodDescriptorProto> Pointer
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 028 Options                                  ModelClassType ServiceOptions ServiceOptions ServiceOptions Pointer
    public partial class ServiceDescriptorProto : DataModel
    {
        public string                                   Name                                    { get; set; }
        public List<MethodDescriptorProto>?             Method                                  { get; set; }
        public ServiceOptions?                          Options                                 { get; set; }

        public static ServiceDescriptorProto? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServiceDescriptorProto() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.Method                                    = GetObjectList<MethodDescriptorProto>(new IntPtr(p + 0x020), ReversePrism.DataModels.MethodDescriptorProto.FromPointer); // 0x20 Method                      ( ModelClassListType RepeatedField`1<MethodDescriptorProto> RepeatedField`1<MethodDescriptorProto> List<MethodDescriptorProto> Pointer )
            value.Options                                   = GetObject<ServiceOptions>(new IntPtr(p + 0x028), ReversePrism.DataModels.ServiceOptions.FromPointer); // 0x28 Options                     ( ModelClassType ServiceOptions ServiceOptions ServiceOptions Pointer )

            return value;
        }
    }
}
