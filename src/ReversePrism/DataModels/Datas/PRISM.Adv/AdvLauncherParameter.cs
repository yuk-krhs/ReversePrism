using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScenarioId                               ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 018 ViewStack                                ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer
    // 020 NextViewType                             ModelClassType Type Type Type Pointer
    // 028 AdditionalUnitIdols                      ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 030 OnUIControlLazyTask                      ModelClassType AsyncLazy AsyncLazy AsyncLazy Pointer
    // 038 AdvScreenViewModel                       ModelClassType AdvScreenViewModel AdvScreenViewModel AdvScreenViewModel Pointer
    // 040 IsContinueBGM                            ModelPrimitiveType bool bool bool Bool
    // 041 IsNoVoice                                ModelPrimitiveType bool bool bool Bool
    // 048 <OnAdvEnd>k__BackingField                Action`2<ScenarioID, ScenarioManager> IL2CPP_TYPE_GENERICINST
    // 050 FinishScenarioTcs                        ModelClassType UniTaskCompletionSource UniTaskCompletionSource UniTaskCompletionSource Pointer
    public partial class AdvLauncherParameter : DataModel
    {
        public ScenarioID?                              ScenarioId                              { get; set; }
        public List<ViewValue>?                         ViewStack                               { get; set; }
        public Type?                                    NextViewType                            { get; set; }
        public List<UnitIdol>?                          AdditionalUnitIdols                     { get; set; }
        public AsyncLazy?                               OnUIControlLazyTask                     { get; set; }
        public AdvScreenViewModel?                      AdvScreenViewModel                      { get; set; }
        public bool                                     IsContinueBGM                           { get; set; }
        public bool                                     IsNoVoice                               { get; set; }
        public UniTaskCompletionSource?                 FinishScenarioTcs                       { get; set; }

        public static AdvLauncherParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvLauncherParameter() { Pointer= p0 };

            value.ScenarioId                                = GetObject<ScenarioID>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScenarioID.FromPointer); // 0x10 ScenarioId                  ( ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.ViewStack                                 = GetObjectList<ViewValue>(new IntPtr(p + 0x018), ReversePrism.DataModels.ViewValue.FromPointer); // 0x18 ViewStack                   ( ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer )
            value.NextViewType                              = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 NextViewType                ( ModelClassType Type Type Type Pointer )
            value.AdditionalUnitIdols                       = GetObjectList<UnitIdol>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x28 AdditionalUnitIdols         ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.OnUIControlLazyTask                       = GetObject<AsyncLazy>(new IntPtr(p + 0x030), ReversePrism.DataModels.AsyncLazy.FromPointer); // 0x30 OnUIControlLazyTask         ( ModelClassType AsyncLazy AsyncLazy AsyncLazy Pointer )
            value.AdvScreenViewModel                        = GetObject<AdvScreenViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.AdvScreenViewModel.FromPointer); // 0x38 AdvScreenViewModel          ( ModelClassType AdvScreenViewModel AdvScreenViewModel AdvScreenViewModel Pointer )
            value.IsContinueBGM                             = GetBool(new IntPtr(p + 0x040)); // 0x40 IsContinueBGM               ( ModelPrimitiveType bool bool bool Bool )
            value.IsNoVoice                                 = GetBool(new IntPtr(p + 0x041)); // 0x41 IsNoVoice                   ( ModelPrimitiveType bool bool bool Bool )
            value.FinishScenarioTcs                         = GetObject<UniTaskCompletionSource>(new IntPtr(p + 0x050), ReversePrism.DataModels.UniTaskCompletionSource.FromPointer); // 0x50 FinishScenarioTcs           ( ModelClassType UniTaskCompletionSource UniTaskCompletionSource UniTaskCompletionSource Pointer )

            return value;
        }
    }
}
