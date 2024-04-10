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
    public partial class Constraint : DataModel
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
            var value   = new Constraint() { Pointer= p0 };

            value.SchemaName                                = GetString(new IntPtr(p + 0x010)); // 0246688F8398 0x10 SchemaName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.InCollection                              = GetBool(new IntPtr(p + 0x018)); // 0246688F83B8 0x18 InCollection                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DataSet                                   = GetObject<DataSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataSet.FromPointer); // 0246688F83D8 0x20 DataSet                     ( 000186680790 ModelClassType DataSet DataSet DataSet Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0246688F83F8 0x28 Name                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ExtendedProperties                        = GetObject<PropertyCollection>(new IntPtr(p + 0x030), ReversePrism.DataModels.PropertyCollection.FromPointer); // 0246688F8418 0x30 ExtendedProperties          ( 0001865D2A60 ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer )

            return value;
        }
    }
}
