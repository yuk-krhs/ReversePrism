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
    // 010 M_Data                                   ModelClassListType List`1<LensFlareCompInfo> List`1<LensFlareCompInfo> List<LensFlareCompInfo> Pointer
    // 018 M_AvailableIndicies                      ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 020 MaxLensFlareWithOcclusion                ModelPrimitiveType int int int Int32
    // 024 MaxLensFlareWithOcclusionTemporalSample  ModelPrimitiveType int int int Int32
    // 028 MergeNeeded                              ModelPrimitiveType int int int Int32
    // 030 OcclusionRT                              ModelClassType RTHandle RTHandle RTHandle Pointer
    // 038 FrameIdx                                 ModelPrimitiveType int int int Int32
    // 03C S_SupportsLensFlareTexFormat             ModelPrimitiveType bool bool bool Bool
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

            value.M_Data                                    = GetObjectList<LensFlareCompInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.LensFlareCompInfo.FromPointer); // 0x10 M_Data                      ( ModelClassListType List`1<LensFlareCompInfo> List`1<LensFlareCompInfo> List<LensFlareCompInfo> Pointer )
            value.M_AvailableIndicies                       = GetInt32List(new IntPtr(p + 0x018)); // 0x18 M_AvailableIndicies         ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.MaxLensFlareWithOcclusion                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 MaxLensFlareWithOcclusion   ( ModelPrimitiveType int int int Int32 )
            value.MaxLensFlareWithOcclusionTemporalSample   = GetInt32(new IntPtr(p + 0x024)); // 0x24 MaxLensFlareWithOcclusionTemporalSample ( ModelPrimitiveType int int int Int32 )
            value.MergeNeeded                               = GetInt32(new IntPtr(p + 0x028)); // 0x28 MergeNeeded                 ( ModelPrimitiveType int int int Int32 )
            value.OcclusionRT                               = GetObject<RTHandle>(new IntPtr(p + 0x030), ReversePrism.DataModels.RTHandle.FromPointer); // 0x30 OcclusionRT                 ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.FrameIdx                                  = GetInt32(new IntPtr(p + 0x038)); // 0x38 FrameIdx                    ( ModelPrimitiveType int int int Int32 )
            value.S_SupportsLensFlareTexFormat              = GetBool(new IntPtr(p + 0x03C)); // 0x3C S_SupportsLensFlareTexFormat ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
