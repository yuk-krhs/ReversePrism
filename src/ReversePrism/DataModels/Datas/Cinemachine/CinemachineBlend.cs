using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CamA                                     ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer
    // 018 CamB                                     ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer
    // 020 BlendCurve                               ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 028 TimeInBlend                              ModelPrimitiveType float float float Single
    // 02C Duration                                 ModelPrimitiveType float float float Single
    public partial class CinemachineBlend : DataModel
    {
        public ICinemachineCamera?                      CamA                                    { get; set; }
        public ICinemachineCamera?                      CamB                                    { get; set; }
        public AnimationCurve?                          BlendCurve                              { get; set; }
        public float                                    TimeInBlend                             { get; set; }
        public float                                    Duration                                { get; set; }

        public static CinemachineBlend? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineBlend() { Pointer= p0 };

            value.CamA                                      = GetObject<ICinemachineCamera>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICinemachineCamera.FromPointer); // 0x10 CamA                        ( ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer )
            value.CamB                                      = GetObject<ICinemachineCamera>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICinemachineCamera.FromPointer); // 0x18 CamB                        ( ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer )
            value.BlendCurve                                = GetObject<AnimationCurve>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x20 BlendCurve                  ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.TimeInBlend                               = GetSingle(new IntPtr(p + 0x028)); // 0x28 TimeInBlend                 ( ModelPrimitiveType float float float Single )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x02C)); // 0x2C Duration                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
