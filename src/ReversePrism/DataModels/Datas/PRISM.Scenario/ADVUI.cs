using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Menu                                     000186668AF0 ModelClassType ADVMenu ADVMenu ADVMenu Pointer
    // 028 Choice                                   000186693AA0 ModelClassType AdvChoiceButtonGroup AdvChoiceButtonGroup AdvChoiceButtonGroup Pointer
    // 030 ProduceTitle                             000186697E60 ModelClassType AdvTitle AdvTitle AdvTitle Pointer
    // 038 SkipGauge                                000186669240 ModelClassType ADVSkipGauge ADVSkipGauge ADVSkipGauge Pointer
    // 040 TapRecognizeLayerPrefab                  00018661F280 ModelClassType TapRecognizeLayer TapRecognizeLayer TapRecognizeLayer Pointer
    // 048 TapStatusHandler                         0001866802E0 ModelClassType TapStatusHandler TapStatusHandler TapStatusHandler Pointer
    // 050 ScenarioManager                          0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 058 AdvScenarioInfo                          0001866EF2B0 ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer
    // 060 AndroidBackKeyDisableScope               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 068 TapRecognizeLayer                        00018661F280 ModelClassType TapRecognizeLayer TapRecognizeLayer TapRecognizeLayer Pointer
    public partial class ADVUI
    {
        public ADVMenu?                                 Menu                                    { get; set; }
        public AdvChoiceButtonGroup?                    Choice                                  { get; set; }
        public AdvTitle?                                ProduceTitle                            { get; set; }
        public ADVSkipGauge?                            SkipGauge                               { get; set; }
        public TapRecognizeLayer?                       TapRecognizeLayerPrefab                 { get; set; }
        public TapStatusHandler?                        TapStatusHandler                        { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public IAdvScenarioInfo?                        AdvScenarioInfo                         { get; set; }
        public IDisposable?                             AndroidBackKeyDisableScope              { get; set; }
        public TapRecognizeLayer?                       TapRecognizeLayer                       { get; set; }

        public static ADVUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVUI();

            value.Menu                                      = GetObject<ADVMenu>(new IntPtr(p + 0x020), ReversePrism.DataModels.ADVMenu.FromPointer); // 027006604C98 0x20 Menu                        ( 000186668AF0 ModelClassType ADVMenu ADVMenu ADVMenu Pointer )
            value.Choice                                    = GetObject<AdvChoiceButtonGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.AdvChoiceButtonGroup.FromPointer); // 027006604CB8 0x28 Choice                      ( 000186693AA0 ModelClassType AdvChoiceButtonGroup AdvChoiceButtonGroup AdvChoiceButtonGroup Pointer )
            value.ProduceTitle                              = GetObject<AdvTitle>(new IntPtr(p + 0x030), ReversePrism.DataModels.AdvTitle.FromPointer); // 027006604CD8 0x30 ProduceTitle                ( 000186697E60 ModelClassType AdvTitle AdvTitle AdvTitle Pointer )
            value.SkipGauge                                 = GetObject<ADVSkipGauge>(new IntPtr(p + 0x038), ReversePrism.DataModels.ADVSkipGauge.FromPointer); // 027006604CF8 0x38 SkipGauge                   ( 000186669240 ModelClassType ADVSkipGauge ADVSkipGauge ADVSkipGauge Pointer )
            value.TapRecognizeLayerPrefab                   = GetObject<TapRecognizeLayer>(new IntPtr(p + 0x040), ReversePrism.DataModels.TapRecognizeLayer.FromPointer); // 027006604D18 0x40 TapRecognizeLayerPrefab     ( 00018661F280 ModelClassType TapRecognizeLayer TapRecognizeLayer TapRecognizeLayer Pointer )
            value.TapStatusHandler                          = GetObject<TapStatusHandler>(new IntPtr(p + 0x048), ReversePrism.DataModels.TapStatusHandler.FromPointer); // 027006604D38 0x48 TapStatusHandler            ( 0001866802E0 ModelClassType TapStatusHandler TapStatusHandler TapStatusHandler Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x050), ReversePrism.DataModels.ScenarioManager.FromPointer); // 027006604D58 0x50 ScenarioManager             ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.AdvScenarioInfo                           = GetObject<IAdvScenarioInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.IAdvScenarioInfo.FromPointer); // 027006604D78 0x58 AdvScenarioInfo             ( 0001866EF2B0 ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer )
            value.AndroidBackKeyDisableScope                = GetObject<IDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDisposable.FromPointer); // 027006604D98 0x60 AndroidBackKeyDisableScope  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.TapRecognizeLayer                         = GetObject<TapRecognizeLayer>(new IntPtr(p + 0x068), ReversePrism.DataModels.TapRecognizeLayer.FromPointer); // 027006604DB8 0x68 TapRecognizeLayer           ( 00018661F280 ModelClassType TapRecognizeLayer TapRecognizeLayer TapRecognizeLayer Pointer )

            return value;
        }
    }
}
