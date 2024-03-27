using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 List                                     000186592230 ModelClassType IList IList IList Pointer
    public partial class ReadOnlyList
    {
        public IList?                                   List                                    { get; set; }

        public static ReadOnlyList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadOnlyList();

            value.List                                      = GetObject<IList>(new IntPtr(p + 0x010), ReversePrism.DataModels.IList.FromPointer); // 0270D7B6BAB8 0x10 List                        ( 000186592230 ModelClassType IList IList IList Pointer )

            return value;
        }
    }
}
