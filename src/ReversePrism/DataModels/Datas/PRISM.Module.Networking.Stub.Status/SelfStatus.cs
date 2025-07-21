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
    // 000 _parser                                  MessageParser`1<SelfStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 038 UserId                                   ModelPrimitiveType string string string String
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 040 Name                                     ModelPrimitiveType string string string String
    // 000 LastLoginDateFieldNumber                 int IL2CPP_TYPE_I4
    // 048 _LastLoginDate                           ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 IsTutorialFinishedFieldNumber            int IL2CPP_TYPE_I4
    // 050 IsTutorialFinished                       ModelPrimitiveType bool bool bool Bool
    // 000 FirstTimeDateFieldNumber                 int IL2CPP_TYPE_I4
    // 058 _FirstTimeDate                           ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 SearchIdFieldNumber                      int IL2CPP_TYPE_I4
    // 060 SearchId                                 ModelPrimitiveType string string string String
    // 000 ConnectedProviderListFieldNumber         int IL2CPP_TYPE_I4
    // 008 _repeated_connectedProviderList_codec    FieldCodec`1<TransferProviderStatus> IL2CPP_TYPE_GENERICINST
    // 068 ConnectedProviderList                    ModelClassListType RepeatedField`1<TransferProviderStatus> RepeatedField`1<TransferProviderStatus> List<TransferProviderStatus> Pointer
    // 000 AssetTagFieldNumber                      int IL2CPP_TYPE_I4
    // 070 AssetTag                                 ModelPrimitiveType string string string String
    // 000 ProceededTutorialListFieldNumber         int IL2CPP_TYPE_I4
    // 010 _repeated_proceededTutorialList_codec    FieldCodec`1<TutorialStatus> IL2CPP_TYPE_GENERICINST
    // 078 ProceededTutorialList                    ModelClassListType RepeatedField`1<TutorialStatus> RepeatedField`1<TutorialStatus> List<TutorialStatus> Pointer
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

            value.LastLoginDate                             = GetDateTime(new IntPtr(p + 0x010)); // 0x10 LastLoginDate               ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.FirstTimeDate                             = GetDateTime(new IntPtr(p + 0x020)); // 0x20 FirstTimeDate               ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.UserId                                    = GetString(new IntPtr(p + 0x038)); // 0x38 UserId                      ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x040)); // 0x40 Name                        ( ModelPrimitiveType string string string String )
            value._LastLoginDate                            = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 0x48 _LastLoginDate              ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.IsTutorialFinished                        = GetBool(new IntPtr(p + 0x050)); // 0x50 IsTutorialFinished          ( ModelPrimitiveType bool bool bool Bool )
            value._FirstTimeDate                            = GetObject<Timestamp>(new IntPtr(p + 0x058), ReversePrism.DataModels.Timestamp.FromPointer); // 0x58 _FirstTimeDate              ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.SearchId                                  = GetString(new IntPtr(p + 0x060)); // 0x60 SearchId                    ( ModelPrimitiveType string string string String )
            value.ConnectedProviderList                     = GetObjectList<TransferProviderStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.TransferProviderStatus.FromPointer); // 0x68 ConnectedProviderList       ( ModelClassListType RepeatedField`1<TransferProviderStatus> RepeatedField`1<TransferProviderStatus> List<TransferProviderStatus> Pointer )
            value.AssetTag                                  = GetString(new IntPtr(p + 0x070)); // 0x70 AssetTag                    ( ModelPrimitiveType string string string String )
            value.ProceededTutorialList                     = GetObjectList<TutorialStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.TutorialStatus.FromPointer); // 0x78 ProceededTutorialList       ( ModelClassListType RepeatedField`1<TutorialStatus> RepeatedField`1<TutorialStatus> List<TutorialStatus> Pointer )
            value.LastLoginDate                 = ToDateTime(value._LastLoginDate);
            value.FirstTimeDate                 = ToDateTime(value._FirstTimeDate);

            return value;
        }
    }
}
