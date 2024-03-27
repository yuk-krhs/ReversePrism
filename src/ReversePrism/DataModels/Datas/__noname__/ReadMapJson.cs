using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Id                                       0001866722E0 ModelPrimitiveType string string string String
    // 020 Actions                                  000185CBC648 ModelEnumListType ReadActionJson[] ReadActionJson[] List<ReadActionJson> Pointer
    // 028 Bindings                                 000185CBC468 ModelEnumListType BindingJson[] BindingJson[] List<BindingJson> Pointer
    public partial class ReadMapJson
    {
        public string                                   Name                                    { get; set; }
        public string                                   Id                                      { get; set; }
        public List<ReadActionJson>?                    Actions                                 { get; set; }
        public List<BindingJson>?                       Bindings                                { get; set; }

        public static ReadMapJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadMapJson();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D763DDD0 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Id                                        = GetString(new IntPtr(p + 0x018)); // 0270D763DDF0 0x18 Id                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Actions                                   = GetEnumList<ReadActionJson>(new IntPtr(p + 0x020)); // 0270D763DE10 0x20 Actions                     ( 000185CBC648 ModelEnumListType ReadActionJson[] ReadActionJson[] List<ReadActionJson> Pointer )
            value.Bindings                                  = GetEnumList<BindingJson>(new IntPtr(p + 0x028)); // 0270D763DE30 0x28 Bindings                    ( 000185CBC468 ModelEnumListType BindingJson[] BindingJson[] List<BindingJson> Pointer )

            return value;
        }
    }
}
