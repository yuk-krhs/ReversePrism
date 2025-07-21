using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_FailRefresh                            ModelPrimitiveType bool bool bool Bool
    // 011 SimulateAskToBuy                         ModelPrimitiveType bool bool bool Bool
    public partial class FakeAppleExtensions : DataModel
    {
        public bool                                     M_FailRefresh                           { get; set; }
        public bool                                     SimulateAskToBuy                        { get; set; }

        public static FakeAppleExtensions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FakeAppleExtensions() { Pointer= p0 };

            value.M_FailRefresh                             = GetBool(new IntPtr(p + 0x010)); // 0x10 M_FailRefresh               ( ModelPrimitiveType bool bool bool Bool )
            value.SimulateAskToBuy                          = GetBool(new IntPtr(p + 0x011)); // 0x11 SimulateAskToBuy            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
