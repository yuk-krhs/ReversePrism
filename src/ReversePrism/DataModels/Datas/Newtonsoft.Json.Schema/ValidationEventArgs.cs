using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ex                                       00018675B950 ModelClassType JsonSchemaException JsonSchemaException JsonSchemaException Pointer
    public partial class ValidationEventArgs : DataModel
    {
        public JsonSchemaException?                     Ex                                      { get; set; }

        public static ValidationEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValidationEventArgs() { Pointer= p0 };

            value.Ex                                        = GetObject<JsonSchemaException>(new IntPtr(p + 0x010), ReversePrism.DataModels.JsonSchemaException.FromPointer); // 0246687ED320 0x10 Ex                          ( 00018675B950 ModelClassType JsonSchemaException JsonSchemaException JsonSchemaException Pointer )

            return value;
        }
    }
}
