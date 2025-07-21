using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SPECTRUM_BUS_NAME                        string IL2CPP_TYPE_STRING
    // 000 LEVEL_OFFSET                             float IL2CPP_TYPE_R4
    // 020 Bars                                     ModelClassListType RectTransform[] RectTransform[] List<RectTransform> Pointer
    // 028 Analyzer                                 ModelClassType CriAtomExOutputAnalyzer CriAtomExOutputAnalyzer CriAtomExOutputAnalyzer Pointer
    // 030 LinearSpectrumLevels                     ModelPrimitiveListType float[] float[] List<float> Pointer
    // 038 LogSpectrumLevels                        ModelPrimitiveListType float[] float[] List<float> Pointer
    // 040 MaxLevel                                 ModelPrimitiveType float float float Single
    // 044 MaxBarSize                               ModelPrimitiveType float float float Single
    public partial class MusicSpectrumVisualizer : DataModel
    {
        public List<RectTransform>?                     Bars                                    { get; set; }
        public CriAtomExOutputAnalyzer?                 Analyzer                                { get; set; }
        public List<float>?                             LinearSpectrumLevels                    { get; set; }
        public List<float>?                             LogSpectrumLevels                       { get; set; }
        public float                                    MaxLevel                                { get; set; }
        public float                                    MaxBarSize                              { get; set; }

        public static MusicSpectrumVisualizer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicSpectrumVisualizer() { Pointer= p0 };

            value.Bars                                      = GetObjectList<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 Bars                        ( ModelClassListType RectTransform[] RectTransform[] List<RectTransform> Pointer )
            value.Analyzer                                  = GetObject<CriAtomExOutputAnalyzer>(new IntPtr(p + 0x028), ReversePrism.DataModels.CriAtomExOutputAnalyzer.FromPointer); // 0x28 Analyzer                    ( ModelClassType CriAtomExOutputAnalyzer CriAtomExOutputAnalyzer CriAtomExOutputAnalyzer Pointer )
            value.LinearSpectrumLevels                      = GetSingleList(new IntPtr(p + 0x030)); // 0x30 LinearSpectrumLevels        ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.LogSpectrumLevels                         = GetSingleList(new IntPtr(p + 0x038)); // 0x38 LogSpectrumLevels           ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.MaxLevel                                  = GetSingle(new IntPtr(p + 0x040)); // 0x40 MaxLevel                    ( ModelPrimitiveType float float float Single )
            value.MaxBarSize                                = GetSingle(new IntPtr(p + 0x044)); // 0x44 MaxBarSize                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
