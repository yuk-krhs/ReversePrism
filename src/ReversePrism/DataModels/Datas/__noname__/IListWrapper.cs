using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 List                                     000186591B20 ModelClassType IList IList IList Pointer
    public partial class IListWrapper : DataModel
    {
        public IList?                                   List                                    { get; set; }

        public static IListWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IListWrapper() { Pointer= p0 };

            value.List                                      = GetObject<IList>(new IntPtr(p + 0x028), ReversePrism.DataModels.IList.FromPointer); // 024666DD37D8 0x28 List                        ( 000186591B20 ModelClassType IList IList IList Pointer )

            return value;
        }
    }
}
