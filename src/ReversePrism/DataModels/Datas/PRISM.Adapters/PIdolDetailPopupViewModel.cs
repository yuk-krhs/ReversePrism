using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FavoriteMarkIdRP                         ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 018 DetailType                               ModelEnumType PIdolDetailType PIdolDetailType PIdolDetailType Int32
    // 020 PIdolIcon                                ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer
    // 028 InitialTabIndex                          ModelPrimitiveType int int int Int32
    // 02C MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 030 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 038 VoDaViMe                                 ModelClassType VoDaViMeViewModel VoDaViMeViewModel VoDaViMeViewModel Pointer
    // 040 EvolutionLv                              ModelPrimitiveType int int int Int32
    // 044 SelectedMstIdolSkillId                   ModelPrimitiveType int int int Int32
    // 048 IdolSkillList                            ModelClassListType IReadOnlyList`1<IIdolSkillStatus> IReadOnlyList`1<IIdolSkillStatus> List<IIdolSkillStatus> Pointer
    // 050 IdolSkillContentList                     ModelClassListType IdolSkillContentViewModel[] IdolSkillContentViewModel[] List<IdolSkillContentViewModel> Pointer
    // 058 EventList                                ModelClassListType EventModel[] EventModel[] List<EventModel> Pointer
    // 060 PotentialLiveSkillList                   ModelClassListType PotentialLiveSkillInfoViewModel[] PotentialLiveSkillInfoViewModel[] List<PotentialLiveSkillInfoViewModel> Pointer
    // 068 CostumeSetInfoList                       ModelClassListType CostumeSetInfoViewModel[] CostumeSetInfoViewModel[] List<CostumeSetInfoViewModel> Pointer
    // 070 IsChangeableIdolSkill                    ModelPrimitiveType bool bool bool Bool
    // 071 IsChangeableFavorite                     ModelPrimitiveType bool bool bool Bool
    // 072 AsMax                                    ModelPrimitiveType bool bool bool Bool
    // 073 InLive                                   ModelPrimitiveType bool bool bool Bool
    // 074 UpgradingButtonActive                    ModelPrimitiveType bool bool bool Bool
    // 075 LiveOnly                                 ModelPrimitiveType bool bool bool Bool
    public partial class PIdolDetailPopupViewModel : DataModel
    {
        public IntReactiveProperty?                     FavoriteMarkIdRP                        { get; set; }
        public PIdolDetailType                          DetailType                              { get; set; }
        public PIdolIcon?                               PIdolIcon                               { get; set; }
        public int                                      InitialTabIndex                         { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public VoDaViMeViewModel?                       VoDaViMe                                { get; set; }
        public int                                      EvolutionLv                             { get; set; }
        public int                                      SelectedMstIdolSkillId                  { get; set; }
        public List<IIdolSkillStatus>?                  IdolSkillList                           { get; set; }
        public List<IdolSkillContentViewModel>?         IdolSkillContentList                    { get; set; }
        public List<EventModel>?                        EventList                               { get; set; }
        public List<PotentialLiveSkillInfoViewModel>?   PotentialLiveSkillList                  { get; set; }
        public List<CostumeSetInfoViewModel>?           CostumeSetInfoList                      { get; set; }
        public bool                                     IsChangeableIdolSkill                   { get; set; }
        public bool                                     IsChangeableFavorite                    { get; set; }
        public bool                                     AsMax                                   { get; set; }
        public bool                                     InLive                                  { get; set; }
        public bool                                     UpgradingButtonActive                   { get; set; }
        public bool                                     LiveOnly                                { get; set; }

        public static PIdolDetailPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolDetailPopupViewModel() { Pointer= p0 };

            value.FavoriteMarkIdRP                          = GetObject<IntReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x10 FavoriteMarkIdRP            ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.DetailType                                = (PIdolDetailType)GetInt32(new IntPtr(p + 0x018)); // 0x18 DetailType                  ( ModelEnumType PIdolDetailType PIdolDetailType PIdolDetailType Int32 )
            value.PIdolIcon                                 = GetObject<PIdolIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0x20 PIdolIcon                   ( ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer )
            value.InitialTabIndex                           = GetInt32(new IntPtr(p + 0x028)); // 0x28 InitialTabIndex             ( ModelPrimitiveType int int int Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x030)); // 0x30 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.VoDaViMe                                  = GetObject<VoDaViMeViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.VoDaViMeViewModel.FromPointer); // 0x38 VoDaViMe                    ( ModelClassType VoDaViMeViewModel VoDaViMeViewModel VoDaViMeViewModel Pointer )
            value.EvolutionLv                               = GetInt32(new IntPtr(p + 0x040)); // 0x40 EvolutionLv                 ( ModelPrimitiveType int int int Int32 )
            value.SelectedMstIdolSkillId                    = GetInt32(new IntPtr(p + 0x044)); // 0x44 SelectedMstIdolSkillId      ( ModelPrimitiveType int int int Int32 )
            value.IdolSkillList                             = GetObjectList<IIdolSkillStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IIdolSkillStatus.FromPointer); // 0x48 IdolSkillList               ( ModelClassListType IReadOnlyList`1<IIdolSkillStatus> IReadOnlyList`1<IIdolSkillStatus> List<IIdolSkillStatus> Pointer )
            value.IdolSkillContentList                      = GetObjectList<IdolSkillContentViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.IdolSkillContentViewModel.FromPointer); // 0x50 IdolSkillContentList        ( ModelClassListType IdolSkillContentViewModel[] IdolSkillContentViewModel[] List<IdolSkillContentViewModel> Pointer )
            value.EventList                                 = GetObjectList<EventModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.EventModel.FromPointer); // 0x58 EventList                   ( ModelClassListType EventModel[] EventModel[] List<EventModel> Pointer )
            value.PotentialLiveSkillList                    = GetObjectList<PotentialLiveSkillInfoViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.PotentialLiveSkillInfoViewModel.FromPointer); // 0x60 PotentialLiveSkillList      ( ModelClassListType PotentialLiveSkillInfoViewModel[] PotentialLiveSkillInfoViewModel[] List<PotentialLiveSkillInfoViewModel> Pointer )
            value.CostumeSetInfoList                        = GetObjectList<CostumeSetInfoViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.CostumeSetInfoViewModel.FromPointer); // 0x68 CostumeSetInfoList          ( ModelClassListType CostumeSetInfoViewModel[] CostumeSetInfoViewModel[] List<CostumeSetInfoViewModel> Pointer )
            value.IsChangeableIdolSkill                     = GetBool(new IntPtr(p + 0x070)); // 0x70 IsChangeableIdolSkill       ( ModelPrimitiveType bool bool bool Bool )
            value.IsChangeableFavorite                      = GetBool(new IntPtr(p + 0x071)); // 0x71 IsChangeableFavorite        ( ModelPrimitiveType bool bool bool Bool )
            value.AsMax                                     = GetBool(new IntPtr(p + 0x072)); // 0x72 AsMax                       ( ModelPrimitiveType bool bool bool Bool )
            value.InLive                                    = GetBool(new IntPtr(p + 0x073)); // 0x73 InLive                      ( ModelPrimitiveType bool bool bool Bool )
            value.UpgradingButtonActive                     = GetBool(new IntPtr(p + 0x074)); // 0x74 UpgradingButtonActive       ( ModelPrimitiveType bool bool bool Bool )
            value.LiveOnly                                  = GetBool(new IntPtr(p + 0x075)); // 0x75 LiveOnly                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
