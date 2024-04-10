using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Help> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LinksFieldNumber                         int IL2CPP_TYPE_I4
    // 008 _repeated_links_codec                    FieldCodec`1<Link> IL2CPP_TYPE_GENERICINST
    // 018 Links                                    000185CF9008 ModelClassListType RepeatedField`1<Link> RepeatedField`1<Link> List<Link> Pointer
    public partial class Help : DataModel
    {
        public List<Link>?                              Links                                   { get; set; }

        public static Help? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Help() { Pointer= p0 };

            value.Links                                     = GetObjectList<Link>(new IntPtr(p + 0x018), ReversePrism.DataModels.Link.FromPointer); // 02466A74FFE0 0x18 Links                       ( 000185CF9008 ModelClassListType RepeatedField`1<Link> RepeatedField`1<Link> List<Link> Pointer )

            return value;
        }
    }
}
