using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SharedProfile                            00018676CF70 ModelClassType PostProcessProfile PostProcessProfile PostProcessProfile Pointer
    // 028 IsGlobal                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 02C BlendDistance                            000186666050 ModelPrimitiveType float float float Single
    // 030 Weight                                   000186666050 ModelPrimitiveType float float float Single
    // 034 Priority                                 000186666050 ModelPrimitiveType float float float Single
    // 038 M_PreviousLayer                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C M_PreviousPriority                       0001866656B0 ModelPrimitiveType float float float Single
    // 040 M_TempColliders                          000185CD3048 ModelClassListType List`1<Collider> List`1<Collider> List<Collider> Pointer
    // 048 M_InternalProfile                        00018676CCB0 ModelClassType PostProcessProfile PostProcessProfile PostProcessProfile Pointer
    public partial class PostProcessVolume
    {
        public PostProcessProfile?                      SharedProfile                           { get; set; }
        public bool                                     IsGlobal                                { get; set; }
        public float                                    BlendDistance                           { get; set; }
        public float                                    Weight                                  { get; set; }
        public float                                    Priority                                { get; set; }
        public int                                      M_PreviousLayer                         { get; set; }
        public float                                    M_PreviousPriority                      { get; set; }
        public List<Collider>?                          M_TempColliders                         { get; set; }
        public PostProcessProfile?                      M_InternalProfile                       { get; set; }

        public static PostProcessVolume? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostProcessVolume();

            value.SharedProfile                             = GetObject<PostProcessProfile>(new IntPtr(p + 0x020), ReversePrism.DataModels.PostProcessProfile.FromPointer); // 0270D3307A48 0x20 SharedProfile               ( 00018676CF70 ModelClassType PostProcessProfile PostProcessProfile PostProcessProfile Pointer )
            value.IsGlobal                                  = GetBool(new IntPtr(p + 0x028)); // 0270D3307A68 0x28 IsGlobal                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.BlendDistance                             = GetSingle(new IntPtr(p + 0x02C)); // 0270D3307A88 0x2C BlendDistance               ( 000186666050 ModelPrimitiveType float float float Single )
            value.Weight                                    = GetSingle(new IntPtr(p + 0x030)); // 0270D3307AA8 0x30 Weight                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Priority                                  = GetSingle(new IntPtr(p + 0x034)); // 0270D3307AC8 0x34 Priority                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.M_PreviousLayer                           = GetInt32(new IntPtr(p + 0x038)); // 0270D3307AE8 0x38 M_PreviousLayer             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_PreviousPriority                        = GetSingle(new IntPtr(p + 0x03C)); // 0270D3307B08 0x3C M_PreviousPriority          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_TempColliders                           = GetObjectList<Collider>(new IntPtr(p + 0x040), ReversePrism.DataModels.Collider.FromPointer); // 0270D3307B28 0x40 M_TempColliders             ( 000185CD3048 ModelClassListType List`1<Collider> List`1<Collider> List<Collider> Pointer )
            value.M_InternalProfile                         = GetObject<PostProcessProfile>(new IntPtr(p + 0x048), ReversePrism.DataModels.PostProcessProfile.FromPointer); // 0270D3307B48 0x48 M_InternalProfile           ( 00018676CCB0 ModelClassType PostProcessProfile PostProcessProfile PostProcessProfile Pointer )

            return value;
        }
    }
}
