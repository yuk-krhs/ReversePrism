using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enabled                                  ModelPrimitiveType bool bool bool Bool
    // 018 Id                                       ModelPrimitiveType string string string String
    // 020 Version                                  ModelPrimitiveType string string string String
    // 028 CustomData                               ModelPrimitiveType string string string String
    public partial class ProviderData : DataModel
    {
        public bool                                     Enabled                                 { get; set; }
        public string                                   Id                                      { get; set; }
        public string                                   Version                                 { get; set; }
        public string                                   CustomData                              { get; set; }

        public static ProviderData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProviderData() { Pointer= p0 };

            value.Enabled                                   = GetBool(new IntPtr(p + 0x010)); // 0x10 Enabled                     ( ModelPrimitiveType bool bool bool Bool )
            value.Id                                        = GetString(new IntPtr(p + 0x018)); // 0x18 Id                          ( ModelPrimitiveType string string string String )
            value.Version                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Version                     ( ModelPrimitiveType string string string String )
            value.CustomData                                = GetString(new IntPtr(p + 0x028)); // 0x28 CustomData                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
