using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 _object                                  Nullable`1<LocalDefinition> IL2CPP_TYPE_GENERICINST
    // 030 Field                                    000186573870 ModelClassType FieldInfo FieldInfo FieldInfo Pointer
    public partial class FieldByRefUpdater : DataModel
    {
        public FieldInfo?                               Field                                   { get; set; }

        public static FieldByRefUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldByRefUpdater() { Pointer= p0 };

            value.Field                                     = GetObject<FieldInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.FieldInfo.FromPointer); // 02466A0705F8 0x30 Field                       ( 000186573870 ModelClassType FieldInfo FieldInfo FieldInfo Pointer )

            return value;
        }
    }
}
