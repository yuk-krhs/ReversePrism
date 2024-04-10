using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 M_Hits                                   000185CA00A8 ModelEnumListType RaycastHit2D[] RaycastHit2D[] List<RaycastHit2D> Pointer
    public partial class Physics2DRaycaster : DataModel
    {
        public List<RaycastHit2D>?                      M_Hits                                  { get; set; }

        public static Physics2DRaycaster? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Physics2DRaycaster() { Pointer= p0 };

            value.M_Hits                                    = GetEnumList<RaycastHit2D>(new IntPtr(p + 0x048)); // 0245A68A9208 0x48 M_Hits                      ( 000185CA00A8 ModelEnumListType RaycastHit2D[] RaycastHit2D[] List<RaycastHit2D> Pointer )

            return value;
        }
    }
}
