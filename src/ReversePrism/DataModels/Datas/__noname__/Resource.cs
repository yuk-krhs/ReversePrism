using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Resource> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ServiceFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Service                                  ModelPrimitiveType string string string String
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Name                                     ModelPrimitiveType string string string String
    // 000 TypeFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Type                                     ModelPrimitiveType string string string String
    // 000 LabelsFieldNumber                        int IL2CPP_TYPE_I4
    // 008 _map_labels_codec                        Codec<string, string> IL2CPP_TYPE_GENERICINST
    // 030 labels_                                  MapField`2<string, string> IL2CPP_TYPE_GENERICINST
    // 000 UidFieldNumber                           int IL2CPP_TYPE_I4
    // 038 Uid                                      ModelPrimitiveType string string string String
    // 000 AnnotationsFieldNumber                   int IL2CPP_TYPE_I4
    // 010 _map_annotations_codec                   Codec<string, string> IL2CPP_TYPE_GENERICINST
    // 040 annotations_                             MapField`2<string, string> IL2CPP_TYPE_GENERICINST
    // 000 DisplayNameFieldNumber                   int IL2CPP_TYPE_I4
    // 048 DisplayName                              ModelPrimitiveType string string string String
    // 000 CreateTimeFieldNumber                    int IL2CPP_TYPE_I4
    // 050 _CreateTime                              ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 UpdateTimeFieldNumber                    int IL2CPP_TYPE_I4
    // 058 _UpdateTime                              ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 DeleteTimeFieldNumber                    int IL2CPP_TYPE_I4
    // 060 _DeleteTime                              ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EtagFieldNumber                          int IL2CPP_TYPE_I4
    // 068 Etag                                     ModelPrimitiveType string string string String
    // 000 LocationFieldNumber                      int IL2CPP_TYPE_I4
    // 070 Location                                 ModelPrimitiveType string string string String
    public partial class Resource : DataModel
    {
        public string                                   Service                                 { get; set; }
        public string                                   Name                                    { get; set; }
        public string                                   Type                                    { get; set; }
        public string                                   Uid                                     { get; set; }
        public string                                   DisplayName                             { get; set; }
        public Timestamp?                               _CreateTime                             { get; set; }
        public Timestamp?                               _UpdateTime                             { get; set; }
        public Timestamp?                               _DeleteTime                             { get; set; }
        public string                                   Etag                                    { get; set; }
        public string                                   Location                                { get; set; }

        public static Resource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Resource() { Pointer= p0 };

            value.Service                                   = GetString(new IntPtr(p + 0x018)); // 0x18 Service                     ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Type                        ( ModelPrimitiveType string string string String )
            value.Uid                                       = GetString(new IntPtr(p + 0x038)); // 0x38 Uid                         ( ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x048)); // 0x48 DisplayName                 ( ModelPrimitiveType string string string String )
            value._CreateTime                               = GetObject<Timestamp>(new IntPtr(p + 0x050), ReversePrism.DataModels.Timestamp.FromPointer); // 0x50 _CreateTime                 ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._UpdateTime                               = GetObject<Timestamp>(new IntPtr(p + 0x058), ReversePrism.DataModels.Timestamp.FromPointer); // 0x58 _UpdateTime                 ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._DeleteTime                               = GetObject<Timestamp>(new IntPtr(p + 0x060), ReversePrism.DataModels.Timestamp.FromPointer); // 0x60 _DeleteTime                 ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.Etag                                      = GetString(new IntPtr(p + 0x068)); // 0x68 Etag                        ( ModelPrimitiveType string string string String )
            value.Location                                  = GetString(new IntPtr(p + 0x070)); // 0x70 Location                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
