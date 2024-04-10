using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 declarations                             Lazy`1<Dictionary`2<IDescriptor, DescriptorDeclaration>> IL2CPP_TYPE_GENERICINST
    // 018 Proto                                    00018657A150 ModelClassType FileDescriptorProto FileDescriptorProto FileDescriptorProto Pointer
    // 020 Syntax                                   000186603C10 ModelEnumType Syntax Syntax Syntax Int32
    // 028 <MessageTypes>k__BackingField            IList`1<MessageDescriptor> IL2CPP_TYPE_GENERICINST
    // 030 <EnumTypes>k__BackingField               IList`1<EnumDescriptor> IL2CPP_TYPE_GENERICINST
    // 038 <Services>k__BackingField                IList`1<ServiceDescriptor> IL2CPP_TYPE_GENERICINST
    // 040 Extensions                               000186530A20 ModelClassType ExtensionCollection ExtensionCollection ExtensionCollection Pointer
    // 048 <Dependencies>k__BackingField            IList`1<FileDescriptor> IL2CPP_TYPE_GENERICINST
    // 050 <PublicDependencies>k__BackingField      IList`1<FileDescriptor> IL2CPP_TYPE_GENERICINST
    // 058 SerializedData                           00018659F1A0 ModelClassType ByteString ByteString ByteString Pointer
    // 060 DescriptorPool                           0001866C5700 ModelClassType DescriptorPool DescriptorPool DescriptorPool Pointer
    public partial class FileDescriptor : DataModel
    {
        public FileDescriptorProto?                     Proto                                   { get; set; }
        public Syntax                                   Syntax                                  { get; set; }
        public ExtensionCollection?                     Extensions                              { get; set; }
        public ByteString?                              SerializedData                          { get; set; }
        public DescriptorPool?                          DescriptorPool                          { get; set; }

        public static FileDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileDescriptor() { Pointer= p0 };

            value.Proto                                     = GetObject<FileDescriptorProto>(new IntPtr(p + 0x018), ReversePrism.DataModels.FileDescriptorProto.FromPointer); // 0245A3B01AE0 0x18 Proto                       ( 00018657A150 ModelClassType FileDescriptorProto FileDescriptorProto FileDescriptorProto Pointer )
            value.Syntax                                    = (Syntax)GetInt32(new IntPtr(p + 0x020)); // 0245A3B01B00 0x20 Syntax                      ( 000186603C10 ModelEnumType Syntax Syntax Syntax Int32 )
            value.Extensions                                = GetObject<ExtensionCollection>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExtensionCollection.FromPointer); // 0245A3B01B80 0x40 Extensions                  ( 000186530A20 ModelClassType ExtensionCollection ExtensionCollection ExtensionCollection Pointer )
            value.SerializedData                            = GetObject<ByteString>(new IntPtr(p + 0x058), ReversePrism.DataModels.ByteString.FromPointer); // 0245A3B01BE0 0x58 SerializedData              ( 00018659F1A0 ModelClassType ByteString ByteString ByteString Pointer )
            value.DescriptorPool                            = GetObject<DescriptorPool>(new IntPtr(p + 0x060), ReversePrism.DataModels.DescriptorPool.FromPointer); // 0245A3B01C00 0x60 DescriptorPool              ( 0001866C5700 ModelClassType DescriptorPool DescriptorPool DescriptorPool Pointer )

            return value;
        }
    }
}
