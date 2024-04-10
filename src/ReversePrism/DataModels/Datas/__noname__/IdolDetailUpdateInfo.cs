using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <OnChangeFavoriteMark>k__BackingField    IObservable`1<IProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 018 <OnChangeIdolSkill>k__BackingField       IObservable`1<IProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 020 <DeferTask>k__BackingField               UniTask`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class IdolDetailUpdateInfo : DataModel
    {

        public static IdolDetailUpdateInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolDetailUpdateInfo() { Pointer= p0 };


            return value;
        }
    }
}
