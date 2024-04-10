using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sampler                                  00018666CA30 ModelClassType CustomSampler CustomSampler CustomSampler Pointer
    // 018 InlineSampler                            00018666CA30 ModelClassType CustomSampler CustomSampler CustomSampler Pointer
    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    // 028 M_Recorder                               00018662BD80 ModelClassType Recorder Recorder Recorder Pointer
    // 030 M_InlineRecorder                         00018662BD80 ModelClassType Recorder Recorder Recorder Pointer
    public partial class ProfilingSampler : DataModel
    {
        public CustomSampler?                           Sampler                                 { get; set; }
        public CustomSampler?                           InlineSampler                           { get; set; }
        public string                                   Name                                    { get; set; }
        public Recorder?                                M_Recorder                              { get; set; }
        public Recorder?                                M_InlineRecorder                        { get; set; }

        public static ProfilingSampler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilingSampler() { Pointer= p0 };

            value.Sampler                                   = GetObject<CustomSampler>(new IntPtr(p + 0x010), ReversePrism.DataModels.CustomSampler.FromPointer); // 0245A35E7178 0x10 Sampler                     ( 00018666CA30 ModelClassType CustomSampler CustomSampler CustomSampler Pointer )
            value.InlineSampler                             = GetObject<CustomSampler>(new IntPtr(p + 0x018), ReversePrism.DataModels.CustomSampler.FromPointer); // 0245A35E7198 0x18 InlineSampler               ( 00018666CA30 ModelClassType CustomSampler CustomSampler CustomSampler Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0245A35E71B8 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Recorder                                = GetObject<Recorder>(new IntPtr(p + 0x028), ReversePrism.DataModels.Recorder.FromPointer); // 0245A35E71D8 0x28 M_Recorder                  ( 00018662BD80 ModelClassType Recorder Recorder Recorder Pointer )
            value.M_InlineRecorder                          = GetObject<Recorder>(new IntPtr(p + 0x030), ReversePrism.DataModels.Recorder.FromPointer); // 0245A35E71F8 0x30 M_InlineRecorder            ( 00018662BD80 ModelClassType Recorder Recorder Recorder Pointer )

            return value;
        }
    }
}
