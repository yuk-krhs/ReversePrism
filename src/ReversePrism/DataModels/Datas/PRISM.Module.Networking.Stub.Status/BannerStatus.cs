using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<BannerStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BannerIdFieldNumber                      int IL2CPP_TYPE_I4
    // 038 BannerId                                 000186671910 ModelPrimitiveType string string string String
    // 000 MstBannerGenreIdFieldNumber              int IL2CPP_TYPE_I4
    // 040 MstBannerGenreId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 BannerTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 044 BannerType                               00018673B240 ModelEnumType BannerType BannerType BannerType Int32
    // 000 DisplayPriorityFieldNumber               int IL2CPP_TYPE_I4
    // 048 DisplayPriority                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ImageUrlFieldNumber                      int IL2CPP_TYPE_I4
    // 050 ImageUrl                                 000186671910 ModelPrimitiveType string string string String
    // 000 ArticleIdFieldNumber                     int IL2CPP_TYPE_I4
    // 058 ArticleId                                000186671910 ModelPrimitiveType string string string String
    // 000 OpenUrlFieldNumber                       int IL2CPP_TYPE_I4
    // 060 OpenUrl                                  000186671910 ModelPrimitiveType string string string String
    // 000 TextFieldNumber                          int IL2CPP_TYPE_I4
    // 068 Text                                     000186671910 ModelPrimitiveType string string string String
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 070 _BeginDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 078 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 JumpFieldNumber                          int IL2CPP_TYPE_I4
    // 080 Jump                                     000186768670 ModelClassType JumpStatus JumpStatus JumpStatus Pointer
    public partial class BannerStatus
    {
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public string                                   BannerId                                { get; set; }
        public int                                      MstBannerGenreId                        { get; set; }
        public BannerType                               BannerType                              { get; set; }
        public int                                      DisplayPriority                         { get; set; }
        public string                                   ImageUrl                                { get; set; }
        public string                                   ArticleId                               { get; set; }
        public string                                   OpenUrl                                 { get; set; }
        public string                                   Text                                    { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public JumpStatus?                              Jump                                    { get; set; }

        public static BannerStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BannerStatus();

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0270D0B391B0 0x10 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0270D0B391D0 0x20 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.BannerId                                  = GetString(new IntPtr(p + 0x038)); // 0270D0B39250 0x38 BannerId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.MstBannerGenreId                          = GetInt32(new IntPtr(p + 0x040)); // 0270D0B39290 0x40 MstBannerGenreId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BannerType                                = (BannerType)GetInt32(new IntPtr(p + 0x044)); // 0270D0B392D0 0x44 BannerType                  ( 00018673B240 ModelEnumType BannerType BannerType BannerType Int32 )
            value.DisplayPriority                           = GetInt32(new IntPtr(p + 0x048)); // 0270D0B39310 0x48 DisplayPriority             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ImageUrl                                  = GetString(new IntPtr(p + 0x050)); // 0270D0B39350 0x50 ImageUrl                    ( 000186671910 ModelPrimitiveType string string string String )
            value.ArticleId                                 = GetString(new IntPtr(p + 0x058)); // 0270D0B39390 0x58 ArticleId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.OpenUrl                                   = GetString(new IntPtr(p + 0x060)); // 0270D0B393D0 0x60 OpenUrl                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Text                                      = GetString(new IntPtr(p + 0x068)); // 0270D0B39410 0x68 Text                        ( 000186671910 ModelPrimitiveType string string string String )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x070), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D0B39450 0x70 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x078), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D0B39490 0x78 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.Jump                                      = GetObject<JumpStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.JumpStatus.FromPointer); // 0270D0B394D0 0x80 Jump                        ( 000186768670 ModelClassType JumpStatus JumpStatus JumpStatus Pointer )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
