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
    // 010 EpisodeId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 ItemId                                   0001866E67F0 ModelEnumType LogItemType LogItemType LogItemType Int32
    // 018 ProducePolicyId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Season                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 ScheduleDetailType                       000186614E40 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 024 ScheduleLevel                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 IdolId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 ScenarioTypeID                           0001866C4B30 ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 038 AccordionOnList                          000185CF1028 ModelClassListType List`1<LogAccordionOnCommonViewModel> List`1<LogAccordionOnCommonViewModel> List<LogAccordionOnCommonViewModel> Pointer
    // 040 IsOpened                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 044 CellHeight                               0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.EpisodeId                                 = GetInt32(new IntPtr(p + 0x010)); // 0246665714A0 0x10 EpisodeId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ItemId                                    = (LogItemType)GetInt32(new IntPtr(p + 0x014)); // 0246665714C0 0x14 ItemId                      ( 0001866E67F0 ModelEnumType LogItemType LogItemType LogItemType Int32 )
            value.ProducePolicyId                           = GetInt32(new IntPtr(p + 0x018)); // 0246665714E0 0x18 ProducePolicyId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Season                                    = GetInt32(new IntPtr(p + 0x01C)); // 024666571500 0x1C Season                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x020)); // 024666571520 0x20 ScheduleDetailType          ( 000186614E40 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x024)); // 024666571540 0x24 ScheduleLevel               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdolId                                    = GetInt32(new IntPtr(p + 0x028)); // 024666571560 0x28 IdolId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScenarioTypeID                            = GetObject<ScenarioID>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScenarioID.FromPointer); // 024666571580 0x30 ScenarioTypeID              ( 0001866C4B30 ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.AccordionOnList                           = GetObjectList<LogAccordionOnCommonViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.LogAccordionOnCommonViewModel.FromPointer); // 0246665715A0 0x38 AccordionOnList             ( 000185CF1028 ModelClassListType List`1<LogAccordionOnCommonViewModel> List`1<LogAccordionOnCommonViewModel> List<LogAccordionOnCommonViewModel> Pointer )
            value.IsOpened                                  = GetBool(new IntPtr(p + 0x040)); // 0246665715C0 0x40 IsOpened                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CellHeight                                = GetInt32(new IntPtr(p + 0x044)); // 0246665715E0 0x44 CellHeight                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
