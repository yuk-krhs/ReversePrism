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
    public partial class AsyncValueTaskMethodBuilder : DataModel
    {
        public AsyncTaskMethodBuilder                   MethodBuilder                           { get; set; }
        public bool                                     HaveResult                              { get; set; }
        public bool                                     UseBuilder                              { get; set; }

        public static AsyncValueTaskMethodBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncValueTaskMethodBuilder() { Pointer= p0 };

            value.MethodBuilder                             = (AsyncTaskMethodBuilder)GetInt32(new IntPtr(p + 0x010)); // 024666D02B38 0x10 MethodBuilder               ( 000186705530 ModelEnumType AsyncTaskMethodBuilder AsyncTaskMethodBuilder AsyncTaskMethodBuilder Int32 )
            value.HaveResult                                = GetBool(new IntPtr(p + 0x028)); // 024666D02B58 0x28 HaveResult                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UseBuilder                                = GetBool(new IntPtr(p + 0x029)); // 024666D02B78 0x29 UseBuilder                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
