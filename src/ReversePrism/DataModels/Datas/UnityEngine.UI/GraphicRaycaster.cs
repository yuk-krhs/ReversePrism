using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kNoEventMaskSet                          int IL2CPP_TYPE_I4
    // 028 M_IgnoreReversedGraphics                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C M_BlockingObjects                        00018651D470 ModelEnumType BlockingObjects BlockingObjects BlockingObjects Int32
    // 030 M_BlockingMask                           00018650B3C0 ModelEnumType LayerMask LayerMask LayerMask Int32
    // 038 M_Canvas                                 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 040 M_RaycastResults                         000185CDF288 ModelClassListType List`1<Graphic> List`1<Graphic> List<Graphic> Pointer
    // 000 s_SortedGraphics                         List`1<Graphic> IL2CPP_TYPE_GENERICINST
    public partial class GraphicRaycaster : DataModel
    {
        public bool                                     M_IgnoreReversedGraphics                { get; set; }
        public BlockingObjects                          M_BlockingObjects                       { get; set; }
        public LayerMask                                M_BlockingMask                          { get; set; }
        public Canvas?                                  M_Canvas                                { get; set; }
        public List<Graphic>?                           M_RaycastResults                        { get; set; }

        public static GraphicRaycaster? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GraphicRaycaster() { Pointer= p0 };

            value.M_IgnoreReversedGraphics                  = GetBool(new IntPtr(p + 0x028)); // 0245A35E7838 0x28 M_IgnoreReversedGraphics    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_BlockingObjects                         = (BlockingObjects)GetInt32(new IntPtr(p + 0x02C)); // 0245A35E7858 0x2C M_BlockingObjects           ( 00018651D470 ModelEnumType BlockingObjects BlockingObjects BlockingObjects Int32 )
            value.M_BlockingMask                            = (LayerMask)GetInt32(new IntPtr(p + 0x030)); // 0245A35E7878 0x30 M_BlockingMask              ( 00018650B3C0 ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.M_Canvas                                  = GetObject<Canvas>(new IntPtr(p + 0x038), ReversePrism.DataModels.Canvas.FromPointer); // 0245A35E7898 0x38 M_Canvas                    ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.M_RaycastResults                          = GetObjectList<Graphic>(new IntPtr(p + 0x040), ReversePrism.DataModels.Graphic.FromPointer); // 0245A35E78B8 0x40 M_RaycastResults            ( 000185CDF288 ModelClassListType List`1<Graphic> List`1<Graphic> List<Graphic> Pointer )

            return value;
        }
    }
}
