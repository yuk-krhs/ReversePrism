using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 oid                                      string IL2CPP_TYPE_STRING
    // 000 friendlyName                             string IL2CPP_TYPE_STRING
    // 028 SubjectKeyIdentifier                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Ski                                      ModelPrimitiveType string string string String
    // 038 Status                                   ModelEnumType AsnDecodeStatus AsnDecodeStatus AsnDecodeStatus Int32
    public partial class X509SubjectKeyIdentifierExtension : DataModel
    {
        public List<sbyte>?                             SubjectKeyIdentifier                    { get; set; }
        public string                                   Ski                                     { get; set; }
        public AsnDecodeStatus                          Status                                  { get; set; }

        public static X509SubjectKeyIdentifierExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509SubjectKeyIdentifierExtension() { Pointer= p0 };

            value.SubjectKeyIdentifier                      = GetSByteList(new IntPtr(p + 0x028)); // 0x28 SubjectKeyIdentifier        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Ski                                       = GetString(new IntPtr(p + 0x030)); // 0x30 Ski                         ( ModelPrimitiveType string string string String )
            value.Status                                    = (AsnDecodeStatus)GetInt32(new IntPtr(p + 0x038)); // 0x38 Status                      ( ModelEnumType AsnDecodeStatus AsnDecodeStatus AsnDecodeStatus Int32 )

            return value;
        }
    }
}
