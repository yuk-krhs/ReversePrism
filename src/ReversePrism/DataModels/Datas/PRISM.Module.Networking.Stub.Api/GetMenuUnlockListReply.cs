using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetMenuUnlockListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MenuUnlockListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_menuUnlockList_codec           FieldCodec`1<MenuUnlockStatus> IL2CPP_TYPE_GENERICINST
    // 018 MenuUnlockList                           000185CE5E58 ModelClassListType RepeatedField`1<MenuUnlockStatus> RepeatedField`1<MenuUnlockStatus> List<MenuUnlockStatus> Pointer
    public partial class GetMenuUnlockListReply : DataModel
    {
        public List<MenuUnlockStatus>?                  MenuUnlockList                          { get; set; }

        public static GetMenuUnlockListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetMenuUnlockListReply() { Pointer= p0 };

            value.MenuUnlockList                            = GetObjectList<MenuUnlockStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.MenuUnlockStatus.FromPointer); // 024660B2C790 0x18 MenuUnlockList              ( 000185CE5E58 ModelClassListType RepeatedField`1<MenuUnlockStatus> RepeatedField`1<MenuUnlockStatus> List<MenuUnlockStatus> Pointer )

            return value;
        }
    }
}
