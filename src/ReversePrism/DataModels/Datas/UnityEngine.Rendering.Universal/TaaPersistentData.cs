using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 formatList                               GraphicsFormat[] IL2CPP_TYPE_SZARRAY
    // 010 M_RtDesc                                 ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
    // 048 M_AccumulationTexture                    ModelClassType RTHandle RTHandle RTHandle Pointer
    // 050 M_AccumulationTexture2                   ModelClassType RTHandle RTHandle RTHandle Pointer
    // 058 M_LastAccumUpdateFrameIndex              ModelPrimitiveType int int int Int32
    // 05C M_LastAccumUpdateFrameIndex2             ModelPrimitiveType int int int Int32
    public partial class TaaPersistentData : DataModel
    {
        public RenderTextureDescriptor                  M_RtDesc                                { get; set; }
        public RTHandle?                                M_AccumulationTexture                   { get; set; }
        public RTHandle?                                M_AccumulationTexture2                  { get; set; }
        public int                                      M_LastAccumUpdateFrameIndex             { get; set; }
        public int                                      M_LastAccumUpdateFrameIndex2            { get; set; }

        public static TaaPersistentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TaaPersistentData() { Pointer= p0 };

            value.M_RtDesc                                  = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_RtDesc                    ( ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )
            value.M_AccumulationTexture                     = GetObject<RTHandle>(new IntPtr(p + 0x048), ReversePrism.DataModels.RTHandle.FromPointer); // 0x48 M_AccumulationTexture       ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_AccumulationTexture2                    = GetObject<RTHandle>(new IntPtr(p + 0x050), ReversePrism.DataModels.RTHandle.FromPointer); // 0x50 M_AccumulationTexture2      ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_LastAccumUpdateFrameIndex               = GetInt32(new IntPtr(p + 0x058)); // 0x58 M_LastAccumUpdateFrameIndex ( ModelPrimitiveType int int int Int32 )
            value.M_LastAccumUpdateFrameIndex2              = GetInt32(new IntPtr(p + 0x05C)); // 0x5C M_LastAccumUpdateFrameIndex2 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
