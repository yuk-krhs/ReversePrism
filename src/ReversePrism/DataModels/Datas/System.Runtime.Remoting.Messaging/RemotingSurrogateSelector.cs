using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_cachedTypeObjRef                       Type IL2CPP_TYPE_CLASS
    // 008 _objRefSurrogate                         ObjRefSurrogate IL2CPP_TYPE_CLASS
    // 010 ObjRemotingSurrogate                     00018664BBF0 ModelClassType RemotingSurrogate RemotingSurrogate RemotingSurrogate Pointer
    // 010 Next                                     0001865E4F40 ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer
    public partial class RemotingSurrogateSelector : DataModel
    {
        public RemotingSurrogate?                       ObjRemotingSurrogate                    { get; set; }
        public ISurrogateSelector?                      Next                                    { get; set; }

        public static RemotingSurrogateSelector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemotingSurrogateSelector() { Pointer= p0 };

            value.ObjRemotingSurrogate                      = GetObject<RemotingSurrogate>(new IntPtr(p + 0x010), ReversePrism.DataModels.RemotingSurrogate.FromPointer); // 024666C64408 0x10 ObjRemotingSurrogate        ( 00018664BBF0 ModelClassType RemotingSurrogate RemotingSurrogate RemotingSurrogate Pointer )
            value.Next                                      = GetObject<ISurrogateSelector>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISurrogateSelector.FromPointer); // 024666C64428 0x10 Next                        ( 0001865E4F40 ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer )

            return value;
        }
    }
}
