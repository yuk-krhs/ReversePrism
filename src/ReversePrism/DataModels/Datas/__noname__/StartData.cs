using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BgPrefabName                             ModelPrimitiveType string string string String
    // 018 SceneName                                ModelPrimitiveType string string string String
    // 020 SoundName                                ModelPrimitiveType string string string String
    // 028 Frame                                    ModelPrimitiveType float float float Single
    // 02C DelayFrame                               ModelPrimitiveType float float float Single
    // 030 CamPos                                   ModelEnumType Vector3 Vector3 Vector3 Int32
    // 03C CamRot                                   ModelEnumType Vector3 Vector3 Vector3 Int32
    // 048 FieldOfView                              ModelPrimitiveType float float float Single
    // 04C Spread                                   ModelPrimitiveType float float float Single
    // 050 StageZ                                   ModelPrimitiveType float float float Single
    public partial class StartData : DataModel
    {
        public string                                   BgPrefabName                            { get; set; }
        public string                                   SceneName                               { get; set; }
        public string                                   SoundName                               { get; set; }
        public float                                    Frame                                   { get; set; }
        public float                                    DelayFrame                              { get; set; }
        public Vector3                                  CamPos                                  { get; set; }
        public Vector3                                  CamRot                                  { get; set; }
        public float                                    FieldOfView                             { get; set; }
        public float                                    Spread                                  { get; set; }
        public float                                    StageZ                                  { get; set; }

        public static StartData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartData() { Pointer= p0 };

            value.BgPrefabName                              = GetString(new IntPtr(p + 0x010)); // 0x10 BgPrefabName                ( ModelPrimitiveType string string string String )
            value.SceneName                                 = GetString(new IntPtr(p + 0x018)); // 0x18 SceneName                   ( ModelPrimitiveType string string string String )
            value.SoundName                                 = GetString(new IntPtr(p + 0x020)); // 0x20 SoundName                   ( ModelPrimitiveType string string string String )
            value.Frame                                     = GetSingle(new IntPtr(p + 0x028)); // 0x28 Frame                       ( ModelPrimitiveType float float float Single )
            value.DelayFrame                                = GetSingle(new IntPtr(p + 0x02C)); // 0x2C DelayFrame                  ( ModelPrimitiveType float float float Single )
            value.CamPos                                    = (Vector3)GetInt32(new IntPtr(p + 0x030)); // 0x30 CamPos                      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CamRot                                    = (Vector3)GetInt32(new IntPtr(p + 0x03C)); // 0x3C CamRot                      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.FieldOfView                               = GetSingle(new IntPtr(p + 0x048)); // 0x48 FieldOfView                 ( ModelPrimitiveType float float float Single )
            value.Spread                                    = GetSingle(new IntPtr(p + 0x04C)); // 0x4C Spread                      ( ModelPrimitiveType float float float Single )
            value.StageZ                                    = GetSingle(new IntPtr(p + 0x050)); // 0x50 StageZ                      ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
