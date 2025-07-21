using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Exemplar> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ValueFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Value                                    ModelPrimitiveType double double double Double
    // 000 TimestampFieldNumber                     int IL2CPP_TYPE_I4
    // 020 _Timestamp                               ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 AttachmentsFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_attachments_codec              FieldCodec`1<Any> IL2CPP_TYPE_GENERICINST
    // 028 Attachments                              ModelClassListType RepeatedField`1<Any> RepeatedField`1<Any> List<Any> Pointer
    public partial class Exemplar : DataModel
    {
        public double                                   Value                                   { get; set; }
        public Timestamp?                               _Timestamp                              { get; set; }
        public List<Any>?                               Attachments                             { get; set; }

        public static Exemplar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Exemplar() { Pointer= p0 };

            value.Value                                     = GetDouble(new IntPtr(p + 0x018)); // 0x18 Value                       ( ModelPrimitiveType double double double Double )
            value._Timestamp                                = GetObject<Timestamp>(new IntPtr(p + 0x020), ReversePrism.DataModels.Timestamp.FromPointer); // 0x20 _Timestamp                  ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.Attachments                               = GetObjectList<Any>(new IntPtr(p + 0x028), ReversePrism.DataModels.Any.FromPointer); // 0x28 Attachments                 ( ModelClassListType RepeatedField`1<Any> RepeatedField`1<Any> List<Any> Pointer )

            return value;
        }
    }
}
