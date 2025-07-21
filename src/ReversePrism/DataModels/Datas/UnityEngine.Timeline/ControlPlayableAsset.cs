using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_MaxRandInt                             int IL2CPP_TYPE_I4
    // 000 k_EmptyDirectorsList                     List`1<PlayableDirector> IL2CPP_TYPE_GENERICINST
    // 008 k_EmptyParticlesList                     List`1<ParticleSystem> IL2CPP_TYPE_GENERICINST
    // 010 s_SubEmitterCollector                    HashSet`1<ParticleSystem> IL2CPP_TYPE_GENERICINST
    // 018 sourceGameObject                         ExposedReference`1<GameObject> IL2CPP_TYPE_GENERICINST
    // 028 PrefabGameObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 030 UpdateParticle                           ModelPrimitiveType bool bool bool Bool
    // 034 ParticleRandomSeed                       ModelPrimitiveType uint uint uint UInt32
    // 038 UpdateDirector                           ModelPrimitiveType bool bool bool Bool
    // 039 UpdateITimeControl                       ModelPrimitiveType bool bool bool Bool
    // 03A SearchHierarchy                          ModelPrimitiveType bool bool bool Bool
    // 03B Active                                   ModelPrimitiveType bool bool bool Bool
    // 03C PostPlayback                             ModelEnumType PostPlaybackState PostPlaybackState PostPlaybackState Int32
    // 040 M_ControlDirectorAsset                   ModelClassType PlayableAsset PlayableAsset PlayableAsset Pointer
    // 048 M_Duration                               ModelPrimitiveType double double double Double
    // 050 M_SupportLoop                            ModelPrimitiveType bool bool bool Bool
    // 018 s_ProcessedDirectors                     HashSet`1<PlayableDirector> IL2CPP_TYPE_GENERICINST
    // 020 s_CreatedPrefabs                         HashSet`1<GameObject> IL2CPP_TYPE_GENERICINST
    // 051 ControllingDirectors                     ModelPrimitiveType bool bool bool Bool
    // 052 ControllingParticles                     ModelPrimitiveType bool bool bool Bool
    public partial class ControlPlayableAsset : DataModel
    {
        public GameObject?                              PrefabGameObject                        { get; set; }
        public bool                                     UpdateParticle                          { get; set; }
        public uint                                     ParticleRandomSeed                      { get; set; }
        public bool                                     UpdateDirector                          { get; set; }
        public bool                                     UpdateITimeControl                      { get; set; }
        public bool                                     SearchHierarchy                         { get; set; }
        public bool                                     Active                                  { get; set; }
        public PostPlaybackState                        PostPlayback                            { get; set; }
        public PlayableAsset?                           M_ControlDirectorAsset                  { get; set; }
        public double                                   M_Duration                              { get; set; }
        public bool                                     M_SupportLoop                           { get; set; }
        public bool                                     ControllingDirectors                    { get; set; }
        public bool                                     ControllingParticles                    { get; set; }

        public static ControlPlayableAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ControlPlayableAsset() { Pointer= p0 };

            value.PrefabGameObject                          = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 PrefabGameObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.UpdateParticle                            = GetBool(new IntPtr(p + 0x030)); // 0x30 UpdateParticle              ( ModelPrimitiveType bool bool bool Bool )
            value.ParticleRandomSeed                        = GetUInt32(new IntPtr(p + 0x034)); // 0x34 ParticleRandomSeed          ( ModelPrimitiveType uint uint uint UInt32 )
            value.UpdateDirector                            = GetBool(new IntPtr(p + 0x038)); // 0x38 UpdateDirector              ( ModelPrimitiveType bool bool bool Bool )
            value.UpdateITimeControl                        = GetBool(new IntPtr(p + 0x039)); // 0x39 UpdateITimeControl          ( ModelPrimitiveType bool bool bool Bool )
            value.SearchHierarchy                           = GetBool(new IntPtr(p + 0x03A)); // 0x3A SearchHierarchy             ( ModelPrimitiveType bool bool bool Bool )
            value.Active                                    = GetBool(new IntPtr(p + 0x03B)); // 0x3B Active                      ( ModelPrimitiveType bool bool bool Bool )
            value.PostPlayback                              = (PostPlaybackState)GetInt32(new IntPtr(p + 0x03C)); // 0x3C PostPlayback                ( ModelEnumType PostPlaybackState PostPlaybackState PostPlaybackState Int32 )
            value.M_ControlDirectorAsset                    = GetObject<PlayableAsset>(new IntPtr(p + 0x040), ReversePrism.DataModels.PlayableAsset.FromPointer); // 0x40 M_ControlDirectorAsset      ( ModelClassType PlayableAsset PlayableAsset PlayableAsset Pointer )
            value.M_Duration                                = GetDouble(new IntPtr(p + 0x048)); // 0x48 M_Duration                  ( ModelPrimitiveType double double double Double )
            value.M_SupportLoop                             = GetBool(new IntPtr(p + 0x050)); // 0x50 M_SupportLoop               ( ModelPrimitiveType bool bool bool Bool )
            value.ControllingDirectors                      = GetBool(new IntPtr(p + 0x051)); // 0x51 ControllingDirectors        ( ModelPrimitiveType bool bool bool Bool )
            value.ControllingParticles                      = GetBool(new IntPtr(p + 0x052)); // 0x52 ControllingParticles        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
