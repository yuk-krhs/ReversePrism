using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Category                                 ModelPrimitiveType string string string String
    // 028 BodyParamType                            ModelEnumType BodyParamType BodyParamType BodyParamType Int32
    // 02C MinBodyParamValue                        ModelPrimitiveType float float float Single
    // 030 MaxBodyParamValue                        ModelPrimitiveType float float float Single
    // 038 Center                                   ModelClassType BodyParamVector3Property BodyParamVector3Property BodyParamVector3Property Pointer
    public partial class AMagicaBodyParamColliderController : DataModel
    {
        public string                                   Category                                { get; set; }
        public BodyParamType                            BodyParamType                           { get; set; }
        public float                                    MinBodyParamValue                       { get; set; }
        public float                                    MaxBodyParamValue                       { get; set; }
        public BodyParamVector3Property?                Center                                  { get; set; }

        public static AMagicaBodyParamColliderController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AMagicaBodyParamColliderController() { Pointer= p0 };

            value.Category                                  = GetString(new IntPtr(p + 0x020)); // 0x20 Category                    ( ModelPrimitiveType string string string String )
            value.BodyParamType                             = (BodyParamType)GetInt32(new IntPtr(p + 0x028)); // 0x28 BodyParamType               ( ModelEnumType BodyParamType BodyParamType BodyParamType Int32 )
            value.MinBodyParamValue                         = GetSingle(new IntPtr(p + 0x02C)); // 0x2C MinBodyParamValue           ( ModelPrimitiveType float float float Single )
            value.MaxBodyParamValue                         = GetSingle(new IntPtr(p + 0x030)); // 0x30 MaxBodyParamValue           ( ModelPrimitiveType float float float Single )
            value.Center                                    = GetObject<BodyParamVector3Property>(new IntPtr(p + 0x038), ReversePrism.DataModels.BodyParamVector3Property.FromPointer); // 0x38 Center                      ( ModelClassType BodyParamVector3Property BodyParamVector3Property BodyParamVector3Property Pointer )

            return value;
        }
    }
}
