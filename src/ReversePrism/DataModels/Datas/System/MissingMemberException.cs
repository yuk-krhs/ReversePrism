using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ClassName                                ModelPrimitiveType string string string String
    // 098 MemberName                               ModelPrimitiveType string string string String
    // 0A0 Signature                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class MissingMemberException : DataModel
    {
        public string                                   ClassName                               { get; set; }
        public string                                   MemberName                              { get; set; }
        public List<sbyte>?                             Signature                               { get; set; }

        public static MissingMemberException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissingMemberException() { Pointer= p0 };

            value.ClassName                                 = GetString(new IntPtr(p + 0x090)); // 0x90 ClassName                   ( ModelPrimitiveType string string string String )
            value.MemberName                                = GetString(new IntPtr(p + 0x098)); // 0x98 MemberName                  ( ModelPrimitiveType string string string String )
            value.Signature                                 = GetSByteList(new IntPtr(p + 0x0A0)); // 0xA0 Signature                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
