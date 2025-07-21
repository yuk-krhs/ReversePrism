using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GeneratedCodeInfo> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 AnnotationFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_annotation_codec               FieldCodec`1<Annotation> IL2CPP_TYPE_GENERICINST
    // 018 Annotation                               ModelClassListType RepeatedField`1<Annotation> RepeatedField`1<Annotation> List<Annotation> Pointer
    public partial class GeneratedCodeInfo : DataModel
    {
        public List<Annotation>?                        Annotation                              { get; set; }

        public static GeneratedCodeInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GeneratedCodeInfo() { Pointer= p0 };

            value.Annotation                                = GetObjectList<Annotation>(new IntPtr(p + 0x018), ReversePrism.DataModels.Annotation.FromPointer); // 0x18 Annotation                  ( ModelClassListType RepeatedField`1<Annotation> RepeatedField`1<Annotation> List<Annotation> Pointer )

            return value;
        }
    }
}
