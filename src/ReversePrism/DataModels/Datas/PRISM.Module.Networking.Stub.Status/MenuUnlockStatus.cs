using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MenuUnlockStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MenuTypeFieldNumber                      int IL2CPP_TYPE_I4
    // 018 MenuType                                 ModelEnumType MenuType MenuType MenuType Int32
    // 000 IsUnlockedFieldNumber                    int IL2CPP_TYPE_I4
    // 01C IsUnlocked                               ModelPrimitiveType bool bool bool Bool
    public partial class MenuUnlockStatus : DataModel
    {
        public MenuType                                 MenuType                                { get; set; }
        public bool                                     IsUnlocked                              { get; set; }

        public static MenuUnlockStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MenuUnlockStatus() { Pointer= p0 };

            value.MenuType                                  = (MenuType)GetInt32(new IntPtr(p + 0x018)); // 0x18 MenuType                    ( ModelEnumType MenuType MenuType MenuType Int32 )
            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsUnlocked                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
