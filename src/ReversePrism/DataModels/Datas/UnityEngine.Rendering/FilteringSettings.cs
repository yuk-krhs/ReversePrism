using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_RenderQueueRange                       000186659330 ModelEnumType RenderQueueRange RenderQueueRange RenderQueueRange Int32
    // 018 M_LayerMask                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C M_RenderingLayerMask                     000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 020 M_ExcludeMotionVectorObjects             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 M_SortingLayerRange                      000186534D60 ModelEnumType SortingLayerRange SortingLayerRange SortingLayerRange Int32
    public partial class FilteringSettings
    {
        public RenderQueueRange                         M_RenderQueueRange                      { get; set; }
        public int                                      M_LayerMask                             { get; set; }
        public uint                                     M_RenderingLayerMask                    { get; set; }
        public int                                      M_ExcludeMotionVectorObjects            { get; set; }
        public SortingLayerRange                        M_SortingLayerRange                     { get; set; }

        public static FilteringSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FilteringSettings();

            value.M_RenderQueueRange                        = (RenderQueueRange)GetInt32(new IntPtr(p + 0x010)); // 0270D0ABF258 0x10 M_RenderQueueRange          ( 000186659330 ModelEnumType RenderQueueRange RenderQueueRange RenderQueueRange Int32 )
            value.M_LayerMask                               = GetInt32(new IntPtr(p + 0x018)); // 0270D0ABF278 0x18 M_LayerMask                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_RenderingLayerMask                      = GetUInt32(new IntPtr(p + 0x01C)); // 0270D0ABF298 0x1C M_RenderingLayerMask        ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_ExcludeMotionVectorObjects              = GetInt32(new IntPtr(p + 0x020)); // 0270D0ABF2B8 0x20 M_ExcludeMotionVectorObjects ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_SortingLayerRange                       = (SortingLayerRange)GetInt32(new IntPtr(p + 0x024)); // 0270D0ABF2D8 0x24 M_SortingLayerRange         ( 000186534D60 ModelEnumType SortingLayerRange SortingLayerRange SortingLayerRange Int32 )

            return value;
        }
    }
}
