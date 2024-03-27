using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 PipelineTypes                            000185B83050 ModelClassListType Type[] Type[] List<Type> Pointer
    public partial class VolumeComponentMenuForRenderPipeline
    {
        public List<Type>?                              PipelineTypes                           { get; set; }

        public static VolumeComponentMenuForRenderPipeline? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VolumeComponentMenuForRenderPipeline();

            value.PipelineTypes                             = GetObjectList<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0270D92D27F8 0x18 PipelineTypes               ( 000185B83050 ModelClassListType Type[] Type[] List<Type> Pointer )

            return value;
        }
    }
}
