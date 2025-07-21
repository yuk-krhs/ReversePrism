using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LiveScene                                ModelPrimitiveType string string string String
    // 018 Duration                                 ModelPrimitiveType float float float Single
    // 020 CutSceneData                             ModelClassListType CutSceneData[] CutSceneData[] List<CutSceneData> Pointer
    // 028 InFade                                   ModelClassType FadeData FadeData FadeData Pointer
    // 030 OutFade                                  ModelClassType FadeData FadeData FadeData Pointer
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

            value.LiveScene                                 = GetString(new IntPtr(p + 0x010)); // 0x10 LiveScene                   ( ModelPrimitiveType string string string String )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x018)); // 0x18 Duration                    ( ModelPrimitiveType float float float Single )
            value.CutSceneData                              = GetObjectList<CutSceneData>(new IntPtr(p + 0x020), ReversePrism.DataModels.CutSceneData.FromPointer); // 0x20 CutSceneData                ( ModelClassListType CutSceneData[] CutSceneData[] List<CutSceneData> Pointer )
            value.InFade                                    = GetObject<FadeData>(new IntPtr(p + 0x028), ReversePrism.DataModels.FadeData.FromPointer); // 0x28 InFade                      ( ModelClassType FadeData FadeData FadeData Pointer )
            value.OutFade                                   = GetObject<FadeData>(new IntPtr(p + 0x030), ReversePrism.DataModels.FadeData.FromPointer); // 0x30 OutFade                     ( ModelClassType FadeData FadeData FadeData Pointer )

            return value;
        }
    }
}
