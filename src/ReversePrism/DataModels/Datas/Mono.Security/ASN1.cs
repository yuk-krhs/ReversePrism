using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_nTag                                   00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 M_aValue                                 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Elist                                    00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    public partial class ASN1 : DataModel
    {
        public sbyte                                    M_nTag                                  { get; set; }
        public List<sbyte>?                             M_aValue                                { get; set; }
        public ArrayList?                               Elist                                   { get; set; }

        public static ASN1? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ASN1() { Pointer= p0 };

            value.M_nTag                                    = GetSByte(new IntPtr(p + 0x010)); // 02466B405600 0x10 M_nTag                      ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_aValue                                  = GetSByteList(new IntPtr(p + 0x018)); // 02466B405620 0x18 M_aValue                    ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Elist                                     = GetObject<ArrayList>(new IntPtr(p + 0x020), ReversePrism.DataModels.ArrayList.FromPointer); // 02466B405640 0x20 Elist                       ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )

            return value;
        }
    }
}
