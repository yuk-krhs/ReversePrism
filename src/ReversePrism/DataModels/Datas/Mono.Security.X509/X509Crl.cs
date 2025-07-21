using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Issuer                                   ModelPrimitiveType string string string String
    // 018 Version                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 020 ThisUpdate                               ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 NextUpdate                               ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 030 Entries                                  ModelClassType ArrayList ArrayList ArrayList Pointer
    // 038 SignatureOID                             ModelPrimitiveType string string string String
    // 040 Signature                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 Extensions                               ModelClassType X509ExtensionCollection X509ExtensionCollection X509ExtensionCollection Pointer
    // 050 Encoded                                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 058 Hash_value                               ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class X509Crl : DataModel
    {
        public string                                   Issuer                                  { get; set; }
        public sbyte                                    Version                                 { get; set; }
        public DateTime                                 ThisUpdate                              { get; set; }
        public DateTime                                 NextUpdate                              { get; set; }
        public ArrayList?                               Entries                                 { get; set; }
        public string                                   SignatureOID                            { get; set; }
        public List<sbyte>?                             Signature                               { get; set; }
        public X509ExtensionCollection?                 Extensions                              { get; set; }
        public List<sbyte>?                             Encoded                                 { get; set; }
        public List<sbyte>?                             Hash_value                              { get; set; }

        public static X509Crl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509Crl() { Pointer= p0 };

            value.Issuer                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Issuer                      ( ModelPrimitiveType string string string String )
            value.Version                                   = GetSByte(new IntPtr(p + 0x018)); // 0x18 Version                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.ThisUpdate                                = GetDateTime(new IntPtr(p + 0x020)); // 0x20 ThisUpdate                  ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.NextUpdate                                = GetDateTime(new IntPtr(p + 0x028)); // 0x28 NextUpdate                  ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Entries                                   = GetObject<ArrayList>(new IntPtr(p + 0x030), ReversePrism.DataModels.ArrayList.FromPointer); // 0x30 Entries                     ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.SignatureOID                              = GetString(new IntPtr(p + 0x038)); // 0x38 SignatureOID                ( ModelPrimitiveType string string string String )
            value.Signature                                 = GetSByteList(new IntPtr(p + 0x040)); // 0x40 Signature                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Extensions                                = GetObject<X509ExtensionCollection>(new IntPtr(p + 0x048), ReversePrism.DataModels.X509ExtensionCollection.FromPointer); // 0x48 Extensions                  ( ModelClassType X509ExtensionCollection X509ExtensionCollection X509ExtensionCollection Pointer )
            value.Encoded                                   = GetSByteList(new IntPtr(p + 0x050)); // 0x50 Encoded                     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Hash_value                                = GetSByteList(new IntPtr(p + 0x058)); // 0x58 Hash_value                  ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
