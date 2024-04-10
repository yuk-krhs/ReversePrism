using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScenarioId                               0001866C4FD0 ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 018 ViewStack                                000185CC58D8 ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer
    // 020 NextViewType                             0001866936B0 ModelClassType Type Type Type Pointer
    // 028 AdditionalUnitIdols                      000185CAF458 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 030 OnUIControlLazyTask                      0001866F6520 ModelClassType AsyncLazy AsyncLazy AsyncLazy Pointer
    // 038 UIInitializer                            00018666A120 ModelClassType ADVUIInitializer ADVUIInitializer ADVUIInitializer Pointer
    // 040 IsContinueBGM                            0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 041 IsNoVoice                                0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 048 <OnAdvEnd>k__BackingField                Action`2<ScenarioID, ScenarioManager> IL2CPP_TYPE_GENERICINST
    public partial class ViewScenarioParameter : DataModel
    {
        public ScenarioID?                              ScenarioId                              { get; set; }
        public List<ViewValue>?                         ViewStack                               { get; set; }
        public Type?                                    NextViewType                            { get; set; }
        public List<UnitIdol>?                          AdditionalUnitIdols                     { get; set; }
        public AsyncLazy?                               OnUIControlLazyTask                     { get; set; }
        public ADVUIInitializer?                        UIInitializer                           { get; set; }
        public bool                                     IsContinueBGM                           { get; set; }
        public bool                                     IsNoVoice                               { get; set; }

        public static ViewScenarioParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewScenarioParameter() { Pointer= p0 };

            value.ScenarioId                                = GetObject<ScenarioID>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScenarioID.FromPointer); // 024665E68598 0x10 ScenarioId                  ( 0001866C4FD0 ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.ViewStack                                 = GetObjectList<ViewValue>(new IntPtr(p + 0x018), ReversePrism.DataModels.ViewValue.FromPointer); // 024665E685B8 0x18 ViewStack                   ( 000185CC58D8 ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer )
            value.NextViewType                              = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 024665E685D8 0x20 NextViewType                ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.AdditionalUnitIdols                       = GetObjectList<UnitIdol>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnitIdol.FromPointer); // 024665E685F8 0x28 AdditionalUnitIdols         ( 000185CAF458 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.OnUIControlLazyTask                       = GetObject<AsyncLazy>(new IntPtr(p + 0x030), ReversePrism.DataModels.AsyncLazy.FromPointer); // 024665E68618 0x30 OnUIControlLazyTask         ( 0001866F6520 ModelClassType AsyncLazy AsyncLazy AsyncLazy Pointer )
            value.UIInitializer                             = GetObject<ADVUIInitializer>(new IntPtr(p + 0x038), ReversePrism.DataModels.ADVUIInitializer.FromPointer); // 024665E68638 0x38 UIInitializer               ( 00018666A120 ModelClassType ADVUIInitializer ADVUIInitializer ADVUIInitializer Pointer )
            value.IsContinueBGM                             = GetBool(new IntPtr(p + 0x040)); // 024665E68658 0x40 IsContinueBGM               ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsNoVoice                                 = GetBool(new IntPtr(p + 0x041)); // 024665E68678 0x41 IsNoVoice                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
