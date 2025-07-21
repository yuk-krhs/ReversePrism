using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Next                                     ModelClassType Axis Axis Axis Pointer
    public partial class DoubleLinkAxis : DataModel
    {
        public Axis?                                    Next                                    { get; set; }

        public static DoubleLinkAxis? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DoubleLinkAxis() { Pointer= p0 };

            value.Next                                      = GetObject<Axis>(new IntPtr(p + 0x040), ReversePrism.DataModels.Axis.FromPointer); // 0x40 Next                        ( ModelClassType Axis Axis Axis Pointer )

            return value;
        }
    }
}
