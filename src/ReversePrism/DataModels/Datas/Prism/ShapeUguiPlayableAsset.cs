using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Target                                   ModelClassType ShapeUgui ShapeUgui ShapeUgui Pointer
    // 028 Bounds                                   ModelEnumType Bounds Bounds Bounds Int32
    public partial class ShapeUguiPlayableAsset : DataModel
    {
        public ShapeUgui?                               Target                                  { get; set; }
        public Bounds                                   Bounds                                  { get; set; }

        public static ShapeUguiPlayableAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShapeUguiPlayableAsset() { Pointer= p0 };

            value.Target                                    = GetObject<ShapeUgui>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShapeUgui.FromPointer); // 0x20 Target                      ( ModelClassType ShapeUgui ShapeUgui ShapeUgui Pointer )
            value.Bounds                                    = (Bounds)GetInt32(new IntPtr(p + 0x028)); // 0x28 Bounds                      ( ModelEnumType Bounds Bounds Bounds Int32 )

            return value;
        }
    }
}
