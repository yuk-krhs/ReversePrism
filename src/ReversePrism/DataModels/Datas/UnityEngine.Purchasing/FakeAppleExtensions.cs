using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_FailRefresh                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 SimulateAskToBuy                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class FakeAppleExtensions
    {
        public bool                                     M_FailRefresh                           { get; set; }
        public bool                                     SimulateAskToBuy                        { get; set; }

        public static FakeAppleExtensions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FakeAppleExtensions();

            value.M_FailRefresh                             = GetBool(new IntPtr(p + 0x010)); // 0270069161A8 0x10 M_FailRefresh               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SimulateAskToBuy                          = GetBool(new IntPtr(p + 0x011)); // 0270069161C8 0x11 SimulateAskToBuy            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
