using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 M_RaycastResultsCache                    000185D2EB98 ModelEnumListType List`1<RaycastHitData> List`1<RaycastHitData> List<RaycastHitData> Pointer
    // 000 s_Instances                              InlinedArray`1<TrackedDeviceRaycaster> IL2CPP_TYPE_GENERICINST
    // 018 S_SortedGraphics                         000185D2EB28 ModelEnumListType List`1<RaycastHitData> List`1<RaycastHitData> List<RaycastHitData> Pointer
    // 030 M_IgnoreReversedGraphics                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 M_CheckFor2DOcclusion                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 032 M_CheckFor3DOcclusion                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 M_MaxDistance                            0001866656B0 ModelPrimitiveType float float float Single
    // 038 M_BlockingMask                           00018650B160 ModelEnumType LayerMask LayerMask LayerMask Int32
    // 040 M_Canvas                                 000186540820 ModelClassType Canvas Canvas Canvas Pointer
    public partial class TrackedDeviceRaycaster : DataModel
    {
        public List<RaycastHitData>?                    M_RaycastResultsCache                   { get; set; }
        public List<RaycastHitData>?                    S_SortedGraphics                        { get; set; }
        public bool                                     M_IgnoreReversedGraphics                { get; set; }
        public bool                                     M_CheckFor2DOcclusion                   { get; set; }
        public bool                                     M_CheckFor3DOcclusion                   { get; set; }
        public float                                    M_MaxDistance                           { get; set; }
        public LayerMask                                M_BlockingMask                          { get; set; }
        public Canvas?                                  M_Canvas                                { get; set; }

        public static TrackedDeviceRaycaster? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TrackedDeviceRaycaster() { Pointer= p0 };

            value.M_RaycastResultsCache                     = GetEnumList<RaycastHitData>(new IntPtr(p + 0x028)); // 02466780B798 0x28 M_RaycastResultsCache       ( 000185D2EB98 ModelEnumListType List`1<RaycastHitData> List`1<RaycastHitData> List<RaycastHitData> Pointer )
            value.S_SortedGraphics                          = GetEnumList<RaycastHitData>(new IntPtr(p + 0x018)); // 02466780B7D8 0x18 S_SortedGraphics            ( 000185D2EB28 ModelEnumListType List`1<RaycastHitData> List`1<RaycastHitData> List<RaycastHitData> Pointer )
            value.M_IgnoreReversedGraphics                  = GetBool(new IntPtr(p + 0x030)); // 02466780B7F8 0x30 M_IgnoreReversedGraphics    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CheckFor2DOcclusion                     = GetBool(new IntPtr(p + 0x031)); // 02466780B818 0x31 M_CheckFor2DOcclusion       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CheckFor3DOcclusion                     = GetBool(new IntPtr(p + 0x032)); // 02466780B838 0x32 M_CheckFor3DOcclusion       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_MaxDistance                             = GetSingle(new IntPtr(p + 0x034)); // 02466780B858 0x34 M_MaxDistance               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_BlockingMask                            = (LayerMask)GetInt32(new IntPtr(p + 0x038)); // 02466780B878 0x38 M_BlockingMask              ( 00018650B160 ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.M_Canvas                                  = GetObject<Canvas>(new IntPtr(p + 0x040), ReversePrism.DataModels.Canvas.FromPointer); // 02466780B898 0x40 M_Canvas                    ( 000186540820 ModelClassType Canvas Canvas Canvas Pointer )

            return value;
        }
    }
}
