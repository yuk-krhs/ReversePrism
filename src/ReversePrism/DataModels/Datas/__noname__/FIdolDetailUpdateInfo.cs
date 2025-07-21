using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <OnChange>k__BackingField                IObservable`1<IFesIdolStatus> IL2CPP_TYPE_GENERICINST
    // 018 DeferTask                                ModelEnumType UniTask UniTask UniTask Int32
    public partial class FIdolDetailUpdateInfo : DataModel
    {
        public UniTask                                  DeferTask                               { get; set; }

        public static FIdolDetailUpdateInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FIdolDetailUpdateInfo() { Pointer= p0 };

            value.DeferTask                                 = (UniTask)GetInt32(new IntPtr(p + 0x018)); // 0x18 DeferTask                   ( ModelEnumType UniTask UniTask UniTask Int32 )

            return value;
        }
    }
}
