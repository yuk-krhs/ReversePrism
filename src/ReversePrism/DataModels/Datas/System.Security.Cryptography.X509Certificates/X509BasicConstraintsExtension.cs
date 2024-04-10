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
    // 028 CertificateAuthority                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 HasPathLengthConstraint                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C PathLengthConstraint                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 Status                                   0001866DC700 ModelEnumType AsnDecodeStatus AsnDecodeStatus AsnDecodeStatus Int32
    public partial class X509BasicConstraintsExtension : DataModel
    {
        public bool                                     CertificateAuthority                    { get; set; }
        public bool                                     HasPathLengthConstraint                 { get; set; }
        public int                                      PathLengthConstraint                    { get; set; }
        public AsnDecodeStatus                          Status                                  { get; set; }

        public static X509BasicConstraintsExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509BasicConstraintsExtension() { Pointer= p0 };

            value.CertificateAuthority                      = GetBool(new IntPtr(p + 0x028)); // 024667A3AF00 0x28 CertificateAuthority        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasPathLengthConstraint                   = GetBool(new IntPtr(p + 0x029)); // 024667A3AF20 0x29 HasPathLengthConstraint     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PathLengthConstraint                      = GetInt32(new IntPtr(p + 0x02C)); // 024667A3AF40 0x2C PathLengthConstraint        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Status                                    = (AsnDecodeStatus)GetInt32(new IntPtr(p + 0x030)); // 024667A3AF60 0x30 Status                      ( 0001866DC700 ModelEnumType AsnDecodeStatus AsnDecodeStatus AsnDecodeStatus Int32 )

            return value;
        }
    }
}
