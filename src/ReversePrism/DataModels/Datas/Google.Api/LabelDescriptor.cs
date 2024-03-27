using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LabelDescriptor> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 KeyFieldNumber                           int IL2CPP_TYPE_I4
    // 018 Key                                      000186671910 ModelPrimitiveType string string string String
    // 000 ValueTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 020 ValueType                                000186533D30 ModelEnumType ValueType ValueType ValueType Int32
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 028 Description                              000186671910 ModelPrimitiveType string string string String
    public partial class LabelDescriptor
    {
        public string                                   Key                                     { get; set; }
        public ValueType                                ValueType                               { get; set; }
        public string                                   Description                             { get; set; }

        public static LabelDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LabelDescriptor();

            value.Key                                       = GetString(new IntPtr(p + 0x018)); // 0270DA7D7E50 0x18 Key                         ( 000186671910 ModelPrimitiveType string string string String )
            value.ValueType                                 = (ValueType)GetInt32(new IntPtr(p + 0x020)); // 0270DA7D7E90 0x20 ValueType                   ( 000186533D30 ModelEnumType ValueType ValueType ValueType Int32 )
            value.Description                               = GetString(new IntPtr(p + 0x028)); // 0270DA7D7ED0 0x28 Description                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
