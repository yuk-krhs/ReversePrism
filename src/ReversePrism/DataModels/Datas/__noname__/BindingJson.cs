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
    // 020 Path                                     ModelPrimitiveType string string string String
    // 028 Interactions                             ModelPrimitiveType string string string String
    // 030 Processors                               ModelPrimitiveType string string string String
    // 038 Groups                                   ModelPrimitiveType string string string String
    // 040 Action                                   ModelPrimitiveType string string string String
    // 048 IsComposite                              ModelPrimitiveType bool bool bool Bool
    // 049 IsPartOfComposite                        ModelPrimitiveType bool bool bool Bool
    public partial class BindingJson : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   Id                                      { get; set; }
        public string                                   Path                                    { get; set; }
        public string                                   Interactions                            { get; set; }
        public string                                   Processors                              { get; set; }
        public string                                   Groups                                  { get; set; }
        public string                                   Action                                  { get; set; }
        public bool                                     IsComposite                             { get; set; }
        public bool                                     IsPartOfComposite                       { get; set; }

        public static BindingJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BindingJson() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Id                                        = GetString(new IntPtr(p + 0x018)); // 0x18 Id                          ( ModelPrimitiveType string string string String )
            value.Path                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Path                        ( ModelPrimitiveType string string string String )
            value.Interactions                              = GetString(new IntPtr(p + 0x028)); // 0x28 Interactions                ( ModelPrimitiveType string string string String )
            value.Processors                                = GetString(new IntPtr(p + 0x030)); // 0x30 Processors                  ( ModelPrimitiveType string string string String )
            value.Groups                                    = GetString(new IntPtr(p + 0x038)); // 0x38 Groups                      ( ModelPrimitiveType string string string String )
            value.Action                                    = GetString(new IntPtr(p + 0x040)); // 0x40 Action                      ( ModelPrimitiveType string string string String )
            value.IsComposite                               = GetBool(new IntPtr(p + 0x048)); // 0x48 IsComposite                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsPartOfComposite                         = GetBool(new IntPtr(p + 0x049)); // 0x49 IsPartOfComposite           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
