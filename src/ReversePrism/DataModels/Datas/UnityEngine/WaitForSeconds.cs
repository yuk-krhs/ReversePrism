using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Seconds                                000186665900 ModelPrimitiveType float float float Single
    public partial class WaitForSeconds : DataModel
    {
        public float                                    M_Seconds                               { get; set; }

        public static WaitForSeconds? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitForSeconds() { Pointer= p0 };

            value.M_Seconds                                 = GetSingle(new IntPtr(p + 0x010)); // 0245A24CAFA8 0x10 M_Seconds                   ( 000186665900 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
