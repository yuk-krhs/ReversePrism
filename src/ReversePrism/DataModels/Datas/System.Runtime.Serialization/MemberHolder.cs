using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MemberType                               000186693960 ModelClassType Type Type Type Pointer
    // 018 Context                                  0001865B9460 ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    public partial class MemberHolder
    {
        public Type?                                    MemberType                              { get; set; }
        public StreamingContext                         Context                                 { get; set; }

        public static MemberHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemberHolder();

            value.MemberType                                = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 027004D48948 0x10 MemberType                  ( 000186693960 ModelClassType Type Type Type Pointer )
            value.Context                                   = (StreamingContext)GetInt32(new IntPtr(p + 0x018)); // 027004D48968 0x18 Context                     ( 0001865B9460 ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )

            return value;
        }
    }
}
