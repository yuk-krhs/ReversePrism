using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CommonCategoryName                       string IL2CPP_TYPE_STRING
    // 000 IngameCategoryName                       string IL2CPP_TYPE_STRING
    // 000 OutgameCategoryName                      string IL2CPP_TYPE_STRING
    // 010 PropertyChanged                          0001865D1C20 ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer
    public partial class ProduceSrOption : DataModel
    {
        public PropertyChangedEventHandler?             PropertyChanged                         { get; set; }

        public static ProduceSrOption? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSrOption() { Pointer= p0 };

            value.PropertyChanged                           = GetObject<PropertyChangedEventHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.PropertyChangedEventHandler.FromPointer); // 024665D9DA98 0x10 PropertyChanged             ( 0001865D1C20 ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer )

            return value;
        }
    }
}
