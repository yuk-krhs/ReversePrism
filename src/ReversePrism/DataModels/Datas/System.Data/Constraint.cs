using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SchemaName                               ModelPrimitiveType string string string String
    // 018 InCollection                             ModelPrimitiveType bool bool bool Bool
    // 020 DataSet                                  ModelClassType DataSet DataSet DataSet Pointer
    // 028 Name                                     ModelPrimitiveType string string string String
    // 030 ExtendedProperties                       ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer
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

            value.SchemaName                                = GetString(new IntPtr(p + 0x010)); // 0x10 SchemaName                  ( ModelPrimitiveType string string string String )
            value.InCollection                              = GetBool(new IntPtr(p + 0x018)); // 0x18 InCollection                ( ModelPrimitiveType bool bool bool Bool )
            value.DataSet                                   = GetObject<DataSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataSet.FromPointer); // 0x20 DataSet                     ( ModelClassType DataSet DataSet DataSet Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Name                        ( ModelPrimitiveType string string string String )
            value.ExtendedProperties                        = GetObject<PropertyCollection>(new IntPtr(p + 0x030), ReversePrism.DataModels.PropertyCollection.FromPointer); // 0x30 ExtendedProperties          ( ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer )

            return value;
        }
    }
}
