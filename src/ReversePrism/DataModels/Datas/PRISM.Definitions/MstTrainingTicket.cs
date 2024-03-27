using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 ProductType                              0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Exp                                      0001865F4260 ModelPrimitiveType int int int Int32
    // 01C PresentFilterType                        0001865F4260 ModelPrimitiveType int int int Int32
    // 020 ItemNaviType                             0001865F4260 ModelPrimitiveType int int int Int32
    // 024 SortId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 028 ReleaseDate                              0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class MstTrainingTicket
    {
        public int                                      Id                                      { get; set; }
        public int                                      ProductType                             { get; set; }
        public int                                      Exp                                     { get; set; }
        public int                                      PresentFilterType                       { get; set; }
        public int                                      ItemNaviType                            { get; set; }
        public int                                      SortId                                  { get; set; }
        public DateTime                                 ReleaseDate                             { get; set; }

        public static MstTrainingTicket? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstTrainingTicket();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 027004642CC8 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ProductType                               = GetInt32(new IntPtr(p + 0x014)); // 027004642CE8 0x14 ProductType                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Exp                                       = GetInt32(new IntPtr(p + 0x018)); // 027004642D08 0x18 Exp                         ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.PresentFilterType                         = GetInt32(new IntPtr(p + 0x01C)); // 027004642D28 0x1C PresentFilterType           ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ItemNaviType                              = GetInt32(new IntPtr(p + 0x020)); // 027004642D48 0x20 ItemNaviType                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x024)); // 027004642D68 0x24 SortId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x028)); // 027004642D88 0x28 ReleaseDate                 ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
