using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SeSheetName                              string IL2CPP_TYPE_STRING
    // 020 OpenGashaScene                           000186671910 ModelPrimitiveType string string string String
    // 028 SceneLoader                              0001866CC6B0 ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer
    // 030 GashaSequencer                           00018661A3F0 ModelClassType GashaSequencer GashaSequencer GashaSequencer Pointer
    // 038 EffectCts                                0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 040 IsProduceIdol                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 GashaResultData                          000186615640 ModelClassType GashaResultData GashaResultData GashaResultData Pointer
    // 050 OnFinishEffect                           0001866792B0 ModelClassType Action Action Action Pointer
    // 058 Pe                                       000186529CB0 ModelClassType IGashaStageEffectStatus IGashaStageEffectStatus IGashaStageEffectStatus Pointer
    // 060 IsSkip                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 Phase3Step1Cts                           0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 070 Phase3Step2Cts                           0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 078 finishedPhases                           HashSet`1<ValueTuple`2<int, string>> IL2CPP_TYPE_GENERICINST
    // 080 Logs                                     000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class GashaSequenceDirection : DataModel
    {
        public string                                   OpenGashaScene                          { get; set; }
        public SceneLoaderAddressable?                  SceneLoader                             { get; set; }
        public GashaSequencer?                          GashaSequencer                          { get; set; }
        public CancellationTokenSource?                 EffectCts                               { get; set; }
        public bool                                     IsProduceIdol                           { get; set; }
        public GashaResultData?                         GashaResultData                         { get; set; }
        public Action?                                  OnFinishEffect                          { get; set; }
        public IGashaStageEffectStatus?                 Pe                                      { get; set; }
        public bool                                     IsSkip                                  { get; set; }
        public CancellationTokenSource?                 Phase3Step1Cts                          { get; set; }
        public CancellationTokenSource?                 Phase3Step2Cts                          { get; set; }
        public List<string>?                            Logs                                    { get; set; }

        public static GashaSequenceDirection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaSequenceDirection() { Pointer= p0 };

            value.OpenGashaScene                            = GetString(new IntPtr(p + 0x020)); // 0246653E6650 0x20 OpenGashaScene              ( 000186671910 ModelPrimitiveType string string string String )
            value.SceneLoader                               = GetObject<SceneLoaderAddressable>(new IntPtr(p + 0x028), ReversePrism.DataModels.SceneLoaderAddressable.FromPointer); // 0246653E6670 0x28 SceneLoader                 ( 0001866CC6B0 ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer )
            value.GashaSequencer                            = GetObject<GashaSequencer>(new IntPtr(p + 0x030), ReversePrism.DataModels.GashaSequencer.FromPointer); // 0246653E6690 0x30 GashaSequencer              ( 00018661A3F0 ModelClassType GashaSequencer GashaSequencer GashaSequencer Pointer )
            value.EffectCts                                 = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246653E66B0 0x38 EffectCts                   ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsProduceIdol                             = GetBool(new IntPtr(p + 0x040)); // 0246653E66D0 0x40 IsProduceIdol               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.GashaResultData                           = GetObject<GashaResultData>(new IntPtr(p + 0x048), ReversePrism.DataModels.GashaResultData.FromPointer); // 0246653E66F0 0x48 GashaResultData             ( 000186615640 ModelClassType GashaResultData GashaResultData GashaResultData Pointer )
            value.OnFinishEffect                            = GetObject<Action>(new IntPtr(p + 0x050), ReversePrism.DataModels.Action.FromPointer); // 0246653E6710 0x50 OnFinishEffect              ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.Pe                                        = GetObject<IGashaStageEffectStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IGashaStageEffectStatus.FromPointer); // 0246653E6730 0x58 Pe                          ( 000186529CB0 ModelClassType IGashaStageEffectStatus IGashaStageEffectStatus IGashaStageEffectStatus Pointer )
            value.IsSkip                                    = GetBool(new IntPtr(p + 0x060)); // 0246653E6750 0x60 IsSkip                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Phase3Step1Cts                            = GetObject<CancellationTokenSource>(new IntPtr(p + 0x068), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246653E6770 0x68 Phase3Step1Cts              ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Phase3Step2Cts                            = GetObject<CancellationTokenSource>(new IntPtr(p + 0x070), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246653E6790 0x70 Phase3Step2Cts              ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Logs                                      = GetStringList(new IntPtr(p + 0x080)); // 0246653E67D0 0x80 Logs                        ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
