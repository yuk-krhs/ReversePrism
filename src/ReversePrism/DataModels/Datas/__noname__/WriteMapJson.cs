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
    // 020 Actions                                  000185CBCA98 ModelEnumListType WriteActionJson[] WriteActionJson[] List<WriteActionJson> Pointer
    // 028 Bindings                                 000185CBC468 ModelEnumListType BindingJson[] BindingJson[] List<BindingJson> Pointer
    public partial class WriteMapJson : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   Id                                      { get; set; }
        public List<WriteActionJson>?                   Actions                                 { get; set; }
        public List<BindingJson>?                       Bindings                                { get; set; }

        public static WriteMapJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WriteMapJson() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0246676AE320 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Id                                        = GetString(new IntPtr(p + 0x018)); // 0246676AE340 0x18 Id                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Actions                                   = GetEnumList<WriteActionJson>(new IntPtr(p + 0x020)); // 0246676AE360 0x20 Actions                     ( 000185CBCA98 ModelEnumListType WriteActionJson[] WriteActionJson[] List<WriteActionJson> Pointer )
            value.Bindings                                  = GetEnumList<BindingJson>(new IntPtr(p + 0x028)); // 0246676AE380 0x28 Bindings                    ( 000185CBC468 ModelEnumListType BindingJson[] BindingJson[] List<BindingJson> Pointer )

            return value;
        }
    }
}
