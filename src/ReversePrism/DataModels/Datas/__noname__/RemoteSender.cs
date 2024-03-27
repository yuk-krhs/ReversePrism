using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SenderId                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Layouts                                  000185B8E660 ModelEnumListType InternedString[] InternedString[] List<InternedString> Pointer
    // 020 Devices                                  000185CBE028 ModelEnumListType RemoteInputDevice[] RemoteInputDevice[] List<RemoteInputDevice> Pointer
    public partial class RemoteSender
    {
        public int                                      SenderId                                { get; set; }
        public List<InternedString>?                    Layouts                                 { get; set; }
        public List<RemoteInputDevice>?                 Devices                                 { get; set; }

        public static RemoteSender? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemoteSender();

            value.SenderId                                  = GetInt32(new IntPtr(p + 0x010)); // 0270D7718C78 0x10 SenderId                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Layouts                                   = GetEnumList<InternedString>(new IntPtr(p + 0x018)); // 0270D7718C98 0x18 Layouts                     ( 000185B8E660 ModelEnumListType InternedString[] InternedString[] List<InternedString> Pointer )
            value.Devices                                   = GetEnumList<RemoteInputDevice>(new IntPtr(p + 0x020)); // 0270D7718CB8 0x20 Devices                     ( 000185CBE028 ModelEnumListType RemoteInputDevice[] RemoteInputDevice[] List<RemoteInputDevice> Pointer )

            return value;
        }
    }
}
