using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 Volumes                                  ModelClassListType List`1<PostProcessVolume> List`1<PostProcessVolume> List<PostProcessVolume> Pointer
    // 0E8 IsValid                                  ModelPrimitiveType bool bool bool Bool
    public partial class SplitScreenPostProcessingApplyPass : DataModel
    {
        public List<PostProcessVolume>?                 Volumes                                 { get; set; }
        public bool                                     IsValid                                 { get; set; }

        public static SplitScreenPostProcessingApplyPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SplitScreenPostProcessingApplyPass() { Pointer= p0 };

            value.Volumes                                   = GetObjectList<PostProcessVolume>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.PostProcessVolume.FromPointer); // 0xE0 Volumes                     ( ModelClassListType List`1<PostProcessVolume> List`1<PostProcessVolume> List<PostProcessVolume> Pointer )
            value.IsValid                                   = GetBool(new IntPtr(p + 0x0E8)); // 0xE8 IsValid                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
