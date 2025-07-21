using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sn                                       ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 RevocationDate                           ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 Extensions                               ModelClassType X509ExtensionCollection X509ExtensionCollection X509ExtensionCollection Pointer
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

            value.Sn                                        = GetSByteList(new IntPtr(p + 0x010)); // 0x10 Sn                          ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.RevocationDate                            = GetDateTime(new IntPtr(p + 0x018)); // 0x18 RevocationDate              ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Extensions                                = GetObject<X509ExtensionCollection>(new IntPtr(p + 0x020), ReversePrism.DataModels.X509ExtensionCollection.FromPointer); // 0x20 Extensions                  ( ModelClassType X509ExtensionCollection X509ExtensionCollection X509ExtensionCollection Pointer )

            return value;
        }
    }
}
