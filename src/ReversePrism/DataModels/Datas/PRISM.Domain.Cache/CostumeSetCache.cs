using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 costumeSetMap                            Dictionary`2<int, ICostumeSetStatus> IL2CPP_TYPE_GENERICINST
    // 018 IsReady                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 <OnAddCostumeSet>k__BackingField         Subject`1<ValueTuple`2<int, ICostumeSetStatus>> IL2CPP_TYPE_GENERICINST
    public partial class CostumeSetCache : DataModel
    {
        public bool                                     IsReady                                 { get; set; }

        public static CostumeSetCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeSetCache() { Pointer= p0 };

            value.IsReady                                   = GetBool(new IntPtr(p + 0x018)); // 0245A4ADD120 0x18 IsReady                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
