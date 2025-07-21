using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sampler                                  ModelClassType CustomSampler CustomSampler CustomSampler Pointer
    // 018 InlineSampler                            ModelClassType CustomSampler CustomSampler CustomSampler Pointer
    // 020 Name                                     ModelPrimitiveType string string string String
    // 028 M_Recorder                               ModelClassType Recorder Recorder Recorder Pointer
    // 030 M_InlineRecorder                         ModelClassType Recorder Recorder Recorder Pointer
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

            value.Sampler                                   = GetObject<CustomSampler>(new IntPtr(p + 0x010), ReversePrism.DataModels.CustomSampler.FromPointer); // 0x10 Sampler                     ( ModelClassType CustomSampler CustomSampler CustomSampler Pointer )
            value.InlineSampler                             = GetObject<CustomSampler>(new IntPtr(p + 0x018), ReversePrism.DataModels.CustomSampler.FromPointer); // 0x18 InlineSampler               ( ModelClassType CustomSampler CustomSampler CustomSampler Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.M_Recorder                                = GetObject<Recorder>(new IntPtr(p + 0x028), ReversePrism.DataModels.Recorder.FromPointer); // 0x28 M_Recorder                  ( ModelClassType Recorder Recorder Recorder Pointer )
            value.M_InlineRecorder                          = GetObject<Recorder>(new IntPtr(p + 0x030), ReversePrism.DataModels.Recorder.FromPointer); // 0x30 M_InlineRecorder            ( ModelClassType Recorder Recorder Recorder Pointer )

            return value;
        }
    }
}
