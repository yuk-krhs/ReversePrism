using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Type                                     ModelPrimitiveType string string string String
    // 020 Id                                       ModelPrimitiveType string string string String
    // 028 ExpectedControlType                      ModelPrimitiveType string string string String
    // 030 Processors                               ModelPrimitiveType string string string String
    // 038 Interactions                             ModelPrimitiveType string string string String
    // 040 InitialStateCheck                        ModelPrimitiveType bool bool bool Bool
    public partial class WriteActionJson : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   Type                                    { get; set; }
        public string                                   Id                                      { get; set; }
        public string                                   ExpectedControlType                     { get; set; }
        public string                                   Processors                              { get; set; }
        public string                                   Interactions                            { get; set; }
        public bool                                     InitialStateCheck                       { get; set; }

        public static WriteActionJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WriteActionJson() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Type                        ( ModelPrimitiveType string string string String )
            value.Id                                        = GetString(new IntPtr(p + 0x020)); // 0x20 Id                          ( ModelPrimitiveType string string string String )
            value.ExpectedControlType                       = GetString(new IntPtr(p + 0x028)); // 0x28 ExpectedControlType         ( ModelPrimitiveType string string string String )
            value.Processors                                = GetString(new IntPtr(p + 0x030)); // 0x30 Processors                  ( ModelPrimitiveType string string string String )
            value.Interactions                              = GetString(new IntPtr(p + 0x038)); // 0x38 Interactions                ( ModelPrimitiveType string string string String )
            value.InitialStateCheck                         = GetBool(new IntPtr(p + 0x040)); // 0x40 InitialStateCheck           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
