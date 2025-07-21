using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProjectProperties> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PropertiesFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_properties_codec               FieldCodec`1<Property> IL2CPP_TYPE_GENERICINST
    // 018 Properties                               ModelClassListType RepeatedField`1<Property> RepeatedField`1<Property> List<Property> Pointer
    public partial class ProjectProperties : DataModel
    {
        public List<Property>?                          Properties                              { get; set; }

        public static ProjectProperties? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProjectProperties() { Pointer= p0 };

            value.Properties                                = GetObjectList<Property>(new IntPtr(p + 0x018), ReversePrism.DataModels.Property.FromPointer); // 0x18 Properties                  ( ModelClassListType RepeatedField`1<Property> RepeatedField`1<Property> List<Property> Pointer )

            return value;
        }
    }
}
