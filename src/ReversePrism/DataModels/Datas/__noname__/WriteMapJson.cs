using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Id                                       ModelPrimitiveType string string string String
    // 020 Actions                                  ModelEnumListType WriteActionJson[] WriteActionJson[] List<WriteActionJson> Pointer
    // 028 Bindings                                 ModelEnumListType BindingJson[] BindingJson[] List<BindingJson> Pointer
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

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Id                                        = GetString(new IntPtr(p + 0x018)); // 0x18 Id                          ( ModelPrimitiveType string string string String )
            value.Actions                                   = GetEnumList<WriteActionJson>(new IntPtr(p + 0x020)); // 0x20 Actions                     ( ModelEnumListType WriteActionJson[] WriteActionJson[] List<WriteActionJson> Pointer )
            value.Bindings                                  = GetEnumList<BindingJson>(new IntPtr(p + 0x028)); // 0x28 Bindings                    ( ModelEnumListType BindingJson[] BindingJson[] List<BindingJson> Pointer )

            return value;
        }
    }
}
