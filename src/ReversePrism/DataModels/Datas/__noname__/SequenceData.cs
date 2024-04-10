using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LiveScene                                0001866722E0 ModelPrimitiveType string string string String
    // 018 Duration                                 000186666050 ModelPrimitiveType float float float Single
    // 020 CutSceneData                             000185CBF5F8 ModelClassListType CutSceneData[] CutSceneData[] List<CutSceneData> Pointer
    // 028 InFade                                   00018676CE10 ModelClassType FadeData FadeData FadeData Pointer
    // 030 OutFade                                  00018676CE10 ModelClassType FadeData FadeData FadeData Pointer
    public partial class SequenceData : DataModel
    {
        public string                                   LiveScene                               { get; set; }
        public float                                    Duration                                { get; set; }
        public List<CutSceneData>?                      CutSceneData                            { get; set; }
        public FadeData?                                InFade                                  { get; set; }
        public FadeData?                                OutFade                                 { get; set; }

        public static SequenceData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SequenceData() { Pointer= p0 };

            value.LiveScene                                 = GetString(new IntPtr(p + 0x010)); // 024664E454A8 0x10 LiveScene                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x018)); // 024664E454C8 0x18 Duration                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.CutSceneData                              = GetObjectList<CutSceneData>(new IntPtr(p + 0x020), ReversePrism.DataModels.CutSceneData.FromPointer); // 024664E454E8 0x20 CutSceneData                ( 000185CBF5F8 ModelClassListType CutSceneData[] CutSceneData[] List<CutSceneData> Pointer )
            value.InFade                                    = GetObject<FadeData>(new IntPtr(p + 0x028), ReversePrism.DataModels.FadeData.FromPointer); // 024664E45508 0x28 InFade                      ( 00018676CE10 ModelClassType FadeData FadeData FadeData Pointer )
            value.OutFade                                   = GetObject<FadeData>(new IntPtr(p + 0x030), ReversePrism.DataModels.FadeData.FromPointer); // 024664E45528 0x30 OutFade                     ( 00018676CE10 ModelClassType FadeData FadeData FadeData Pointer )

            return value;
        }
    }
}
