using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Name                                     ModelPrimitiveType string string string String
    // 028 CanonEncoding                            ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class X500DistinguishedName : DataModel
    {
        public string                                   Name                                    { get; set; }
        public List<sbyte>?                             CanonEncoding                           { get; set; }

        public static X500DistinguishedName? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X500DistinguishedName() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.CanonEncoding                             = GetSByteList(new IntPtr(p + 0x028)); // 0x28 CanonEncoding               ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
