using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_defaultDistances                       000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 048 M_scaledDistances                        000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 050 Init                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 M_cachedCamera                           0001865A1C90 ModelClassType Camera Camera Camera Pointer
    public partial class AdaptiveLayerCulling
    {
        public List<float>?                             M_defaultDistances                      { get; set; }
        public List<float>?                             M_scaledDistances                       { get; set; }
        public bool                                     Init                                    { get; set; }
        public Camera?                                  M_cachedCamera                          { get; set; }

        public static AdaptiveLayerCulling? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveLayerCulling();

            value.M_defaultDistances                        = GetSingleList(new IntPtr(p + 0x040)); // 0270DB689A38 0x40 M_defaultDistances          ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.M_scaledDistances                         = GetSingleList(new IntPtr(p + 0x048)); // 0270DB689A58 0x48 M_scaledDistances           ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Init                                      = GetBool(new IntPtr(p + 0x050)); // 0270DB689A78 0x50 Init                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_cachedCamera                            = GetObject<Camera>(new IntPtr(p + 0x058), ReversePrism.DataModels.Camera.FromPointer); // 0270DB689A98 0x58 M_cachedCamera              ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )

            return value;
        }
    }
}
