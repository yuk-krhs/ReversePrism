using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FavoriteMarkIdRP                         000186714310 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 018 DetailType                               00018670BD50 ModelEnumType PIdolDetailType PIdolDetailType PIdolDetailType Int32
    // 020 PIdolIcon                                00018670C310 ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer
    // 028 InitialTabIndex                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 VoDaViMe                                 0001865321F0 ModelClassType VoDaViMeViewModel VoDaViMeViewModel VoDaViMeViewModel Pointer
    // 040 EvolutionLv                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 SelectedMstIdolSkillId                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 IdolSkillList                            000185CFE0F8 ModelClassListType IReadOnlyList`1<IIdolSkillStatus> IReadOnlyList`1<IIdolSkillStatus> List<IIdolSkillStatus> Pointer
    // 050 IdolSkillContentList                     000185B8AB00 ModelClassListType IdolSkillContentViewModel[] IdolSkillContentViewModel[] List<IdolSkillContentViewModel> Pointer
    // 058 EventList                                000185B7CA30 ModelClassListType EventModel[] EventModel[] List<EventModel> Pointer
    // 060 PotentialLiveSkillList                   000185B9C1D0 ModelClassListType PotentialLiveSkillInfoViewModel[] PotentialLiveSkillInfoViewModel[] List<PotentialLiveSkillInfoViewModel> Pointer
    // 068 CostumeSetInfoList                       000185B77B30 ModelClassListType CostumeSetInfoViewModel[] CostumeSetInfoViewModel[] List<CostumeSetInfoViewModel> Pointer
    // 070 IsChangeableIdolSkill                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 071 IsChangeableFavorite                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 072 AsMax                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 073 InLive                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 074 UpgradingButtonActive                    000186594D10 ModelPrimitiveType bool bool bool Bool
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

        public static PIdolDetailPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolDetailPopupViewModel() { Pointer= p0 };

            value.FavoriteMarkIdRP                          = GetObject<IntReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 024665FE3F88 0x10 FavoriteMarkIdRP            ( 000186714310 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.DetailType                                = (PIdolDetailType)GetInt32(new IntPtr(p + 0x018)); // 024665FE3FA8 0x18 DetailType                  ( 00018670BD50 ModelEnumType PIdolDetailType PIdolDetailType PIdolDetailType Int32 )
            value.PIdolIcon                                 = GetObject<PIdolIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.PIdolIcon.FromPointer); // 024665FE3FC8 0x20 PIdolIcon                   ( 00018670C310 ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer )
            value.InitialTabIndex                           = GetInt32(new IntPtr(p + 0x028)); // 024665FE3FE8 0x28 InitialTabIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x02C)); // 024665FE4008 0x2C MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x030)); // 024665FE4028 0x30 MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VoDaViMe                                  = GetObject<VoDaViMeViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.VoDaViMeViewModel.FromPointer); // 024665FE4048 0x38 VoDaViMe                    ( 0001865321F0 ModelClassType VoDaViMeViewModel VoDaViMeViewModel VoDaViMeViewModel Pointer )
            value.EvolutionLv                               = GetInt32(new IntPtr(p + 0x040)); // 024665FE4068 0x40 EvolutionLv                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectedMstIdolSkillId                    = GetInt32(new IntPtr(p + 0x044)); // 024665FE4088 0x44 SelectedMstIdolSkillId      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdolSkillList                             = GetObjectList<IIdolSkillStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IIdolSkillStatus.FromPointer); // 024665FE40A8 0x48 IdolSkillList               ( 000185CFE0F8 ModelClassListType IReadOnlyList`1<IIdolSkillStatus> IReadOnlyList`1<IIdolSkillStatus> List<IIdolSkillStatus> Pointer )
            value.IdolSkillContentList                      = GetObjectList<IdolSkillContentViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.IdolSkillContentViewModel.FromPointer); // 024665FE40C8 0x50 IdolSkillContentList        ( 000185B8AB00 ModelClassListType IdolSkillContentViewModel[] IdolSkillContentViewModel[] List<IdolSkillContentViewModel> Pointer )
            value.EventList                                 = GetObjectList<EventModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.EventModel.FromPointer); // 024665FE40E8 0x58 EventList                   ( 000185B7CA30 ModelClassListType EventModel[] EventModel[] List<EventModel> Pointer )
            value.PotentialLiveSkillList                    = GetObjectList<PotentialLiveSkillInfoViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.PotentialLiveSkillInfoViewModel.FromPointer); // 024665FE4108 0x60 PotentialLiveSkillList      ( 000185B9C1D0 ModelClassListType PotentialLiveSkillInfoViewModel[] PotentialLiveSkillInfoViewModel[] List<PotentialLiveSkillInfoViewModel> Pointer )
            value.CostumeSetInfoList                        = GetObjectList<CostumeSetInfoViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.CostumeSetInfoViewModel.FromPointer); // 024665FE4128 0x68 CostumeSetInfoList          ( 000185B77B30 ModelClassListType CostumeSetInfoViewModel[] CostumeSetInfoViewModel[] List<CostumeSetInfoViewModel> Pointer )
            value.IsChangeableIdolSkill                     = GetBool(new IntPtr(p + 0x070)); // 024665FE4148 0x70 IsChangeableIdolSkill       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsChangeableFavorite                      = GetBool(new IntPtr(p + 0x071)); // 024665FE4168 0x71 IsChangeableFavorite        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AsMax                                     = GetBool(new IntPtr(p + 0x072)); // 024665FE4188 0x72 AsMax                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.InLive                                    = GetBool(new IntPtr(p + 0x073)); // 024665FE41A8 0x73 InLive                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UpgradingButtonActive                     = GetBool(new IntPtr(p + 0x074)); // 024665FE41C8 0x74 UpgradingButtonActive       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
