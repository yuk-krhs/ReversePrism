using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_LowerBound                             0001865F1060 ModelPrimitiveType short short short Int16
    // 012 M_UpperBound                             0001865F1060 ModelPrimitiveType short short short Int16
    public partial class SortingLayerRange
    {
        public short                                    M_LowerBound                            { get; set; }
        public short                                    M_UpperBound                            { get; set; }

        public static SortingLayerRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortingLayerRange();

            value.M_LowerBound                              = GetInt16(new IntPtr(p + 0x010)); // 0270D0ABF378 0x10 M_LowerBound                ( 0001865F1060 ModelPrimitiveType short short short Int16 )
            value.M_UpperBound                              = GetInt16(new IntPtr(p + 0x012)); // 0270D0ABF398 0x12 M_UpperBound                ( 0001865F1060 ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
