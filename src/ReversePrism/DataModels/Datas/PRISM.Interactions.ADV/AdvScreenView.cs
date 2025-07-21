using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AdvTitle                                 ModelClassType AdvTitleView AdvTitleView AdvTitleView Pointer
    // 028 AdvMenu                                  ModelClassType AdvMenuView AdvMenuView AdvMenuView Pointer
    // 030 AdvSkipGauge                             ModelClassType AdvSkipGaugeView AdvSkipGaugeView AdvSkipGaugeView Pointer
    // 038 AdvChoiceButtonGroup                     ModelClassType AdvChoiceButtonGroup AdvChoiceButtonGroup AdvChoiceButtonGroup Pointer
    // 040 TapRecognizeLayerPrefab                  ModelClassType TapRecognizeLayer TapRecognizeLayer TapRecognizeLayer Pointer
    // 048 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 050 BackKeyObservable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 058 TapRecognizeLayer                        ModelClassType TapRecognizeLayer TapRecognizeLayer TapRecognizeLayer Pointer
    // 060 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 068 onTapped                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 070 onTerminated                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class AdvScreenView : DataModel
    {
        public AdvTitleView?                            AdvTitle                                { get; set; }
        public AdvMenuView?                             AdvMenu                                 { get; set; }
        public AdvSkipGaugeView?                        AdvSkipGauge                            { get; set; }
        public AdvChoiceButtonGroup?                    AdvChoiceButtonGroup                    { get; set; }
        public TapRecognizeLayer?                       TapRecognizeLayerPrefab                 { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public IDisposable?                             BackKeyObservable                       { get; set; }
        public TapRecognizeLayer?                       TapRecognizeLayer                       { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static AdvScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvScreenView() { Pointer= p0 };

            value.AdvTitle                                  = GetObject<AdvTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdvTitleView.FromPointer); // 0x20 AdvTitle                    ( ModelClassType AdvTitleView AdvTitleView AdvTitleView Pointer )
            value.AdvMenu                                   = GetObject<AdvMenuView>(new IntPtr(p + 0x028), ReversePrism.DataModels.AdvMenuView.FromPointer); // 0x28 AdvMenu                     ( ModelClassType AdvMenuView AdvMenuView AdvMenuView Pointer )
            value.AdvSkipGauge                              = GetObject<AdvSkipGaugeView>(new IntPtr(p + 0x030), ReversePrism.DataModels.AdvSkipGaugeView.FromPointer); // 0x30 AdvSkipGauge                ( ModelClassType AdvSkipGaugeView AdvSkipGaugeView AdvSkipGaugeView Pointer )
            value.AdvChoiceButtonGroup                      = GetObject<AdvChoiceButtonGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.AdvChoiceButtonGroup.FromPointer); // 0x38 AdvChoiceButtonGroup        ( ModelClassType AdvChoiceButtonGroup AdvChoiceButtonGroup AdvChoiceButtonGroup Pointer )
            value.TapRecognizeLayerPrefab                   = GetObject<TapRecognizeLayer>(new IntPtr(p + 0x040), ReversePrism.DataModels.TapRecognizeLayer.FromPointer); // 0x40 TapRecognizeLayerPrefab     ( ModelClassType TapRecognizeLayer TapRecognizeLayer TapRecognizeLayer Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0x48 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.BackKeyObservable                         = GetObject<IDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.IDisposable.FromPointer); // 0x50 BackKeyObservable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.TapRecognizeLayer                         = GetObject<TapRecognizeLayer>(new IntPtr(p + 0x058), ReversePrism.DataModels.TapRecognizeLayer.FromPointer); // 0x58 TapRecognizeLayer           ( ModelClassType TapRecognizeLayer TapRecognizeLayer TapRecognizeLayer Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x60 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
