using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayUI                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 018 DisplayButtons                           000185D25748 ModelEnumListType List`1<ButtonType> List`1<ButtonType> List<ButtonType> Pointer
    public partial class DisplayUIInfo : DataModel
    {
        public GameObject?                              DisplayUI                               { get; set; }
        public List<ButtonType>?                        DisplayButtons                          { get; set; }

        public static DisplayUIInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DisplayUIInfo() { Pointer= p0 };

            value.DisplayUI                                 = GetObject<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 024665CBF650 0x10 DisplayUI                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.DisplayButtons                            = GetEnumList<ButtonType>(new IntPtr(p + 0x018)); // 024665CBF670 0x18 DisplayButtons              ( 000185D25748 ModelEnumListType List`1<ButtonType> List`1<ButtonType> List<ButtonType> Pointer )

            return value;
        }
    }
}
