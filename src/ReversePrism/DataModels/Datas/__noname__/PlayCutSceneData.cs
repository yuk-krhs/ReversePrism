using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartFrame                               ModelPrimitiveType float float float Single
    // 014 Duration                                 ModelPrimitiveType float float float Single
    // 018 Name                                     ModelPrimitiveType string string string String
    // 020 OutBeforeIn                              ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer
    // 028 InFade                                   ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer
    // 030 OutFade                                  ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer
    // 038 InAfterOut                               ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer
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

            value.StartFrame                                = GetSingle(new IntPtr(p + 0x010)); // 0x10 StartFrame                  ( ModelPrimitiveType float float float Single )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x014)); // 0x14 Duration                    ( ModelPrimitiveType float float float Single )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.OutBeforeIn                               = GetObject<PlayFadeData>(new IntPtr(p + 0x020), ReversePrism.DataModels.PlayFadeData.FromPointer); // 0x20 OutBeforeIn                 ( ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer )
            value.InFade                                    = GetObject<PlayFadeData>(new IntPtr(p + 0x028), ReversePrism.DataModels.PlayFadeData.FromPointer); // 0x28 InFade                      ( ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer )
            value.OutFade                                   = GetObject<PlayFadeData>(new IntPtr(p + 0x030), ReversePrism.DataModels.PlayFadeData.FromPointer); // 0x30 OutFade                     ( ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer )
            value.InAfterOut                                = GetObject<PlayFadeData>(new IntPtr(p + 0x038), ReversePrism.DataModels.PlayFadeData.FromPointer); // 0x38 InAfterOut                  ( ModelClassType PlayFadeData PlayFadeData PlayFadeData Pointer )

            return value;
        }
    }
}
