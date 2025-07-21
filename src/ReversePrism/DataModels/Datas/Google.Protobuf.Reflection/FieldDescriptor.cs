using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 EnumType                                 ModelClassType EnumDescriptor EnumDescriptor EnumDescriptor Pointer
    // 030 ExtendeeType                             ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    // 038 MessageType                              ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    // 040 FieldType                                ModelEnumType FieldType FieldType FieldType Int32
    // 048 Accessor                                 ModelClassType IFieldAccessor IFieldAccessor IFieldAccessor Pointer
    // 050 ContainingType                           ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer
    // 058 ContainingOneof                          ModelClassType OneofDescriptor OneofDescriptor OneofDescriptor Pointer
    // 060 JsonName                                 ModelPrimitiveType string string string String
    // 068 PropertyName                             ModelPrimitiveType string string string String
    // 070 Proto                                    ModelClassType FieldDescriptorProto FieldDescriptorProto FieldDescriptorProto Pointer
    // 078 Extension                                ModelClassType Extension Extension Extension Pointer
    public partial class FieldDescriptor : DataModel
    {
        public EnumDescriptor?                          EnumType                                { get; set; }
        public MessageDescriptor?                       ExtendeeType                            { get; set; }
        public MessageDescriptor?                       MessageType                             { get; set; }
        public FieldType                                FieldType                               { get; set; }
        public IFieldAccessor?                          Accessor                                { get; set; }
        public MessageDescriptor?                       ContainingType                          { get; set; }
        public OneofDescriptor?                         ContainingOneof                         { get; set; }
        public string                                   JsonName                                { get; set; }
        public string                                   PropertyName                            { get; set; }
        public FieldDescriptorProto?                    Proto                                   { get; set; }
        public Extension?                               Extension                               { get; set; }

        public static FieldDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldDescriptor() { Pointer= p0 };

            value.EnumType                                  = GetObject<EnumDescriptor>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnumDescriptor.FromPointer); // 0x28 EnumType                    ( ModelClassType EnumDescriptor EnumDescriptor EnumDescriptor Pointer )
            value.ExtendeeType                              = GetObject<MessageDescriptor>(new IntPtr(p + 0x030), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 0x30 ExtendeeType                ( ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )
            value.MessageType                               = GetObject<MessageDescriptor>(new IntPtr(p + 0x038), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 0x38 MessageType                 ( ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )
            value.FieldType                                 = (FieldType)GetInt32(new IntPtr(p + 0x040)); // 0x40 FieldType                   ( ModelEnumType FieldType FieldType FieldType Int32 )
            value.Accessor                                  = GetObject<IFieldAccessor>(new IntPtr(p + 0x048), ReversePrism.DataModels.IFieldAccessor.FromPointer); // 0x48 Accessor                    ( ModelClassType IFieldAccessor IFieldAccessor IFieldAccessor Pointer )
            value.ContainingType                            = GetObject<MessageDescriptor>(new IntPtr(p + 0x050), ReversePrism.DataModels.MessageDescriptor.FromPointer); // 0x50 ContainingType              ( ModelClassType MessageDescriptor MessageDescriptor MessageDescriptor Pointer )
            value.ContainingOneof                           = GetObject<OneofDescriptor>(new IntPtr(p + 0x058), ReversePrism.DataModels.OneofDescriptor.FromPointer); // 0x58 ContainingOneof             ( ModelClassType OneofDescriptor OneofDescriptor OneofDescriptor Pointer )
            value.JsonName                                  = GetString(new IntPtr(p + 0x060)); // 0x60 JsonName                    ( ModelPrimitiveType string string string String )
            value.PropertyName                              = GetString(new IntPtr(p + 0x068)); // 0x68 PropertyName                ( ModelPrimitiveType string string string String )
            value.Proto                                     = GetObject<FieldDescriptorProto>(new IntPtr(p + 0x070), ReversePrism.DataModels.FieldDescriptorProto.FromPointer); // 0x70 Proto                       ( ModelClassType FieldDescriptorProto FieldDescriptorProto FieldDescriptorProto Pointer )
            value.Extension                                 = GetObject<Extension>(new IntPtr(p + 0x078), ReversePrism.DataModels.Extension.FromPointer); // 0x78 Extension                   ( ModelClassType Extension Extension Extension Pointer )

            return value;
        }
    }
}
