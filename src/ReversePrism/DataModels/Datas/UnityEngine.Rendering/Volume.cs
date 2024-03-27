using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_IsGlobal                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 024 Priority                                 000186666050 ModelPrimitiveType float float float Single
    // 028 BlendDistance                            000186666050 ModelPrimitiveType float float float Single
    // 02C Weight                                   000186666050 ModelPrimitiveType float float float Single
    // 030 SharedProfile                            00018653D060 ModelClassType VolumeProfile VolumeProfile VolumeProfile Pointer
    // 038 M_Colliders                              000185CD30B8 ModelClassListType List`1<Collider> List`1<Collider> List<Collider> Pointer
    // 040 M_PreviousLayer                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 M_PreviousPriority                       0001866656B0 ModelPrimitiveType float float float Single
    // 048 M_InternalProfile                        00018653CE10 ModelClassType VolumeProfile VolumeProfile VolumeProfile Pointer
    public partial class Volume
    {
        public bool                                     M_IsGlobal                              { get; set; }
        public float                                    Priority                                { get; set; }
        public float                                    BlendDistance                           { get; set; }
        public float                                    Weight                                  { get; set; }
        public VolumeProfile?                           SharedProfile                           { get; set; }
        public List<Collider>?                          M_Colliders                             { get; set; }
        public int                                      M_PreviousLayer                         { get; set; }
        public float                                    M_PreviousPriority                      { get; set; }
        public VolumeProfile?                           M_InternalProfile                       { get; set; }

        public static Volume? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Volume();

            value.M_IsGlobal                                = GetBool(new IntPtr(p + 0x020)); // 0270D9158F18 0x20 M_IsGlobal                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Priority                                  = GetSingle(new IntPtr(p + 0x024)); // 0270D9158F38 0x24 Priority                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.BlendDistance                             = GetSingle(new IntPtr(p + 0x028)); // 0270D9158F58 0x28 BlendDistance               ( 000186666050 ModelPrimitiveType float float float Single )
            value.Weight                                    = GetSingle(new IntPtr(p + 0x02C)); // 0270D9158F78 0x2C Weight                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.SharedProfile                             = GetObject<VolumeProfile>(new IntPtr(p + 0x030), ReversePrism.DataModels.VolumeProfile.FromPointer); // 0270D9158F98 0x30 SharedProfile               ( 00018653D060 ModelClassType VolumeProfile VolumeProfile VolumeProfile Pointer )
            value.M_Colliders                               = GetObjectList<Collider>(new IntPtr(p + 0x038), ReversePrism.DataModels.Collider.FromPointer); // 0270D9158FB8 0x38 M_Colliders                 ( 000185CD30B8 ModelClassListType List`1<Collider> List`1<Collider> List<Collider> Pointer )
            value.M_PreviousLayer                           = GetInt32(new IntPtr(p + 0x040)); // 0270D9158FD8 0x40 M_PreviousLayer             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_PreviousPriority                        = GetSingle(new IntPtr(p + 0x044)); // 0270D9158FF8 0x44 M_PreviousPriority          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_InternalProfile                         = GetObject<VolumeProfile>(new IntPtr(p + 0x048), ReversePrism.DataModels.VolumeProfile.FromPointer); // 0270D9159018 0x48 M_InternalProfile           ( 00018653CE10 ModelClassType VolumeProfile VolumeProfile VolumeProfile Pointer )

            return value;
        }
    }
}
