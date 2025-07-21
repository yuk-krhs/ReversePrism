using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 018 Blend                                    ModelClassType CinemachineBlend CinemachineBlend CinemachineBlend Pointer
    // 020 WorkingBlend                             ModelClassType CinemachineBlend CinemachineBlend CinemachineBlend Pointer
    // 028 WorkingBlendSource                       ModelClassType BlendSourceVirtualCamera BlendSourceVirtualCamera BlendSourceVirtualCamera Pointer
    // 030 DeltaTimeOverride                        ModelPrimitiveType float float float Single
    // 034 BlendStartPosition                       ModelPrimitiveType float float float Single
    public partial class BrainFrame : DataModel
    {
        public int                                      Id                                      { get; set; }
        public CinemachineBlend?                        Blend                                   { get; set; }
        public CinemachineBlend?                        WorkingBlend                            { get; set; }
        public BlendSourceVirtualCamera?                WorkingBlendSource                      { get; set; }
        public float                                    DeltaTimeOverride                       { get; set; }
        public float                                    BlendStartPosition                      { get; set; }

        public static BrainFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BrainFrame() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.Blend                                     = GetObject<CinemachineBlend>(new IntPtr(p + 0x018), ReversePrism.DataModels.CinemachineBlend.FromPointer); // 0x18 Blend                       ( ModelClassType CinemachineBlend CinemachineBlend CinemachineBlend Pointer )
            value.WorkingBlend                              = GetObject<CinemachineBlend>(new IntPtr(p + 0x020), ReversePrism.DataModels.CinemachineBlend.FromPointer); // 0x20 WorkingBlend                ( ModelClassType CinemachineBlend CinemachineBlend CinemachineBlend Pointer )
            value.WorkingBlendSource                        = GetObject<BlendSourceVirtualCamera>(new IntPtr(p + 0x028), ReversePrism.DataModels.BlendSourceVirtualCamera.FromPointer); // 0x28 WorkingBlendSource          ( ModelClassType BlendSourceVirtualCamera BlendSourceVirtualCamera BlendSourceVirtualCamera Pointer )
            value.DeltaTimeOverride                         = GetSingle(new IntPtr(p + 0x030)); // 0x30 DeltaTimeOverride           ( ModelPrimitiveType float float float Single )
            value.BlendStartPosition                        = GetSingle(new IntPtr(p + 0x034)); // 0x34 BlendStartPosition          ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
