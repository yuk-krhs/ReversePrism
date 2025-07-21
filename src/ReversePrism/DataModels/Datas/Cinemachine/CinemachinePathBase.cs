using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Resolution                             ModelPrimitiveType int int int Int32
    // 028 M_Appearance                             ModelClassType Appearance Appearance Appearance Pointer
    // 030 M_DistanceToPos                          ModelPrimitiveListType float[] float[] List<float> Pointer
    // 038 M_PosToDistance                          ModelPrimitiveListType float[] float[] List<float> Pointer
    // 040 M_CachedSampleSteps                      ModelPrimitiveType int int int Int32
    // 044 M_PathLength                             ModelPrimitiveType float float float Single
    // 048 M_cachedPosStepSize                      ModelPrimitiveType float float float Single
    // 04C M_cachedDistanceStepSize                 ModelPrimitiveType float float float Single
    public partial class CinemachinePathBase : DataModel
    {
        public int                                      M_Resolution                            { get; set; }
        public Appearance?                              M_Appearance                            { get; set; }
        public List<float>?                             M_DistanceToPos                         { get; set; }
        public List<float>?                             M_PosToDistance                         { get; set; }
        public int                                      M_CachedSampleSteps                     { get; set; }
        public float                                    M_PathLength                            { get; set; }
        public float                                    M_cachedPosStepSize                     { get; set; }
        public float                                    M_cachedDistanceStepSize                { get; set; }

        public static CinemachinePathBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachinePathBase() { Pointer= p0 };

            value.M_Resolution                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_Resolution                ( ModelPrimitiveType int int int Int32 )
            value.M_Appearance                              = GetObject<Appearance>(new IntPtr(p + 0x028), ReversePrism.DataModels.Appearance.FromPointer); // 0x28 M_Appearance                ( ModelClassType Appearance Appearance Appearance Pointer )
            value.M_DistanceToPos                           = GetSingleList(new IntPtr(p + 0x030)); // 0x30 M_DistanceToPos             ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.M_PosToDistance                           = GetSingleList(new IntPtr(p + 0x038)); // 0x38 M_PosToDistance             ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.M_CachedSampleSteps                       = GetInt32(new IntPtr(p + 0x040)); // 0x40 M_CachedSampleSteps         ( ModelPrimitiveType int int int Int32 )
            value.M_PathLength                              = GetSingle(new IntPtr(p + 0x044)); // 0x44 M_PathLength                ( ModelPrimitiveType float float float Single )
            value.M_cachedPosStepSize                       = GetSingle(new IntPtr(p + 0x048)); // 0x48 M_cachedPosStepSize         ( ModelPrimitiveType float float float Single )
            value.M_cachedDistanceStepSize                  = GetSingle(new IntPtr(p + 0x04C)); // 0x4C M_cachedDistanceStepSize    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
