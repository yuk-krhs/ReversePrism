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
    public partial class X501 : DataModel
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
            var value   = new X501() { Pointer= p0 };

            value.OrganizationalUnitName                    = GetSByteList(new IntPtr(p + 0x010)); // 02466B409A28 0x10 OrganizationalUnitName      ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.CommonName                                = GetSByteList(new IntPtr(p + 0x018)); // 02466B409A48 0x18 CommonName                  ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LocalityName                              = GetSByteList(new IntPtr(p + 0x020)); // 02466B409A68 0x20 LocalityName                ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.StateOrProvinceName                       = GetSByteList(new IntPtr(p + 0x028)); // 02466B409A88 0x28 StateOrProvinceName         ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.StreetAddress                             = GetSByteList(new IntPtr(p + 0x030)); // 02466B409AA8 0x30 StreetAddress               ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.SerialNumber                              = GetSByteList(new IntPtr(p + 0x038)); // 02466B409AC8 0x38 SerialNumber                ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DomainComponent                           = GetSByteList(new IntPtr(p + 0x040)); // 02466B409AE8 0x40 DomainComponent             ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Userid                                    = GetSByteList(new IntPtr(p + 0x048)); // 02466B409B08 0x48 Userid                      ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Email                                     = GetSByteList(new IntPtr(p + 0x050)); // 02466B409B28 0x50 Email                       ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DnQualifier                               = GetSByteList(new IntPtr(p + 0x058)); // 02466B409B48 0x58 DnQualifier                 ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Title                                     = GetSByteList(new IntPtr(p + 0x060)); // 02466B409B68 0x60 Title                       ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Surname                                   = GetSByteList(new IntPtr(p + 0x068)); // 02466B409B88 0x68 Surname                     ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.GivenName                                 = GetSByteList(new IntPtr(p + 0x070)); // 02466B409BA8 0x70 GivenName                   ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Initial                                   = GetSByteList(new IntPtr(p + 0x078)); // 02466B409BC8 0x78 Initial                     ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
