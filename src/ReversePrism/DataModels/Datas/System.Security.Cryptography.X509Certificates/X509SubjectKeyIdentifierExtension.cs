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
    // 028 SubjectKeyIdentifier                     000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Ski                                      000186671910 ModelPrimitiveType string string string String
    // 038 Status                                   0001866DC700 ModelEnumType AsnDecodeStatus AsnDecodeStatus AsnDecodeStatus Int32
    public partial class X509SubjectKeyIdentifierExtension
    {
        public List<sbyte>?                             SubjectKeyIdentifier                    { get; set; }
        public string                                   Ski                                     { get; set; }
        public AsnDecodeStatus                          Status                                  { get; set; }

        public static X509SubjectKeyIdentifierExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509SubjectKeyIdentifierExtension();

            value.SubjectKeyIdentifier                      = GetSByteList(new IntPtr(p + 0x028)); // 0270D79EE7F0 0x28 SubjectKeyIdentifier        ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Ski                                       = GetString(new IntPtr(p + 0x030)); // 0270D79EE810 0x30 Ski                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Status                                    = (AsnDecodeStatus)GetInt32(new IntPtr(p + 0x038)); // 0270D79EE830 0x38 Status                      ( 0001866DC700 ModelEnumType AsnDecodeStatus AsnDecodeStatus AsnDecodeStatus Int32 )

            return value;
        }
    }
}
