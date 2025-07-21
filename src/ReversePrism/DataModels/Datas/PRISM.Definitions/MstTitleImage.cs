using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 018 ImageKey                                 ModelPrimitiveType string string string String
    // 020 BeginDate                                ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 EndDate                                  ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class MstTitleImage : DataModel
    {
        public int                                      Id                                      { get; set; }
        public string                                   ImageKey                                { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }

        public static MstTitleImage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstTitleImage() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.ImageKey                                  = GetString(new IntPtr(p + 0x018)); // 0x18 ImageKey                    ( ModelPrimitiveType string string string String )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x020)); // 0x20 BeginDate                   ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x028)); // 0x28 EndDate                     ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
