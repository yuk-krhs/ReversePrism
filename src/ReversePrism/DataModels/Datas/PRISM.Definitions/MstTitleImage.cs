using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ImageKey                                 000186672F10 ModelPrimitiveType string string string String
    // 020 BeginDate                                0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 EndDate                                  0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
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

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A4611240 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ImageKey                                  = GetString(new IntPtr(p + 0x018)); // 0245A4611260 0x18 ImageKey                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x020)); // 0245A4611280 0x20 BeginDate                   ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x028)); // 0245A46112A0 0x28 EndDate                     ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
