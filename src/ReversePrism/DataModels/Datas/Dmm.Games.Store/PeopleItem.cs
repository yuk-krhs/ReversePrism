using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001866722E0 ModelPrimitiveType string string string String
    // 018 NickName                                 0001866722E0 ModelPrimitiveType string string string String
    // 020 DisplayName                              0001866722E0 ModelPrimitiveType string string string String
    // 028 Grade                                    0001866722E0 ModelPrimitiveType string string string String
    // 030 Age                                      0001866722E0 ModelPrimitiveType string string string String
    // 038 AboutMe                                  0001866722E0 ModelPrimitiveType string string string String
    // 040 Birthday                                 0001866722E0 ModelPrimitiveType string string string String
    // 048 BloodType                                0001866722E0 ModelPrimitiveType string string string String
    // 050 ChannelUserId                            0001866722E0 ModelPrimitiveType string string string String
    // 058 ClientUserId                             0001866722E0 ModelPrimitiveType string string string String
    // 060 Gender                                   0001866722E0 ModelPrimitiveType string string string String
    // 068 HasApp                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 070 ProfileUrl                               0001866722E0 ModelPrimitiveType string string string String
    // 078 ThumbnailUrl                             0001866722E0 ModelPrimitiveType string string string String
    // 080 ThumbnailUrlSmall                        0001866722E0 ModelPrimitiveType string string string String
    // 088 ThumbnailUrlLarge                        0001866722E0 ModelPrimitiveType string string string String
    // 090 ThumbnailUrlHuge                         0001866722E0 ModelPrimitiveType string string string String
    // 098 UserType                                 0001866722E0 ModelPrimitiveType string string string String
    // 0A0 Addresses                                00018668CD70 ModelClassType Address Address Address Pointer
    public partial class PeopleItem
    {
        public string                                   Id                                      { get; set; }
        public string                                   NickName                                { get; set; }
        public string                                   DisplayName                             { get; set; }
        public string                                   Grade                                   { get; set; }
        public string                                   Age                                     { get; set; }
        public string                                   AboutMe                                 { get; set; }
        public string                                   Birthday                                { get; set; }
        public string                                   BloodType                               { get; set; }
        public string                                   ChannelUserId                           { get; set; }
        public string                                   ClientUserId                            { get; set; }
        public string                                   Gender                                  { get; set; }
        public bool                                     HasApp                                  { get; set; }
        public string                                   ProfileUrl                              { get; set; }
        public string                                   ThumbnailUrl                            { get; set; }
        public string                                   ThumbnailUrlSmall                       { get; set; }
        public string                                   ThumbnailUrlLarge                       { get; set; }
        public string                                   ThumbnailUrlHuge                        { get; set; }
        public string                                   UserType                                { get; set; }
        public Address?                                 Addresses                               { get; set; }

        public static PeopleItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PeopleItem();

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 0270DB4C45E8 0x10 Id                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.NickName                                  = GetString(new IntPtr(p + 0x018)); // 0270DB4C4608 0x18 NickName                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x020)); // 0270DB4C4628 0x20 DisplayName                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Grade                                     = GetString(new IntPtr(p + 0x028)); // 0270DB4C4648 0x28 Grade                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Age                                       = GetString(new IntPtr(p + 0x030)); // 0270DB4C4668 0x30 Age                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AboutMe                                   = GetString(new IntPtr(p + 0x038)); // 0270DB4C4688 0x38 AboutMe                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Birthday                                  = GetString(new IntPtr(p + 0x040)); // 0270DB4C46A8 0x40 Birthday                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.BloodType                                 = GetString(new IntPtr(p + 0x048)); // 0270DB4C46C8 0x48 BloodType                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ChannelUserId                             = GetString(new IntPtr(p + 0x050)); // 0270DB4C46E8 0x50 ChannelUserId               ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ClientUserId                              = GetString(new IntPtr(p + 0x058)); // 0270DB4C4708 0x58 ClientUserId                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Gender                                    = GetString(new IntPtr(p + 0x060)); // 0270DB4C4728 0x60 Gender                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.HasApp                                    = GetBool(new IntPtr(p + 0x068)); // 0270DB4C4748 0x68 HasApp                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ProfileUrl                                = GetString(new IntPtr(p + 0x070)); // 0270DB4C4768 0x70 ProfileUrl                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ThumbnailUrl                              = GetString(new IntPtr(p + 0x078)); // 0270DB4C4788 0x78 ThumbnailUrl                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ThumbnailUrlSmall                         = GetString(new IntPtr(p + 0x080)); // 0270DB4C47A8 0x80 ThumbnailUrlSmall           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ThumbnailUrlLarge                         = GetString(new IntPtr(p + 0x088)); // 0270DB4C47C8 0x88 ThumbnailUrlLarge           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ThumbnailUrlHuge                          = GetString(new IntPtr(p + 0x090)); // 0270DB4C47E8 0x90 ThumbnailUrlHuge            ( 0001866722E0 ModelPrimitiveType string string string String )
            value.UserType                                  = GetString(new IntPtr(p + 0x098)); // 0270DB4C4808 0x98 UserType                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Addresses                                 = GetObject<Address>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Address.FromPointer); // 0270DB4C4828 0xA0 Addresses                   ( 00018668CD70 ModelClassType Address Address Address Pointer )

            return value;
        }
    }
}
