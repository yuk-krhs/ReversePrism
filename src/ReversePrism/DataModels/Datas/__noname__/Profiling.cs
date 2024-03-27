using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BeginContext                             ProfilingSampler IL2CPP_TYPE_CLASS
    // 008 EndContext                               ProfilingSampler IL2CPP_TYPE_CLASS
    // 010 DrawGizmos                               0001865CD840 ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 018 PrismRenderPipeline                      0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer
    // 020 BeginCamera                              0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer
    // 028 EndCamera                                0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer
    // 030 Begin3D                                  0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer
    // 038 DrawGrabPass                             0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer
    // 040 DrawReservedBufferPass                   0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer
    // 048 RestoreCamera                            0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer
    // 050 End3D                                    0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer
    // 058 OnRenderObject                           0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer
    // 060 HashSamplerCache                         Dictionary`2<int, ProfileSampler> IL2CPP_TYPE_GENERICINST
    public partial class Profiling
    {
        public ProfilingSampler?                        DrawGizmos                              { get; set; }
        public ProfileSampler?                          PrismRenderPipeline                     { get; set; }
        public ProfileSampler?                          BeginCamera                             { get; set; }
        public ProfileSampler?                          EndCamera                               { get; set; }
        public ProfileSampler?                          Begin3D                                 { get; set; }
        public ProfileSampler?                          DrawGrabPass                            { get; set; }
        public ProfileSampler?                          DrawReservedBufferPass                  { get; set; }
        public ProfileSampler?                          RestoreCamera                           { get; set; }
        public ProfileSampler?                          End3D                                   { get; set; }
        public ProfileSampler?                          OnRenderObject                          { get; set; }

        public static Profiling? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Profiling();

            value.DrawGizmos                                = GetObject<ProfilingSampler>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 027003FEDE50 0x10 DrawGizmos                  ( 0001865CD840 ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.PrismRenderPipeline                       = GetObject<ProfileSampler>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProfileSampler.FromPointer); // 027003FEDE70 0x18 PrismRenderPipeline         ( 0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer )
            value.BeginCamera                               = GetObject<ProfileSampler>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileSampler.FromPointer); // 027003FEDE90 0x20 BeginCamera                 ( 0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer )
            value.EndCamera                                 = GetObject<ProfileSampler>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProfileSampler.FromPointer); // 027003FEDEB0 0x28 EndCamera                   ( 0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer )
            value.Begin3D                                   = GetObject<ProfileSampler>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProfileSampler.FromPointer); // 027003FEDED0 0x30 Begin3D                     ( 0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer )
            value.DrawGrabPass                              = GetObject<ProfileSampler>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfileSampler.FromPointer); // 027003FEDEF0 0x38 DrawGrabPass                ( 0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer )
            value.DrawReservedBufferPass                    = GetObject<ProfileSampler>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfileSampler.FromPointer); // 027003FEDF10 0x40 DrawReservedBufferPass      ( 0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer )
            value.RestoreCamera                             = GetObject<ProfileSampler>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProfileSampler.FromPointer); // 027003FEDF30 0x48 RestoreCamera               ( 0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer )
            value.End3D                                     = GetObject<ProfileSampler>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProfileSampler.FromPointer); // 027003FEDF50 0x50 End3D                       ( 0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer )
            value.OnRenderObject                            = GetObject<ProfileSampler>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProfileSampler.FromPointer); // 027003FEDF70 0x58 OnRenderObject              ( 0001865C15E0 ModelClassType ProfileSampler ProfileSampler ProfileSampler Pointer )

            return value;
        }
    }
}
