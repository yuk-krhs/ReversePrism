using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMaxAreaTolerance                        float IL2CPP_TYPE_R4
    // 004 kMaxEdgeTolerance                        float IL2CPP_TYPE_R4
    public partial class Smoothen : DataModel
    {

        public static Smoothen? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Smoothen() { Pointer= p0 };


            return value;
        }
    }
}
