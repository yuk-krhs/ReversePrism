using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Name                                     000186671BA0 ModelPrimitiveType string string string String
    // 020 Found                                    000186595210 ModelPrimitiveType bool bool bool Bool
    // 028 Column                                   000186675CB0 ModelClassType DataColumn DataColumn DataColumn Pointer
    public partial class NameNode
    {
        public string                                   Name                                    { get; set; }
        public bool                                     Found                                   { get; set; }
        public DataColumn?                              Column                                  { get; set; }

        public static NameNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameNode();

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270D892D500 0x18 Name                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Found                                     = GetBool(new IntPtr(p + 0x020)); // 0270D892D520 0x20 Found                       ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Column                                    = GetObject<DataColumn>(new IntPtr(p + 0x028), ReversePrism.DataModels.DataColumn.FromPointer); // 0270D892D540 0x28 Column                      ( 000186675CB0 ModelClassType DataColumn DataColumn DataColumn Pointer )

            return value;
        }
    }
}
