using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MemberName                               000186672F10 ModelPrimitiveType string string string String
    public partial class DefaultMemberAttribute : DataModel
    {
        public string                                   MemberName                              { get; set; }

        public static DefaultMemberAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultMemberAttribute() { Pointer= p0 };

            value.MemberName                                = GetString(new IntPtr(p + 0x010)); // 0245A662DD28 0x10 MemberName                  ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
