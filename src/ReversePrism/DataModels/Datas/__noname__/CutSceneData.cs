using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType string string string String
    // 018 StartFrame                               ModelPrimitiveType float float float Single
    // 01C Duration                                 ModelPrimitiveType float float float Single
    // 020 CutSceneList                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 OutBeforeIn                              ModelClassType FadeData FadeData FadeData Pointer
    // 030 InFade                                   ModelClassType FadeData FadeData FadeData Pointer
    // 038 OutFade                                  ModelClassType FadeData FadeData FadeData Pointer
    // 040 InAfterOut                               ModelClassType FadeData FadeData FadeData Pointer
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

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType string string string String )
            value.StartFrame                                = GetSingle(new IntPtr(p + 0x018)); // 0x18 StartFrame                  ( ModelPrimitiveType float float float Single )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Duration                    ( ModelPrimitiveType float float float Single )
            value.CutSceneList                              = GetStringList(new IntPtr(p + 0x020)); // 0x20 CutSceneList                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.OutBeforeIn                               = GetObject<FadeData>(new IntPtr(p + 0x028), ReversePrism.DataModels.FadeData.FromPointer); // 0x28 OutBeforeIn                 ( ModelClassType FadeData FadeData FadeData Pointer )
            value.InFade                                    = GetObject<FadeData>(new IntPtr(p + 0x030), ReversePrism.DataModels.FadeData.FromPointer); // 0x30 InFade                      ( ModelClassType FadeData FadeData FadeData Pointer )
            value.OutFade                                   = GetObject<FadeData>(new IntPtr(p + 0x038), ReversePrism.DataModels.FadeData.FromPointer); // 0x38 OutFade                     ( ModelClassType FadeData FadeData FadeData Pointer )
            value.InAfterOut                                = GetObject<FadeData>(new IntPtr(p + 0x040), ReversePrism.DataModels.FadeData.FromPointer); // 0x40 InAfterOut                  ( ModelClassType FadeData FadeData FadeData Pointer )

            return value;
        }
    }
}
