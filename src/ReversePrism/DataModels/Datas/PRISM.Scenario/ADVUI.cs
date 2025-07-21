using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Menu                                     ModelClassType AdvMenuView AdvMenuView AdvMenuView Pointer
    // 028 Choice                                   ModelClassType AdvChoiceButtonGroup AdvChoiceButtonGroup AdvChoiceButtonGroup Pointer
    // 030 ProduceTitle                             ModelClassType AdvTitle AdvTitle AdvTitle Pointer
    // 038 SkipGauge                                ModelClassType ADVSkipGauge ADVSkipGauge ADVSkipGauge Pointer
    // 040 TapRecognizeLayerPrefab                  ModelClassType TapRecognizeLayer TapRecognizeLayer TapRecognizeLayer Pointer
    // 048 TapStatusHandler                         ModelClassType TapStatusHandler TapStatusHandler TapStatusHandler Pointer
    // 050 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 058 AdvScenarioInfo                          ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer
    // 060 AndroidBackKeyDisableScope               ModelClassType IDisposable IDisposable IDisposable Pointer
    // 068 TapRecognizeLayer                        ModelClassType TapRecognizeLayer TapRecognizeLayer TapRecognizeLayer Pointer
    // 070 AdvMenuPresenter                         ModelClassType AdvMenuPresenter AdvMenuPresenter AdvMenuPresenter Pointer
    // 078 ResourceTag                              ModelPrimitiveType string string string String
    public partial class ADVUI : DataModel
    {
        public AdvMenuView?                             Menu                                    { get; set; }
        public AdvChoiceButtonGroup?                    Choice                                  { get; set; }
        public AdvTitle?                                ProduceTitle                            { get; set; }
        public ADVSkipGauge?                            SkipGauge                               { get; set; }
        public TapRecognizeLayer?                       TapRecognizeLayerPrefab                 { get; set; }
        public TapStatusHandler?                        TapStatusHandler                        { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public IAdvScenarioInfo?                        AdvScenarioInfo                         { get; set; }
        public IDisposable?                             AndroidBackKeyDisableScope              { get; set; }
        public TapRecognizeLayer?                       TapRecognizeLayer                       { get; set; }
        public AdvMenuPresenter?                        AdvMenuPresenter                        { get; set; }
        public string                                   ResourceTag                             { get; set; }

        public static ADVUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVUI() { Pointer= p0 };

            value.Menu                                      = GetObject<AdvMenuView>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdvMenuView.FromPointer); // 0x20 Menu                        ( ModelClassType AdvMenuView AdvMenuView AdvMenuView Pointer )
            value.Choice                                    = GetObject<AdvChoiceButtonGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.AdvChoiceButtonGroup.FromPointer); // 0x28 Choice                      ( ModelClassType AdvChoiceButtonGroup AdvChoiceButtonGroup AdvChoiceButtonGroup Pointer )
            value.ProduceTitle                              = GetObject<AdvTitle>(new IntPtr(p + 0x030), ReversePrism.DataModels.AdvTitle.FromPointer); // 0x30 ProduceTitle                ( ModelClassType AdvTitle AdvTitle AdvTitle Pointer )
            value.SkipGauge                                 = GetObject<ADVSkipGauge>(new IntPtr(p + 0x038), ReversePrism.DataModels.ADVSkipGauge.FromPointer); // 0x38 SkipGauge                   ( ModelClassType ADVSkipGauge ADVSkipGauge ADVSkipGauge Pointer )
            value.TapRecognizeLayerPrefab                   = GetObject<TapRecognizeLayer>(new IntPtr(p + 0x040), ReversePrism.DataModels.TapRecognizeLayer.FromPointer); // 0x40 TapRecognizeLayerPrefab     ( ModelClassType TapRecognizeLayer TapRecognizeLayer TapRecognizeLayer Pointer )
            value.TapStatusHandler                          = GetObject<TapStatusHandler>(new IntPtr(p + 0x048), ReversePrism.DataModels.TapStatusHandler.FromPointer); // 0x48 TapStatusHandler            ( ModelClassType TapStatusHandler TapStatusHandler TapStatusHandler Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x050), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0x50 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.AdvScenarioInfo                           = GetObject<IAdvScenarioInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.IAdvScenarioInfo.FromPointer); // 0x58 AdvScenarioInfo             ( ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer )
            value.AndroidBackKeyDisableScope                = GetObject<IDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDisposable.FromPointer); // 0x60 AndroidBackKeyDisableScope  ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.TapRecognizeLayer                         = GetObject<TapRecognizeLayer>(new IntPtr(p + 0x068), ReversePrism.DataModels.TapRecognizeLayer.FromPointer); // 0x68 TapRecognizeLayer           ( ModelClassType TapRecognizeLayer TapRecognizeLayer TapRecognizeLayer Pointer )
            value.AdvMenuPresenter                          = GetObject<AdvMenuPresenter>(new IntPtr(p + 0x070), ReversePrism.DataModels.AdvMenuPresenter.FromPointer); // 0x70 AdvMenuPresenter            ( ModelClassType AdvMenuPresenter AdvMenuPresenter AdvMenuPresenter Pointer )
            value.ResourceTag                               = GetString(new IntPtr(p + 0x078)); // 0x78 ResourceTag                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
