using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ResourceInfo> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ResourceTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 018 ResourceType                             ModelPrimitiveType string string string String
    // 000 ResourceNameFieldNumber                  int IL2CPP_TYPE_I4
    // 020 ResourceName                             ModelPrimitiveType string string string String
    // 000 OwnerFieldNumber                         int IL2CPP_TYPE_I4
    // 028 Owner                                    ModelPrimitiveType string string string String
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 030 Description                              ModelPrimitiveType string string string String
    public partial class ResourceInfo : DataModel
    {
        public string                                   ResourceType                            { get; set; }
        public string                                   ResourceName                            { get; set; }
        public string                                   Owner                                   { get; set; }
        public string                                   Description                             { get; set; }

        public static ResourceInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceInfo() { Pointer= p0 };

            value.ResourceType                              = GetString(new IntPtr(p + 0x018)); // 0x18 ResourceType                ( ModelPrimitiveType string string string String )
            value.ResourceName                              = GetString(new IntPtr(p + 0x020)); // 0x20 ResourceName                ( ModelPrimitiveType string string string String )
            value.Owner                                     = GetString(new IntPtr(p + 0x028)); // 0x28 Owner                       ( ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x030)); // 0x30 Description                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
