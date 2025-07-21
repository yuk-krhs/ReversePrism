using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 CellHeight                               ModelPrimitiveType float float float Single
    // 040 TxtTitle                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtSelectedEffectType                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtSelectedSchedule                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 BtnClose                                 ModelClassType UIButton UIButton UIButton Pointer
    // 060 TypeToggleButtonGroup                    ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 068 TypeToggleButtons                        ModelClassListType List`1<ToggleButton> List`1<ToggleButton> List<ToggleButton> Pointer
    // 070 ScheduleToggleButtonGroup                ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 078 ScheduleToggleButtons                    ModelClassListType List`1<ToggleButton> List`1<ToggleButton> List<ToggleButton> Pointer
    // 080 BtnReset                                 ModelClassType UIButton UIButton UIButton Pointer
    // 088 Disposable                               ModelClassType IDisposable IDisposable IDisposable Pointer
    // 090 LockScheduleSelect                       ModelPrimitiveType bool bool bool Bool
    public partial class SupportCharaSupportEffectFilterCellView : DataModel
    {
        public float                                    CellHeight                              { get; set; }
        public UITextMeshProUGUI?                       TxtTitle                                { get; set; }
        public UITextMeshProUGUI?                       TxtSelectedEffectType                   { get; set; }
        public UITextMeshProUGUI?                       TxtSelectedSchedule                     { get; set; }
        public UIButton?                                BtnClose                                { get; set; }
        public ToggleButtonGroup?                       TypeToggleButtonGroup                   { get; set; }
        public List<ToggleButton>?                      TypeToggleButtons                       { get; set; }
        public ToggleButtonGroup?                       ScheduleToggleButtonGroup               { get; set; }
        public List<ToggleButton>?                      ScheduleToggleButtons                   { get; set; }
        public UIButton?                                BtnReset                                { get; set; }
        public IDisposable?                             Disposable                              { get; set; }
        public bool                                     LockScheduleSelect                      { get; set; }

        public static SupportCharaSupportEffectFilterCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaSupportEffectFilterCellView() { Pointer= p0 };

            value.CellHeight                                = GetSingle(new IntPtr(p + 0x038)); // 0x38 CellHeight                  ( ModelPrimitiveType float float float Single )
            value.TxtTitle                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtTitle                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSelectedEffectType                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtSelectedEffectType       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSelectedSchedule                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtSelectedSchedule         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnClose                                  = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 BtnClose                    ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TypeToggleButtonGroup                     = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x60 TypeToggleButtonGroup       ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.TypeToggleButtons                         = GetObjectList<ToggleButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x68 TypeToggleButtons           ( ModelClassListType List`1<ToggleButton> List`1<ToggleButton> List<ToggleButton> Pointer )
            value.ScheduleToggleButtonGroup                 = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x70 ScheduleToggleButtonGroup   ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.ScheduleToggleButtons                     = GetObjectList<ToggleButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x78 ScheduleToggleButtons       ( ModelClassListType List`1<ToggleButton> List`1<ToggleButton> List<ToggleButton> Pointer )
            value.BtnReset                                  = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 0x80 BtnReset                    ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.IDisposable.FromPointer); // 0x88 Disposable                  ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.LockScheduleSelect                        = GetBool(new IntPtr(p + 0x090)); // 0x90 LockScheduleSelect          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
