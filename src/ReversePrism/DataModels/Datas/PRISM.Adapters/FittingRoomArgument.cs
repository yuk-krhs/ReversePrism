using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedCharacterInfoId                  ModelPrimitiveType int int int Int32
    // 014 OrderedCostumeSetId                      ModelPrimitiveType int int int Int32
    // 018 OrderedCostumeId                         ModelPrimitiveType int int int Int32
    // 01C OrderedHairstyleId                       ModelPrimitiveType int int int Int32
    // 020 OrderedGlassId                           ModelPrimitiveType int int int Int32
    // 024 OrderedEarringId                         ModelPrimitiveType int int int Int32
    // 028 OrderedMakeupId                          ModelPrimitiveType int int int Int32
    public partial class FittingRoomArgument : DataModel
    {
        public int                                      SelectedCharacterInfoId                 { get; set; }
        public int                                      OrderedCostumeSetId                     { get; set; }
        public int                                      OrderedCostumeId                        { get; set; }
        public int                                      OrderedHairstyleId                      { get; set; }
        public int                                      OrderedGlassId                          { get; set; }
        public int                                      OrderedEarringId                        { get; set; }
        public int                                      OrderedMakeupId                         { get; set; }

        public static FittingRoomArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FittingRoomArgument() { Pointer= p0 };

            value.SelectedCharacterInfoId                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 SelectedCharacterInfoId     ( ModelPrimitiveType int int int Int32 )
            value.OrderedCostumeSetId                       = GetInt32(new IntPtr(p + 0x014)); // 0x14 OrderedCostumeSetId         ( ModelPrimitiveType int int int Int32 )
            value.OrderedCostumeId                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 OrderedCostumeId            ( ModelPrimitiveType int int int Int32 )
            value.OrderedHairstyleId                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C OrderedHairstyleId          ( ModelPrimitiveType int int int Int32 )
            value.OrderedGlassId                            = GetInt32(new IntPtr(p + 0x020)); // 0x20 OrderedGlassId              ( ModelPrimitiveType int int int Int32 )
            value.OrderedEarringId                          = GetInt32(new IntPtr(p + 0x024)); // 0x24 OrderedEarringId            ( ModelPrimitiveType int int int Int32 )
            value.OrderedMakeupId                           = GetInt32(new IntPtr(p + 0x028)); // 0x28 OrderedMakeupId             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
