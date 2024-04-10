using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<QuotaFailure> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ViolationsFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_violations_codec               FieldCodec`1<Violation> IL2CPP_TYPE_GENERICINST
    // 018 Violations                               000185CF9928 ModelClassListType RepeatedField`1<Violation> RepeatedField`1<Violation> List<Violation> Pointer
    public partial class QuotaFailure : DataModel
    {
        public List<Violation>?                         Violations                              { get; set; }

        public static QuotaFailure? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QuotaFailure() { Pointer= p0 };

            value.Violations                                = GetObjectList<Violation>(new IntPtr(p + 0x018), ReversePrism.DataModels.Violation.FromPointer); // 02466A71A578 0x18 Violations                  ( 000185CF9928 ModelClassListType RepeatedField`1<Violation> RepeatedField`1<Violation> List<Violation> Pointer )

            return value;
        }
    }
}
