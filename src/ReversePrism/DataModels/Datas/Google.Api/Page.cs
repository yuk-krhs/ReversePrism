using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Page> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     ModelPrimitiveType string string string String
    // 000 ContentFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Content                                  ModelPrimitiveType string string string String
    // 000 SubpagesFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_subpages_codec                 FieldCodec`1<Page> IL2CPP_TYPE_GENERICINST
    // 028 Subpages                                 ModelClassListType RepeatedField`1<Page> RepeatedField`1<Page> List<Page> Pointer
    public partial class Page : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   Content                                 { get; set; }
        public List<Page>?                              Subpages                                { get; set; }

        public static Page? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Page() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.Content                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Content                     ( ModelPrimitiveType string string string String )
            value.Subpages                                  = GetObjectList<Page>(new IntPtr(p + 0x028), ReversePrism.DataModels.Page.FromPointer); // 0x28 Subpages                    ( ModelClassListType RepeatedField`1<Page> RepeatedField`1<Page> List<Page> Pointer )

            return value;
        }
    }
}
