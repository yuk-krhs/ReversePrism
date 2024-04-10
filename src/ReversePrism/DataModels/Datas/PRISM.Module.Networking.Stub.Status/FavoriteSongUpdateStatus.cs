using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FavoriteSongUpdateStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SlotFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Slot                                     00018655C790 ModelEnumType FavoriteSongSlot FavoriteSongSlot FavoriteSongSlot Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 IsActiveFieldNumber                      int IL2CPP_TYPE_I4
    // 028 IsActive                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class FavoriteSongUpdateStatus : DataModel
    {
        public FavoriteSongSlot                         Slot                                    { get; set; }
        public string                                   Name                                    { get; set; }
        public bool                                     IsActive                                { get; set; }

        public static FavoriteSongUpdateStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FavoriteSongUpdateStatus() { Pointer= p0 };

            value.Slot                                      = (FavoriteSongSlot)GetInt32(new IntPtr(p + 0x018)); // 0246612C4050 0x18 Slot                        ( 00018655C790 ModelEnumType FavoriteSongSlot FavoriteSongSlot FavoriteSongSlot Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0246612C4090 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x028)); // 0246612C40D0 0x28 IsActive                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
