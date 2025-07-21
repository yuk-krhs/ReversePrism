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
    // 020 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 028 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 Scroller                                 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 038 ProduceLogListCellAccordionOff           ModelClassType ProduceLogListCellAccordionOff ProduceLogListCellAccordionOff ProduceLogListCellAccordionOff Pointer
    // 040 Scrollbar                                ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 048 WaitLoadImageObject                      ModelClassType GameObject GameObject GameObject Pointer
    // 050 ProduceLogCellList                       ModelClassListType List`1<IProduceLogCell> List`1<IProduceLogCell> List<IProduceLogCell> Pointer
    // 058 CurrentIndex                             ModelPrimitiveType int int int Int32
    // 05C MaxIndex                                 ModelPrimitiveType int int int Int32
    public partial class ProduceLogCellListView : DataModel
    {
        public IResourceLoader?                         ResourceLoader                          { get; set; }
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
            var value   = new ProduceLogCellListView() { Pointer= p0 };

            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x020), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x20 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 0x28 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x030), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 0x30 Scroller                    ( ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.ProduceLogListCellAccordionOff            = GetObject<ProduceLogListCellAccordionOff>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceLogListCellAccordionOff.FromPointer); // 0x38 ProduceLogListCellAccordionOff ( ModelClassType ProduceLogListCellAccordionOff ProduceLogListCellAccordionOff ProduceLogListCellAccordionOff Pointer )
            value.Scrollbar                                 = GetObject<Scrollbar>(new IntPtr(p + 0x040), ReversePrism.DataModels.Scrollbar.FromPointer); // 0x40 Scrollbar                   ( ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.WaitLoadImageObject                       = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 WaitLoadImageObject         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ProduceLogCellList                        = GetObjectList<IProduceLogCell>(new IntPtr(p + 0x050), ReversePrism.DataModels.IProduceLogCell.FromPointer); // 0x50 ProduceLogCellList          ( ModelClassListType List`1<IProduceLogCell> List`1<IProduceLogCell> List<IProduceLogCell> Pointer )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x058)); // 0x58 CurrentIndex                ( ModelPrimitiveType int int int Int32 )
            value.MaxIndex                                  = GetInt32(new IntPtr(p + 0x05C)); // 0x5C MaxIndex                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
