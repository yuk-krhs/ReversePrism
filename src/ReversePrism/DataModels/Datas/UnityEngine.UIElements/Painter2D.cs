using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Ctx                                    ModelClassType MeshGenerationContext MeshGenerationContext MeshGenerationContext Pointer
    // 018 M_DetachedAllocator                      ModelClassType DetachedAllocator DetachedAllocator DetachedAllocator Pointer
    // 020 M_Handle                                 ModelEnumType SafeHandleAccess SafeHandleAccess SafeHandleAccess Int32
    // 028 M_Disposed                               ModelPrimitiveType bool bool bool Bool
    // 000 <isPainterActive>k__BackingField         bool IL2CPP_TYPE_BOOLEAN
    // 004 s_MaxArcRadius                           float IL2CPP_TYPE_R4
    // 008 s_StrokeMarker                           ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 S_FillMarker                             ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    public partial class Painter2D : DataModel
    {
        public MeshGenerationContext?                   M_Ctx                                   { get; set; }
        public DetachedAllocator?                       M_DetachedAllocator                     { get; set; }
        public SafeHandleAccess                         M_Handle                                { get; set; }
        public bool                                     M_Disposed                              { get; set; }
        public ProfilerMarker                           S_FillMarker                            { get; set; }

        public static Painter2D? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Painter2D() { Pointer= p0 };

            value.M_Ctx                                     = GetObject<MeshGenerationContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.MeshGenerationContext.FromPointer); // 0x10 M_Ctx                       ( ModelClassType MeshGenerationContext MeshGenerationContext MeshGenerationContext Pointer )
            value.M_DetachedAllocator                       = GetObject<DetachedAllocator>(new IntPtr(p + 0x018), ReversePrism.DataModels.DetachedAllocator.FromPointer); // 0x18 M_DetachedAllocator         ( ModelClassType DetachedAllocator DetachedAllocator DetachedAllocator Pointer )
            value.M_Handle                                  = (SafeHandleAccess)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_Handle                    ( ModelEnumType SafeHandleAccess SafeHandleAccess SafeHandleAccess Int32 )
            value.M_Disposed                                = GetBool(new IntPtr(p + 0x028)); // 0x28 M_Disposed                  ( ModelPrimitiveType bool bool bool Bool )
            value.S_FillMarker                              = (ProfilerMarker)GetInt32(new IntPtr(p + 0x010)); // 0x10 S_FillMarker                ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )

            return value;
        }
    }
}
