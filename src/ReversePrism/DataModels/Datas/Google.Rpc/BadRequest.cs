using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<BadRequest> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FieldViolationsFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_fieldViolations_codec          FieldCodec`1<FieldViolation> IL2CPP_TYPE_GENERICINST
    // 018 FieldViolations                          ModelClassListType RepeatedField`1<FieldViolation> RepeatedField`1<FieldViolation> List<FieldViolation> Pointer
    public partial class BadRequest : DataModel
    {
        public List<FieldViolation>?                    FieldViolations                         { get; set; }

        public static BadRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BadRequest() { Pointer= p0 };

            value.FieldViolations                           = GetObjectList<FieldViolation>(new IntPtr(p + 0x018), ReversePrism.DataModels.FieldViolation.FromPointer); // 0x18 FieldViolations             ( ModelClassListType RepeatedField`1<FieldViolation> RepeatedField`1<FieldViolation> List<FieldViolation> Pointer )

            return value;
        }
    }
}
