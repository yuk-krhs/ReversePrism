using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MonitoredResourceDescriptor> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 TypeFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Type                                     000186671910 ModelPrimitiveType string string string String
    // 000 DisplayNameFieldNumber                   int IL2CPP_TYPE_I4
    // 028 DisplayName                              000186671910 ModelPrimitiveType string string string String
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 030 Description                              000186671910 ModelPrimitiveType string string string String
    // 000 LabelsFieldNumber                        int IL2CPP_TYPE_I4
    // 008 _repeated_labels_codec                   FieldCodec`1<LabelDescriptor> IL2CPP_TYPE_GENERICINST
    // 038 Labels                                   000185CE27E8 ModelClassListType RepeatedField`1<LabelDescriptor> RepeatedField`1<LabelDescriptor> List<LabelDescriptor> Pointer
    // 000 LaunchStageFieldNumber                   int IL2CPP_TYPE_I4
    // 040 LaunchStage                              00018650A860 ModelEnumType LaunchStage LaunchStage LaunchStage Int32
    public partial class MonitoredResourceDescriptor
    {
        public string                                   Name                                    { get; set; }
        public string                                   Type                                    { get; set; }
        public string                                   DisplayName                             { get; set; }
        public string                                   Description                             { get; set; }
        public List<LabelDescriptor>?                   Labels                                  { get; set; }
        public LaunchStage                              LaunchStage                             { get; set; }

        public static MonitoredResourceDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonitoredResourceDescriptor();

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270DA7FFC50 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x020)); // 0270DA7FFC90 0x20 Type                        ( 000186671910 ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x028)); // 0270DA7FFCD0 0x28 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x030)); // 0270DA7FFD10 0x30 Description                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Labels                                    = GetObjectList<LabelDescriptor>(new IntPtr(p + 0x038), ReversePrism.DataModels.LabelDescriptor.FromPointer); // 0270DA7FFD70 0x38 Labels                      ( 000185CE27E8 ModelClassListType RepeatedField`1<LabelDescriptor> RepeatedField`1<LabelDescriptor> List<LabelDescriptor> Pointer )
            value.LaunchStage                               = (LaunchStage)GetInt32(new IntPtr(p + 0x040)); // 0270DA7FFDB0 0x40 LaunchStage                 ( 00018650A860 ModelEnumType LaunchStage LaunchStage LaunchStage Int32 )

            return value;
        }
    }
}
