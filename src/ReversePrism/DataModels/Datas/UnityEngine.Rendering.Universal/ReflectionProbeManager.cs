using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Resolution                             ModelEnumType int2 int2 int2 Int32
    // 018 M_AtlasTexture0                          ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 020 M_AtlasTexture1                          ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 028 M_AtlasAllocator                         ModelEnumType BuddyAllocator BuddyAllocator BuddyAllocator Int32
    // 050 m_Cache                                  Dictionary`2<int, CachedProbe> IL2CPP_TYPE_GENERICINST
    // 058 m_WarningCache                           Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 060 M_NeedsUpdate                            ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 068 M_NeedsRemove                            ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 070 M_BoxMax                                 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 078 M_BoxMin                                 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 080 M_ProbePosition                          ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 088 M_MipScaleOffset                         ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 000 k_MaxMipCount                            int IL2CPP_TYPE_I4
    public partial class ReflectionProbeManager : DataModel
    {
        public int2                                     M_Resolution                            { get; set; }
        public RenderTexture?                           M_AtlasTexture0                         { get; set; }
        public RenderTexture?                           M_AtlasTexture1                         { get; set; }
        public BuddyAllocator                           M_AtlasAllocator                        { get; set; }
        public List<int>?                               M_NeedsUpdate                           { get; set; }
        public List<int>?                               M_NeedsRemove                           { get; set; }
        public List<Vector4>?                           M_BoxMax                                { get; set; }
        public List<Vector4>?                           M_BoxMin                                { get; set; }
        public List<Vector4>?                           M_ProbePosition                         { get; set; }
        public List<Vector4>?                           M_MipScaleOffset                        { get; set; }

        public static ReflectionProbeManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectionProbeManager() { Pointer= p0 };

            value.M_Resolution                              = (int2)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Resolution                ( ModelEnumType int2 int2 int2 Int32 )
            value.M_AtlasTexture0                           = GetObject<RenderTexture>(new IntPtr(p + 0x018), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x18 M_AtlasTexture0             ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.M_AtlasTexture1                           = GetObject<RenderTexture>(new IntPtr(p + 0x020), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x20 M_AtlasTexture1             ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.M_AtlasAllocator                          = (BuddyAllocator)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_AtlasAllocator            ( ModelEnumType BuddyAllocator BuddyAllocator BuddyAllocator Int32 )
            value.M_NeedsUpdate                             = GetInt32List(new IntPtr(p + 0x060)); // 0x60 M_NeedsUpdate               ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.M_NeedsRemove                             = GetInt32List(new IntPtr(p + 0x068)); // 0x68 M_NeedsRemove               ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.M_BoxMax                                  = GetEnumList<Vector4>(new IntPtr(p + 0x070)); // 0x70 M_BoxMax                    ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_BoxMin                                  = GetEnumList<Vector4>(new IntPtr(p + 0x078)); // 0x78 M_BoxMin                    ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_ProbePosition                           = GetEnumList<Vector4>(new IntPtr(p + 0x080)); // 0x80 M_ProbePosition             ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_MipScaleOffset                          = GetEnumList<Vector4>(new IntPtr(p + 0x088)); // 0x88 M_MipScaleOffset            ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )

            return value;
        }
    }
}
