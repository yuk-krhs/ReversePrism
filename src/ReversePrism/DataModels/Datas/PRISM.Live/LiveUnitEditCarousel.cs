using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 098 SummerCellPrefab                         ModelClassType GameObject GameObject GameObject Pointer
    public partial class LiveUnitEditCarousel : DataModel
    {
        public GameObject?                              SummerCellPrefab                        { get; set; }

        public static LiveUnitEditCarousel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditCarousel() { Pointer= p0 };

            value.SummerCellPrefab                          = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 SummerCellPrefab            ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
