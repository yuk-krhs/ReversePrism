using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Options                                000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 018 m_OnDropdown                             Action`2<int, string> IL2CPP_TYPE_GENERICINST
    // 020 ScrollPosition                           0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class UIFakeStoreDropdown : DataModel
    {
        public List<string>?                            M_Options                               { get; set; }
        public Vector2                                  ScrollPosition                          { get; set; }

        public static UIFakeStoreDropdown? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIFakeStoreDropdown() { Pointer= p0 };

            value.M_Options                                 = GetStringList(new IntPtr(p + 0x010)); // 0245A68DC2A0 0x10 M_Options                   ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.ScrollPosition                            = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0245A68DC2E0 0x20 ScrollPosition              ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
