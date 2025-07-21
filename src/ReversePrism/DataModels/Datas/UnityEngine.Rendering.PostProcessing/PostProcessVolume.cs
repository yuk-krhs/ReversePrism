using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SharedProfile                            ModelClassType PostProcessProfile PostProcessProfile PostProcessProfile Pointer
    // 028 IsGlobal                                 ModelPrimitiveType bool bool bool Bool
    // 02C BlendDistance                            ModelPrimitiveType float float float Single
    // 030 Weight                                   ModelPrimitiveType float float float Single
    // 034 Priority                                 ModelPrimitiveType float float float Single
    // 038 M_PreviousLayer                          ModelPrimitiveType int int int Int32
    // 03C M_PreviousPriority                       ModelPrimitiveType float float float Single
    // 040 M_TempColliders                          ModelClassListType List`1<Collider> List`1<Collider> List<Collider> Pointer
    // 048 M_InternalProfile                        ModelClassType PostProcessProfile PostProcessProfile PostProcessProfile Pointer
    public partial class PostProcessVolume : DataModel
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
            var value   = new PostProcessVolume() { Pointer= p0 };

            value.SharedProfile                             = GetObject<PostProcessProfile>(new IntPtr(p + 0x020), ReversePrism.DataModels.PostProcessProfile.FromPointer); // 0x20 SharedProfile               ( ModelClassType PostProcessProfile PostProcessProfile PostProcessProfile Pointer )
            value.IsGlobal                                  = GetBool(new IntPtr(p + 0x028)); // 0x28 IsGlobal                    ( ModelPrimitiveType bool bool bool Bool )
            value.BlendDistance                             = GetSingle(new IntPtr(p + 0x02C)); // 0x2C BlendDistance               ( ModelPrimitiveType float float float Single )
            value.Weight                                    = GetSingle(new IntPtr(p + 0x030)); // 0x30 Weight                      ( ModelPrimitiveType float float float Single )
            value.Priority                                  = GetSingle(new IntPtr(p + 0x034)); // 0x34 Priority                    ( ModelPrimitiveType float float float Single )
            value.M_PreviousLayer                           = GetInt32(new IntPtr(p + 0x038)); // 0x38 M_PreviousLayer             ( ModelPrimitiveType int int int Int32 )
            value.M_PreviousPriority                        = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M_PreviousPriority          ( ModelPrimitiveType float float float Single )
            value.M_TempColliders                           = GetObjectList<Collider>(new IntPtr(p + 0x040), ReversePrism.DataModels.Collider.FromPointer); // 0x40 M_TempColliders             ( ModelClassListType List`1<Collider> List`1<Collider> List<Collider> Pointer )
            value.M_InternalProfile                         = GetObject<PostProcessProfile>(new IntPtr(p + 0x048), ReversePrism.DataModels.PostProcessProfile.FromPointer); // 0x48 M_InternalProfile           ( ModelClassType PostProcessProfile PostProcessProfile PostProcessProfile Pointer )

            return value;
        }
    }
}
