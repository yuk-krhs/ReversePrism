using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 UnitTypeCount                            int IL2CPP_TYPE_I4
    // 010 UnitType                                 000186613920 ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32
    // 014 EventId                                  0001865F4940 ModelPrimitiveType int int int Int32
    // 018 UserRanking                              0001865F4940 ModelPrimitiveType int int int Int32
    // 020 EventStatus                              00018651F050 ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer
    // 028 FesUnitIconList                          000185CDC368 ModelClassListType List`1<FUnitIcon> List`1<FUnitIcon> List<FUnitIcon> Pointer
    // 030 SelectedUnitId                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 SelectedFUnitIcon                        00018654C900 ModelClassType FUnitIcon FUnitIcon FUnitIcon Pointer
    // 040 OffenceUnitModel                         0001865F8EB0 ModelClassType PvpUnitViewModel PvpUnitViewModel PvpUnitViewModel Pointer
    // 048 DefenceUnitModel                         0001865F8EB0 ModelClassType PvpUnitViewModel PvpUnitViewModel PvpUnitViewModel Pointer
    // 050 DefencePvpUnitChangeableDate             000185D00A78 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 060 sortFilterSaveData                       SavableJsonObject`1<IdolListFUSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 068 SortFilterModel                          00018654D810 ModelClassType FUnitSortFilterModel FUnitSortFilterModel FUnitSortFilterModel Pointer
    // 070 FUnitList                                000185CF7C18 ModelClassListType IReadOnlyList`1<IFesUnitStatus> IReadOnlyList`1<IFesUnitStatus> List<IFesUnitStatus> Pointer
    // 078 OriginalFesUnitIconList                  000185CDC2F8 ModelClassListType List`1<FUnitIcon> List`1<FUnitIcon> List<FUnitIcon> Pointer
    public partial class PvpUnitEditViewModel : DataModel
    {
        public PvpUnitType                              UnitType                                { get; set; }
        public int                                      EventId                                 { get; set; }
        public int                                      UserRanking                             { get; set; }
        public IGameEventStatus?                        EventStatus                             { get; set; }
        public List<FUnitIcon>?                         FesUnitIconList                         { get; set; }
        public int                                      SelectedUnitId                          { get; set; }
        public FUnitIcon?                               SelectedFUnitIcon                       { get; set; }
        public PvpUnitViewModel?                        OffenceUnitModel                        { get; set; }
        public PvpUnitViewModel?                        DefenceUnitModel                        { get; set; }
        public DateTime                                 DefencePvpUnitChangeableDate            { get; set; }
        public FUnitSortFilterModel?                    SortFilterModel                         { get; set; }
        public List<IFesUnitStatus>?                    FUnitList                               { get; set; }
        public List<FUnitIcon>?                         OriginalFesUnitIconList                 { get; set; }

        public static PvpUnitEditViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpUnitEditViewModel() { Pointer= p0 };

            value.UnitType                                  = (PvpUnitType)GetInt32(new IntPtr(p + 0x010)); // 02466668E320 0x10 UnitType                    ( 000186613920 ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32 )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x014)); // 02466668E340 0x14 EventId                     ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.UserRanking                               = GetInt32(new IntPtr(p + 0x018)); // 02466668E360 0x18 UserRanking                 ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.EventStatus                               = GetObject<IGameEventStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IGameEventStatus.FromPointer); // 02466668E380 0x20 EventStatus                 ( 00018651F050 ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer )
            value.FesUnitIconList                           = GetObjectList<FUnitIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.FUnitIcon.FromPointer); // 02466668E3A0 0x28 FesUnitIconList             ( 000185CDC368 ModelClassListType List`1<FUnitIcon> List`1<FUnitIcon> List<FUnitIcon> Pointer )
            value.SelectedUnitId                            = GetInt32(new IntPtr(p + 0x030)); // 02466668E3C0 0x30 SelectedUnitId              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SelectedFUnitIcon                         = GetObject<FUnitIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.FUnitIcon.FromPointer); // 02466668E3E0 0x38 SelectedFUnitIcon           ( 00018654C900 ModelClassType FUnitIcon FUnitIcon FUnitIcon Pointer )
            value.OffenceUnitModel                          = GetObject<PvpUnitViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.PvpUnitViewModel.FromPointer); // 02466668E400 0x40 OffenceUnitModel            ( 0001865F8EB0 ModelClassType PvpUnitViewModel PvpUnitViewModel PvpUnitViewModel Pointer )
            value.DefenceUnitModel                          = GetObject<PvpUnitViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.PvpUnitViewModel.FromPointer); // 02466668E420 0x48 DefenceUnitModel            ( 0001865F8EB0 ModelClassType PvpUnitViewModel PvpUnitViewModel PvpUnitViewModel Pointer )
            value.DefencePvpUnitChangeableDate              = GetDateTime(new IntPtr(p + 0x050)); // 02466668E440 0x50 DefencePvpUnitChangeableDate ( 000185D00A78 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.SortFilterModel                           = GetObject<FUnitSortFilterModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.FUnitSortFilterModel.FromPointer); // 02466668E480 0x68 SortFilterModel             ( 00018654D810 ModelClassType FUnitSortFilterModel FUnitSortFilterModel FUnitSortFilterModel Pointer )
            value.FUnitList                                 = GetObjectList<IFesUnitStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.IFesUnitStatus.FromPointer); // 02466668E4A0 0x70 FUnitList                   ( 000185CF7C18 ModelClassListType IReadOnlyList`1<IFesUnitStatus> IReadOnlyList`1<IFesUnitStatus> List<IFesUnitStatus> Pointer )
            value.OriginalFesUnitIconList                   = GetObjectList<FUnitIcon>(new IntPtr(p + 0x078), ReversePrism.DataModels.FUnitIcon.FromPointer); // 02466668E4C0 0x78 OriginalFesUnitIconList     ( 000185CDC2F8 ModelClassListType List`1<FUnitIcon> List`1<FUnitIcon> List<FUnitIcon> Pointer )

            return value;
        }
    }
}
