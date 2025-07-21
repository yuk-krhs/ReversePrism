using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Activators                               ModelEnumListType List`1<ManipulatorActivationFilter> List`1<ManipulatorActivationFilter> List<ManipulatorActivationFilter> Pointer
    // 020 M_currentActivator                       ModelEnumType ManipulatorActivationFilter ManipulatorActivationFilter ManipulatorActivationFilter Int32
    public partial class MouseManipulator : DataModel
    {
        public List<ManipulatorActivationFilter>?       Activators                              { get; set; }
        public ManipulatorActivationFilter              M_currentActivator                      { get; set; }

        public static MouseManipulator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MouseManipulator() { Pointer= p0 };

            value.Activators                                = GetEnumList<ManipulatorActivationFilter>(new IntPtr(p + 0x018)); // 0x18 Activators                  ( ModelEnumListType List`1<ManipulatorActivationFilter> List`1<ManipulatorActivationFilter> List<ManipulatorActivationFilter> Pointer )
            value.M_currentActivator                        = (ManipulatorActivationFilter)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_currentActivator          ( ModelEnumType ManipulatorActivationFilter ManipulatorActivationFilter ManipulatorActivationFilter Int32 )

            return value;
        }
    }
}
