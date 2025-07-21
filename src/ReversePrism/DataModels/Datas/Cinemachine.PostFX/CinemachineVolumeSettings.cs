using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_VolumePriority                         float IL2CPP_TYPE_R4
    // 030 M_FocusTracksTarget                      ModelPrimitiveType bool bool bool Bool
    // 034 M_FocusTracking                          ModelEnumType FocusTrackingMode FocusTrackingMode FocusTrackingMode Int32
    // 038 M_FocusTarget                            ModelClassType Transform Transform Transform Pointer
    // 040 M_FocusOffset                            ModelPrimitiveType float float float Single
    // 048 M_Profile                                ModelClassType VolumeProfile VolumeProfile VolumeProfile Pointer
    // 008 sVolumeOwnerName                         string IL2CPP_TYPE_STRING
    // 010 SVolumes                                 ModelClassListType List`1<Volume> List`1<Volume> List<Volume> Pointer
    public partial class CinemachineVolumeSettings : DataModel
    {
        public bool                                     M_FocusTracksTarget                     { get; set; }
        public FocusTrackingMode                        M_FocusTracking                         { get; set; }
        public Transform?                               M_FocusTarget                           { get; set; }
        public float                                    M_FocusOffset                           { get; set; }
        public VolumeProfile?                           M_Profile                               { get; set; }
        public List<Volume>?                            SVolumes                                { get; set; }

        public static CinemachineVolumeSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineVolumeSettings() { Pointer= p0 };

            value.M_FocusTracksTarget                       = GetBool(new IntPtr(p + 0x030)); // 0x30 M_FocusTracksTarget         ( ModelPrimitiveType bool bool bool Bool )
            value.M_FocusTracking                           = (FocusTrackingMode)GetInt32(new IntPtr(p + 0x034)); // 0x34 M_FocusTracking             ( ModelEnumType FocusTrackingMode FocusTrackingMode FocusTrackingMode Int32 )
            value.M_FocusTarget                             = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0x38 M_FocusTarget               ( ModelClassType Transform Transform Transform Pointer )
            value.M_FocusOffset                             = GetSingle(new IntPtr(p + 0x040)); // 0x40 M_FocusOffset               ( ModelPrimitiveType float float float Single )
            value.M_Profile                                 = GetObject<VolumeProfile>(new IntPtr(p + 0x048), ReversePrism.DataModels.VolumeProfile.FromPointer); // 0x48 M_Profile                   ( ModelClassType VolumeProfile VolumeProfile VolumeProfile Pointer )
            value.SVolumes                                  = GetObjectList<Volume>(new IntPtr(p + 0x010), ReversePrism.DataModels.Volume.FromPointer); // 0x10 SVolumes                    ( ModelClassListType List`1<Volume> List`1<Volume> List<Volume> Pointer )

            return value;
        }
    }
}
