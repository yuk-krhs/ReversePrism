using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Aki                                      ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class AuthorityKeyIdentifierExtension : DataModel
    {
        public List<sbyte>?                             Aki                                     { get; set; }

        public static AuthorityKeyIdentifierExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthorityKeyIdentifierExtension() { Pointer= p0 };

            value.Aki                                       = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Aki                         ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
