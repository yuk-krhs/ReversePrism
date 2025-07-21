using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType string string string String
    // 018 NickName                                 ModelPrimitiveType string string string String
    // 020 DisplayName                              ModelPrimitiveType string string string String
    // 028 Grade                                    ModelPrimitiveType string string string String
    // 030 Age                                      ModelPrimitiveType string string string String
    // 038 AboutMe                                  ModelPrimitiveType string string string String
    // 040 Birthday                                 ModelPrimitiveType string string string String
    // 048 BloodType                                ModelPrimitiveType string string string String
    // 050 ChannelUserId                            ModelPrimitiveType string string string String
    // 058 ClientUserId                             ModelPrimitiveType string string string String
    // 060 Gender                                   ModelPrimitiveType string string string String
    // 068 HasApp                                   ModelPrimitiveType bool bool bool Bool
    // 070 ProfileUrl                               ModelPrimitiveType string string string String
    // 078 ThumbnailUrl                             ModelPrimitiveType string string string String
    // 080 ThumbnailUrlSmall                        ModelPrimitiveType string string string String
    // 088 ThumbnailUrlLarge                        ModelPrimitiveType string string string String
    // 090 ThumbnailUrlHuge                         ModelPrimitiveType string string string String
    // 098 UserType                                 ModelPrimitiveType string string string String
    // 0A0 Addresses                                ModelClassType Address Address Address Pointer
    public partial class PeopleItem : DataModel
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
            var value   = new PeopleItem() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType string string string String )
            value.NickName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 NickName                    ( ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x020)); // 0x20 DisplayName                 ( ModelPrimitiveType string string string String )
            value.Grade                                     = GetString(new IntPtr(p + 0x028)); // 0x28 Grade                       ( ModelPrimitiveType string string string String )
            value.Age                                       = GetString(new IntPtr(p + 0x030)); // 0x30 Age                         ( ModelPrimitiveType string string string String )
            value.AboutMe                                   = GetString(new IntPtr(p + 0x038)); // 0x38 AboutMe                     ( ModelPrimitiveType string string string String )
            value.Birthday                                  = GetString(new IntPtr(p + 0x040)); // 0x40 Birthday                    ( ModelPrimitiveType string string string String )
            value.BloodType                                 = GetString(new IntPtr(p + 0x048)); // 0x48 BloodType                   ( ModelPrimitiveType string string string String )
            value.ChannelUserId                             = GetString(new IntPtr(p + 0x050)); // 0x50 ChannelUserId               ( ModelPrimitiveType string string string String )
            value.ClientUserId                              = GetString(new IntPtr(p + 0x058)); // 0x58 ClientUserId                ( ModelPrimitiveType string string string String )
            value.Gender                                    = GetString(new IntPtr(p + 0x060)); // 0x60 Gender                      ( ModelPrimitiveType string string string String )
            value.HasApp                                    = GetBool(new IntPtr(p + 0x068)); // 0x68 HasApp                      ( ModelPrimitiveType bool bool bool Bool )
            value.ProfileUrl                                = GetString(new IntPtr(p + 0x070)); // 0x70 ProfileUrl                  ( ModelPrimitiveType string string string String )
            value.ThumbnailUrl                              = GetString(new IntPtr(p + 0x078)); // 0x78 ThumbnailUrl                ( ModelPrimitiveType string string string String )
            value.ThumbnailUrlSmall                         = GetString(new IntPtr(p + 0x080)); // 0x80 ThumbnailUrlSmall           ( ModelPrimitiveType string string string String )
            value.ThumbnailUrlLarge                         = GetString(new IntPtr(p + 0x088)); // 0x88 ThumbnailUrlLarge           ( ModelPrimitiveType string string string String )
            value.ThumbnailUrlHuge                          = GetString(new IntPtr(p + 0x090)); // 0x90 ThumbnailUrlHuge            ( ModelPrimitiveType string string string String )
            value.UserType                                  = GetString(new IntPtr(p + 0x098)); // 0x98 UserType                    ( ModelPrimitiveType string string string String )
            value.Addresses                                 = GetObject<Address>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Address.FromPointer); // 0xA0 Addresses                   ( ModelClassType Address Address Address Pointer )

            return value;
        }
    }
}
