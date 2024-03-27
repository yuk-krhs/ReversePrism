using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ClassName                                000186671E00 ModelPrimitiveType string string string String
    // 098 MemberName                               000186671E00 ModelPrimitiveType string string string String
    // 0A0 Signature                                000185B79A50 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class MissingMemberException
    {
        public string                                   ClassName                               { get; set; }
        public string                                   MemberName                              { get; set; }
        public List<sbyte>?                             Signature                               { get; set; }

        public static MissingMemberException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissingMemberException();

            value.ClassName                                 = GetString(new IntPtr(p + 0x090)); // 0270D69ED810 0x90 ClassName                   ( 000186671E00 ModelPrimitiveType string string string String )
            value.MemberName                                = GetString(new IntPtr(p + 0x098)); // 0270D69ED830 0x98 MemberName                  ( 000186671E00 ModelPrimitiveType string string string String )
            value.Signature                                 = GetSByteList(new IntPtr(p + 0x0A0)); // 0270D69ED850 0xA0 Signature                   ( 000185B79A50 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
