using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Oid                                      0001866D8600 ModelClassType Oid Oid Oid Pointer
    // 018 Raw                                      000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class AsnEncodedData : DataModel
    {
        public Oid?                                     Oid                                     { get; set; }
        public List<sbyte>?                             Raw                                     { get; set; }

        public static AsnEncodedData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsnEncodedData() { Pointer= p0 };

            value.Oid                                       = GetObject<Oid>(new IntPtr(p + 0x010), ReversePrism.DataModels.Oid.FromPointer); // 0246679E24C0 0x10 Oid                         ( 0001866D8600 ModelClassType Oid Oid Oid Pointer )
            value.Raw                                       = GetSByteList(new IntPtr(p + 0x018)); // 0246679E24E0 0x18 Raw                         ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
