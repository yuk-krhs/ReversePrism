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
    public partial class LegacyFittingRoomParameter : DataModel
    {
        public int                                      SelectedCharacterInfoId                 { get; set; }
        public int                                      OrderedCostumeSetId                     { get; set; }
        public int                                      OrderedCostumeId                        { get; set; }
        public int                                      OrderedHairstyleId                      { get; set; }
        public int                                      OrderedGlassId                          { get; set; }
        public int                                      OrderedEarringId                        { get; set; }
        public int                                      OrderedMakeupId                         { get; set; }

        public static LegacyFittingRoomParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyFittingRoomParameter() { Pointer= p0 };

            value.SelectedCharacterInfoId                   = GetInt32(new IntPtr(p + 0x010)); // 024664F588B0 0x10 SelectedCharacterInfoId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OrderedCostumeSetId                       = GetInt32(new IntPtr(p + 0x014)); // 024664F588D0 0x14 OrderedCostumeSetId         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OrderedCostumeId                          = GetInt32(new IntPtr(p + 0x018)); // 024664F588F0 0x18 OrderedCostumeId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OrderedHairstyleId                        = GetInt32(new IntPtr(p + 0x01C)); // 024664F58910 0x1C OrderedHairstyleId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OrderedGlassId                            = GetInt32(new IntPtr(p + 0x020)); // 024664F58930 0x20 OrderedGlassId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OrderedEarringId                          = GetInt32(new IntPtr(p + 0x024)); // 024664F58950 0x24 OrderedEarringId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OrderedMakeupId                           = GetInt32(new IntPtr(p + 0x028)); // 024664F58970 0x28 OrderedMakeupId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
