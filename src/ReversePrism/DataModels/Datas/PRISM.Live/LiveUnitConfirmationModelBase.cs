using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 UnitMaxCount                             int IL2CPP_TYPE_I4
    // 010 CostumeService                           000186715F00 ModelClassType ICachedCostumeService ICachedCostumeService ICachedCostumeService Pointer
    // 018 onChangeCameraModeSetting                Subject`1<LiveCameraModeSetting> IL2CPP_TYPE_GENERICINST
    // 020 SpecialUnitCount                         0001865F3220 ModelPrimitiveType int int int Int32
    // 028 MusicData                                000186665050 ModelClassType MusicData MusicData MusicData Pointer
    public partial class LiveUnitConfirmationModelBase
    {
        public ICachedCostumeService?                   CostumeService                          { get; set; }
        public int                                      SpecialUnitCount                        { get; set; }
        public MusicData?                               MusicData                               { get; set; }

        public static LiveUnitConfirmationModelBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationModelBase();

            value.CostumeService                            = GetObject<ICachedCostumeService>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICachedCostumeService.FromPointer); // 0270D510EDB8 0x10 CostumeService              ( 000186715F00 ModelClassType ICachedCostumeService ICachedCostumeService ICachedCostumeService Pointer )
            value.SpecialUnitCount                          = GetInt32(new IntPtr(p + 0x020)); // 0270D510EDF8 0x20 SpecialUnitCount            ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.MusicData                                 = GetObject<MusicData>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicData.FromPointer); // 0270D510EE18 0x28 MusicData                   ( 000186665050 ModelClassType MusicData MusicData MusicData Pointer )

            return value;
        }
    }
}
