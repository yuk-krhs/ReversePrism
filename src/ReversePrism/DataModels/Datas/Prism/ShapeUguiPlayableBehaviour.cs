using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vertices                                 ModelEnumListType List`1<Vector2> List`1<Vector2> List<Vector2> Pointer
    public partial class ShapeUguiPlayableBehaviour : DataModel
    {
        public List<Vector2>?                           Vertices                                { get; set; }

        public static ShapeUguiPlayableBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShapeUguiPlayableBehaviour() { Pointer= p0 };

            value.Vertices                                  = GetEnumList<Vector2>(new IntPtr(p + 0x010)); // 0x10 Vertices                    ( ModelEnumListType List`1<Vector2> List`1<Vector2> List<Vector2> Pointer )

            return value;
        }
    }
}
