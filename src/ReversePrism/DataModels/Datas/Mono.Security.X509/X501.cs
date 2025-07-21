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
    // 010 OrganizationalUnitName                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 CommonName                               ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 LocalityName                             ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 StateOrProvinceName                      ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 StreetAddress                            ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 SerialNumber                             ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 DomainComponent                          ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 Userid                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 Email                                    ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 058 DnQualifier                              ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 060 Title                                    ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 068 Surname                                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 070 GivenName                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 078 Initial                                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
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

            value.OrganizationalUnitName                    = GetSByteList(new IntPtr(p + 0x010)); // 0x10 OrganizationalUnitName      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.CommonName                                = GetSByteList(new IntPtr(p + 0x018)); // 0x18 CommonName                  ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LocalityName                              = GetSByteList(new IntPtr(p + 0x020)); // 0x20 LocalityName                ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.StateOrProvinceName                       = GetSByteList(new IntPtr(p + 0x028)); // 0x28 StateOrProvinceName         ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.StreetAddress                             = GetSByteList(new IntPtr(p + 0x030)); // 0x30 StreetAddress               ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.SerialNumber                              = GetSByteList(new IntPtr(p + 0x038)); // 0x38 SerialNumber                ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DomainComponent                           = GetSByteList(new IntPtr(p + 0x040)); // 0x40 DomainComponent             ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Userid                                    = GetSByteList(new IntPtr(p + 0x048)); // 0x48 Userid                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Email                                     = GetSByteList(new IntPtr(p + 0x050)); // 0x50 Email                       ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DnQualifier                               = GetSByteList(new IntPtr(p + 0x058)); // 0x58 DnQualifier                 ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Title                                     = GetSByteList(new IntPtr(p + 0x060)); // 0x60 Title                       ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Surname                                   = GetSByteList(new IntPtr(p + 0x068)); // 0x68 Surname                     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.GivenName                                 = GetSByteList(new IntPtr(p + 0x070)); // 0x70 GivenName                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Initial                                   = GetSByteList(new IntPtr(p + 0x078)); // 0x78 Initial                     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
