using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_WorldCorners                           ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 018 M_CanvasCorners                          ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    public partial class RectangularVertexClipper : DataModel
    {
        public List<Vector3>?                           M_WorldCorners                          { get; set; }
        public List<Vector3>?                           M_CanvasCorners                         { get; set; }

        public static RectangularVertexClipper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RectangularVertexClipper() { Pointer= p0 };

            value.M_WorldCorners                            = GetEnumList<Vector3>(new IntPtr(p + 0x010)); // 0x10 M_WorldCorners              ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.M_CanvasCorners                           = GetEnumList<Vector3>(new IntPtr(p + 0x018)); // 0x18 M_CanvasCorners             ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )

            return value;
        }
    }
}
