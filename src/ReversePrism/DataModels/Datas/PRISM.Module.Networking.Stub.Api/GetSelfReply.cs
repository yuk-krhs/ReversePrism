using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastLoginDate                            ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 FirstTimeDate                            ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 FullRecoverDate                          ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GetSelfReply> IL2CPP_TYPE_GENERICINST
    // 040 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 048 UserId                                   ModelPrimitiveType string string string String
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 050 Name                                     ModelPrimitiveType string string string String
    // 000 LastLoginDateFieldNumber                 int IL2CPP_TYPE_I4
    // 058 _LastLoginDate                           ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 IsTutorialFinishedFieldNumber            int IL2CPP_TYPE_I4
    // 060 IsTutorialFinished                       ModelPrimitiveType bool bool bool Bool
    // 000 FirstTimeDateFieldNumber                 int IL2CPP_TYPE_I4
    // 068 _FirstTimeDate                           ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 SearchIdFieldNumber                      int IL2CPP_TYPE_I4
    // 070 SearchId                                 ModelPrimitiveType string string string String
    // 000 MoneyFieldNumber                         int IL2CPP_TYPE_I4
    // 078 Money                                    ModelPrimitiveType int int int Int32
    // 000 MaxMoneyFieldNumber                      int IL2CPP_TYPE_I4
    // 07C MaxMoney                                 ModelPrimitiveType int int int Int32
    // 000 VitalityFieldNumber                      int IL2CPP_TYPE_I4
    // 080 Vitality                                 ModelPrimitiveType int int int Int32
    // 000 MaxVitalityFieldNumber                   int IL2CPP_TYPE_I4
    // 084 MaxVitality                              ModelPrimitiveType int int int Int32
    // 000 FullRecoverDateFieldNumber               int IL2CPP_TYPE_I4
    // 088 _FullRecoverDate                         ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 AutoRecoverIntervalFieldNumber           int IL2CPP_TYPE_I4
    // 090 AutoRecoverInterval                      ModelPrimitiveType int int int Int32
    // 000 ExpFieldNumber                           int IL2CPP_TYPE_I4
    // 094 Exp                                      ModelPrimitiveType int int int Int32
    // 000 NextExpFieldNumber                       int IL2CPP_TYPE_I4
    // 098 NextExp                                  ModelPrimitiveType int int int Int32
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 09C Level                                    ModelPrimitiveType int int int Int32
    // 000 MaxLevelFieldNumber                      int IL2CPP_TYPE_I4
    // 0A0 MaxLevel                                 ModelPrimitiveType int int int Int32
    // 000 ConnectedProviderListFieldNumber         int IL2CPP_TYPE_I4
    // 008 _repeated_connectedProviderList_codec    FieldCodec`1<TransferProviderStatus> IL2CPP_TYPE_GENERICINST
    // 0A8 ConnectedProviderList                    ModelClassListType RepeatedField`1<TransferProviderStatus> RepeatedField`1<TransferProviderStatus> List<TransferProviderStatus> Pointer
    // 000 AssetTagFieldNumber                      int IL2CPP_TYPE_I4
    // 0B0 AssetTag                                 ModelPrimitiveType string string string String
    public partial class GetSelfReply : DataModel
    {
        public DateTime                                 LastLoginDate                           { get; set; }
        public DateTime                                 FirstTimeDate                           { get; set; }
        public DateTime                                 FullRecoverDate                         { get; set; }
        public string                                   UserId                                  { get; set; }
        public string                                   Name                                    { get; set; }
        public Timestamp?                               _LastLoginDate                          { get; set; }
        public bool                                     IsTutorialFinished                      { get; set; }
        public Timestamp?                               _FirstTimeDate                          { get; set; }
        public string                                   SearchId                                { get; set; }
        public int                                      Money                                   { get; set; }
        public int                                      MaxMoney                                { get; set; }
        public int                                      Vitality                                { get; set; }
        public int                                      MaxVitality                             { get; set; }
        public Timestamp?                               _FullRecoverDate                        { get; set; }
        public int                                      AutoRecoverInterval                     { get; set; }
        public int                                      Exp                                     { get; set; }
        public int                                      NextExp                                 { get; set; }
        public int                                      Level                                   { get; set; }
        public int                                      MaxLevel                                { get; set; }
        public List<TransferProviderStatus>?            ConnectedProviderList                   { get; set; }
        public string                                   AssetTag                                { get; set; }

        public static GetSelfReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetSelfReply() { Pointer= p0 };

            value.LastLoginDate                             = GetDateTime(new IntPtr(p + 0x010)); // 0x10 LastLoginDate               ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.FirstTimeDate                             = GetDateTime(new IntPtr(p + 0x020)); // 0x20 FirstTimeDate               ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.FullRecoverDate                           = GetDateTime(new IntPtr(p + 0x030)); // 0x30 FullRecoverDate             ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.UserId                                    = GetString(new IntPtr(p + 0x048)); // 0x48 UserId                      ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x050)); // 0x50 Name                        ( ModelPrimitiveType string string string String )
            value._LastLoginDate                            = GetObject<Timestamp>(new IntPtr(p + 0x058), ReversePrism.DataModels.Timestamp.FromPointer); // 0x58 _LastLoginDate              ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.IsTutorialFinished                        = GetBool(new IntPtr(p + 0x060)); // 0x60 IsTutorialFinished          ( ModelPrimitiveType bool bool bool Bool )
            value._FirstTimeDate                            = GetObject<Timestamp>(new IntPtr(p + 0x068), ReversePrism.DataModels.Timestamp.FromPointer); // 0x68 _FirstTimeDate              ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.SearchId                                  = GetString(new IntPtr(p + 0x070)); // 0x70 SearchId                    ( ModelPrimitiveType string string string String )
            value.Money                                     = GetInt32(new IntPtr(p + 0x078)); // 0x78 Money                       ( ModelPrimitiveType int int int Int32 )
            value.MaxMoney                                  = GetInt32(new IntPtr(p + 0x07C)); // 0x7C MaxMoney                    ( ModelPrimitiveType int int int Int32 )
            value.Vitality                                  = GetInt32(new IntPtr(p + 0x080)); // 0x80 Vitality                    ( ModelPrimitiveType int int int Int32 )
            value.MaxVitality                               = GetInt32(new IntPtr(p + 0x084)); // 0x84 MaxVitality                 ( ModelPrimitiveType int int int Int32 )
            value._FullRecoverDate                          = GetObject<Timestamp>(new IntPtr(p + 0x088), ReversePrism.DataModels.Timestamp.FromPointer); // 0x88 _FullRecoverDate            ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.AutoRecoverInterval                       = GetInt32(new IntPtr(p + 0x090)); // 0x90 AutoRecoverInterval         ( ModelPrimitiveType int int int Int32 )
            value.Exp                                       = GetInt32(new IntPtr(p + 0x094)); // 0x94 Exp                         ( ModelPrimitiveType int int int Int32 )
            value.NextExp                                   = GetInt32(new IntPtr(p + 0x098)); // 0x98 NextExp                     ( ModelPrimitiveType int int int Int32 )
            value.Level                                     = GetInt32(new IntPtr(p + 0x09C)); // 0x9C Level                       ( ModelPrimitiveType int int int Int32 )
            value.MaxLevel                                  = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 MaxLevel                    ( ModelPrimitiveType int int int Int32 )
            value.ConnectedProviderList                     = GetObjectList<TransferProviderStatus>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.TransferProviderStatus.FromPointer); // 0xA8 ConnectedProviderList       ( ModelClassListType RepeatedField`1<TransferProviderStatus> RepeatedField`1<TransferProviderStatus> List<TransferProviderStatus> Pointer )
            value.AssetTag                                  = GetString(new IntPtr(p + 0x0B0)); // 0xB0 AssetTag                    ( ModelPrimitiveType string string string String )
            value.LastLoginDate                 = ToDateTime(value._LastLoginDate);
            value.FirstTimeDate                 = ToDateTime(value._FirstTimeDate);
            value.FullRecoverDate               = ToDateTime(value._FullRecoverDate);

            return value;
        }
    }
}
