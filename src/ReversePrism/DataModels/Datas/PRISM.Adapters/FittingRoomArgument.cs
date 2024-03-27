using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedCharacterInfoId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 OrderedCostumeSetId                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 OrderedCostumeId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C OrderedHairstyleId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 OrderedGlassId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 OrderedEarringId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 OrderedMakeupId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class FittingRoomArgument
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
            var value   = new FittingRoomArgument();

            value.SelectedCharacterInfoId                   = GetInt32(new IntPtr(p + 0x010)); // 0270D6273F20 0x10 SelectedCharacterInfoId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OrderedCostumeSetId                       = GetInt32(new IntPtr(p + 0x014)); // 0270D6273F40 0x14 OrderedCostumeSetId         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OrderedCostumeId                          = GetInt32(new IntPtr(p + 0x018)); // 0270D6273F60 0x18 OrderedCostumeId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OrderedHairstyleId                        = GetInt32(new IntPtr(p + 0x01C)); // 0270D6273F80 0x1C OrderedHairstyleId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OrderedGlassId                            = GetInt32(new IntPtr(p + 0x020)); // 0270D6273FA0 0x20 OrderedGlassId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OrderedEarringId                          = GetInt32(new IntPtr(p + 0x024)); // 0270D6273FC0 0x24 OrderedEarringId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OrderedMakeupId                           = GetInt32(new IntPtr(p + 0x028)); // 0270D6273FE0 0x28 OrderedMakeupId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
