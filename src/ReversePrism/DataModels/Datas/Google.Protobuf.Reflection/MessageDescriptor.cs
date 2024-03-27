using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 WellKnownTypeNames                       HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 028 fieldsInDeclarationOrder                 IList`1<FieldDescriptor> IL2CPP_TYPE_GENERICINST
    // 030 fieldsInNumberOrder                      IList`1<FieldDescriptor> IL2CPP_TYPE_GENERICINST
    // 038 jsonFieldMap                             IDictionary`2<string, FieldDescriptor> IL2CPP_TYPE_GENERICINST
    // 040 extensionSetIsInitialized                Func`2<IMessage, bool> IL2CPP_TYPE_GENERICINST
    // 048 Proto                                    0001866C5BE0 ModelClassType DescriptorProto DescriptorProto DescriptorProto Pointer
    // 050 ClrType                                  0001866936B0 ModelClassType Type Type Type Pointer
    // 058 Parser                                   0001866090C0 ModelClassType MessageParser MessageParser MessageParser Pointer
    // 060 ContainingType                           000186606DB0 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    // 068 Fields                                   000186711990 ModelClassType FieldCollection FieldCollection FieldCollection Pointer
    // 070 Extensions                               000186530A20 ModelClassType ExtensionCollection ExtensionCollection ExtensionCollection Pointer
    // 078 <NestedTypes>k__BackingField             IList`1<MessageDescriptor> IL2CPP_TYPE_GENERICINST
    // 080 <EnumTypes>k__BackingField               IList`1<EnumDescriptor> IL2CPP_TYPE_GENERICINST
    // 088 <Oneofs>k__BackingField                  IList`1<OneofDescriptor> IL2CPP_TYPE_GENERICINST
    // 090 RealOneofCount                           0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MessageDescriptor
    {
        public DescriptorProto?                         Proto                                   { get; set; }
        public Type?                                    ClrType                                 { get; set; }
        public MessageParser?                           Parser                                  { get; set; }
        public MessageDescriptor?                       ContainingType                          { get; set; }
        public FieldCollection?                         Fields                                  { get; set; }
        public ExtensionCollection?                     Extensions                              { get; set; }
        public int                                      RealOneofCount                          { get; set; }

        public static MessageDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessageDescriptor();

            value.Proto                                     = GetObject<DescriptorProto>(new IntPtr(p + 0x048), ReversePrism.DataModels.DescriptorProto.FromPointer); // 0270D0CE6C28 0x48 Proto                       ( 0001866C5BE0 ModelClassType DescriptorProto DescriptorProto DescriptorProto Pointer )
            value.ClrType                                   = GetObject<Type>(new IntPtr(p + 0x050), ReversePrism.DataModels.Type.FromPointer); // 0270D0CE6C48 0x50 ClrType                     ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.Parser                                    = GetObject<MessageParser>(new IntPtr(p + 0x058), ReversePrism.DataModels.MessageParser.FromPointer); // 0270D0CE6C68 0x58 Parser                      ( 0001866090C0 ModelClassType MessageParser MessageParser MessageParser Pointer )
            value.ContainingType                            = GetObject<MessageDescriptor>(new IntPtr(p + 0x060), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 0270D0CE6C88 0x60 ContainingType              ( 000186606DB0 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )
            value.Fields                                    = GetObject<FieldCollection>(new IntPtr(p + 0x068), ReversePrism.DataModels.FieldCollection.FromPointer); // 0270D0CE6CA8 0x68 Fields                      ( 000186711990 ModelClassType FieldCollection FieldCollection FieldCollection Pointer )
            value.Extensions                                = GetObject<ExtensionCollection>(new IntPtr(p + 0x070), ReversePrism.DataModels.ExtensionCollection.FromPointer); // 0270D0CE6CC8 0x70 Extensions                  ( 000186530A20 ModelClassType ExtensionCollection ExtensionCollection ExtensionCollection Pointer )
            value.RealOneofCount                            = GetInt32(new IntPtr(p + 0x090)); // 0270D0CE6D48 0x90 RealOneofCount              ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
