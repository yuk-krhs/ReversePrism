using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 LittleIndexTopHeight                     int IL2CPP_TYPE_I4
    // 000 LittleIndexHeight                        int IL2CPP_TYPE_I4
    // 000 LittleIndexUnderHeight                   int IL2CPP_TYPE_I4
    // 000 AccordionOffTopHeight                    int IL2CPP_TYPE_I4
    // 000 AccordionOffHeight                       int IL2CPP_TYPE_I4
    // 000 AccordionOffUnderHeight                  int IL2CPP_TYPE_I4
    // 000 ProducePolicyHeight                      int IL2CPP_TYPE_I4
    // 000 AdvHeight                                int IL2CPP_TYPE_I4
    // 000 ScheduleHeight                           int IL2CPP_TYPE_I4
    // 000 ScheduleHeightLineUnder3                 int IL2CPP_TYPE_I4
    // 000 ScheduleHeightLineUnder6                 int IL2CPP_TYPE_I4
    // 020 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 028 Scroller                                 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 030 ProduceLogListCellAccordionOff           00018655DCF0 ModelClassType ProduceLogListCellAccordionOff ProduceLogListCellAccordionOff ProduceLogListCellAccordionOff Pointer
    // 038 Scrollbar                                0001866FA460 ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 040 WaitLoadImageObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 ProduceLogCellList                       000185CE7828 ModelClassListType List`1<IProduceLogCell> List`1<IProduceLogCell> List<IProduceLogCell> Pointer
    // 050 CurrentIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 MaxIndex                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProduceLogCellListView
    {
        public CancellationToken                        CancellationToken                       { get; set; }
        public EnhancedScroller?                        Scroller                                { get; set; }
        public ProduceLogListCellAccordionOff?          ProduceLogListCellAccordionOff          { get; set; }
        public Scrollbar?                               Scrollbar                               { get; set; }
        public GameObject?                              WaitLoadImageObject                     { get; set; }
        public List<IProduceLogCell>?                   ProduceLogCellList                      { get; set; }
        public int                                      CurrentIndex                            { get; set; }
        public int                                      MaxIndex                                { get; set; }

        public static ProduceLogCellListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceLogCellListView();

            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 0270DA1147F8 0x20 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 0270DA114818 0x28 Scroller                    ( 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.ProduceLogListCellAccordionOff            = GetObject<ProduceLogListCellAccordionOff>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceLogListCellAccordionOff.FromPointer); // 0270DA114838 0x30 ProduceLogListCellAccordionOff ( 00018655DCF0 ModelClassType ProduceLogListCellAccordionOff ProduceLogListCellAccordionOff ProduceLogListCellAccordionOff Pointer )
            value.Scrollbar                                 = GetObject<Scrollbar>(new IntPtr(p + 0x038), ReversePrism.DataModels.Scrollbar.FromPointer); // 0270DA114858 0x38 Scrollbar                   ( 0001866FA460 ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.WaitLoadImageObject                       = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA114878 0x40 WaitLoadImageObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ProduceLogCellList                        = GetObjectList<IProduceLogCell>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProduceLogCell.FromPointer); // 0270DA114898 0x48 ProduceLogCellList          ( 000185CE7828 ModelClassListType List`1<IProduceLogCell> List`1<IProduceLogCell> List<IProduceLogCell> Pointer )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x050)); // 0270DA1148B8 0x50 CurrentIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxIndex                                  = GetInt32(new IntPtr(p + 0x054)); // 0270DA1148D8 0x54 MaxIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
