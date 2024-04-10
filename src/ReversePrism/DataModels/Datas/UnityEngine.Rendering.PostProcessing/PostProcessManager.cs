using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               PostProcessManager IL2CPP_TYPE_CLASS
    // 000 k_MaxLayerCount                          int IL2CPP_TYPE_I4
    // 010 m_SortedVolumes                          Dictionary`2<int, List`1<PostProcessVolume>> IL2CPP_TYPE_GENERICINST
    // 018 M_Volumes                                000185CFABD8 ModelClassListType List`1<PostProcessVolume> List`1<PostProcessVolume> List<PostProcessVolume> Pointer
    // 020 m_SortNeeded                             Dictionary`2<int, bool> IL2CPP_TYPE_GENERICINST
    // 028 M_BaseSettings                           000185CFA9B8 ModelClassListType List`1<PostProcessEffectSettings> List`1<PostProcessEffectSettings> List<PostProcessEffectSettings> Pointer
    // 030 M_TempColliders                          000185CD3138 ModelClassListType List`1<Collider> List`1<Collider> List<Collider> Pointer
    // 038 settingsTypes                            Dictionary`2<Type, PostProcessAttribute> IL2CPP_TYPE_GENERICINST
    public partial class PostProcessManager : DataModel
    {
        public List<PostProcessVolume>?                 M_Volumes                               { get; set; }
        public List<PostProcessEffectSettings>?         M_BaseSettings                          { get; set; }
        public List<Collider>?                          M_TempColliders                         { get; set; }

        public static PostProcessManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostProcessManager() { Pointer= p0 };

            value.M_Volumes                                 = GetObjectList<PostProcessVolume>(new IntPtr(p + 0x018), ReversePrism.DataModels.PostProcessVolume.FromPointer); // 0245A60EC748 0x18 M_Volumes                   ( 000185CFABD8 ModelClassListType List`1<PostProcessVolume> List`1<PostProcessVolume> List<PostProcessVolume> Pointer )
            value.M_BaseSettings                            = GetObjectList<PostProcessEffectSettings>(new IntPtr(p + 0x028), ReversePrism.DataModels.PostProcessEffectSettings.FromPointer); // 0245A60EC788 0x28 M_BaseSettings              ( 000185CFA9B8 ModelClassListType List`1<PostProcessEffectSettings> List`1<PostProcessEffectSettings> List<PostProcessEffectSettings> Pointer )
            value.M_TempColliders                           = GetObjectList<Collider>(new IntPtr(p + 0x030), ReversePrism.DataModels.Collider.FromPointer); // 0245A60EC7A8 0x30 M_TempColliders             ( 000185CD3138 ModelClassListType List`1<Collider> List`1<Collider> List<Collider> Pointer )

            return value;
        }
    }
}
