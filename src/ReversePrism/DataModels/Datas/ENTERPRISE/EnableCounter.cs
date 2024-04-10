using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 enabled                                  ReactiveProperty`1<bool> IL2CPP_TYPE_GENERICINST
    // 018 Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 tempDisableObjects                       HashSet`1<TempDisableObject> IL2CPP_TYPE_GENERICINST
    // 028 Logger                                   00018654E3B0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
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

            value.Count                                     = GetInt32(new IntPtr(p + 0x018)); // 024660B94020 0x18 Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Logger                                    = GetObject<CategorizedLogger>(new IntPtr(p + 0x028), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 024660B94060 0x28 Logger                      ( 00018654E3B0 ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )

            return value;
        }
    }
}
