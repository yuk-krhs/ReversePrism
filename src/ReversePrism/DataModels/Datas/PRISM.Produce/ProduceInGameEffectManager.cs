using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EffectGroups                             ModelClassListType List`1<ProduceInGameEffectGroup> List`1<ProduceInGameEffectGroup> List<ProduceInGameEffectGroup> Pointer
    // 018 effectsFromType                          ListWithKey`2<ProduceInGameEffectType, ProduceInGameEffect> IL2CPP_TYPE_GENERICINST
    // 020 onAddEffect                              Subject`1<ProduceInGameEffect> IL2CPP_TYPE_GENERICINST
    // 028 onRemoveEffect                           Subject`1<ProduceInGameEffect> IL2CPP_TYPE_GENERICINST
    // 030 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 onTimeUpdateRemoveEffect                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 onUpdateEffectGroup                      Subject`1<IReadOnlyList`1<ProduceInGameEffectGroup>> IL2CPP_TYPE_GENERICINST
    // 048 onUpdateEffectGroupDuration              Subject`1<IReadOnlyList`1<ProduceInGameEffectGroup>> IL2CPP_TYPE_GENERICINST
    public partial class ProduceInGameEffectManager : DataModel
    {
        public List<ProduceInGameEffectGroup>?          EffectGroups                            { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static ProduceInGameEffectManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceInGameEffectManager() { Pointer= p0 };

            value.EffectGroups                              = GetObjectList<ProduceInGameEffectGroup>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceInGameEffectGroup.FromPointer); // 0x10 EffectGroups                ( ModelClassListType List`1<ProduceInGameEffectGroup> List`1<ProduceInGameEffectGroup> List<ProduceInGameEffectGroup> Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
