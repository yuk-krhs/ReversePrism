using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ButtonList                               000185CCBFF8 ModelClassListType List`1<AdvChoiceButton> List`1<AdvChoiceButton> List<AdvChoiceButton> Pointer
    // 028 FourChoiceButtonsIndices                 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 030 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 onChoiceStart                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 onChoiceFinish                           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 050 ScenarioManager                          0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 058 IsSelected                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class AdvChoiceButtonGroup
    {
        public List<AdvChoiceButton>?                   ButtonList                              { get; set; }
        public List<int>?                               FourChoiceButtonsIndices                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public bool                                     IsSelected                              { get; set; }

        public static AdvChoiceButtonGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvChoiceButtonGroup();

            value.ButtonList                                = GetObjectList<AdvChoiceButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdvChoiceButton.FromPointer); // 0270D5DB3528 0x20 ButtonList                  ( 000185CCBFF8 ModelClassListType List`1<AdvChoiceButton> List`1<AdvChoiceButton> List<AdvChoiceButton> Pointer )
            value.FourChoiceButtonsIndices                  = GetInt32List(new IntPtr(p + 0x028)); // 0270D5DB3548 0x28 FourChoiceButtonsIndices    ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D5DB3568 0x30 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x048), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5DB35C8 0x48 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x050), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0270D5DB35E8 0x50 ScenarioManager             ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.IsSelected                                = GetBool(new IntPtr(p + 0x058)); // 0270D5DB3608 0x58 IsSelected                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
