using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ControlButtons                           000185B914F0 ModelClassListType LiveResultPhaseControlButtonView[] LiveResultPhaseControlButtonView[] List<LiveResultPhaseControlButtonView> Pointer
    // 028 PhaseViews                               000185B915E0 ModelClassListType LiveResultViewBase[] LiveResultViewBase[] List<LiveResultViewBase> Pointer
    // 030 onFinish                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 AvailablePhaseViews                      000185B915E0 ModelClassListType LiveResultViewBase[] LiveResultViewBase[] List<LiveResultViewBase> Pointer
    // 040 CurrentIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class LiveResultPhaseControlView : DataModel
    {
        public List<LiveResultPhaseControlButtonView>?  ControlButtons                          { get; set; }
        public List<LiveResultViewBase>?                PhaseViews                              { get; set; }
        public List<LiveResultViewBase>?                AvailablePhaseViews                     { get; set; }
        public int                                      CurrentIndex                            { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static LiveResultPhaseControlView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultPhaseControlView() { Pointer= p0 };

            value.ControlButtons                            = GetObjectList<LiveResultPhaseControlButtonView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveResultPhaseControlButtonView.FromPointer); // 0246652BCA58 0x20 ControlButtons              ( 000185B914F0 ModelClassListType LiveResultPhaseControlButtonView[] LiveResultPhaseControlButtonView[] List<LiveResultPhaseControlButtonView> Pointer )
            value.PhaseViews                                = GetObjectList<LiveResultViewBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveResultViewBase.FromPointer); // 0246652BCA78 0x28 PhaseViews                  ( 000185B915E0 ModelClassListType LiveResultViewBase[] LiveResultViewBase[] List<LiveResultViewBase> Pointer )
            value.AvailablePhaseViews                       = GetObjectList<LiveResultViewBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveResultViewBase.FromPointer); // 0246652BCAB8 0x38 AvailablePhaseViews         ( 000185B915E0 ModelClassListType LiveResultViewBase[] LiveResultViewBase[] List<LiveResultViewBase> Pointer )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x040)); // 0246652BCAD8 0x40 CurrentIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0246652BCAF8 0x48 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
