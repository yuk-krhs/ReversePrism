using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 UnitTypeCount                            int IL2CPP_TYPE_I4
    // 010 UnitType                                 ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32
    // 014 EventId                                  ModelPrimitiveType int int int Int32
    // 018 UserRanking                              ModelPrimitiveType int int int Int32
    // 020 EventStatus                              ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer
    // 028 FesUnitIconList                          ModelClassListType List`1<FUnitIcon> List`1<FUnitIcon> List<FUnitIcon> Pointer
    // 030 SelectedUnitId                           ModelPrimitiveType int int int Int32
    // 038 SelectedFUnitIcon                        ModelClassType FUnitIcon FUnitIcon FUnitIcon Pointer
    // 040 OffenceUnitModel                         ModelClassType PvpUnitViewModel PvpUnitViewModel PvpUnitViewModel Pointer
    // 048 DefenceUnitModel                         ModelClassType PvpUnitViewModel PvpUnitViewModel PvpUnitViewModel Pointer
    // 050 DefencePvpUnitChangeableDate             ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 060 sortFilterSaveData                       SavableJsonObject`1<IdolListFUSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 068 SortFilterModel                          ModelClassType FUnitSortFilterModel FUnitSortFilterModel FUnitSortFilterModel Pointer
    // 070 FUnitList                                ModelClassListType IReadOnlyList`1<IFesUnitStatus> IReadOnlyList`1<IFesUnitStatus> List<IFesUnitStatus> Pointer
    // 078 OriginalFesUnitIconList                  ModelClassListType List`1<FUnitIcon> List`1<FUnitIcon> List<FUnitIcon> Pointer
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

            value.UnitType                                  = (PvpUnitType)GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitType                    ( ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32 )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 EventId                     ( ModelPrimitiveType int int int Int32 )
            value.UserRanking                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 UserRanking                 ( ModelPrimitiveType int int int Int32 )
            value.EventStatus                               = GetObject<IGameEventStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IGameEventStatus.FromPointer); // 0x20 EventStatus                 ( ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer )
            value.FesUnitIconList                           = GetObjectList<FUnitIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.FUnitIcon.FromPointer); // 0x28 FesUnitIconList             ( ModelClassListType List`1<FUnitIcon> List`1<FUnitIcon> List<FUnitIcon> Pointer )
            value.SelectedUnitId                            = GetInt32(new IntPtr(p + 0x030)); // 0x30 SelectedUnitId              ( ModelPrimitiveType int int int Int32 )
            value.SelectedFUnitIcon                         = GetObject<FUnitIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.FUnitIcon.FromPointer); // 0x38 SelectedFUnitIcon           ( ModelClassType FUnitIcon FUnitIcon FUnitIcon Pointer )
            value.OffenceUnitModel                          = GetObject<PvpUnitViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.PvpUnitViewModel.FromPointer); // 0x40 OffenceUnitModel            ( ModelClassType PvpUnitViewModel PvpUnitViewModel PvpUnitViewModel Pointer )
            value.DefenceUnitModel                          = GetObject<PvpUnitViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.PvpUnitViewModel.FromPointer); // 0x48 DefenceUnitModel            ( ModelClassType PvpUnitViewModel PvpUnitViewModel PvpUnitViewModel Pointer )
            value.DefencePvpUnitChangeableDate              = GetDateTime(new IntPtr(p + 0x050)); // 0x50 DefencePvpUnitChangeableDate ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.SortFilterModel                           = GetObject<FUnitSortFilterModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.FUnitSortFilterModel.FromPointer); // 0x68 SortFilterModel             ( ModelClassType FUnitSortFilterModel FUnitSortFilterModel FUnitSortFilterModel Pointer )
            value.FUnitList                                 = GetObjectList<IFesUnitStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.IFesUnitStatus.FromPointer); // 0x70 FUnitList                   ( ModelClassListType IReadOnlyList`1<IFesUnitStatus> IReadOnlyList`1<IFesUnitStatus> List<IFesUnitStatus> Pointer )
            value.OriginalFesUnitIconList                   = GetObjectList<FUnitIcon>(new IntPtr(p + 0x078), ReversePrism.DataModels.FUnitIcon.FromPointer); // 0x78 OriginalFesUnitIconList     ( ModelClassListType List`1<FUnitIcon> List`1<FUnitIcon> List<FUnitIcon> Pointer )

            return value;
        }
    }
}
