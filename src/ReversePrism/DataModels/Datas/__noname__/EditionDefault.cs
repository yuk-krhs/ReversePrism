using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EditionDefault> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 HasBits0                                 ModelPrimitiveType int int int Int32
    // 000 EditionFieldNumber                       int IL2CPP_TYPE_I4
    // 008 EditionDefaultValue                      Edition IL2CPP_TYPE_VALUETYPE
    // 01C Edition                                  ModelEnumType Edition Edition Edition Int32
    // 000 ValueFieldNumber                         int IL2CPP_TYPE_I4
    // 010 ValueDefaultValue                        ModelPrimitiveType string string string String
    // 020 Value                                    ModelPrimitiveType string string string String
    public partial class EditionDefault : DataModel
    {
        public int                                      HasBits0                                { get; set; }
        public Edition                                  Edition                                 { get; set; }
        public string                                   ValueDefaultValue                       { get; set; }
        public string                                   Value                                   { get; set; }

        public static EditionDefault? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditionDefault() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 HasBits0                    ( ModelPrimitiveType int int int Int32 )
            value.Edition                                   = (Edition)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Edition                     ( ModelEnumType Edition Edition Edition Int32 )
            value.ValueDefaultValue                         = GetString(new IntPtr(p + 0x010)); // 0x10 ValueDefaultValue           ( ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x020)); // 0x20 Value                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
