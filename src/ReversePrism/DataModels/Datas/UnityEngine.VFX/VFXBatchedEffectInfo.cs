using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VfxAsset                                 ModelClassType VisualEffectAsset VisualEffectAsset VisualEffectAsset Pointer
    // 018 ActiveBatchCount                         ModelPrimitiveType uint uint uint UInt32
    // 01C InactiveBatchCount                       ModelPrimitiveType uint uint uint UInt32
    // 020 ActiveInstanceCount                      ModelPrimitiveType uint uint uint UInt32
    // 024 UnbatchedInstanceCount                   ModelPrimitiveType uint uint uint UInt32
    // 028 TotalInstanceCapacity                    ModelPrimitiveType uint uint uint UInt32
    // 02C MaxInstancePerBatchCapacity              ModelPrimitiveType uint uint uint UInt32
    // 030 TotalGPUSizeInBytes                      ModelPrimitiveType ulong ulong ulong UInt64
    // 038 TotalCPUSizeInBytes                      ModelPrimitiveType ulong ulong ulong UInt64
    public partial class VFXBatchedEffectInfo : DataModel
    {
        public VisualEffectAsset?                       VfxAsset                                { get; set; }
        public uint                                     ActiveBatchCount                        { get; set; }
        public uint                                     InactiveBatchCount                      { get; set; }
        public uint                                     ActiveInstanceCount                     { get; set; }
        public uint                                     UnbatchedInstanceCount                  { get; set; }
        public uint                                     TotalInstanceCapacity                   { get; set; }
        public uint                                     MaxInstancePerBatchCapacity             { get; set; }
        public ulong                                    TotalGPUSizeInBytes                     { get; set; }
        public ulong                                    TotalCPUSizeInBytes                     { get; set; }

        public static VFXBatchedEffectInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VFXBatchedEffectInfo() { Pointer= p0 };

            value.VfxAsset                                  = GetObject<VisualEffectAsset>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualEffectAsset.FromPointer); // 0x10 VfxAsset                    ( ModelClassType VisualEffectAsset VisualEffectAsset VisualEffectAsset Pointer )
            value.ActiveBatchCount                          = GetUInt32(new IntPtr(p + 0x018)); // 0x18 ActiveBatchCount            ( ModelPrimitiveType uint uint uint UInt32 )
            value.InactiveBatchCount                        = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C InactiveBatchCount          ( ModelPrimitiveType uint uint uint UInt32 )
            value.ActiveInstanceCount                       = GetUInt32(new IntPtr(p + 0x020)); // 0x20 ActiveInstanceCount         ( ModelPrimitiveType uint uint uint UInt32 )
            value.UnbatchedInstanceCount                    = GetUInt32(new IntPtr(p + 0x024)); // 0x24 UnbatchedInstanceCount      ( ModelPrimitiveType uint uint uint UInt32 )
            value.TotalInstanceCapacity                     = GetUInt32(new IntPtr(p + 0x028)); // 0x28 TotalInstanceCapacity       ( ModelPrimitiveType uint uint uint UInt32 )
            value.MaxInstancePerBatchCapacity               = GetUInt32(new IntPtr(p + 0x02C)); // 0x2C MaxInstancePerBatchCapacity ( ModelPrimitiveType uint uint uint UInt32 )
            value.TotalGPUSizeInBytes                       = GetUInt64(new IntPtr(p + 0x030)); // 0x30 TotalGPUSizeInBytes         ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.TotalCPUSizeInBytes                       = GetUInt64(new IntPtr(p + 0x038)); // 0x38 TotalCPUSizeInBytes         ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
