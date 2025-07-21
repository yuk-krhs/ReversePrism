using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 enabled                                  ReactiveProperty`1<bool> IL2CPP_TYPE_GENERICINST
    // 018 Count                                    ModelPrimitiveType int int int Int32
    // 020 tempDisableObjects                       HashSet`1<TempDisableObject> IL2CPP_TYPE_GENERICINST
    // 028 Logger                                   ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    public partial class EnableCounter : DataModel
    {
        public int                                      Count                                   { get; set; }
        public CategorizedLogger?                       Logger                                  { get; set; }

        public static EnableCounter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnableCounter() { Pointer= p0 };

            value.Count                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Count                       ( ModelPrimitiveType int int int Int32 )
            value.Logger                                    = GetObject<CategorizedLogger>(new IntPtr(p + 0x028), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x28 Logger                      ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )

            return value;
        }
    }
}
