using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Next                                     000186649310 ModelClassType MonoListItem MonoListItem MonoListItem Pointer
    // 018 data                                     <object> IL2CPP_TYPE_OBJECT
    public partial class MonoListItem : DataModel
    {
        public MonoListItem?                            Next                                    { get; set; }

        public static MonoListItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoListItem() { Pointer= p0 };

            value.Next                                      = GetObject<MonoListItem>(new IntPtr(p + 0x010), ReversePrism.DataModels.MonoListItem.FromPointer); // 024666AC8708 0x10 Next                        ( 000186649310 ModelClassType MonoListItem MonoListItem MonoListItem Pointer )

            return value;
        }
    }
}
