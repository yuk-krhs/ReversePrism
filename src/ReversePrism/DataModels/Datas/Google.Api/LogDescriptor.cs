using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LogDescriptor> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 LabelsFieldNumber                        int IL2CPP_TYPE_I4
    // 008 _repeated_labels_codec                   FieldCodec`1<LabelDescriptor> IL2CPP_TYPE_GENERICINST
    // 020 Labels                                   000185CE27E8 ModelClassListType RepeatedField`1<LabelDescriptor> RepeatedField`1<LabelDescriptor> List<LabelDescriptor> Pointer
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 028 Description                              000186671910 ModelPrimitiveType string string string String
    // 000 DisplayNameFieldNumber                   int IL2CPP_TYPE_I4
    // 030 DisplayName                              000186671910 ModelPrimitiveType string string string String
    public partial class LogDescriptor
    {
        public string                                   Name                                    { get; set; }
        public List<LabelDescriptor>?                   Labels                                  { get; set; }
        public string                                   Description                             { get; set; }
        public string                                   DisplayName                             { get; set; }

        public static LogDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LogDescriptor();

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270DA7E1440 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Labels                                    = GetObjectList<LabelDescriptor>(new IntPtr(p + 0x020), ReversePrism.DataModels.LabelDescriptor.FromPointer); // 0270DA7E14A0 0x20 Labels                      ( 000185CE27E8 ModelClassListType RepeatedField`1<LabelDescriptor> RepeatedField`1<LabelDescriptor> List<LabelDescriptor> Pointer )
            value.Description                               = GetString(new IntPtr(p + 0x028)); // 0270DA7E14E0 0x28 Description                 ( 000186671910 ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x030)); // 0270DA7E1520 0x30 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
