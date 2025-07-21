using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ScheduleDataDefalutOneLine               int IL2CPP_TYPE_I4
    // 000 ScheduleDataPlusOneLine                  int IL2CPP_TYPE_I4
    // 000 ScheduleDataBottom                       int IL2CPP_TYPE_I4
    // 010 EpisodeId                                ModelPrimitiveType int int int Int32
    // 014 ItemId                                   ModelEnumType LogItemType LogItemType LogItemType Int32
    // 018 ProducePolicyId                          ModelPrimitiveType int int int Int32
    // 01C Season                                   ModelPrimitiveType int int int Int32
    // 020 ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 024 ScheduleLevel                            ModelPrimitiveType int int int Int32
    // 028 IdolId                                   ModelPrimitiveType int int int Int32
    // 030 ScenarioTypeID                           ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 038 AccordionOnList                          ModelClassListType List`1<LogAccordionOnCommonViewModel> List`1<LogAccordionOnCommonViewModel> List<LogAccordionOnCommonViewModel> Pointer
    // 040 IsOpened                                 ModelPrimitiveType bool bool bool Bool
    // 044 CellHeight                               ModelPrimitiveType int int int Int32
    public partial class LogAccordionOffViewModel : DataModel
    {
        public int                                      EpisodeId                               { get; set; }
        public LogItemType                              ItemId                                  { get; set; }
        public int                                      ProducePolicyId                         { get; set; }
        public int                                      Season                                  { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public int                                      IdolId                                  { get; set; }
        public ScenarioID?                              ScenarioTypeID                          { get; set; }
        public List<LogAccordionOnCommonViewModel>?     AccordionOnList                         { get; set; }
        public bool                                     IsOpened                                { get; set; }
        public int                                      CellHeight                              { get; set; }

        public static LogAccordionOffViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LogAccordionOffViewModel() { Pointer= p0 };

            value.EpisodeId                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 EpisodeId                   ( ModelPrimitiveType int int int Int32 )
            value.ItemId                                    = (LogItemType)GetInt32(new IntPtr(p + 0x014)); // 0x14 ItemId                      ( ModelEnumType LogItemType LogItemType LogItemType Int32 )
            value.ProducePolicyId                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 ProducePolicyId             ( ModelPrimitiveType int int int Int32 )
            value.Season                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Season                      ( ModelPrimitiveType int int int Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x020)); // 0x20 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x024)); // 0x24 ScheduleLevel               ( ModelPrimitiveType int int int Int32 )
            value.IdolId                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 IdolId                      ( ModelPrimitiveType int int int Int32 )
            value.ScenarioTypeID                            = GetObject<ScenarioID>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScenarioID.FromPointer); // 0x30 ScenarioTypeID              ( ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.AccordionOnList                           = GetObjectList<LogAccordionOnCommonViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.LogAccordionOnCommonViewModel.FromPointer); // 0x38 AccordionOnList             ( ModelClassListType List`1<LogAccordionOnCommonViewModel> List`1<LogAccordionOnCommonViewModel> List<LogAccordionOnCommonViewModel> Pointer )
            value.IsOpened                                  = GetBool(new IntPtr(p + 0x040)); // 0x40 IsOpened                    ( ModelPrimitiveType bool bool bool Bool )
            value.CellHeight                                = GetInt32(new IntPtr(p + 0x044)); // 0x44 CellHeight                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
