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
    public partial class PIdolDetailPopupViewModel
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
            var value   = new PIdolDetailPopupViewModel();

            value.FavoriteMarkIdRP                          = GetObject<IntReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0270D5F73758 0x10 FavoriteMarkIdRP            ( 000186714310 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.DetailType                                = (PIdolDetailType)GetInt32(new IntPtr(p + 0x018)); // 0270D5F73778 0x18 DetailType                  ( 00018670BD50 ModelEnumType PIdolDetailType PIdolDetailType PIdolDetailType Int32 )
            value.PIdolIcon                                 = GetObject<PIdolIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0270D5F73798 0x20 PIdolIcon                   ( 00018670C310 ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer )
            value.InitialTabIndex                           = GetInt32(new IntPtr(p + 0x028)); // 0270D5F737B8 0x28 InitialTabIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x02C)); // 0270D5F737D8 0x2C MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x030)); // 0270D5F737F8 0x30 MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VoDaViMe                                  = GetObject<VoDaViMeViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.VoDaViMeViewModel.FromPointer); // 0270D5F73818 0x38 VoDaViMe                    ( 0001865321F0 ModelClassType VoDaViMeViewModel VoDaViMeViewModel VoDaViMeViewModel Pointer )
            value.EvolutionLv                               = GetInt32(new IntPtr(p + 0x040)); // 0270D5F73838 0x40 EvolutionLv                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectedMstIdolSkillId                    = GetInt32(new IntPtr(p + 0x044)); // 0270D5F73858 0x44 SelectedMstIdolSkillId      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdolSkillList                             = GetObjectList<IIdolSkillStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IIdolSkillStatus.FromPointer); // 0270D5F73878 0x48 IdolSkillList               ( 000185CFE0F8 ModelClassListType IReadOnlyList`1<IIdolSkillStatus> IReadOnlyList`1<IIdolSkillStatus> List<IIdolSkillStatus> Pointer )
            value.IdolSkillContentList                      = GetObjectList<IdolSkillContentViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.IdolSkillContentViewModel.FromPointer); // 0270D5F73898 0x50 IdolSkillContentList        ( 000185B8AB00 ModelClassListType IdolSkillContentViewModel[] IdolSkillContentViewModel[] List<IdolSkillContentViewModel> Pointer )
            value.EventList                                 = GetObjectList<EventModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.EventModel.FromPointer); // 0270D5F738B8 0x58 EventList                   ( 000185B7CA30 ModelClassListType EventModel[] EventModel[] List<EventModel> Pointer )
            value.PotentialLiveSkillList                    = GetObjectList<PotentialLiveSkillInfoViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.PotentialLiveSkillInfoViewModel.FromPointer); // 0270D5F738D8 0x60 PotentialLiveSkillList      ( 000185B9C1D0 ModelClassListType PotentialLiveSkillInfoViewModel[] PotentialLiveSkillInfoViewModel[] List<PotentialLiveSkillInfoViewModel> Pointer )
            value.CostumeSetInfoList                        = GetObjectList<CostumeSetInfoViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.CostumeSetInfoViewModel.FromPointer); // 0270D5F738F8 0x68 CostumeSetInfoList          ( 000185B77B30 ModelClassListType CostumeSetInfoViewModel[] CostumeSetInfoViewModel[] List<CostumeSetInfoViewModel> Pointer )
            value.IsChangeableIdolSkill                     = GetBool(new IntPtr(p + 0x070)); // 0270D5F73918 0x70 IsChangeableIdolSkill       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsChangeableFavorite                      = GetBool(new IntPtr(p + 0x071)); // 0270D5F73938 0x71 IsChangeableFavorite        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AsMax                                     = GetBool(new IntPtr(p + 0x072)); // 0270D5F73958 0x72 AsMax                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.InLive                                    = GetBool(new IntPtr(p + 0x073)); // 0270D5F73978 0x73 InLive                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UpgradingButtonActive                     = GetBool(new IntPtr(p + 0x074)); // 0270D5F73998 0x74 UpgradingButtonActive       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
