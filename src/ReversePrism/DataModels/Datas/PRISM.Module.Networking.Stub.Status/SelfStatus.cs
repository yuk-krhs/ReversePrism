using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastLoginDate                            000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 FirstTimeDate                            000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<SelfStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 038 UserId                                   000186671910 ModelPrimitiveType string string string String
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 040 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 LastLoginDateFieldNumber                 int IL2CPP_TYPE_I4
    // 048 _LastLoginDate                           000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 IsTutorialFinishedFieldNumber            int IL2CPP_TYPE_I4
    // 050 IsTutorialFinished                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 FirstTimeDateFieldNumber                 int IL2CPP_TYPE_I4
    // 058 _FirstTimeDate                           000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 SearchIdFieldNumber                      int IL2CPP_TYPE_I4
    // 060 SearchId                                 000186671910 ModelPrimitiveType string string string String
    // 000 ConnectedProviderListFieldNumber         int IL2CPP_TYPE_I4
    // 008 _repeated_connectedProviderList_codec    FieldCodec`1<TransferProviderStatus> IL2CPP_TYPE_GENERICINST
    // 068 ConnectedProviderList                    000185CF5748 ModelClassListType RepeatedField`1<TransferProviderStatus> RepeatedField`1<TransferProviderStatus> List<TransferProviderStatus> Pointer
    // 000 AssetTagFieldNumber                      int IL2CPP_TYPE_I4
    // 070 AssetTag                                 000186671910 ModelPrimitiveType string string string String
    // 000 ProceededTutorialListFieldNumber         int IL2CPP_TYPE_I4
    // 010 _repeated_proceededTutorialList_codec    FieldCodec`1<TutorialStatus> IL2CPP_TYPE_GENERICINST
    // 078 ProceededTutorialList                    000185CF59A8 ModelClassListType RepeatedField`1<TutorialStatus> RepeatedField`1<TutorialStatus> List<TutorialStatus> Pointer
    public partial class SelfStatus : DataModel
    {
        public DateTime                                 LastLoginDate                           { get; set; }
        public DateTime                                 FirstTimeDate                           { get; set; }
        public string                                   UserId                                  { get; set; }
        public string                                   Name                                    { get; set; }
        public Timestamp?                               _LastLoginDate                          { get; set; }
        public bool                                     IsTutorialFinished                      { get; set; }
        public Timestamp?                               _FirstTimeDate                          { get; set; }
        public string                                   SearchId                                { get; set; }
        public List<TransferProviderStatus>?            ConnectedProviderList                   { get; set; }
        public string                                   AssetTag                                { get; set; }
        public List<TutorialStatus>?                    ProceededTutorialList                   { get; set; }

        public static SelfStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelfStatus() { Pointer= p0 };

            value.LastLoginDate                             = GetDateTime(new IntPtr(p + 0x010)); // 024660D600C8 0x10 LastLoginDate               ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.FirstTimeDate                             = GetDateTime(new IntPtr(p + 0x020)); // 024660D600E8 0x20 FirstTimeDate               ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.UserId                                    = GetString(new IntPtr(p + 0x038)); // 024660D60168 0x38 UserId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x040)); // 024660D601A8 0x40 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value._LastLoginDate                            = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 024660D601E8 0x48 _LastLoginDate              ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.IsTutorialFinished                        = GetBool(new IntPtr(p + 0x050)); // 024660D60228 0x50 IsTutorialFinished          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value._FirstTimeDate                            = GetObject<Timestamp>(new IntPtr(p + 0x058), ReversePrism.DataModels.Timestamp.FromPointer); // 024660D60268 0x58 _FirstTimeDate              ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.SearchId                                  = GetString(new IntPtr(p + 0x060)); // 024660D602A8 0x60 SearchId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.ConnectedProviderList                     = GetObjectList<TransferProviderStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.TransferProviderStatus.FromPointer); // 024660D60308 0x68 ConnectedProviderList       ( 000185CF5748 ModelClassListType RepeatedField`1<TransferProviderStatus> RepeatedField`1<TransferProviderStatus> List<TransferProviderStatus> Pointer )
            value.AssetTag                                  = GetString(new IntPtr(p + 0x070)); // 024660D60348 0x70 AssetTag                    ( 000186671910 ModelPrimitiveType string string string String )
            value.ProceededTutorialList                     = GetObjectList<TutorialStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.TutorialStatus.FromPointer); // 024660D603A8 0x78 ProceededTutorialList       ( 000185CF59A8 ModelClassListType RepeatedField`1<TutorialStatus> RepeatedField`1<TutorialStatus> List<TutorialStatus> Pointer )
            value.LastLoginDate                 = ToDateTime(value._LastLoginDate);
            value.FirstTimeDate                 = ToDateTime(value._FirstTimeDate);

            return value;
        }
    }
}
