using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MethodBuilder                            000186705530 ModelEnumType AsyncTaskMethodBuilder AsyncTaskMethodBuilder AsyncTaskMethodBuilder Int32
    // 028 HaveResult                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 UseBuilder                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class AsyncValueTaskMethodBuilder
    {
        public AsyncTaskMethodBuilder                   MethodBuilder                           { get; set; }
        public bool                                     HaveResult                              { get; set; }
        public bool                                     UseBuilder                              { get; set; }

        public static AsyncValueTaskMethodBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncValueTaskMethodBuilder();

            value.MethodBuilder                             = (AsyncTaskMethodBuilder)GetInt32(new IntPtr(p + 0x010)); // 0270D6CA3368 0x10 MethodBuilder               ( 000186705530 ModelEnumType AsyncTaskMethodBuilder AsyncTaskMethodBuilder AsyncTaskMethodBuilder Int32 )
            value.HaveResult                                = GetBool(new IntPtr(p + 0x028)); // 0270D6CA3388 0x28 HaveResult                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UseBuilder                                = GetBool(new IntPtr(p + 0x029)); // 0270D6CA33A8 0x29 UseBuilder                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
