using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartFrame                               000186666050 ModelPrimitiveType float float float Single
    // 014 Duration                                 000186666050 ModelPrimitiveType float float float Single
    // 018 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 020 OutBeforeIn                              00018676D5D0 ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer
    // 028 InFade                                   00018676D5D0 ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer
    // 030 OutFade                                  00018676D5D0 ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer
    // 038 InAfterOut                               00018676D5D0 ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer
    public partial class PlayCutSceneData : DataModel
    {
        public float                                    StartFrame                              { get; set; }
        public float                                    Duration                                { get; set; }
        public string                                   Name                                    { get; set; }
        public PlayFadeData?                            OutBeforeIn                             { get; set; }
        public PlayFadeData?                            InFade                                  { get; set; }
        public PlayFadeData?                            OutFade                                 { get; set; }
        public PlayFadeData?                            InAfterOut                              { get; set; }

        public static PlayCutSceneData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayCutSceneData() { Pointer= p0 };

            value.StartFrame                                = GetSingle(new IntPtr(p + 0x010)); // 024664E45F80 0x10 StartFrame                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x014)); // 024664E45FA0 0x14 Duration                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 024664E45FC0 0x18 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.OutBeforeIn                               = GetObject<PlayFadeData>(new IntPtr(p + 0x020), ReversePrism.DataModels.PlayFadeData.FromPointer); // 024664E45FE0 0x20 OutBeforeIn                 ( 00018676D5D0 ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer )
            value.InFade                                    = GetObject<PlayFadeData>(new IntPtr(p + 0x028), ReversePrism.DataModels.PlayFadeData.FromPointer); // 024664E46000 0x28 InFade                      ( 00018676D5D0 ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer )
            value.OutFade                                   = GetObject<PlayFadeData>(new IntPtr(p + 0x030), ReversePrism.DataModels.PlayFadeData.FromPointer); // 024664E46020 0x30 OutFade                     ( 00018676D5D0 ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer )
            value.InAfterOut                                = GetObject<PlayFadeData>(new IntPtr(p + 0x038), ReversePrism.DataModels.PlayFadeData.FromPointer); // 024664E46040 0x38 InAfterOut                  ( 00018676D5D0 ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer )

            return value;
        }
    }
}
