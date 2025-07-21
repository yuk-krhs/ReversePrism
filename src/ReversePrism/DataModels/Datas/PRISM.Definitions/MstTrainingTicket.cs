using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 ProductType                              ModelPrimitiveType int int int Int32
    // 018 Exp                                      ModelPrimitiveType int int int Int32
    // 01C PresentFilterType                        ModelPrimitiveType int int int Int32
    // 020 ItemNaviType                             ModelPrimitiveType int int int Int32
    // 024 SortId                                   ModelPrimitiveType int int int Int32
    // 028 ReleaseDate                              ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class MstTrainingTicket : DataModel
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
            var value   = new MstTrainingTicket() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.ProductType                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 ProductType                 ( ModelPrimitiveType int int int Int32 )
            value.Exp                                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 Exp                         ( ModelPrimitiveType int int int Int32 )
            value.PresentFilterType                         = GetInt32(new IntPtr(p + 0x01C)); // 0x1C PresentFilterType           ( ModelPrimitiveType int int int Int32 )
            value.ItemNaviType                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 ItemNaviType                ( ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x024)); // 0x24 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x028)); // 0x28 ReleaseDate                 ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
