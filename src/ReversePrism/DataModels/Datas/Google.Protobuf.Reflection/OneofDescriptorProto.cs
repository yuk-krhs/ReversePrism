using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<OneofDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 008 NameDefaultValue                         string IL2CPP_TYPE_STRING
    // 018 Name                                     ModelPrimitiveType string string string String
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Options                                  ModelClassType OneofOptions OneofOptions OneofOptions Pointer
    public partial class OneofDescriptorProto : DataModel
    {
        public string                                   Name                                    { get; set; }
        public OneofOptions?                            Options                                 { get; set; }

        public static OneofDescriptorProto? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OneofDescriptorProto() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.Options                                   = GetObject<OneofOptions>(new IntPtr(p + 0x020), ReversePrism.DataModels.OneofOptions.FromPointer); // 0x20 Options                     ( ModelClassType OneofOptions OneofOptions OneofOptions Pointer )

            return value;
        }
    }
}
