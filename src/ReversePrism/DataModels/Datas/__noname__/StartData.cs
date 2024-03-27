using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BgPrefabName                             0001866722E0 ModelPrimitiveType string string string String
    // 018 SceneName                                0001866722E0 ModelPrimitiveType string string string String
    // 020 SoundName                                0001866722E0 ModelPrimitiveType string string string String
    // 028 Frame                                    000186666050 ModelPrimitiveType float float float Single
    // 02C DelayFrame                               000186666050 ModelPrimitiveType float float float Single
    // 030 CamPos                                   0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 03C CamRot                                   0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 048 FieldOfView                              000186666050 ModelPrimitiveType float float float Single
    // 04C Spread                                   000186666050 ModelPrimitiveType float float float Single
    // 050 StageZ                                   000186666050 ModelPrimitiveType float float float Single
    public partial class StartData
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
            var value   = new StartData();

            value.BgPrefabName                              = GetString(new IntPtr(p + 0x010)); // 0270D4D9B020 0x10 BgPrefabName                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SceneName                                 = GetString(new IntPtr(p + 0x018)); // 0270D4D9B040 0x18 SceneName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SoundName                                 = GetString(new IntPtr(p + 0x020)); // 0270D4D9B060 0x20 SoundName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Frame                                     = GetSingle(new IntPtr(p + 0x028)); // 0270D4D9B080 0x28 Frame                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.DelayFrame                                = GetSingle(new IntPtr(p + 0x02C)); // 0270D4D9B0A0 0x2C DelayFrame                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.CamPos                                    = (Vector3)GetInt32(new IntPtr(p + 0x030)); // 0270D4D9B0C0 0x30 CamPos                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CamRot                                    = (Vector3)GetInt32(new IntPtr(p + 0x03C)); // 0270D4D9B0E0 0x3C CamRot                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.FieldOfView                               = GetSingle(new IntPtr(p + 0x048)); // 0270D4D9B100 0x48 FieldOfView                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.Spread                                    = GetSingle(new IntPtr(p + 0x04C)); // 0270D4D9B120 0x4C Spread                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.StageZ                                    = GetSingle(new IntPtr(p + 0x050)); // 0270D4D9B140 0x50 StageZ                      ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
