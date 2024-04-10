using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sn                                       000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 RevocationDate                           0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 Extensions                               00018656AF80 ModelClassType X509ExtensionCollection X509ExtensionCollection X509ExtensionCollection Pointer
    public partial class X509CrlEntry : DataModel
    {
        public List<sbyte>?                             Sn                                      { get; set; }
        public DateTime                                 RevocationDate                          { get; set; }
        public X509ExtensionCollection?                 Extensions                              { get; set; }

        public static X509CrlEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509CrlEntry() { Pointer= p0 };

            value.Sn                                        = GetSByteList(new IntPtr(p + 0x010)); // 024667A45928 0x10 Sn                          ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.RevocationDate                            = GetDateTime(new IntPtr(p + 0x018)); // 024667A45948 0x18 RevocationDate              ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Extensions                                = GetObject<X509ExtensionCollection>(new IntPtr(p + 0x020), ReversePrism.DataModels.X509ExtensionCollection.FromPointer); // 024667A45968 0x20 Extensions                  ( 00018656AF80 ModelClassType X509ExtensionCollection X509ExtensionCollection X509ExtensionCollection Pointer )

            return value;
        }
    }
}
