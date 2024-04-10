using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001866722E0 ModelPrimitiveType string string string String
    // 018 StartFrame                               000186666050 ModelPrimitiveType float float float Single
    // 01C Duration                                 000186666050 ModelPrimitiveType float float float Single
    // 020 CutSceneList                             000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 OutBeforeIn                              00018676CE10 ModelClassType FadeData FadeData FadeData Pointer
    // 030 InFade                                   00018676CE10 ModelClassType FadeData FadeData FadeData Pointer
    // 038 OutFade                                  00018676CE10 ModelClassType FadeData FadeData FadeData Pointer
    // 040 InAfterOut                               00018676CE10 ModelClassType FadeData FadeData FadeData Pointer
    public partial class CutSceneData : DataModel
    {
        public string                                   Id                                      { get; set; }
        public float                                    StartFrame                              { get; set; }
        public float                                    Duration                                { get; set; }
        public List<string>?                            CutSceneList                            { get; set; }
        public FadeData?                                OutBeforeIn                             { get; set; }
        public FadeData?                                InFade                                  { get; set; }
        public FadeData?                                OutFade                                 { get; set; }
        public FadeData?                                InAfterOut                              { get; set; }

        public static CutSceneData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CutSceneData() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 024664E455A8 0x10 Id                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.StartFrame                                = GetSingle(new IntPtr(p + 0x018)); // 024664E455C8 0x18 StartFrame                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x01C)); // 024664E455E8 0x1C Duration                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.CutSceneList                              = GetStringList(new IntPtr(p + 0x020)); // 024664E45608 0x20 CutSceneList                ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.OutBeforeIn                               = GetObject<FadeData>(new IntPtr(p + 0x028), ReversePrism.DataModels.FadeData.FromPointer); // 024664E45628 0x28 OutBeforeIn                 ( 00018676CE10 ModelClassType FadeData FadeData FadeData Pointer )
            value.InFade                                    = GetObject<FadeData>(new IntPtr(p + 0x030), ReversePrism.DataModels.FadeData.FromPointer); // 024664E45648 0x30 InFade                      ( 00018676CE10 ModelClassType FadeData FadeData FadeData Pointer )
            value.OutFade                                   = GetObject<FadeData>(new IntPtr(p + 0x038), ReversePrism.DataModels.FadeData.FromPointer); // 024664E45668 0x38 OutFade                     ( 00018676CE10 ModelClassType FadeData FadeData FadeData Pointer )
            value.InAfterOut                                = GetObject<FadeData>(new IntPtr(p + 0x040), ReversePrism.DataModels.FadeData.FromPointer); // 024664E45688 0x40 InAfterOut                  ( 00018676CE10 ModelClassType FadeData FadeData FadeData Pointer )

            return value;
        }
    }
}
