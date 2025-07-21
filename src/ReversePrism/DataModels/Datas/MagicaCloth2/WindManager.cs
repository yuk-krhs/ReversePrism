using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Flag_Valid                               int IL2CPP_TYPE_I4
    // 000 Flag_Enable                              int IL2CPP_TYPE_I4
    // 000 Flag_Addition                            int IL2CPP_TYPE_I4
    // 010 windDataArray                            ExNativeArray`1<WindData> IL2CPP_TYPE_GENERICINST
    // 018 IsValid                                  ModelPrimitiveType bool bool bool Bool
    // 020 windZoneDict                             Dictionary`2<int, MagicaWindZone> IL2CPP_TYPE_GENERICINST
    public partial class WindManager : DataModel
    {
        public bool                                     IsValid                                 { get; set; }

        public static WindManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WindManager() { Pointer= p0 };

            value.IsValid                                   = GetBool(new IntPtr(p + 0x018)); // 0x18 IsValid                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
