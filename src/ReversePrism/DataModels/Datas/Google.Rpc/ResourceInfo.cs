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
    // 018 ResourceType                             000186671910 ModelPrimitiveType string string string String
    // 000 ResourceNameFieldNumber                  int IL2CPP_TYPE_I4
    // 020 ResourceName                             000186671910 ModelPrimitiveType string string string String
    // 000 OwnerFieldNumber                         int IL2CPP_TYPE_I4
    // 028 Owner                                    000186671910 ModelPrimitiveType string string string String
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 030 Description                              000186671910 ModelPrimitiveType string string string String
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

            value.ResourceType                              = GetString(new IntPtr(p + 0x018)); // 02466A74DE30 0x18 ResourceType                ( 000186671910 ModelPrimitiveType string string string String )
            value.ResourceName                              = GetString(new IntPtr(p + 0x020)); // 02466A74DE70 0x20 ResourceName                ( 000186671910 ModelPrimitiveType string string string String )
            value.Owner                                     = GetString(new IntPtr(p + 0x028)); // 02466A74DEB0 0x28 Owner                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x030)); // 02466A74DEF0 0x30 Description                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
