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
    // 018 Service                                  000186671910 ModelPrimitiveType string string string String
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 TypeFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Type                                     000186671910 ModelPrimitiveType string string string String
    // 000 LabelsFieldNumber                        int IL2CPP_TYPE_I4
    // 008 _map_labels_codec                        Codec<string, string> IL2CPP_TYPE_GENERICINST
    // 030 labels_                                  MapField`2<string, string> IL2CPP_TYPE_GENERICINST
    // 000 UidFieldNumber                           int IL2CPP_TYPE_I4
    // 038 Uid                                      000186671910 ModelPrimitiveType string string string String
    // 000 AnnotationsFieldNumber                   int IL2CPP_TYPE_I4
    // 010 _map_annotations_codec                   Codec<string, string> IL2CPP_TYPE_GENERICINST
    // 040 annotations_                             MapField`2<string, string> IL2CPP_TYPE_GENERICINST
    // 000 DisplayNameFieldNumber                   int IL2CPP_TYPE_I4
    // 048 DisplayName                              000186671910 ModelPrimitiveType string string string String
    // 000 CreateTimeFieldNumber                    int IL2CPP_TYPE_I4
    // 050 _CreateTime                              000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 UpdateTimeFieldNumber                    int IL2CPP_TYPE_I4
    // 058 _UpdateTime                              000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 DeleteTimeFieldNumber                    int IL2CPP_TYPE_I4
    // 060 _DeleteTime                              000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EtagFieldNumber                          int IL2CPP_TYPE_I4
    // 068 Etag                                     000186671910 ModelPrimitiveType string string string String
    // 000 LocationFieldNumber                      int IL2CPP_TYPE_I4
    // 070 Location                                 000186671910 ModelPrimitiveType string string string String
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

            value.Service                                   = GetString(new IntPtr(p + 0x018)); // 02466A7749F0 0x18 Service                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 02466A774A30 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x028)); // 02466A774A70 0x28 Type                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Uid                                       = GetString(new IntPtr(p + 0x038)); // 02466A774B10 0x38 Uid                         ( 000186671910 ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x048)); // 02466A774BB0 0x48 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )
            value._CreateTime                               = GetObject<Timestamp>(new IntPtr(p + 0x050), ReversePrism.DataModels.Timestamp.FromPointer); // 02466A774BF0 0x50 _CreateTime                 ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._UpdateTime                               = GetObject<Timestamp>(new IntPtr(p + 0x058), ReversePrism.DataModels.Timestamp.FromPointer); // 02466A774C30 0x58 _UpdateTime                 ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._DeleteTime                               = GetObject<Timestamp>(new IntPtr(p + 0x060), ReversePrism.DataModels.Timestamp.FromPointer); // 02466A774C70 0x60 _DeleteTime                 ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.Etag                                      = GetString(new IntPtr(p + 0x068)); // 02466A774CB0 0x68 Etag                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Location                                  = GetString(new IntPtr(p + 0x070)); // 02466A774CF0 0x70 Location                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
