using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SchemaName                               000186671910 ModelPrimitiveType string string string String
    // 018 InCollection                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 DataSet                                  000186680790 ModelClassType DataSet DataSet DataSet Pointer
    // 028 Name                                     000186671BA0 ModelPrimitiveType string string string String
    // 030 ExtendedProperties                       0001865D2A60 ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer
    public partial class Constraint
    {
        public string                                   SchemaName                              { get; set; }
        public bool                                     InCollection                            { get; set; }
        public DataSet?                                 DataSet                                 { get; set; }
        public string                                   Name                                    { get; set; }
        public PropertyCollection?                      ExtendedProperties                      { get; set; }

        public static Constraint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Constraint();

            value.SchemaName                                = GetString(new IntPtr(p + 0x010)); // 0270D889BE80 0x10 SchemaName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.InCollection                              = GetBool(new IntPtr(p + 0x018)); // 0270D889BEA0 0x18 InCollection                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DataSet                                   = GetObject<DataSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataSet.FromPointer); // 0270D889BEC0 0x20 DataSet                     ( 000186680790 ModelClassType DataSet DataSet DataSet Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0270D889BEE0 0x28 Name                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ExtendedProperties                        = GetObject<PropertyCollection>(new IntPtr(p + 0x030), ReversePrism.DataModels.PropertyCollection.FromPointer); // 0270D889BF00 0x30 ExtendedProperties          ( 0001865D2A60 ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer )

            return value;
        }
    }
}
