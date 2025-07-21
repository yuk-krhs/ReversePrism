using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SenderId                                 ModelPrimitiveType int int int Int32
    // 018 Layouts                                  ModelEnumListType InternedString[] InternedString[] List<InternedString> Pointer
    // 020 Devices                                  ModelEnumListType RemoteInputDevice[] RemoteInputDevice[] List<RemoteInputDevice> Pointer
    public partial class RemoteSender : DataModel
    {
        public int                                      SenderId                                { get; set; }
        public List<InternedString>?                    Layouts                                 { get; set; }
        public List<RemoteInputDevice>?                 Devices                                 { get; set; }

        public static RemoteSender? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemoteSender() { Pointer= p0 };

            value.SenderId                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 SenderId                    ( ModelPrimitiveType int int int Int32 )
            value.Layouts                                   = GetEnumList<InternedString>(new IntPtr(p + 0x018)); // 0x18 Layouts                     ( ModelEnumListType InternedString[] InternedString[] List<InternedString> Pointer )
            value.Devices                                   = GetEnumList<RemoteInputDevice>(new IntPtr(p + 0x020)); // 0x20 Devices                     ( ModelEnumListType RemoteInputDevice[] RemoteInputDevice[] List<RemoteInputDevice> Pointer )

            return value;
        }
    }
}
