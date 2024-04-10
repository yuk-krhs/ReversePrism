using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Graphic                                  000186692860 ModelClassType Graphic Graphic Graphic Pointer
    // 018 WorldHitPosition                         0001866AC430 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 ScreenPosition                           0001866A9350 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 02C Distance                                 000186666CB0 ModelPrimitiveType float float float Single
    public partial class RaycastHitData : DataModel
    {
        public Graphic?                                 Graphic                                 { get; set; }
        public Vector3                                  WorldHitPosition                        { get; set; }
        public Vector2                                  ScreenPosition                          { get; set; }
        public float                                    Distance                                { get; set; }

        public static RaycastHitData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RaycastHitData() { Pointer= p0 };

            value.Graphic                                   = GetObject<Graphic>(new IntPtr(p + 0x010), ReversePrism.DataModels.Graphic.FromPointer); // 02466780B308 0x10 Graphic                     ( 000186692860 ModelClassType Graphic Graphic Graphic Pointer )
            value.WorldHitPosition                          = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 02466780B328 0x18 WorldHitPosition            ( 0001866AC430 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ScreenPosition                            = (Vector2)GetInt32(new IntPtr(p + 0x024)); // 02466780B348 0x24 ScreenPosition              ( 0001866A9350 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Distance                                  = GetSingle(new IntPtr(p + 0x02C)); // 02466780B368 0x2C Distance                    ( 000186666CB0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
