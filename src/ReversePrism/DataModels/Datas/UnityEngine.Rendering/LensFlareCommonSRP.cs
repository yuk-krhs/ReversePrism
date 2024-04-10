using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_Instance                               LensFlareCommonSRP IL2CPP_TYPE_CLASS
    // 008 m_Padlock                                <object> IL2CPP_TYPE_OBJECT
    // 010 M_Data                                   000185D26358 ModelClassListType List`1<LensFlareCompInfo> List`1<LensFlareCompInfo> List<LensFlareCompInfo> Pointer
    // 018 M_AvailableIndicies                      000185CED118 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 020 MaxLensFlareWithOcclusion                0001865F4040 ModelPrimitiveType int int int Int32
    // 024 MaxLensFlareWithOcclusionTemporalSample  0001865F4040 ModelPrimitiveType int int int Int32
    // 028 MergeNeeded                              0001865F4040 ModelPrimitiveType int int int Int32
    // 030 OcclusionRT                              00018664BA80 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 038 FrameIdx                                 0001865F38E0 ModelPrimitiveType int int int Int32
    // 03C S_SupportsLensFlareTexFormat             000186596D40 ModelPrimitiveType bool bool bool Bool
    public partial class LensFlareCommonSRP : DataModel
    {
        public List<LensFlareCompInfo>?                 M_Data                                  { get; set; }
        public List<int>?                               M_AvailableIndicies                     { get; set; }
        public int                                      MaxLensFlareWithOcclusion               { get; set; }
        public int                                      MaxLensFlareWithOcclusionTemporalSample { get; set; }
        public int                                      MergeNeeded                             { get; set; }
        public RTHandle?                                OcclusionRT                             { get; set; }
        public int                                      FrameIdx                                { get; set; }
        public bool                                     S_SupportsLensFlareTexFormat            { get; set; }

        public static LensFlareCommonSRP? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LensFlareCommonSRP() { Pointer= p0 };

            value.M_Data                                    = GetObjectList<LensFlareCompInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.LensFlareCompInfo.FromPointer); // 0246692B6E08 0x10 M_Data                      ( 000185D26358 ModelClassListType List`1<LensFlareCompInfo> List`1<LensFlareCompInfo> List<LensFlareCompInfo> Pointer )
            value.M_AvailableIndicies                       = GetInt32List(new IntPtr(p + 0x018)); // 0246692B6E28 0x18 M_AvailableIndicies         ( 000185CED118 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.MaxLensFlareWithOcclusion                 = GetInt32(new IntPtr(p + 0x020)); // 0246692B6E48 0x20 MaxLensFlareWithOcclusion   ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.MaxLensFlareWithOcclusionTemporalSample   = GetInt32(new IntPtr(p + 0x024)); // 0246692B6E68 0x24 MaxLensFlareWithOcclusionTemporalSample ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.MergeNeeded                               = GetInt32(new IntPtr(p + 0x028)); // 0246692B6E88 0x28 MergeNeeded                 ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.OcclusionRT                               = GetObject<RTHandle>(new IntPtr(p + 0x030), ReversePrism.DataModels.RTHandle.FromPointer); // 0246692B6EA8 0x30 OcclusionRT                 ( 00018664BA80 ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.FrameIdx                                  = GetInt32(new IntPtr(p + 0x038)); // 0246692B6EC8 0x38 FrameIdx                    ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_SupportsLensFlareTexFormat              = GetBool(new IntPtr(p + 0x03C)); // 0246692B6EE8 0x3C S_SupportsLensFlareTexFormat ( 000186596D40 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
