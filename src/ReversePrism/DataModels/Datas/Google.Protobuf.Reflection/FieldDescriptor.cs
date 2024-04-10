using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 EnumType                                 000186739B20 ModelClassType EnumDescriptor EnumDescriptor EnumDescriptor Pointer
    // 030 ExtendeeType                             000186606920 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    // 038 MessageType                              000186606920 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    // 040 FieldType                                0001865772D0 ModelEnumType FieldType FieldType FieldType Int32
    // 048 PropertyName                             000186672F10 ModelPrimitiveType string string string String
    // 050 Accessor                                 00018650AEC0 ModelClassType IFieldAccessor IFieldAccessor IFieldAccessor Pointer
    // 058 ContainingType                           000186606DB0 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    // 060 ContainingOneof                          0001866DFA70 ModelClassType OneofDescriptor OneofDescriptor OneofDescriptor Pointer
    // 068 JsonName                                 000186672F10 ModelPrimitiveType string string string String
    // 070 Proto                                    000186572530 ModelClassType FieldDescriptorProto FieldDescriptorProto FieldDescriptorProto Pointer
    // 078 Extension                                0001865CFEB0 ModelClassType Extension Extension Extension Pointer
    public partial class FieldDescriptor : DataModel
    {
        public EnumDescriptor?                          EnumType                                { get; set; }
        public MessageDescriptor?                       ExtendeeType                            { get; set; }
        public MessageDescriptor?                       MessageType                             { get; set; }
        public FieldType                                FieldType                               { get; set; }
        public string                                   PropertyName                            { get; set; }
        public IFieldAccessor?                          Accessor                                { get; set; }
        public MessageDescriptor?                       ContainingType                          { get; set; }
        public OneofDescriptor?                         ContainingOneof                         { get; set; }
        public string                                   JsonName                                { get; set; }
        public FieldDescriptorProto?                    Proto                                   { get; set; }
        public Extension?                               Extension                               { get; set; }

        public static FieldDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldDescriptor() { Pointer= p0 };

            value.EnumType                                  = GetObject<EnumDescriptor>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnumDescriptor.FromPointer); // 0245A4043140 0x28 EnumType                    ( 000186739B20 ModelClassType EnumDescriptor EnumDescriptor EnumDescriptor Pointer )
            value.ExtendeeType                              = GetObject<MessageDescriptor>(new IntPtr(p + 0x030), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 0245A4043160 0x30 ExtendeeType                ( 000186606920 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )
            value.MessageType                               = GetObject<MessageDescriptor>(new IntPtr(p + 0x038), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 0245A4043180 0x38 MessageType                 ( 000186606920 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )
            value.FieldType                                 = (FieldType)GetInt32(new IntPtr(p + 0x040)); // 0245A40431A0 0x40 FieldType                   ( 0001865772D0 ModelEnumType FieldType FieldType FieldType Int32 )
            value.PropertyName                              = GetString(new IntPtr(p + 0x048)); // 0245A40431C0 0x48 PropertyName                ( 000186672F10 ModelPrimitiveType string string string String )
            value.Accessor                                  = GetObject<IFieldAccessor>(new IntPtr(p + 0x050), ReversePrism.DataModels.IFieldAccessor.FromPointer); // 0245A40431E0 0x50 Accessor                    ( 00018650AEC0 ModelClassType IFieldAccessor IFieldAccessor IFieldAccessor Pointer )
            value.ContainingType                            = GetObject<MessageDescriptor>(new IntPtr(p + 0x058), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 0245A4043200 0x58 ContainingType              ( 000186606DB0 ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )
            value.ContainingOneof                           = GetObject<OneofDescriptor>(new IntPtr(p + 0x060), ReversePrism.DataModels.OneofDescriptor.FromPointer); // 0245A4043220 0x60 ContainingOneof             ( 0001866DFA70 ModelClassType OneofDescriptor OneofDescriptor OneofDescriptor Pointer )
            value.JsonName                                  = GetString(new IntPtr(p + 0x068)); // 0245A4043240 0x68 JsonName                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.Proto                                     = GetObject<FieldDescriptorProto>(new IntPtr(p + 0x070), ReversePrism.DataModels.FieldDescriptorProto.FromPointer); // 0245A4043260 0x70 Proto                       ( 000186572530 ModelClassType FieldDescriptorProto FieldDescriptorProto FieldDescriptorProto Pointer )
            value.Extension                                 = GetObject<Extension>(new IntPtr(p + 0x078), ReversePrism.DataModels.Extension.FromPointer); // 0245A4043280 0x78 Extension                   ( 0001865CFEB0 ModelClassType Extension Extension Extension Pointer )

            return value;
        }
    }
}
