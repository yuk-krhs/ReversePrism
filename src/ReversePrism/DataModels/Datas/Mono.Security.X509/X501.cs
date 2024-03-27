using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 countryName                              sbyte[] IL2CPP_TYPE_SZARRAY
    // 008 organizationName                         sbyte[] IL2CPP_TYPE_SZARRAY
    // 010 OrganizationalUnitName                   000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 CommonName                               000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 LocalityName                             000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 StateOrProvinceName                      000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 StreetAddress                            000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 SerialNumber                             000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 DomainComponent                          000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 Userid                                   000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 Email                                    000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 058 DnQualifier                              000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 060 Title                                    000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 068 Surname                                  000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 070 GivenName                                000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 078 Initial                                  000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class X501
    {
        public List<sbyte>?                             OrganizationalUnitName                  { get; set; }
        public List<sbyte>?                             CommonName                              { get; set; }
        public List<sbyte>?                             LocalityName                            { get; set; }
        public List<sbyte>?                             StateOrProvinceName                     { get; set; }
        public List<sbyte>?                             StreetAddress                           { get; set; }
        public List<sbyte>?                             SerialNumber                            { get; set; }
        public List<sbyte>?                             DomainComponent                         { get; set; }
        public List<sbyte>?                             Userid                                  { get; set; }
        public List<sbyte>?                             Email                                   { get; set; }
        public List<sbyte>?                             DnQualifier                             { get; set; }
        public List<sbyte>?                             Title                                   { get; set; }
        public List<sbyte>?                             Surname                                 { get; set; }
        public List<sbyte>?                             GivenName                               { get; set; }
        public List<sbyte>?                             Initial                                 { get; set; }

        public static X501? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X501();

            value.OrganizationalUnitName                    = GetSByteList(new IntPtr(p + 0x010)); // 0270DB37BC58 0x10 OrganizationalUnitName      ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.CommonName                                = GetSByteList(new IntPtr(p + 0x018)); // 0270DB37BC78 0x18 CommonName                  ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LocalityName                              = GetSByteList(new IntPtr(p + 0x020)); // 0270DB37BC98 0x20 LocalityName                ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.StateOrProvinceName                       = GetSByteList(new IntPtr(p + 0x028)); // 0270DB37BCB8 0x28 StateOrProvinceName         ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.StreetAddress                             = GetSByteList(new IntPtr(p + 0x030)); // 0270DB37BCD8 0x30 StreetAddress               ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.SerialNumber                              = GetSByteList(new IntPtr(p + 0x038)); // 0270DB37BCF8 0x38 SerialNumber                ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DomainComponent                           = GetSByteList(new IntPtr(p + 0x040)); // 0270DB37BD18 0x40 DomainComponent             ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Userid                                    = GetSByteList(new IntPtr(p + 0x048)); // 0270DB37BD38 0x48 Userid                      ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Email                                     = GetSByteList(new IntPtr(p + 0x050)); // 0270DB37BD58 0x50 Email                       ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DnQualifier                               = GetSByteList(new IntPtr(p + 0x058)); // 0270DB37BD78 0x58 DnQualifier                 ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Title                                     = GetSByteList(new IntPtr(p + 0x060)); // 0270DB37BD98 0x60 Title                       ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Surname                                   = GetSByteList(new IntPtr(p + 0x068)); // 0270DB37BDB8 0x68 Surname                     ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.GivenName                                 = GetSByteList(new IntPtr(p + 0x070)); // 0270DB37BDD8 0x70 GivenName                   ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Initial                                   = GetSByteList(new IntPtr(p + 0x078)); // 0270DB37BDF8 0x78 Initial                     ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
