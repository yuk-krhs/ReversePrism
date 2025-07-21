using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               Lazy`1<VolumeManager> IL2CPP_TYPE_GENERICINST
    // 010 Stack                                    ModelClassType VolumeStack VolumeStack VolumeStack Pointer
    // 008 s_SupportedVolumeComponentsForRenderPipeline Dictionary`2<Type, List`1<ValueTuple`2<string, Type>>> IL2CPP_TYPE_GENERICINST
    // 018 BaseComponentTypeArray                   ModelClassListType Type[] Type[] List<Type> Pointer
    // 000 k_MaxLayerCount                          int IL2CPP_TYPE_I4
    // 020 m_SortedVolumes                          Dictionary`2<int, List`1<Volume>> IL2CPP_TYPE_GENERICINST
    // 028 M_Volumes                                ModelClassListType List`1<Volume> List`1<Volume> List<Volume> Pointer
    // 030 m_SortNeeded                             Dictionary`2<int, bool> IL2CPP_TYPE_GENERICINST
    // 038 M_ComponentsDefaultState                 ModelClassListType List`1<VolumeComponent> List`1<VolumeComponent> List<VolumeComponent> Pointer
    // 040 M_TempColliders                          ModelClassListType List`1<Collider> List`1<Collider> List<Collider> Pointer
    // 048 M_DefaultStack                           ModelClassType VolumeStack VolumeStack VolumeStack Pointer
    public partial class VolumeManager : DataModel
    {
        public VolumeStack?                             Stack                                   { get; set; }
        public List<Type>?                              BaseComponentTypeArray                  { get; set; }
        public List<Volume>?                            M_Volumes                               { get; set; }
        public List<VolumeComponent>?                   M_ComponentsDefaultState                { get; set; }
        public List<Collider>?                          M_TempColliders                         { get; set; }
        public VolumeStack?                             M_DefaultStack                          { get; set; }

        public static VolumeManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VolumeManager() { Pointer= p0 };

            value.Stack                                     = GetObject<VolumeStack>(new IntPtr(p + 0x010), ReversePrism.DataModels.VolumeStack.FromPointer); // 0x10 Stack                       ( ModelClassType VolumeStack VolumeStack VolumeStack Pointer )
            value.BaseComponentTypeArray                    = GetObjectList<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0x18 BaseComponentTypeArray      ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.M_Volumes                                 = GetObjectList<Volume>(new IntPtr(p + 0x028), ReversePrism.DataModels.Volume.FromPointer); // 0x28 M_Volumes                   ( ModelClassListType List`1<Volume> List`1<Volume> List<Volume> Pointer )
            value.M_ComponentsDefaultState                  = GetObjectList<VolumeComponent>(new IntPtr(p + 0x038), ReversePrism.DataModels.VolumeComponent.FromPointer); // 0x38 M_ComponentsDefaultState    ( ModelClassListType List`1<VolumeComponent> List`1<VolumeComponent> List<VolumeComponent> Pointer )
            value.M_TempColliders                           = GetObjectList<Collider>(new IntPtr(p + 0x040), ReversePrism.DataModels.Collider.FromPointer); // 0x40 M_TempColliders             ( ModelClassListType List`1<Collider> List`1<Collider> List<Collider> Pointer )
            value.M_DefaultStack                            = GetObject<VolumeStack>(new IntPtr(p + 0x048), ReversePrism.DataModels.VolumeStack.FromPointer); // 0x48 M_DefaultStack              ( ModelClassType VolumeStack VolumeStack VolumeStack Pointer )

            return value;
        }
    }
}
