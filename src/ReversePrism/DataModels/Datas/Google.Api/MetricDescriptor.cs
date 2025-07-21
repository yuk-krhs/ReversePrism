using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MetricDescriptor> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     ModelPrimitiveType string string string String
    // 000 TypeFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Type                                     ModelPrimitiveType string string string String
    // 000 LabelsFieldNumber                        int IL2CPP_TYPE_I4
    // 008 _repeated_labels_codec                   FieldCodec`1<LabelDescriptor> IL2CPP_TYPE_GENERICINST
    // 028 Labels                                   ModelClassListType RepeatedField`1<LabelDescriptor> RepeatedField`1<LabelDescriptor> List<LabelDescriptor> Pointer
    // 000 MetricKindFieldNumber                    int IL2CPP_TYPE_I4
    // 030 MetricKind                               ModelEnumType MetricKind MetricKind MetricKind Int32
    // 000 ValueTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 034 ValueType                                ModelEnumType ValueType ValueType ValueType Int32
    // 000 UnitFieldNumber                          int IL2CPP_TYPE_I4
    // 038 Unit                                     ModelPrimitiveType string string string String
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 040 Description                              ModelPrimitiveType string string string String
    // 000 DisplayNameFieldNumber                   int IL2CPP_TYPE_I4
    // 048 DisplayName                              ModelPrimitiveType string string string String
    // 000 MetadataFieldNumber                      int IL2CPP_TYPE_I4
    // 050 Metadata                                 ModelClassType MetricDescriptorMetadata MetricDescriptorMetadata MetricDescriptorMetadata Pointer
    // 000 LaunchStageFieldNumber                   int IL2CPP_TYPE_I4
    // 058 LaunchStage                              ModelEnumType LaunchStage LaunchStage LaunchStage Int32
    // 000 MonitoredResourceTypesFieldNumber        int IL2CPP_TYPE_I4
    // 010 _repeated_monitoredResourceTypes_codec   FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 060 MonitoredResourceTypes                   ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class MetricDescriptor : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   Type                                    { get; set; }
        public List<LabelDescriptor>?                   Labels                                  { get; set; }
        public MetricKind                               MetricKind                              { get; set; }
        public ValueType                                ValueType                               { get; set; }
        public string                                   Unit                                    { get; set; }
        public string                                   Description                             { get; set; }
        public string                                   DisplayName                             { get; set; }
        public MetricDescriptorMetadata?                Metadata                                { get; set; }
        public LaunchStage                              LaunchStage                             { get; set; }
        public List<string>?                            MonitoredResourceTypes                  { get; set; }

        public static MetricDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MetricDescriptor() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Type                        ( ModelPrimitiveType string string string String )
            value.Labels                                    = GetObjectList<LabelDescriptor>(new IntPtr(p + 0x028), ReversePrism.DataModels.LabelDescriptor.FromPointer); // 0x28 Labels                      ( ModelClassListType RepeatedField`1<LabelDescriptor> RepeatedField`1<LabelDescriptor> List<LabelDescriptor> Pointer )
            value.MetricKind                                = (MetricKind)GetInt32(new IntPtr(p + 0x030)); // 0x30 MetricKind                  ( ModelEnumType MetricKind MetricKind MetricKind Int32 )
            value.ValueType                                 = (ValueType)GetInt32(new IntPtr(p + 0x034)); // 0x34 ValueType                   ( ModelEnumType ValueType ValueType ValueType Int32 )
            value.Unit                                      = GetString(new IntPtr(p + 0x038)); // 0x38 Unit                        ( ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x040)); // 0x40 Description                 ( ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x048)); // 0x48 DisplayName                 ( ModelPrimitiveType string string string String )
            value.Metadata                                  = GetObject<MetricDescriptorMetadata>(new IntPtr(p + 0x050), ReversePrism.DataModels.MetricDescriptorMetadata.FromPointer); // 0x50 Metadata                    ( ModelClassType MetricDescriptorMetadata MetricDescriptorMetadata MetricDescriptorMetadata Pointer )
            value.LaunchStage                               = (LaunchStage)GetInt32(new IntPtr(p + 0x058)); // 0x58 LaunchStage                 ( ModelEnumType LaunchStage LaunchStage LaunchStage Int32 )
            value.MonitoredResourceTypes                    = GetStringList(new IntPtr(p + 0x060)); // 0x60 MonitoredResourceTypes      ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
