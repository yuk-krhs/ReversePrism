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

            value.BgPrefabName                              = GetString(new IntPtr(p + 0x010)); // 024664DF4478 0x10 BgPrefabName                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SceneName                                 = GetString(new IntPtr(p + 0x018)); // 024664DF4498 0x18 SceneName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SoundName                                 = GetString(new IntPtr(p + 0x020)); // 024664DF44B8 0x20 SoundName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Frame                                     = GetSingle(new IntPtr(p + 0x028)); // 024664DF44D8 0x28 Frame                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.DelayFrame                                = GetSingle(new IntPtr(p + 0x02C)); // 024664DF44F8 0x2C DelayFrame                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.CamPos                                    = (Vector3)GetInt32(new IntPtr(p + 0x030)); // 024664DF4518 0x30 CamPos                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CamRot                                    = (Vector3)GetInt32(new IntPtr(p + 0x03C)); // 024664DF4538 0x3C CamRot                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.FieldOfView                               = GetSingle(new IntPtr(p + 0x048)); // 024664DF4558 0x48 FieldOfView                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.Spread                                    = GetSingle(new IntPtr(p + 0x04C)); // 024664DF4578 0x4C Spread                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.StageZ                                    = GetSingle(new IntPtr(p + 0x050)); // 024664DF4598 0x50 StageZ                      ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
